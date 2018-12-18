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

namespace ControlHoras
{
    public partial class Form1 : Form
    {
        private ControlHoras.DAL.AccesoFichador accesoDatos = null;
        private List<FichadorMio> DatosFich = null;
        private List<Fichador> DatosfichadorBD = null;
        private List<TareasLista> datosTareas = null; 

        public Form1()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            var valor = (UsuariosListas)cBoxListado.SelectedValue;

            int total = 0;
            var diaInicio = DateDiaPicker.Value.ToString("d");

            int num = accesoDatos.Jornada( Convert.ToDateTime(diaInicio),valor.ID);
            int num2 = accesoDatos.HorasTrabajadasCalculo(valor.ID, Convert.ToDateTime(diaInicio));
            if (num >= num2)
            {
                total = num - num2;
            }
            else
            {
                total = num2 - num;
            }
            MessageBox.Show("Te quedan" + total + "minutos para recuperar");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (accesoDatos == null)
            {
                accesoDatos = new AccesoFichador();
            }

            //primero será sacar el campo EsAdmin del usuario actual, si es true que active el ComboBox, sino que lo descative y no deje filtrar

           

            var lista = accesoDatos.RellenaComboBox();

            if (accesoDatos.consultaAdmin() == false)
            {

                lista = lista.Where(dato => dato.nombre == Environment.UserName).ToList();
            }

            cBoxListado.DataSource = lista;

            cBoxListado.DisplayMember = "ID";
        }
    }
}
