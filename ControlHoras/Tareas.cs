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
using Alc.Model.ControlHoras;
using ControlHoras.DAL;
using ControlHoras.Models;
using Telerik.WinControls.UI;

namespace ControlHoras
{
    public partial class Tareas : RadForm
    {
        private List<TareasLista> DatosTareas = null;
        private ControlHoras.DAL.AccesoFichador accesoDatos = null;
        private List<Alc.Model.ControlHoras.Tareas> DatosGrid = null;
        private bool VariableControl = false;
        public Tareas()
        {
            InitializeComponent();
            //quita agrupacion del grid:
            GridTareas.EnableGrouping = false;
            //quita primera columna del grid
            GridTareas.ShowRowHeaderColumn = false;

        }

        public void filtrar()
        {
            try
            {
                //Obtenemos las tareas 
                var combo = (UsuariosListas) cBoxListado.SelectedValue;
                DatosGrid = accesoDatos.MostrarListaTareasPorUsuario(combo.ID);
                int resultadoHoras = 0;

                if (DatosGrid.Count > 0)
                {
                    GridTareas.DataSource = DatosGrid.Select(list => new TareasLista
                    {
                        ID = list.Id,
                        IDUsuario = list.IDUsuario,
                        HoraInicioTarea = list.HoraInicioTarea,
                        duracion = list.duracion,
                        Proyecto = list.nombreTarea,
                        Descripcion = list.descripcionTarea,
                        Nombre = list.Nombre
                    }).ToList();
                    GridTareas.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
                    GridTareas.ReadOnly = true;
                    GridTareas.Columns["HoraFinTarea"].IsVisible = false;
                    GridTareas.Columns["IDUsuario"].IsVisible = false;
                    GridTareas.Columns["ID"].IsVisible = false;
                    GridTareas.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
                    GridTareas.ReadOnly = true;
                    GridTareas.Columns[4].HeaderText = "Hora de inicio";
                    GridTareas.Columns[5].HeaderText = "Duracion";

                    var numeroTareas = DatosGrid.Count();
                    var diaTareaPrimero = DatosGrid.Max(x => x.HoraInicioTarea);
                    var diaTareaUltimo = DatosGrid.Min(x => x.HoraInicioTarea);
                    var sumaTareas = DatosGrid.Sum(x => x.duracion);
                 

                    //if (sumaTareas < 60)
                    //{
                    //     var resultadoHoras = sumaTareas/60;
                    //     var resultadoMinutos = sumaTareas%60;
                    //     resultado = resultadoHoras + "" + resultadoMinutos;

                    //}
                    if (GridTareas.RowCount != 0 || GridTareas.Rows != null)
                    {
                        lblNumeroTareas.Visible = true;
                        lblEntreDias.Visible = true;
                        lblSumaTareas.Visible = true;
                        lblNumeroTareas.Text = "Numero de tareas: " + numeroTareas;
                        lblEntreDias.Text = "Primer día: " + diaTareaPrimero + " Y ultimo día: " + diaTareaUltimo;
                        lblSumaTareas.Text = "Total minutos trabajados: " + sumaTareas;
                    }
                }
                else
                {
                    GridTareas.DataSource = null;
                    lblNumeroTareas.Visible = false;
                    lblEntreDias.Visible = false;
                    lblSumaTareas.Visible = false;
                }
            }
            catch (Exception ex)
            {
                accesoDatos.guardarLog(ex.Message, 2);
            }

            accesoDatos.guardarLog("filtrar (Tareas) correctamente realizada", 4);

        }

        public void mostrarDatoslbl()
        {
           

            if (GridTareas.DataSource != null)
            {
                var numeroTareas = DatosGrid.Count();
                var diaTareaUltimo = DatosGrid.Max(x => x.HoraInicioTarea);
                var diaTareaPrimero = DatosGrid.Min(x => x.HoraInicioTarea);
                var sumaTareas = DatosGrid.Sum(x => x.duracion);


                int sumaHoras = sumaTareas/60;
                int sumaMinutos = sumaTareas%60;

                lblNumeroTareas.Visible = true;
                lblEntreDias.Visible = true;
                lblSumaTareas.Visible = true;
                lblNumeroTareas.Text = "Numero de tareas: " + numeroTareas;
                lblEntreDias.Text = "Primer día: " + diaTareaPrimero + " Y ultimo día: " + diaTareaUltimo;
                lblSumaTareas.Text = "Has trabajado " + sumaHoras + " hora/s y " + sumaMinutos+" minuto/s";
            }


            //else
            //{
            //    GridTareas.DataSource = null;
            //    lblNumeroTareas.Visible = false;
            //    lblEntreDias.Visible = false;
            //    lblSumaTareas.Visible = false;

            //}
        }

