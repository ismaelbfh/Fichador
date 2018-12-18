using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alc.Data;
using Alc.Model.ControlHoras;
using ControlHoras.Models;

namespace ControlHoras.DAL
{
    public class AccesoFichador
    {
        public Database ControlHorasDB = null;
        public string _CtrlHoras = string.Empty;
        private Log log = new Log();
        public AccesoFichador()
        {
            _CtrlHoras = string.Empty;
            if (ConfigurationManager.ConnectionStrings["ControlHoras"] != null)
            {
                _CtrlHoras = ConfigurationManager.ConnectionStrings["ControlHoras"].ToString();
            }

            if (this._CtrlHoras.Length > 0)
            {
                this.ControlHorasDB = new Database(_CtrlHoras, "System.Data.SqlClient", "ControlHoras", string.Empty);
            }
            
        }

        public int GetIDUsuarioByUserName(string userName)
        {
            int id = 0;
            try
            {
                id = ControlHorasDB.FirstOrDefault<int>("SELECT Id FROM usuarios WHERE nombre = @0", userName);
            }
            catch (Exception ex)
            {
                guardarLog(ex.Message, 2);
            }
            guardarLog("GetIDUsuarioByUserName correctamente realizada", 4);
            return id;
        }

        public DateTime? GetHoraInicioByIDUsuario(int idUsuario)
        {
            DateTime? resultado = null;
            try
            {
                resultado =
                    ControlHorasDB.FirstOrDefault<DateTime?>(
                        "Select HoraInicio from fichador where IDUsuario = @0 and cast(HoraInicio as date) = cast(getdate() as date)",
                        idUsuario);
            }
            catch (Exception ex)
            {
               guardarLog(ex.Message, 2);
            }
            guardarLog("GetHoraInicioByIDUsuario correctamente realizada", 4);
            return resultado;
        }

        public void guardarLog(string es, int nivel)
        {
            Log log = new Log();
            log.Mensaje = es;
            log.FechaHora = DateTime.Now;
            log.Nivel = nivel;
            ControlHorasDB.Insert(log);
        }

        public DateTime? GetHoraFinByIDUsuario(int idUsuario)
        {
            DateTime? resultado = null;
            try
            {
                resultado =
                    ControlHorasDB.FirstOrDefault<DateTime?>(
                        "Select HoraFin from fichador where IDUsuario = @0 and cast(HoraInicio as date) = cast(getdate() as date)",
                        idUsuario);
            }
            catch (Exception ex)
            {
                guardarLog(ex.Message, 2);
            }
            guardarLog("GetHoraFinByIDUsuario correctamente realizada", 4);
            return resultado;
        }


        public void insertaUsuario(string userName)
        {
            Usuarios usu = new Usuarios();

            usu.nombre = userName;

            ControlHorasDB.Insert(usu);
        }

        public void GuardarUsuarioYHoraEntrada(int IDUsuario, DateTime? horainicio)
        {

            try
            {
                Fichador fichador = new Fichador();
                int id = ControlHorasDB.FirstOrDefault<int>("SELECT Id FROM usuarios WHERE nombre = @0 ",
                    Environment.UserName);
                fichador.IDUsuario = id;
                fichador.HoraInicio = horainicio;
                fichador.HoraFin = null;
                ControlHorasDB.Insert(fichador);

                //se puede hacer de esta forma:
                //    ControlHorasDB.Execute("INSERT INTO fichador(Usuario,HoraInicio) VALUES (@0,@1)", userName, horainicio);

            }
            catch (Exception ex)
            {
                guardarLog(ex.Message, 2);
            }
            guardarLog("GuardarUsuarioYHoraEntrada correctamente realizada", 4);
        }

        public void GuardarHoraSalida(int IDUsuario, DateTime? horafin)
        {

            try
            {
                //instanciamos objeto Fichador
                Fichador ficha = new Fichador();


                //Recuperamos el registro de la consulta con FirstOrDefault, pasandole como parametro @0 el userName
                ficha = ControlHorasDB.FirstOrDefault<Fichador>(
                    "Select * from fichador where IDUsuario = @0 and cast(HoraInicio as date) = cast(getdate() as date)",
                    IDUsuario);
                //asignamos la hora de fin a la que nos pase por parametro
                ficha.HoraFin = horafin;

                ControlHorasDB.Update(ficha);

            }
            catch (Exception ex)
            {
                guardarLog(ex.Message, 2);
            }
            guardarLog("GuardarHoraSalida correctamente realizada", 4);

        }

