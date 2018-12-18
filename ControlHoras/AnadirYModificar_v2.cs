using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alc.Data;
using Alc.Model.ControlHoras;
using ControlHoras.DAL;
using ControlHoras.Models;
using Telerik.WinControls.UI;

namespace ControlHoras
{
    public partial class AnadirYModificar_v2 : RadForm
    {
        private ControlHoras.DAL.AccesoFichador accesoDatos = null;
        private List<FichadorMio> DatosFich = null;
        private List<Fichador> DatosfichadorBD = null;
        private List<TareasLista> datosTareas = null;
        private Tareas vTareas = null;
        private Alc.Model.ControlHoras.Tareas listaTareas = new Alc.Model.ControlHoras.Tareas();
        private bool comprueba = false;

        public AnadirYModificar_v2(Alc.Model.ControlHoras.Tareas lTareas, Tareas vTar)
        {
            InitializeComponent();

            if (accesoDatos == null)
            {
                accesoDatos = new AccesoFichador();
            }
            
            if (lTareas == null)
            {
                comprueba = true;
                this.vTareas = vTar;
                this.Text = "Añadir";
                label1.Text = "*Añadir una Tarea";
            }
            else
            {
                comprueba = false;
                this.Text = "Modificar";
                label1.Text = "*Modificar Tarea";
            }
        }

