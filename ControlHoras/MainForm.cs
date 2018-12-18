using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alc.Model.ControlHoras;
using ControlHoras.DAL;
using ControlHoras.Models;
using Telerik.WinControls.UI;

namespace ControlHoras
//TODO: SEGUIR CON FILTRO TAREAS
{
    public partial class MainForm : RadForm
    {
        private ControlHoras.DAL.AccesoFichador accesoDatos = null;
        private Usuarios user = new Usuarios();
        private FrmFichador vFichador = null;
        private Diario vDiario = null;
        private ValidarPassword vPassword = null;
        private Tareas vTareas = null;
        private ControlEscaqueo vControlEscaqueo = null;

        public MainForm()
        {
            InitializeComponent();
            this.Text = "CONTROL HORAS";

            //A PARTIR DE AQUI ES LO PRIMERO QUE SE EJECUTA:
            try
            {
                if (accesoDatos == null)
                {
                    this.accesoDatos = new AccesoFichador();
                }

                //comprueba que el usuario del entorno existe:

                var compruebaUsuario = accesoDatos.GetUsuarioByUserName(Environment.UserName);

                if (compruebaUsuario == null)
                {
                    //si es nulo crealo
                    accesoDatos.insertaUsuario(Environment.UserName);
                    MessageBox.Show("Se ha insertado el usuario " + Environment.UserName);
                }
            }
            catch (Exception ex)
            {
                accesoDatos.guardarLog(ex.Message, 2);
            }
            accesoDatos.guardarLog("MainForm() correctamente realizado", 4);

        }

        private void fichadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (accesoDatos == null)
                {
                    this.accesoDatos = new AccesoFichador();
                }

                var idusu = accesoDatos.GetIDUsuarioByUserName(Environment.UserName);
                var hInicio = accesoDatos.GetHoraInicioByIDUsuario(idusu);
                var hFin = accesoDatos.GetHoraFinByIDUsuario(idusu);

                if (hInicio != null && hFin != null)
                {
                    MessageBox.Show("Ya has fichado, no se te permite volver a fichar por hoy");
                }
                else
                {
                    if (vFichador == null || vFichador.IsDisposed)
                    {
                        vFichador = new FrmFichador();
                        vFichador.MdiParent = this;
                    }

                    if (vFichador.CanFocus)
                    {
                        vFichador.Focus();
                    }
                    else
                    {
                        vFichador.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                accesoDatos.guardarLog(ex.Message, 2);
            }
            accesoDatos.guardarLog("fichadorToolStripMenuItem_Click correctamente realizado", 4);
        }

        private void consultarDiasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (vDiario == null || vDiario.IsDisposed)
            {
                vDiario = new Diario();
                vDiario.MdiParent = this;
            }

            if (vDiario.CanFocus)
            {
                vDiario.Focus();
            }
            else
            {
                vDiario.Show();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblUserConectado.Text = "ESTAS CONECTADO COMO:  " + Environment.UserName;
            System.Windows.Forms.ToolTip tooltip = new System.Windows.Forms.ToolTip();
            tooltip.AutomaticDelay = 5000;
            tooltip.InitialDelay = 1000;
            tooltip.ReshowDelay = 500;
            tooltip.ShowAlways = true;
        }

        private void validarseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (vPassword == null || vPassword.IsDisposed)
            {
                vPassword = new ValidarPassword();
                vPassword.MdiParent = this;
            }

            if (vPassword.CanFocus)
            {
                vPassword.Focus();
            }
            else
            {
                vPassword.Show();
            }

        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void radLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tareasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (vTareas == null || vTareas.IsDisposed)
            {
                vTareas = new Tareas();
                vTareas.MdiParent = this;
            }

            if (vTareas.CanFocus)
            {
                vTareas.Focus();
            }
            else
            {
                vTareas.Show();
            }

        }

        private void controlToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (vControlEscaqueo == null || vControlEscaqueo.IsDisposed)
            {
                vControlEscaqueo = new ControlEscaqueo();
                vControlEscaqueo.MdiParent = this;
            }

            if (vControlEscaqueo.CanFocus)
            {
                vControlEscaqueo.Focus();
            }
            else
            {
                vControlEscaqueo.Show();
            }
        }

        public void Recargar()
        {
            if (vDiario != null && vDiario.Visible)
            {
                vDiario.Dispose();
                consultarDiasToolStripMenuItem_Click(null, null);
            }
            if (vPassword != null)
            {
                vPassword.Dispose();
            }
            if (vControlEscaqueo != null && vControlEscaqueo.Visible)
            {
                vControlEscaqueo.Dispose();
                controlToolStripMenuItem_Click(null, null);
            }
            if (vTareas != null && vTareas.Visible)
            {
                vTareas.Dispose();
                tareasToolStripMenuItem_Click(null, null);
            }
            //if (vFichador != null)
            //{
            //    vFichador.Dispose();
            //    tareasToolStripMenuItem_Click(null, null);
            //}
        }
    }
}
