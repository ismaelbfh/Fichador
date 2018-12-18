using Alc.Model.ControlHoras;
using ControlHoras.DAL;
using ControlHoras.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace ControlHoras
{
    public partial class AnadirYModificar : RadForm
    {
        private ControlHoras.DAL.AccesoFichador accesoDatos = null;
        private List<FichadorMio> DatosFich = null;
        private List<Fichador> DatosfichadorBD = null;
        private List<TareasLista> datosTareas = null;
        private Tareas vTareas = null;
        private Alc.Model.ControlHoras.Tareas tareaslista = new Alc.Model.ControlHoras.Tareas();
        private bool comprueba = false;
        private Alc.Model.ControlHoras.Tareas tar = new Alc.Model.ControlHoras.Tareas();

        public AnadirYModificar(Alc.Model.ControlHoras.Tareas tareas, Tareas ventanaTareas)
        {
            InitializeComponent();

            if (accesoDatos == null)
            {
                accesoDatos = new AccesoFichador();
            }

            if (tareas == null)
            {
                comprueba = true;
                this.vTareas = ventanaTareas;
                this.Text = "Añadir";
                label1.Text = "*Añadir una Tarea";
            }
            else
            {
                comprueba = false;
                this.Text = "Modificar";
                label1.Text = "*Modificar Tarea";
                txtDescripcionAM.Text = tareas.descripcionTarea;
                nmrDuracion.Value = tareas.duracion;
                txtNombreTareaAM.Text = tareas.nombreTarea;
                DateDiaPickerAM.Text = Convert.ToDateTime(tareas.HoraInicioTarea).ToString("d");

                DateDiaPickerAM.Value = Convert.ToDateTime(tareas.HoraInicioTarea);
                //radTimePickerHoraInicioAM.Value = Convert.ToDateTime(tareas.HoraInicioTarea);

                this.vTareas = ventanaTareas;

                if (accesoDatos == null)
                {
                    accesoDatos = new AccesoFichador();
                }

                //por un lado relleno el combobox
                var listas = accesoDatos.RellenaComboBox();

                cBoxListadoAM.DisplayMember = "nombre";
                cBoxListadoAM.ValueMember = "nombre";

                //por otro lado 
                var idSel = tareas.IDUsuario;
                var usuSel = accesoDatos.getUsuarioById(idSel);

                cBoxListadoAM.DataSource = listas;
                cBoxListadoAM.SelectedValue = usuSel;

                //PARA CONTROLAR EL MODIFICAR LAS HORAS:
                var day = DateDiaPickerAM.Value.ToString("d");

                //sacamos la hora de fin de ese dia y de ese id
                var valorMax = accesoDatos.GetHoraFinByDia(Convert.ToDateTime(day), idSel);
                var valorMin = accesoDatos.GetHoraInicioByDia(Convert.ToDateTime(day), idSel);
                //construimos la fecha haciendo la suma del dia + la hora
                //le decimos que el valor maximo sea esa fecha;
                radTimePickerHoraInicioAM.MaxValue = Convert.ToDateTime(valorMax);
                radTimePickerHoraInicioAM.MinValue = Convert.ToDateTime(valorMin);

                cBoxListadoAM.Enabled = false;
                tareaslista = tareas;
                tareas = tar;
               
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

                //TODO: OTRA MANERA DE CONVERTIR: 
                //var intvalue = 0;
                //int.TryParse(txtDuracionAM.Text, out intvalue);

                var idSel = tareaslista.IDUsuario;
                var usuSel = accesoDatos.getUsuarioById(idSel);
                tareaslista.IDUsuario = idSel;
                tareaslista.descripcionTarea = txtDescripcionAM.Text;

                var val = tareaslista.duracion;

                if (int.TryParse(nmrDuracion.Value.ToString(), out val) == true && val >= 0)
                {
                    tareaslista.duracion = Convert.ToInt32(nmrDuracion.Value);
                }
                else
                {
                    MessageBox.Show("No se pueden poner numeros");
                }

                tareaslista.nombreTarea = txtNombreTareaAM.Text;
                var calculoHoraInicio = accesoDatos.sumaDiaYHora(DateDiaPickerAM.Value, (DateTime)radTimePickerHoraInicioAM.Value);
                tareaslista.HoraInicioTarea = Convert.ToDateTime(calculoHoraInicio);
                DateTime dt = (DateTime)tareaslista.HoraInicioTarea;
                dt = dt.AddMinutes(tareaslista.duracion);
                tareaslista.HoraFinTarea = dt;

                int minutosFichados = accesoDatos.obtenerHorasTrabajadasDiaFichador(DateDiaPickerAM.Value.ToString("d"), idSel);

                if (tareaslista.duracion <= minutosFichados)
                {
                    accesoDatos.ControlHorasDB.Update(tareaslista);
                }
                else
                {
                    MessageBox.Show("REVISAR MINUTOS DE LAS TAREAS");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                accesoDatos.guardarLog(ex.Message,2);
               
            }
            accesoDatos.guardarLog("ModificarTareas correctamente realizado", 4);

        }

        public void AnadirTareas(Tareas ventanaTareas)
        {
            try
            {

                if (accesoDatos == null)
                {
                    accesoDatos = new AccesoFichador();
                }

                var valor = (UsuariosListas)cBoxListadoAM.SelectedValue;
                var usuario = (UsuariosListas)cBoxListadoAM.SelectedItem;


                //TODO: He encontrado otra manera de hacer esto

                //--> var concatenacion = (DateDiaPickerAM.Value).Date + ((DateTime) radTimePickerHoraInicioAM.Value).TimeOfDay;

                //Si vais a utilizar el resultado de sumaDiayHora como DAtetime y no como string, devolver en la funcion datetime y os ahorrais el 
                // casteo cada vez que la utiliceis 
                //var concatenacion = accesoDatos.sumaDiaYHora(DateDiaPickerAM.Value, (DateTime)radTimePickerHoraInicioAM.Value));
                var concatenacion = (DateDiaPickerAM.Value).Date + ((DateTime)radTimePickerHoraInicioAM.Value).TimeOfDay;

                var nomTarea = txtNombreTareaAM.Text;
                var descTarea = txtDescripcionAM.Text;

                //saca la duracion total de ese usuario y de esa fecha "concatenada"
                string minutosTrabajadosDia = accesoDatos.HorasTrabajadas(Convert.ToInt32(valor.ID), Convert.ToDateTime(concatenacion));
                //los minutos totales trabajados en ese dia y para ese usuario
                int minutosFichados = accesoDatos.obtenerHorasTrabajadasDiaFichador(DateDiaPickerAM.Value.ToString("d"), valor.ID);
                //que admita solo enteros el campo duracion:

                int dur = Convert.ToInt32(nmrDuracion.Value);

                //cada vez que le pongamos una duracion que nos lo sume en nuestra variable, para ir acumulandolo y poder controlarlo

                int sumaDurYminTrabajados = Convert.ToInt32(minutosTrabajadosDia) + dur;

                //saca el dia del pick
                var day = DateDiaPickerAM.Value.ToString("d");
                //saca nuestro ID:
                var sacaID = (UsuariosListas)cBoxListadoAM.SelectedValue;
                var ide = accesoDatos.GetIDUsuarioByUserName(sacaID.nombre);

                //saca la hora y fecha  seleccionadas
                var horaDeComboBox = (DateTime)radTimePickerHoraInicioAM.Value;
                var horaDia = horaDeComboBox.ToString("t");//tengo hora del combobox, la que hayamos seleccionado, con formato 00:00

                var horaDelDia = Convert.ToDateTime(concatenacion); //convertido

                //saca la HoraInicio, dado el dia y su id
                var horaInicios = Convert.ToDateTime(accesoDatos.GetHoraInicioByDia(Convert.ToDateTime(day), ide));

                //saca HoraFin dado el dia y su id
                var horaFinal = Convert.ToDateTime(accesoDatos.GetHoraFinByDia(Convert.ToDateTime(day), ide));

                //si los minutos totales fichados(haber fichado y desfichado) son mayores o iguales que la suma de los minutos y duraciones que lo inserte
                //si tenemos 20 minutos fichados y hemos puesto duracion de 10 y luego de 5, si que las insertaria, porque 20>=10 y 20>=(10+5)

                if (minutosFichados == -1)
                {
                    MessageBox.Show("NO HAS TERMINADO DE FICHAR");
                }
                else if (minutosFichados < sumaDurYminTrabajados)
                {
                    MessageBox.Show("REVISAR MINUTOS DE LAS TAREAS");

                } //si se pasa y ya no se cumple no dejará insertar
                else if (horaDelDia < horaInicios || horaDelDia > horaFinal)
                {
                    MessageBox.Show("LA HORA ES INCORRECTA");
                }else if (dur==0)
                {
                    MessageBox.Show(("NO PUEDES PONER VALOR 0 EN UNA TAREA"));
                }
                else
                {
                    accesoDatos.insertaTarea(Convert.ToDateTime(concatenacion), dur, nomTarea, descTarea, usuario.ID);
                }

                if (accesoDatos == null)
                {
                    accesoDatos = new AccesoFichador();
                }
                //  int resultado = accesoDatos.HorasTrabajadas();
                if (DatosFich != null)
                {
                    //hacemos el filtro comparando que el ID del user de la tabla Usuarios coincida con el del objeto de Fichador(el que hayamos seleccionado)
                    DatosFich.Where(user => user.IDUsuario == valor.ID).ToList();
                }
                var listas = accesoDatos.RellenaComboBox();
                cBoxListadoAM.DataSource = listas;
                

            }
            catch (Exception ex)
            {
                accesoDatos.guardarLog(ex.Message, 2);
            }
            accesoDatos.guardarLog("AñadirTareas correctamente realizado", 4);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comprueba == true)
                {
                    AnadirTareas(vTareas);
                }
                else
                {
                    ModificarTareas(tar, vTareas);
                }

                if ((string.IsNullOrEmpty(txtNombreTareaAM.Text))||(string.IsNullOrEmpty(txtDescripcionAM.Text)))
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

        private void AnadirYModificar_Load(object sender, EventArgs e)
        {

            try
            {

                if (accesoDatos == null)
                {
                    accesoDatos = new AccesoFichador();
                }

                DateDiaPickerAM.MaxDate = DateTime.Now;


                if (comprueba == true)
                {
                    DateDiaPickerAM.Value = DateTime.Now;
                    //radTimePickerHoraInicioAM.Value = DateTime.Now;

                    if (accesoDatos == null)
                    {
                        accesoDatos = new AccesoFichador();
                    }

                    //primero será sacar el campo EsAdmin del usuario actual, si es true que active el ComboBox, sino que lo descative y no deje filtrar
                    cBoxListadoAM.Enabled = accesoDatos.consultaAdmin();

                
                    var lista = accesoDatos.RellenaComboBox();

                    cBoxListadoAM.DataSource = lista;
                    cBoxListadoAM.DisplayMember = "nombre";
                    var usuario = lista.FirstOrDefault(x => x.nombre == Environment.UserName);
                    cBoxListadoAM.SelectedIndex = lista.IndexOf(usuario);

                    cBoxListadoAM.DataSource = lista;

                    cBoxListadoAM.DisplayMember = "nombre";

                    filtrarDiaYFecha();
                    radTimePickerHoraInicioAM.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                accesoDatos.guardarLog(ex.Message, 2);
            }
            accesoDatos.guardarLog("AñadirYModificar_load correctamente realizado", 4);
        }
        public void filtrarDiaYFecha()
        {
            try
            {

                //para que solo nos deje el reloj elegir hasta esa fecha:
                //primero saco el dia del picker-calendario con formato DD/MM/YYYY
                var day = DateDiaPickerAM.Value.ToString("d");
                //sacamos id:
                var sacaID = (UsuariosListas)cBoxListadoAM.SelectedValue;
                var ide = accesoDatos.GetIDUsuarioByUserName(sacaID.nombre);

                //sacamos la hora de fin de ese dia y de ese id
                var valorMax = accesoDatos.GetHoraFinByDia(Convert.ToDateTime(day), ide);
                var valorMin = accesoDatos.GetHoraInicioByDia(Convert.ToDateTime(day), ide);
                //construimos la fecha haciendo la suma del dia + la hora
                var sumaFecha = valorMax;
                //le decimos que el valor maximo sea esa fecha;
                radTimePickerHoraInicioAM.MaxValue = Convert.ToDateTime(sumaFecha);
                radTimePickerHoraInicioAM.MinValue = Convert.ToDateTime(valorMin);

                //radTimePickerHoraInicioAM.Value;
            }
            catch (Exception ex)
            {
                accesoDatos.guardarLog(ex.Message, 2);
            }
            accesoDatos.guardarLog("ModificarTareas correctamente realizado", 4);

        }

        private void DateDiaPickerAM_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (comprueba == true)
                {
                    filtrarDiaYFecha();
                }
             radTimePickerHoraInicioAM.Enabled = true;
            }
            catch (Exception ex)
            {
                accesoDatos.guardarLog(ex.Message, 2);
            }
            accesoDatos.guardarLog("DateDiaPickerAM_ValueChanged correctamente realizado", 4);

        }

        private void cBoxListadoAM_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comprueba == true)
                {
                    filtrarDiaYFecha();
                }
            }
            catch (Exception ex)
            {
                accesoDatos.guardarLog(ex.Message, 2);
            }
            accesoDatos.guardarLog("cBoxListadoAM_SelectedIndexChanged correctamente realizado", 4);


        }

        private void AnadirYModificar_FormClosed(object sender, FormClosedEventArgs e)
        {
            vTareas.filtrar();

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (comprueba == true)
            {
                CustomMsgBox.Show("Añadir tareas, primero hay que seleccionar \n la fecha deseada", "Información Añadir", "Aceptar", "Cancelar");
            }
            else if (comprueba == false)
            {
                CustomMsgBox.Show("Modificar tarea seleccionada anteriormente, \n primero hay que seleccionar la fecha deseada", "Información Modificar", "Aceptar", "Cancelar");

            }
        }

    }


}

