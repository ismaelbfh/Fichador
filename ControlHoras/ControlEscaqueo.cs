using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alc.Model.ControlHoras;
using ControlHoras.DAL;
using ControlHoras.Models;
using Telerik.WinControls.UI;
using System.Runtime.InteropServices;

namespace ControlHoras
{
    public partial class ControlEscaqueo : RadForm
    {
        private ControlHoras.DAL.AccesoFichador accesoDatos = null;
        private List<FichadorMio> DatosFich = null;
        private List<Fichador> DatosfichadorBD = null;
        private List<TareasLista> datosTareas = null;
        private List<Jornada> datosJornada = new List<Jornada>();
        private Log log = new Log();
        private bool secuencia = false;

        public ControlEscaqueo()
        {
            InitializeComponent();
            //quita agrupacion:
            DataGridJornada.EnableGrouping = false;
            //quita primera columna del grid
            DataGridJornada.ShowRowHeaderColumn = false;
        }


        

        private void Form1_Load(object sender, EventArgs e)
        {
            //int num = accesoDatos.Jornada(Convert.ToDateTime(diaInicio), valor.ID);
            if (accesoDatos == null)
            {
                accesoDatos = new AccesoFichador();
            }

            DateDiaPicker.MaxDate = DateTime.Now;
            DateDiaPicker.Value = DateTime.Now;
            DateDiaPicker.MinDate = accesoDatos.consultaPrimerRegistro();
            DateDiaPicker2.MinDate = accesoDatos.consultaPrimerRegistro();
            DateDiaPicker2.MaxDate = DateTime.Now;
            DateDiaPicker2.Value = DateTime.Now;

            //primero será sacar el campo EsAdmin del usuario actual, si es true que active el ComboBox, sino que lo descative y no deje filtrar
            cBoxListado.Enabled = accesoDatos.consultaAdmin();
            var lista = accesoDatos.RellenaComboBox();
            if (accesoDatos.consultaAdmin() == false)
            {
                lista = lista.Where(dato => dato.nombre == Environment.UserName).ToList();
            }

            cBoxListado.DataSource = lista;

            cBoxListado.DisplayMember = "nombre";
            secuencia = true;
            filtrarUsuario();



        }

        private void cBoxListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(secuencia==true)
            filtrarUsuario();
        }

        public void filtrarUsuario()
        {

            var diaInicio = DateDiaPicker.Value.ToString("d");
            var diafin = DateDiaPicker2.Value.ToString("d");
            var valor=(UsuariosListas)cBoxListado.SelectedValue;
            try
            {
                if (accesoDatos == null)
                {
                    accesoDatos = new AccesoFichador();
                }

                datosJornada = accesoDatos.Jornada(DateDiaPicker.Value, DateDiaPicker2.Value, valor.ID);

                if (datosJornada.Count != 0)
                {
                    DataGridJornada.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
                    DataGridJornada.ReadOnly = true;
                    DataGridJornada.DataSource = datosJornada;

                    DataGridJornada.DataSource = datosJornada.Select(list => new Jornada { Dia = list.Dia, HorasTrabajadas = list.HorasTrabajadas, TotalTareas = list.TotalTareas, Diferencia = list.Diferencia }).ToList();
                }
 
            }
         
            catch (Exception ex)
            {
                accesoDatos.guardarLog(ex.Message, 2);
            }
            accesoDatos.guardarLog("filtrarUsuario correctamente realizado", 4);
        }

        private void DateDiaPicker2_ValueChanged(object sender, EventArgs e)
        {
            if (secuencia == true)
            filtrarUsuario();
        }

        private void DateDiaPicker_ValueChanged(object sender, EventArgs e)
        {
            if (secuencia == true)
            filtrarUsuario();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomMsgBox.Show("Ventana que te permite saber \n si tienes minutos por recuperar", "Información Filtrar Tareas", "Aceptar", "Cancelar");
        }

        private void cBoxListado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (secuencia == true)
            filtrarUsuario();
        }

        private void ControlEscaqueo_FormClosed(object sender, FormClosedEventArgs e)
        {
            secuencia = false;
        }

       

    }
}