        private void Tareas_Load(object sender, EventArgs e)
        {
            try
            {
                //ESTABLECE DATOS DEL COMBOBOX, SU SELECCION Y CAMPO A MOSTRAR (DisplayMember)

                if (accesoDatos == null)
                {
                    accesoDatos = new AccesoFichador();
                }
                cBoxListado.Enabled = accesoDatos.consultaAdmin();
                var val = (UsuariosListas)cBoxListado.SelectedValue;

                var lista = accesoDatos.RellenaComboBox();
                //COMBOBOX SALE EL USUARIO LOGEADO POR DEFECTO
                if (accesoDatos.consultaAdmin() == false)
                {
                    lista = lista.Where(dato => dato.nombre == Environment.UserName).ToList();
                    //filtrar();
                    //mostrarDatoslbl();
                }


                cBoxListado.DataSource = lista;
                cBoxListado.DisplayMember = "nombre";
                var usuario = lista.FirstOrDefault(x => x.nombre == Environment.UserName);
                cBoxListado.SelectedIndex = lista.IndexOf(usuario);
                lblNumeroTareas.Visible = false;
                lblEntreDias.Visible = false;
                lblSumaTareas.Visible = false;
                Timer myTimer = new Timer();

                myTimer.Interval = 1000;
                myTimer.Start();
                filtrar();
                mostrarDatoslbl();
                VariableControl = true;

            }
            catch (Exception ex)
            {
                accesoDatos.guardarLog(ex.Message, 2);
            }
            accesoDatos.guardarLog("Tareas_Load correctamente realizada", 4);
        }

        private void cBoxListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VariableControl)
            {
            filtrar();
                mostrarDatoslbl();
        }


        }

        //private void btnActualizar_Click(object sender, EventArgs e)
        //{
        //    filtrar();
        //    mostrarDatoslbl();
        //}

        private void btnAnadirTarea_Click(object sender, EventArgs e)
        {
            //para seleccionar un item en datagrid:
            AnadirYModificar_v2 vAnadirYModificarTarea = new AnadirYModificar_v2(null, this);
            //vAnadirYModificarTarea.MdiParent = this.MdiParent;

            vAnadirYModificarTarea.ShowDialog();
            filtrar();
            mostrarDatoslbl();
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (GridTareas.RowCount != 0)
                {
                    TareasLista tareaSeleccionada = (TareasLista)GridTareas.SelectedRows[0].DataBoundItem;
                    AnadirYModificar vAnadirYModificarTarea = new AnadirYModificar(convertToTareas(tareaSeleccionada), this);
                    vAnadirYModificarTarea.ShowDialog();
                    filtrar();
                    mostrarDatoslbl();
                }
            }
            catch (Exception ex)
            {
                accesoDatos.guardarLog(ex.Message, 2);
            }

            accesoDatos.guardarLog("btnModificar_Click correctamente realizada", 4);

        }

        public Alc.Model.ControlHoras.Tareas convertToTareas(TareasLista tareacast)
        {
            Alc.Model.ControlHoras.Tareas tarea = new Alc.Model.ControlHoras.Tareas();
            tarea.duracion = tareacast.duracion;
            tarea.IDUsuario = tareacast.IDUsuario;
            tarea.Id = tareacast.ID;
            tarea.HoraInicioTarea = (DateTime)tareacast.HoraInicioTarea;
            tarea.HoraFinTarea = tareacast.HoraFinTarea;
            tarea.nombreTarea = tareacast.Proyecto;
            tarea.descripcionTarea = tareacast.Descripcion;
            return tarea;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomMsgBox.Show("Ventana en que te permite un control de tus tareas", "Información Tareas", "Aceptar", "Cancelar");
        }
    }
}
