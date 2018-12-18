using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alc.Data;
using Alc.Model.ControlHoras;
using ControlHoras.DAL;
using Telerik.WinControls.UI;
using ControlHoras.Models;
using Telerik.WinControls.Export;
using CellFormattingEventArgs = Telerik.WinControls.UI.CellFormattingEventArgs;
using CellFormattingEventHandler = Telerik.WinControls.UI.CellFormattingEventHandler;

namespace ControlHoras
{
    public partial class Diario : RadForm
    {
        private ControlHoras.DAL.AccesoFichador accesoDatos = null;
        private string UserName = string.Empty;
        private List<Fichador> DatosGrid = null;
        private List<FichadorMio> DatosOriginales = null;
        private List<UsuariosListas> listaUsuarios = null;
        private CellFormattingEventHandler gridCuadroInfo_CellFormatting = new CellFormattingEventHandler(delegate(object sender, CellFormattingEventArgs args) { });
      
        public Diario()
        {
            InitializeComponent();
            this.UserName = String.Format("{0}\\{1}", Environment.UserDomainName, Environment.UserName);
            //quita agrupacion del grid:
            gridCuadroInfo.EnableGrouping = false;
            //quita primera columna del grid
            gridCuadroInfo.ShowRowHeaderColumn = false;
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            //if (accesoDatos == null)
            //{
            //    accesoDatos = new AccesoFichador();
            //}

            //DatosGrid = accesoDatos.GetListaByFecha(TimePickerCalendario.Value, Environment.UserName);

            ////para redimensionar columnasRowInEditMode
            //gridCuadroInfo.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            //gridCuadroInfo.ReadOnly=true;

            ////gridCuadroInfo.DataSource = DatosGrid; //ESTO SE USARIA PARA ASIGNAR LAMBDA

            ////PARA METER LAS COLUMNAS A MANO Y GENERARLO:

            ////gridCuadroInfo.AutoGenerateColumns = false; //SI ES TRUE GENERABA COLUMNAS
            ////var textBoxColumn = new GridViewTextBoxColumn();
            ////textBoxColumn.Name = "Usuario";
            ////textBoxColumn.HeaderText = "Usuario";
            ////textBoxColumn.FieldName = "Usuario"; //TIENE QUE SER EL MISMO NOMBRE DE LA COLUMNA
            ////textBoxColumn.MaxLength = 50;
            ////textBoxColumn.TextAlignment = ContentAlignment.BottomRight;
            ////textBoxColumn.Width = 250;
            ////gridCuadroInfo.MasterTemplate.Columns.Add(textBoxColumn);
            ////var dateColumn = new GridViewDateTimeColumn("HoraInicio");
            ////gridCuadroInfo.MasterTemplate.Columns.Add(dateColumn);
            ////dateColumn = new GridViewDateTimeColumn("HoraFin");
            ////gridCuadroInfo.MasterTemplate.Columns.Add(dateColumn);

            //DatosOriginales = DatosGrid.Select(dato => new FichadorMio { IDUsuario = dato.IDUsuario, HoraInicio = dato.HoraInicio, HoraFin = dato.HoraFin }).ToList();
            //var valor = (UsuariosListas)cBoxUsu.SelectedValue;

            //if (DatosOriginales != null)
            //{
            //    gridCuadroInfo.DataSource = DatosOriginales.Where(user => user.IDUsuario == valor.ID).ToList();
            //}
            //gridCuadroInfo.DataSource = DatosOriginales;
            //con Select seleccionamos datos de una clase, recuperandolos

            //FichadorMio seria una clase creada aparte con sus atributos usuario, horainicio y horafin


            //var listaMayoresAnio2000 = DatosGrid.Where(x => x.HoraInicio > new DateTime(2000, 0, 0)).ToList();
            
            lblDatosBusqueda.Visible = true;
            lblDatosBusqueda.Text="Mostrando datos para la fecha: " + TimePickerCalendario.Value.ToString("d") + " y para el usuario " +cBoxUsu.Text;
            configuraFiltro();
            

            if (gridCuadroInfo.RowCount == 0)
            {
                MessageBox.Show("No hay datos para mostrar dada esa fecha");
                btnPdf.Enabled = false;
                btnEXCEL.Enabled = false;

            }
            else
            {
                btnPdf.Enabled = true;
                btnEXCEL.Enabled = true;
                btnEXCEL.Visible = true;
                btnPdf.Visible = true;
                lblExportarExcel.Visible = true;
                lblExportarPdf.Visible = true;
            }

        }

