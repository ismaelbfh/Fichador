using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alc.Model.ControlHoras;
using ControlHoras.DAL;
using Telerik.WinControls.Themes;
using Telerik.WinControls.UI;


namespace ControlHoras
{
    public partial class FrmFichador : RadForm
    {
        private ControlHoras.DAL.AccesoFichador accesoDatos = null;
        private string UserName = string.Empty;
        private Usuarios user = new Usuarios();

        int buttonF = 0;
        int buttonI = 0;
        
        public FrmFichador()
        {
            InitializeComponent();

                //this.UserName = String.Format("{0}\\{1}", Environment.UserDomainName, Environment.UserName);
                //lblNombre.Text = String.Format("Hola {0}, la hora actual es: {1}", this.UserName, DateTime.Now);
                
                try
                {
                    this.accesoDatos = new AccesoFichador();
                }
                catch (Exception ex)
                {
                    accesoDatos.guardarLog(ex.Message,2);
                }
                    accesoDatos.guardarLog("FrmFichador realizada correctamente",4);

                InicializarEstados();
        }

        private void InicializarEstados()
        {
            try
            {

          
            //sacar ID
            var idusu = accesoDatos.GetIDUsuarioByUserName(Environment.UserName);

           //Comprobar si ya se ha marcado la entrada:
           var horainicio = accesoDatos.GetHoraInicioByIDUsuario(idusu);
                

                if (horainicio != null)
                {
                    lblHoraEntrada.Text = ((DateTime) horainicio).ToString("G");
                    btnEntrada.Enabled = false;
                }

                //Comprobar si ya se ha marcado la salida:
                var horafin = accesoDatos.GetHoraFinByIDUsuario(idusu);

                if (horafin != null)
                {
                    lblHoraSalida.Text = ((DateTime) horafin).ToString("G");
                    btnSalida.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                accesoDatos.guardarLog(ex.Message, 2);
            }
            accesoDatos.guardarLog("InicializarEstados realizada correctamente", 4);


            
        }

        //METODOS DE LOS BOTONES: 

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            
                DateTime horaentrada = DateTime.Now; //variable que cvale la hora-fecha actual
                lblHoraEntrada.Text = horaentrada.ToString(); //el label ("---") de Text lo modificamos por horaentrada
                
                btnEntrada.Enabled = false; //desactivamos el botón
                this.accesoDatos = new AccesoFichador(); //instaciamos un objeto para conectarnos con la base de datos
                
                //llamamos al metodo correspondiente con sus parametros
                var IDUsuario = accesoDatos.GetIDUsuarioByUserName(Environment.UserName);
                accesoDatos.GuardarUsuarioYHoraEntrada(IDUsuario, horaentrada);
                btnSalida.Enabled = true;

                buttonI = 1;
                InicializarEstados();
                
                
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            try
            {

            
          
               DateTime horasalida = DateTime.Now;
               lblHoraSalida.Text = horasalida.ToString();
               btnSalida.Enabled = false;
               this.accesoDatos = new AccesoFichador();
               var IDUsuario = accesoDatos.GetIDUsuarioByUserName(Environment.UserName);
               accesoDatos.GuardarHoraSalida(IDUsuario, horasalida);
               InicializarEstados();
            }
            catch (Exception ex)
            {
                accesoDatos.guardarLog(ex.Message, 2);
            }
            accesoDatos.guardarLog("btnSalida_click realizada correctamente", 4);

        }

        private void timer1_tick(object sender, EventArgs e)
        {
            lblNombre.Text = DateTime.Now.ToString("F");
        }

        private void FrmFichador_Load(object sender, EventArgs e)
        {
            try
            {

           
            timer1.Interval = 1000;
            timer1.Start();
            timer1.Tick += new EventHandler(timer1_tick);

          
            var idusu = accesoDatos.GetIDUsuarioByUserName(Environment.UserName);
            var horainicio = accesoDatos.GetHoraInicioByIDUsuario(idusu);
            var horafin = accesoDatos.GetHoraFinByIDUsuario(idusu);
            if ((horainicio == null)&&(horafin == null))
            {
                btnEntrada.Enabled = true;
                btnSalida.Enabled = false;
            }
            else if((horainicio != null)&&(horafin == null))
            {
                btnEntrada.Enabled = false;
                btnSalida.Enabled = true;
            }
            }
            catch (Exception ex)
            {
                accesoDatos.guardarLog(ex.Message, 2);
            }
            accesoDatos.guardarLog("FrmFichador_load realizada correctamente", 4);
           

        }

        private void FrmFichador_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {

            

            if(buttonI==1 && buttonF==0)
            {
                btnEntrada.Enabled = true;
                btnSalida.Enabled = true;
            }
            }
            catch (Exception ex)
            {
                accesoDatos.guardarLog(ex.Message, 2);
            }
            accesoDatos.guardarLog("FrmFichador_FromClosed realizada correctamente", 4);
            
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            CustomMsgBox.Show("Ventana que te permite fichar, \n guardando hora entrada y hora de salida", "Información Fichador", "Aceptar", "Cancelar");
        }

      



    }
}