        public List<Jornada> Jornada(DateTime FechaIni, DateTime FechaFin, int IdUser)
        {
            List<Jornada> resultado = new List<Jornada>();
            try
            {
                resultado = ControlHorasDB.Fetch<Jornada>(@"SELECT cast(f.HoraInicio as date) as Dia, DATEDIFF(minute,f.HoraInicio,f.HoraFin) AS HorasTrabajadas,
                                                                sum(t.duracion) as TotalTareas from ControlHoras.dbo.fichador f 
                                                                INNER JOIN tareas t on t.IDUsuario = f.IDUsuario and cast(t.HoraInicioTarea as date) = cast(f.HoraInicio as date)                                                          
                                                                WHERE f.IDUsuario= @0 and DATEDIFF(minute,HoraInicio,HoraFin) < 530 and cast(HoraInicio as date) >= @1 
                                                                and cast(HoraInicio as date) <=@2 group by cast(f.HoraInicio as date),
                                                                DATEDIFF(minute,f.HoraInicio,f.HoraFin)", IdUser, FechaIni, FechaFin).ToList();

            }
            catch (Exception ex)
            {
                guardarLog(ex.Message, 2);
            }

            guardarLog("Jornada correctamente realizada", 4);

            return resultado;
        }

        private object ToInt(List<Models.Jornada> resultado)
        {
            throw new NotImplementedException();
        }

        public Usuarios GetUsuarioByUserName(string userName)
        {
            //HACER LA SELECT QUE NOS DEVUELVA EL USUARIO
            Usuarios resultado = null;
            try
            {
                resultado = ControlHorasDB.FirstOrDefault<Usuarios>("Select nombre from usuarios where nombre = @0", userName);
            }
            catch (Exception ex)
            {
                guardarLog(ex.Message, 2);
            }

            guardarLog("GetUsuarioByUserName correctamente realizada", 4);

            return resultado;
        }

        public List<Fichador> GetListaByEntreFechas(DateTime fechaInicial, DateTime fechaFinal)
        {
            List<Fichador> resultado = null;
            try
            {
                resultado = ControlHorasDB.Fetch<Fichador>(
                        "Select uno.nombre, dos.HoraInicio,dos.HoraFin,dos.ID, dos.IDUsuario from ControlHoras.dbo.usuarios as uno, ControlHoras.dbo.Fichador as dos where uno.ID=dos.IDUsuario and cast(HoraInicio as date) >= @0 and cast(HoraInicio as date) <= @1 order by IDUsuario, HoraInicio",
                        fechaInicial.ToString("yyyyMMdd"), fechaFinal.ToString("yyyyMMdd"));
            }
            catch (Exception ex)
            {
                guardarLog(ex.Message, 2);
            }

            guardarLog("GetListaByEntreFechas correctamente realizada", 4);

            return resultado;
        }

        public List<Fichador> GetListaByEntreFechasID(DateTime fechaInicial, DateTime fechaFinal, int id)
        {
            List<Fichador> resultado = null;
            try
            {

                resultado =
                    ControlHorasDB.Fetch<Fichador>(
                        "Select uno.nombre, dos.HoraInicio,dos.HoraFin,dos.ID, dos.IDUsuario from ControlHoras.dbo.usuarios as uno, ControlHoras.dbo.Fichador as dos   where uno.ID=dos.IDUsuario and IDUsuario = @0 and cast(HoraInicio as date) >= @1 and cast(HoraInicio as date) <= @2 order by IDUsuario, HoraInicio",
                        id, fechaInicial.ToString("yyyyMMdd"), fechaFinal.ToString("yyyyMMdd"));

            }
            catch (Exception ex)
            {
                guardarLog(ex.Message, 2);
            }

            guardarLog("GetListaByEntreFechasID correctamente realizada", 4);

            return resultado;
        }


        public List<Fichador> GetDatosFichador()
        {
            List<Fichador> resultado = null;
            try
            {
                resultado = ControlHorasDB.Fetch<Fichador>("Select * from fichador");
            }
            catch (Exception ex)
            {
                guardarLog(ex.Message, 2);
            }
            guardarLog("GetDatosFichador correctamente realizada", 4);
            return resultado;
        }

        public List<Fichador> GetListaByFecha(DateTime fecha, int id)
        {
            List<Fichador> resultado = null;
            try
            {
               
                resultado =
                    ControlHorasDB.Fetch<Fichador>(
                        "Select * from fichador where IDUsuario = @0 and cast(HoraInicio as date) = @1",
                        id, fecha.ToString("yyyyMMdd"));
            }
            catch (Exception ex)
            {
                guardarLog(ex.Message, 2);
            }

            guardarLog("GetListaByFecha correctamente realizada", 4);

            return resultado;
        }

        public List<Fichador> GetListaByFecha2(DateTime fecha, int id)
        {
            List<Fichador> resultado = null;
            try
            {

                resultado =
                    ControlHorasDB.Fetch<Fichador>(
                        @"Select uno.nombre as Nombre, dos.HoraInicio as HoraInicio, dos.HoraFin as HoraFin, dos.ID as ID ,dos.IDUsuario as IDUsuario from ControlHoras.dbo.usuarios as uno, ControlHoras.dbo.Fichador as dos 
                        where cast(HoraInicio as date) = @1 and uno.ID = dos.IDUsuario and dos.IDUsuario= @0",id, fecha.ToString("yyyyMMdd"));
            }
            catch (Exception ex)
            {
                guardarLog(ex.Message, 2);
            }

            guardarLog("GetListaByFecha correctamente realizada", 4);

            return resultado;
        }

        public string HorasTrabajadas(int id, DateTime diaInicio)
        {
            string resultado = null;
            
            try
            {
                resultado = ControlHorasDB.FirstOrDefault<string>("select sum(duracion) from Tareas where IDUsuario = @0 and cast(HoraInicioTarea as date) = @1", id, diaInicio.ToString("d"));   
            }
            catch (Exception ex)
            {
                guardarLog(ex.Message, 2);
            }
            guardarLog("HorasTrabajadas correctamente realizada", 4);
            return resultado;
        }

        public int HorasTrabajadasCalculo(int id, DateTime diaInicio)
        {
            int resultado = 0;
            try
            {
                resultado = ControlHorasDB.FirstOrDefault<int>("select sum(duracion)  from Tareas where IDUsuario=@0 and cast(HoraInicioTarea as date =@1", id, diaInicio);
            }
            catch (Exception ex)
            {
                guardarLog(ex.Message, 2);
            }

            guardarLog("HorasTrabajadasCalculo correctamente realizada", 4);

            return resultado;
        }

        public List<Usuarios> GetListaUsuarios()
        {
            List<Usuarios> lista = null;
            try
            {
                lista = ControlHorasDB.Fetch<Usuarios>("Select * from usuarios");
            }
            catch (Exception ex)
            {
                guardarLog(ex.Message, 2);
            }

            guardarLog("GetListaUsuarios correctamente realizada", 4);

            return lista;
        }


        public void GuardarListaUsuarios(List<UsuariosListas> lista)
        {
            try
            {
                foreach (UsuariosListas user in lista) //recorre la lista del datagrid
                {
                    //actualiza todos los registros haya cambios o no los haya
                    ControlHorasDB.Execute("UPDATE usuarios SET EsAdmin = @0 WHERE Id = @1", user.EsAdmin, user.ID);
                }
            }
            catch (Exception ex)
            {
                guardarLog(ex.Message, 2);
            }

            guardarLog("GuardarListaUsuarios correctamente realizada", 4);

        }

        public DateTime consultaPrimerRegistro()
        {
            DateTime ch = new DateTime();
            try
            {
                ch = ControlHorasDB.FirstOrDefault<DateTime>("Select HoraInicio from fichador ORDER BY HoraInicio ASC");
            }
            catch (Exception ex)
            {
                guardarLog(ex.Message, 2);
            }

            guardarLog("consultaPrimerRegistro correctamente realizada", 4);

            return ch;
        }

        public List<UsuariosListas> RellenaComboBox()
        {
            List<UsuariosListas> lista = null;
            try
            {
               lista = ControlHorasDB.Fetch<UsuariosListas>("Select nombre, Id from usuarios ");

            }
            catch (Exception ex)
            {
                guardarLog(ex.Message, 2);
            }

            guardarLog("RellenaComboBox correctamente realizada", 4);

            return lista;
        }

        public List<Tareas> MostrarListaTareas()
        {
            List<Tareas> listaTareas = null;
            try
            {
                listaTareas = ControlHorasDB.Fetch<Tareas>("select tareas.*, usuarios.nombre as Nombre from tareas inner join usuarios  on Usuarios.Id = tareas.IDUsuario");
            }
            catch (Exception ex)
            {
                guardarLog(ex.Message, 2);
            }

            guardarLog("MostrarListaTareas correctamente realizada", 4);

            return listaTareas;
        }

        public List<Tareas> MostrarListaTareasPorUsuario(int id)
        {
            List<Tareas> listaTareas = null;
            try
            {
                listaTareas = ControlHorasDB.Fetch<Tareas>("select tareas.*, usuarios.nombre as Nombre from tareas inner join usuarios  on Usuarios.Id = tareas.IDUsuario where tareas.IDUsuario=@0", id);
            }
            catch (Exception ex)
            {
                guardarLog(ex.Message, 2);
            }

            guardarLog("MostrarListaTareasPorUsuario correctamente realizada", 4);

            return listaTareas;
        }
       
      
        public bool consultaAdmin()
        {
            bool check = false;
            try
            {
                check = ControlHorasDB.FirstOrDefault<bool>("Select EsAdmin from usuarios Where nombre = @0", Environment.UserName);

            }
            catch (Exception ex)
            {
                guardarLog(ex.Message, 2);
            }

            guardarLog("consultaAdmin correctamente realizada", 4);

            return check;
        }

        //TAREAS:

        public void insertaTarea(DateTime hInicio, int dur, string nomtarea, string desc, int IDu)
        {
            try
            {
              var horafin = hInicio.AddMinutes(dur);

                if (consultaAdmin() == false)
                {
                    var id = GetIDUsuarioByUserName(Environment.UserName);
                    ControlHorasDB.Execute(
                        "INSERT INTO Tareas(IDUsuario, HoraInicioTarea, HoraFinTarea, duracion, nombreTarea, descripcionTarea) VALUES (@0,@1,@2,@3,@4,@5)",
                        id, hInicio, horafin, dur, nomtarea, desc);
                }
                else
                {
                    ControlHorasDB.Execute(
                        "INSERT INTO Tareas(IDUsuario, HoraInicioTarea, HoraFinTarea, duracion, nombreTarea, descripcionTarea) VALUES (@0,@1,@2,@3,@4,@5)",
                        IDu, hInicio, horafin, dur, nomtarea, desc);
                }

            }
            catch (Exception ex)
            {
                guardarLog(ex.Message, 2);
            }

            guardarLog("insertaTarea correctamente realizada", 4);
        }

        public string GetHoraInicioByDia(DateTime dia, int idusuario)
        {
            string hora = null;
            try
            {
                hora =
                    ControlHorasDB.FirstOrDefault<string>(
                        "Select HoraInicio from Fichador where IDUsuario = @0 and cast(Horafin as date) = @1", idusuario,
                        dia);
            }
            catch (Exception ex)
            {
                guardarLog(ex.Message, 2);
            }

            guardarLog("GetHoraInicioByDia correctamente realizada", 4);
                
            return hora;
        }
                    
        public string GetHoraFinByDia(DateTime dia, int idusuario)
        {
            string hora = null;
            try
            {
                hora =
                    ControlHorasDB.FirstOrDefault<string>(
                        "Select HoraFin from Fichador where IDUsuario = @0 and cast(Horafin as date) = @1", idusuario,
                        dia);
            }
            catch (Exception ex)
            {
                guardarLog(ex.Message, 2);
            }

            guardarLog("GetHoraFinByDia correctamente realizada", 4);

            return hora;
        }

        public Tareas getNombreUserTareas(int id)
        {
            Tareas p = null;
            try
            {
                p = ControlHorasDB.FirstOrDefault<Tareas>("Select nombre from Tareas inner join usuarios on tareas.IDUsuario=usuarios.Id where IDUsuario = @0", id);
             
            }
            catch (Exception ex)
            {
                guardarLog(ex.Message, 2);
            }

            guardarLog("getNombreUserTareas correctamente realizada", 4);

            return p;
        }

        public string getUsuarioById(int id)
        {
            string nameUsuario = null;
            try
            {
                nameUsuario = ControlHorasDB.FirstOrDefault<string>("Select nombre from usuarios where Id = @0", id);
            }
            catch (Exception ex)
            {
                guardarLog(ex.Message, 2);
            }

            guardarLog("getUsuarioById correctamente realizada", 4);

            return nameUsuario;
        }
        public string sumaDiaYHora(DateTime diaInicio, DateTime horaInicio)
        {
            var dia = diaInicio.ToString("d");
            var h = horaInicio.ToString("T");
            var concat = dia + " " + h;
            return concat;
        }

        public int obtenerHorasTrabajadasDiaFichador(string diaSeleccion, int id)
        {
            int resultado = -1;
            try
            {
                //haz la resta de la HoraInicio - Horafin para saber cuantos minutos (la duracion) desde que ha fichado hasta que ha desfichado
                resultado = ControlHorasDB.FirstOrDefault<int>("Select Datediff(minute,HoraInicio, HoraFin) from fichador where cast(HoraInicio as date) = @0 and IDUsuario = @1", diaSeleccion, id);
            }
            catch (Exception ex)
            {
                guardarLog(ex.Message, 2);
        }
      
            guardarLog("obtenerHorasTrabajadasDiaFichador correctamente realizada", 4);

            return resultado;
        }
    }
}