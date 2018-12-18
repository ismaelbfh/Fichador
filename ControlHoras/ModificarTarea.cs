using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlHoras.Models;

namespace ControlHoras
{
    public partial class ModificarTarea : Form
    {
        public ModificarTarea(TareasLista tareas)
        {
            //var diaInicio = DateDiaPicker.Value;
            //hazle un casteo a la hora seleccionada en el timepicker de la hora
            //var hInicio = (DateTime)radTimePickerHoraInicio.Value;

            InitializeComponent();
            txtDescripcion.Text = tareas.desc;
            txtDuracion.Text = tareas.dur.ToString();
            txtNombreTarea.Text = tareas.nombreT;
            //acer modificaciones
            DateDiaPicker.Value = (DateTime) tareas.HoraInicioTarea;
            
        }

        private void ModificarTarea_Load(object sender, EventArgs e)
        {

        }
    }
}
