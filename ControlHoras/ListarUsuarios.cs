using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Alc.Model.ControlHoras;
using ControlHoras.DAL;
using ControlHoras.Models;
using Telerik.WinControls.UI;
namespace ControlHoras
{
    public partial class ListarUsuarios : RadForm
    {
        private ControlHoras.DAL.AccesoFichador accesoDatos = null;
        private List<Usuarios> DatosGridUsuario = null;
        MainForm main = new MainForm();

        public ListarUsuarios(MainForm main)
        {
            InitializeComponent();
            //quita agrupacion:
            rdGridUsuarios.EnableGrouping = false;
            //quita primera columna del grid
            rdGridUsuarios.ShowRowHeaderColumn = false;
            this.main = main;

        }
        public event EventHandler SalirConEsc;
        [DllImport("user32.dll")]
        static extern IntPtr GetFocus();
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            var wndHandle = GetFocus();
            var focusedControl = FromChildHandle(wndHandle);
            if (keyData == Keys.F5)
            {
                accesoDatos = new AccesoFichador();

                DatosGridUsuario = accesoDatos.GetListaUsuarios();
                rdGridUsuarios.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

                rdGridUsuarios.DataSource = DatosGridUsuario.Select(list => new UsuariosListas { ID = list.Id, nombre = list.nombre, EsAdmin = list.EsAdmin }).ToList();
                rdGridUsuarios.Columns["Id"].ReadOnly = true;
                rdGridUsuarios.Columns["nombre"].ReadOnly = true;
                rdGridUsuarios.Columns["EsAdmin"].ReadOnly = false;
            }

            if (keyData == Keys.Escape && SalirConEsc != null)
            {
                if (!(focusedControl is TextBoxBase) && !(focusedControl is RadTextBoxControl))
                {
                    var parentForm = ParentForm;
                    if (parentForm != null)
                    {
                        SalirConEsc(parentForm.ActiveControl, null);
                    }
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ListarUsuarios_Load(object sender, EventArgs e)
        {
            try
            {


                if (accesoDatos == null)
                {
                    accesoDatos = new AccesoFichador();
                }

                DatosGridUsuario = accesoDatos.GetListaUsuarios();
                rdGridUsuarios.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

                rdGridUsuarios.DataSource = rdGridUsuarios.DataSource = DatosGridUsuario.Select(list => new UsuariosListas { ID = list.Id, nombre = list.nombre, EsAdmin = list.EsAdmin }).ToList();
                rdGridUsuarios.Columns["Id"].ReadOnly = true;
                rdGridUsuarios.Columns["nombre"].ReadOnly = true;
                rdGridUsuarios.Columns["EsAdmin"].ReadOnly = false;
            }
            catch (Exception ex)
            {
                accesoDatos.guardarLog(ex.Message, 2);
            }
            accesoDatos.guardarLog("ListarUsuario_Load realizada correctamente", 4);

        }

        private void btnListar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {


                if (accesoDatos == null)
                {
                    accesoDatos = new AccesoFichador();
                }

                //hacemos una variable que contenga una lista con los datos del DataGrid
                var lista = (List<UsuariosListas>)rdGridUsuarios.DataSource;
                //la pasamos al metodo
                accesoDatos.GuardarListaUsuarios(lista);

                DatosGridUsuario = accesoDatos.GetListaUsuarios();
                rdGridUsuarios.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
                //rdGridUsuarios.ReadOnly = true;

                rdGridUsuarios.DataSource = rdGridUsuarios.DataSource = DatosGridUsuario.Select(list => new UsuariosListas { ID = list.Id, nombre = list.nombre, EsAdmin = list.EsAdmin }).ToList();
                rdGridUsuarios.Columns["Id"].ReadOnly = true;
                rdGridUsuarios.Columns["nombre"].ReadOnly = true;
                rdGridUsuarios.Columns["EsAdmin"].ReadOnly = false;
                //rdGridUsuarios.DataSource = DatosGridUsuarios;
            }
            catch (Exception ex)
            {
                accesoDatos.guardarLog(ex.Message, 2);
            }
            accesoDatos.guardarLog("btnGuardar_Click realizada correctamente", 4);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {

           
            this.Visible = false;
            main.Recargar();
            }
            catch (Exception ex)
            {
                accesoDatos.guardarLog(ex.Message, 2);
            }
            accesoDatos.guardarLog("btnSalir_Click realizada correctamente", 4);
        }

        private void btnF5_Click(object sender, EventArgs e)
        {
            try
            {

                accesoDatos = new AccesoFichador();

                DatosGridUsuario = accesoDatos.GetListaUsuarios();
                rdGridUsuarios.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
                //rdGridUsuarios.ReadOnly = true;

                rdGridUsuarios.DataSource = rdGridUsuarios.DataSource = DatosGridUsuario.Select(list => new UsuariosListas { ID = list.Id, nombre = list.nombre, EsAdmin = list.EsAdmin }).ToList();
                rdGridUsuarios.Columns["Id"].ReadOnly = true;
                rdGridUsuarios.Columns["nombre"].ReadOnly = true;
                rdGridUsuarios.Columns["EsAdmin"].ReadOnly = false;
            }
            catch (Exception ex)
            {
                accesoDatos.guardarLog(ex.Message, 2);
            }
            accesoDatos.guardarLog("btnF5_Click realizada correctamente", 4);

        }



        private void button1_Click(object sender, EventArgs e)
        {
            CustomMsgBox.Show("Listado de usuarios y sus permisos", "Información Listado Usuarios", "Aceptar", "Cancelar");
        }


    }
}