        private void Diario_Load(object sender, EventArgs e)
        {
            if (accesoDatos == null)
            {
                accesoDatos = new AccesoFichador();
            }
            lblDatosBusqueda.Visible = false;
            btnEXCEL.Visible = false;
            btnPdf.Visible = false;
            lblExportarExcel.Visible = false;
            lblExportarPdf.Visible = false;
            

            //primero será sacar el campo EsAdmin del usuario actual, si es true que active el ComboBox, sino que lo descative y no deje filtrar

            cBoxUsu.Enabled = accesoDatos.consultaAdmin();

            var lista = accesoDatos.RellenaComboBox();
            if (accesoDatos.consultaAdmin() == false)
            {
                lista = lista.Where(dato => dato.nombre == Environment.UserName).ToList();
            }
            cBoxUsu.DataSource = lista;
            cBoxUsu.DisplayMember = "nombre";
            var usuario = lista.FirstOrDefault(x => x.nombre == Environment.UserName);
            cBoxUsu.SelectedIndex = lista.IndexOf(usuario);

            cBoxUsu.DataSource = lista;

            cBoxUsu.DisplayMember = "nombre";

            //inicializar calendarios
            TimePickerCalendario.MaxDate = DateTime.Now;
            TimePickerCalendario.MinDate = accesoDatos.consultaPrimerRegistro();
            TimePickerCalendario.Value = DateTime.Now;
            radDateTimeDiaInicial.MaxDate = DateTime.Now;
            radDateTimeDiaInicial.MinDate = accesoDatos.consultaPrimerRegistro();
            radDateTimeDiaInicial.Value = DateTime.Now;
            radDateTimeDiaFinal.MaxDate = DateTime.Now;
            radDateTimeDiaFinal.MinDate = accesoDatos.consultaPrimerRegistro();
            radDateTimeDiaFinal.Value = DateTime.Now;
        }


        private void cBoxUsu_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// METODO PARA RELLENAR Y CONFIGURAR DATAGRID:
        /// </summary>
        private void configuraFiltro()
        {
            if (accesoDatos == null)
            {
                accesoDatos = new AccesoFichador();
            }

            var usu = (UsuariosListas)cBoxUsu.SelectedItem;
            //selecciona los datos del fichador basado en la fecha que selecciones

            DatosGrid = accesoDatos.GetListaByFecha2(TimePickerCalendario.Value, usu.ID);

            //autoajusta tamaño
            

            //DatosOriginales contiene una lista de FichadorMio
            //selecciona los datos del objeto, en el grid pon lo que selecciona

            DatosOriginales =
                DatosGrid.Select(
                    dato =>
                        new FichadorMio
                        {
                            Nombre = dato.Nombre,
                            HoraInicio = dato.HoraInicio,
                            HoraFin = dato.HoraFin,
                            IDUsuario = dato.IDUsuario,
                            ID = dato.Id
                            
                        }).ToList();

          
            //valor es igual al objeto del ComboBox, que lo casteamos a la lista de usuarios para poder seleccionar cada campo y hacer el Where
            var valor = (UsuariosListas)cBoxUsu.SelectedValue;

            if (DatosOriginales != null)
            {
                //hacemos el filtro comparando que el ID del user de la tabla Usuarios coincida con el del objeto de Fichador(el que hayamos seleccionado)
                gridCuadroInfo.DataSource = DatosOriginales.Where(user => user.IDUsuario == valor.ID).ToList();

                gridCuadroInfo.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
                gridCuadroInfo.ReadOnly = true;
                gridCuadroInfo.Columns["IDUsuario"].IsVisible = false;
                //gridCuadroInfo.Columns["Nombre"].So
            }
            else //por si acaso
            {
                gridCuadroInfo.DataSource = DatosOriginales;
            }
            gridCuadroInfo.Columns[1].HeaderText = "Hora de inicio";
            gridCuadroInfo.Columns[2].HeaderText = "Hora de fin";

        }

