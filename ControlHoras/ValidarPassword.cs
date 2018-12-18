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
using Alc.Model.ControlHoras;
using ControlHoras.DAL;
using ControlHoras.Models;

namespace ControlHoras
{
    public partial class ValidarPassword : RadForm
    {
        private ControlHoras.DAL.AccesoFichador accesoDatos = new AccesoFichador();
        //CONSTRUCTOR
        public ValidarPassword()
        {
            InitializeComponent();
            this.AcceptButton = btnAceptar;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                String a = "boira";
                var dia = DateTime.Now.ToString("dd");
                var mes = DateTime.Now.ToString("MM");
                var result = Convert.ToInt32(dia) + Convert.ToInt32(mes);
                String pass = a + result;
                String caja = txtPassword.Text;

                if (caja == pass)
                {

                    ListarUsuarios vListarUsuarios = new ListarUsuarios((MainForm)this.MdiParent);
                    vListarUsuarios.ShowDialog();
                    this.Close();
                    Visible = false;

                }
                else
                {
                    MessageBox.Show("CONTRASEÑA INCORRECTA");
                }
            }
            catch (Exception ex)
            {
                accesoDatos.guardarLog(ex.Message, 2);
            }
            accesoDatos.guardarLog("btnAceptar_Clic correctamente realizado", 4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomMsgBox.Show("Ventana para loguearte como administrador", "Información Validar Password", "Aceptar", "Cancelar");
        }


    }
}