        public void ModificarTareas(Alc.Model.ControlHoras.Tareas tareas, Tareas ventanaTareas)
        {

            try
            {
                if (accesoDatos == null)
                {
                    accesoDatos = new AccesoFichador();
                }

                var idSel = listaTareas.IDUsuario;
                var usuSel = accesoDatos.getUsuarioById(idSel);
                listaTareas.IDUsuario = idSel;
                listaTareas.descripcionTarea = txtDescripcionAM2.Text;
                
                var val = listaTareas.duracion;

                if (int.TryParse(nmrDuracion2.Value.ToString(), out val) == true && val >= 0)
                {
                    listaTareas.duracion = Convert.ToInt32(nmrDuracion2.Value);
                }
                else
                {
                    MessageBox.Show("No se pueden poner numeros");
                }

                listaTareas.nombreTarea = txtNombreTareaAM2.Text;
                var calculoHoraInicio = accesoDatos.sumaDiaYHora(DateDiaPickerAM2.Value, (DateTime)radTimePickerHoraInicioAM2.Value);
                listaTareas.HoraInicioTarea = Convert.ToDateTime(calculoHoraInicio);
                DateTime dt = (DateTime)listaTareas.HoraInicioTarea;
                dt = dt.AddMinutes(listaTareas.duracion);
                listaTareas.HoraFinTarea = dt;

                int minutosFichados = accesoDatos.obtenerHorasTrabajadasDiaFichador(DateDiaPickerAM2.Value.ToString("d"), idSel);

                if (listaTareas.duracion <= minutosFichados)
                {
                    accesoDatos.ControlHorasDB.Update(listaTareas);
                }
                else
                {
                    MessageBox.Show("REVISAR MINUTOS DE LAS TAREAS");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                accesoDatos.guardarLog(ex.Message, 2);

            }
            accesoDatos.guardarLog("ModificarTareas correctamente realizado", 4);

        }

        private void btnAceptar2_Click(object sender, EventArgs e)
        {
            try
            {
                if (comprueba == true)
                {
                    AnadirTarea(vTareas);
                }
                else
                {
                    ModificarTareas(listaTareas, vTareas);
                }

                if ((string.IsNullOrEmpty(txtNombreTareaAM2.Text)) || (string.IsNullOrEmpty(txtDescripcionAM2.Text)))
                {
                    MessageBox.Show("Debe completar la informacion");
                }


            }
            catch (Exception ex)
            {

                accesoDatos.guardarLog(ex.Message, 2);
            }
            accesoDatos.guardarLog("btnAceptar_click correctamente realizado", 4);
        }

        public void sacaH¡

        public void AnadirTarea(Tareas ventanaTareas)
        {
            try
            {

                if (accesoDatos == null)
                {
                    accesoDatos = new AccesoFichador();
                }

                MessageBox.Show("Has entrado a anadir");
                var valor = (UsuariosListas)cBoxListadoAM2.SelectedValue;

                var sumaDiaYHora = (DateDiaPickerAM2.Value).Date + ((DateTime)radTimePickerHoraInicioAM2.Value).TimeOfDay;



                listaTareas.IDUsuario = valor.ID;
                listaTareas.descripcionTarea = txtDescripcionAM2.Text;
                listaTareas.nombreTarea = txtNombreTareaAM2.Text;
                listaTareas.duracion = (int) nmrDuracion2.Value;
                listaTareas.HoraFinTarea = DateDiaPickerAM2.Value.AddMinutes((int) nmrDuracion2.Value);
                listaTareas.HoraInicioTarea = sumaDiaYHora;
                




                //var concatenacion = (DateDiaPickerAM2.Value).Date + ((DateTime)radTimePickerHoraInicioAM2.Value).TimeOfDay;

                //var nomTarea = txtNombreTareaAM2.Text;
                //var descTarea = txtDescripcionAM2.Text;

                ////saca la duracion total de ese usuario y de esa fecha "concatenada"
                //string minutosTrabajadosDia = accesoDatos.HorasTrabajadas(Convert.ToInt32(valor.ID), Convert.ToDateTime(concatenacion));
                ////los minutos totales trabajados en ese dia y para ese usuario
                //int minutosFichados = accesoDatos.obtenerHorasTrabajadasDiaFichador(DateDiaPickerAM2.Value.ToString("d"), valor.ID);
                ////que admita solo enteros el campo duracion:

                //int dur = Convert.ToInt32(nmrDuracion2.Value);

                ////cada vez que le pongamos una duracion que nos lo sume en nuestra variable, para ir acumulandolo y poder controlarlo

                //int sumaDurYminTrabajados = Convert.ToInt32(minutosTrabajadosDia) + dur;

                ////saca el dia del pick
                //var day = DateDiaPickerAM2.Value.ToString("d");
                ////saca nuestro ID:
                //var sacaID = (UsuariosListas)cBoxListadoAM2.SelectedValue;
                //var ide = accesoDatos.GetIDUsuarioByUserName(sacaID.nombre);

                ////saca la hora y fecha  seleccionadas
                //var horaDeComboBox = (DateTime)radTimePickerHoraInicioAM2.Value;
                //var horaDia = horaDeComboBox.ToString("t");//tengo hora del combobox, la que hayamos seleccionado, con formato 00:00

                //var horaDelDia = Convert.ToDateTime(concatenacion); //convertido

                ////saca la HoraInicio, dado el dia y su id
                //var horaInicios = Convert.ToDateTime(accesoDatos.GetHoraInicioByDia(Convert.ToDateTime(day), ide));

                ////saca HoraFin dado el dia y su id
                //var horaFinal = Convert.ToDateTime(accesoDatos.GetHoraFinByDia(Convert.ToDateTime(day), ide));

                ////si los minutos totales fichados(haber fichado y desfichado) son mayores o iguales que la suma de los minutos y duraciones que lo inserte
                ////si tenemos 20 minutos fichados y hemos puesto duracion de 10 y luego de 5, si que las insertaria, porque 20>=10 y 20>=(10+5)

                //if (minutosFichados == -1)
                //{
                //    MessageBox.Show("NO HAS TERMINADO DE FICHAR");
                //}
                //else if (minutosFichados < sumaDurYminTrabajados)
                //{
                //    MessageBox.Show("REVISAR MINUTOS DE LAS TAREAS");

                //} //si se pasa y ya no se cumple no dejará insertar
                //else if (horaDelDia < horaInicios || horaDelDia > horaFinal)
                //{
                //    MessageBox.Show("LA HORA ES INCORRECTA");
                //}
                //else if (dur == 0)
                //{
                //    MessageBox.Show(("NO PUEDES PONER VALOR 0 EN UNA TAREA"));
                //}
                //else
                //{
                //    accesoDatos.insertaTarea(Convert.ToDateTime(concatenacion), dur, nomTarea, descTarea, usuario.ID);
                //}

                //if (accesoDatos == null)
                //{
                //    accesoDatos = new AccesoFichador();
                //}
                ////  int resultado = accesoDatos.HorasTrabajadas();
                //if (DatosFich != null)
                //{
                //    //hacemos el filtro comparando que el ID del user de la tabla Usuarios coincida con el del objeto de Fichador(el que hayamos seleccionado)
                //    DatosFich.Where(user => user.IDUsuario == valor.ID).ToList();
                //}
                //var listas = accesoDatos.RellenaComboBox();
                //cBoxListadoAM2.DataSource = listas;


            }
            catch (Exception ex)
            {
                accesoDatos.guardarLog(ex.Message, 2);
            }
            accesoDatos.guardarLog("AñadirTareas correctamente realizado", 4);
        }

        private void AnadirYModificar_v2_Load(object sender, EventArgs e)
        {
            //var lista = accesoDatos.RellenaComboBox();
            var lista = new Sql();
            lista.Select("*").From("Usuarios");
            ControlHorasDB control = new ControlHorasDB();
            var data = control.Fetch<UsuariosListas>(lista);

            cBoxListadoAM2.DisplayMember = "nombre";
            cBoxListadoAM2.ValueMember = "nombre";
            cBoxListadoAM2.DataSource = data;





        }

        public static string GetMemberName<T, TValue>(Expression<Func<T, TValue>> memberAccess)
        {
            return ((MemberExpression)memberAccess.Body).Member.Name;
        }
    }
}