        private void configurarFiltrosEntreDias()
        {
            if (accesoDatos == null)
            {
                accesoDatos = new AccesoFichador();
            }
            var usu = (UsuariosListas)cBoxUsu.SelectedItem;
            //selecciona los datos del fichador basado en la fecha que selecciones

            if (accesoDatos.consultaAdmin())
            {
                DatosGrid = accesoDatos.GetListaByEntreFechas(radDateTimeDiaInicial.Value, radDateTimeDiaFinal.Value);
            }
            else
            {
                //var IDUsuario = accesoDatos.GetIDUsuarioByUserName(Environment.UserName);

                DatosGrid = accesoDatos.GetListaByEntreFechasID(radDateTimeDiaInicial.Value, radDateTimeDiaFinal.Value, usu.ID);
            }

            //autoajusta tamaño
            gridCuadroInfo.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            gridCuadroInfo.ReadOnly = true;
            gridCuadroInfo.DataSource = DatosGrid;

            //DatosOriginales contiene una lista de FichadorMio
            //selecciona los datos del objeto, en el grid pon lo que selecciona
            //DatosOriginales = DatosGrid.Select(dato => new FichadorMio { IDUsuario = dato.IDUsuario, HoraInicio = dato.HoraInicio, HoraFin = dato.HoraFin }).ToList();

            //valor es igual al objeto del ComboBox, que lo casteamos a la lista de usuarios para poder seleccionar cada campo y hacer el Where
            /*var valor = (UsuariosListas)cBoxUsu.SelectedValue;

            if (DatosOriginales != null)
            {
                //hacemos el filtro comparando que el ID del user de la tabla Usuarios coincida con el del objeto de Fichador(el que hayamos seleccionado)
                gridCuadroInfo.DataSource = DatosOriginales.Where(user => user.IDUsuario == valor.ID).ToList();
            }
            else //por si acaso
            {
                gridCuadroInfo.DataSource = DatosOriginales;
            }
            */

        }

        private void radDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDetallesEntreDias_Click(object sender, EventArgs e)
        {
            lblDatosBusqueda.Visible = true;
            lblDatosBusqueda.Text = " Mostrando datos entre " + radDateTimeDiaInicial.Value.ToString("d") + " y " + radDateTimeDiaFinal.Value.ToString("d");
            configurarFiltrosEntreDias();

            if (gridCuadroInfo.RowCount == 0)
            {
                MessageBox.Show("No hay datos para mostrar dada esa fecha");
                btnPdf.Enabled = false;
                btnEXCEL.Enabled = false;

            }
            else
            {
                btnPdf.Enabled = true;
                btnEXCEL.Enabled = true;
                btnEXCEL.Visible = true;
                btnPdf.Visible = true;
                lblExportarExcel.Visible = true;
                lblExportarPdf.Visible = true;
            }
        }

        private void radDateTimeDiaFinal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            Telerik.WinControls.Export.GridViewPdfExport pdfExporter = new Telerik.WinControls.Export.GridViewPdfExport(this.gridCuadroInfo);
            pdfExporter.FileExtension = "pdf";
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "pdf|*.pdf";
            saveFileDialog1.Title = "Convertir a PDF";
            saveFileDialog1.ShowDialog();

            var file = saveFileDialog1.FileName;
            if (!string.IsNullOrWhiteSpace(file))
            {
                pdfExporter.RunExport(file);
            }
            //OLA
        }

        private void btnEXCEL_Click_1(object sender, EventArgs e)
        {
            Telerik.WinControls.Export.GridViewSpreadExport exporter = new Telerik.WinControls.Export.GridViewSpreadExport(this.gridCuadroInfo);
            Telerik.WinControls.Export.SpreadExportRenderer renderer = new Telerik.WinControls.Export.SpreadExportRenderer();

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "xslx|*.xslx";
            saveFileDialog1.Title = "Convertir a Excel";

            saveFileDialog1.ShowDialog();

            var file = saveFileDialog1.FileName;
            //Al darle a cancelar o cerrar nos devuelve un valor vacio y no encuentra el formato por se concatena un caracter para que no de fallo y deje cerrar

            if (!string.IsNullOrWhiteSpace(file))
            {
                exporter.RunExport(file);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomMsgBox.Show("Ventana que te permite saber \n todos los dias en que has fichado", "Información Diario", "Aceptar", "Cancelar");
        }

        private void TimePickerCalendario_ValueChanged(object sender, EventArgs e)
        {

        }
    }

}
