namespace ControlHoras
{
    partial class Diario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diario));
            this.btnDetalles = new Telerik.WinControls.UI.RadButton();
            this.TimePickerCalendario = new Telerik.WinControls.UI.RadDateTimePicker();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.gridCuadroInfo = new Telerik.WinControls.UI.RadGridView();
            this.cBoxUsu = new System.Windows.Forms.ComboBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radDateTimeDiaInicial = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radDateTimeDiaFinal = new Telerik.WinControls.UI.RadDateTimePicker();
            this.btnDetallesEntreDias = new Telerik.WinControls.UI.RadButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEXCEL = new Telerik.WinControls.UI.RadButton();
            this.btnPdf = new Telerik.WinControls.UI.RadButton();
            this.button1 = new System.Windows.Forms.Button();
            this.lblFecha = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.lblDatosBusqueda = new Telerik.WinControls.UI.RadLabel();
            this.lblExportarExcel = new Telerik.WinControls.UI.RadLabel();
            this.lblExportarPdf = new Telerik.WinControls.UI.RadLabel();
            this.windows7Theme1 = new Telerik.WinControls.Themes.Windows7Theme();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimePickerCalendario)).BeginInit();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCuadroInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCuadroInfo.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimeDiaInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimeDiaFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetallesEntreDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEXCEL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDatosBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblExportarExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblExportarPdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDetalles
            // 
            this.btnDetalles.Location = new System.Drawing.Point(199, 101);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(121, 22);
            this.btnDetalles.TabIndex = 0;
            this.btnDetalles.Text = "Detalles ";
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // TimePickerCalendario
            // 
            this.TimePickerCalendario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TimePickerCalendario.Location = new System.Drawing.Point(156, 38);
            this.TimePickerCalendario.MaxDate = new System.DateTime(2016, 7, 12, 17, 14, 54, 0);
            this.TimePickerCalendario.Name = "TimePickerCalendario";
            this.TimePickerCalendario.Size = new System.Drawing.Size(164, 20);
            this.TimePickerCalendario.TabIndex = 3;
            this.TimePickerCalendario.TabStop = false;
            this.TimePickerCalendario.Text = "03/07/2016";
            this.TimePickerCalendario.Value = new System.DateTime(2016, 7, 3, 0, 0, 0, 0);
            this.TimePickerCalendario.ValueChanged += new System.EventHandler(this.TimePickerCalendario_ValueChanged);
            // 
            // grpDatos
            // 
            this.grpDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDatos.Controls.Add(this.gridCuadroInfo);
            this.grpDatos.Location = new System.Drawing.Point(26, 166);
            this.grpDatos.MinimumSize = new System.Drawing.Size(50, 50);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(791, 208);
            this.grpDatos.TabIndex = 4;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "DATOS";
            // 
            // gridCuadroInfo
            // 
            this.gridCuadroInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCuadroInfo.Location = new System.Drawing.Point(3, 16);
            // 
            // 
            // 
            this.gridCuadroInfo.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gridCuadroInfo.Name = "gridCuadroInfo";
            this.gridCuadroInfo.Size = new System.Drawing.Size(785, 189);
            this.gridCuadroInfo.TabIndex = 0;
            this.gridCuadroInfo.Text = "radGridView1";
            this.gridCuadroInfo.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.gridCuadroInfo_CellFormatting);
            // 
            // cBoxUsu
            // 
            this.cBoxUsu.FormattingEnabled = true;
            this.cBoxUsu.Location = new System.Drawing.Point(156, 61);
            this.cBoxUsu.Name = "cBoxUsu";
            this.cBoxUsu.Size = new System.Drawing.Size(164, 21);
            this.cBoxUsu.TabIndex = 5;
            this.cBoxUsu.SelectedIndexChanged += new System.EventHandler(this.cBoxUsu_SelectedIndexChanged);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(67, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(122, 18);
            this.radLabel1.TabIndex = 6;
            this.radLabel1.Text = "Filtro por dia y persona";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(447, 15);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(84, 18);
            this.radLabel2.TabIndex = 7;
            this.radLabel2.Text = "Filtro entre dias";
            // 
            // radDateTimeDiaInicial
            // 
            this.radDateTimeDiaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.radDateTimeDiaInicial.Location = new System.Drawing.Point(537, 38);
            this.radDateTimeDiaInicial.MaxDate = new System.DateTime(2016, 7, 12, 17, 14, 54, 0);
            this.radDateTimeDiaInicial.Name = "radDateTimeDiaInicial";
            this.radDateTimeDiaInicial.Size = new System.Drawing.Size(164, 20);
            this.radDateTimeDiaInicial.TabIndex = 8;
            this.radDateTimeDiaInicial.TabStop = false;
            this.radDateTimeDiaInicial.Text = "03/07/2016";
            this.radDateTimeDiaInicial.Value = new System.DateTime(2016, 7, 3, 0, 0, 0, 0);
            // 
            // radDateTimeDiaFinal
            // 
            this.radDateTimeDiaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.radDateTimeDiaFinal.Location = new System.Drawing.Point(537, 64);
            this.radDateTimeDiaFinal.MaxDate = new System.DateTime(2016, 7, 12, 17, 14, 54, 0);
            this.radDateTimeDiaFinal.Name = "radDateTimeDiaFinal";
            this.radDateTimeDiaFinal.Size = new System.Drawing.Size(164, 20);
            this.radDateTimeDiaFinal.TabIndex = 9;
            this.radDateTimeDiaFinal.TabStop = false;
            this.radDateTimeDiaFinal.Text = "03/07/2016";
            this.radDateTimeDiaFinal.Value = new System.DateTime(2016, 7, 3, 0, 0, 0, 0);
            // 
            // btnDetallesEntreDias
            // 
            this.btnDetallesEntreDias.Location = new System.Drawing.Point(580, 101);
            this.btnDetallesEntreDias.Name = "btnDetallesEntreDias";
            this.btnDetallesEntreDias.Size = new System.Drawing.Size(121, 22);
            this.btnDetallesEntreDias.TabIndex = 10;
            this.btnDetallesEntreDias.Text = "Filtrar ";
            this.btnDetallesEntreDias.Click += new System.EventHandler(this.btnDetallesEntreDias_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label1.Location = new System.Drawing.Point(289, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 31;
            // 
            // btnEXCEL
            // 
            this.btnEXCEL.Image = ((System.Drawing.Image)(resources.GetObject("btnEXCEL.Image")));
            this.btnEXCEL.Location = new System.Drawing.Point(129, 385);
            this.btnEXCEL.Name = "btnEXCEL";
            this.btnEXCEL.Size = new System.Drawing.Size(25, 25);
            this.btnEXCEL.TabIndex = 1;
            this.btnEXCEL.Click += new System.EventHandler(this.btnEXCEL_Click_1);
            // 
            // btnPdf
            // 
            this.btnPdf.Image = ((System.Drawing.Image)(resources.GetObject("btnPdf.Image")));
            this.btnPdf.Location = new System.Drawing.Point(287, 385);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(25, 25);
            this.btnPdf.TabIndex = 11;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // button1
            // 
            this.button1.Image = global::ControlHoras.Properties.Resources.Circle_question;
            this.button1.Location = new System.Drawing.Point(-2, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 43);
            this.button1.TabIndex = 34;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(83, 39);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 18);
            this.lblFecha.TabIndex = 35;
            this.lblFecha.Text = "Fecha:";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(83, 64);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(47, 18);
            this.radLabel4.TabIndex = 36;
            this.radLabel4.Text = "Usuario:";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(462, 39);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(69, 18);
            this.radLabel3.TabIndex = 37;
            this.radLabel3.Text = "Fecha Inicial:";
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(467, 63);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(64, 18);
            this.radLabel5.TabIndex = 38;
            this.radLabel5.Text = "Fecha Final:";
            // 
            // lblDatosBusqueda
            // 
            this.lblDatosBusqueda.Location = new System.Drawing.Point(29, 142);
            this.lblDatosBusqueda.Name = "lblDatosBusqueda";
            this.lblDatosBusqueda.Size = new System.Drawing.Size(84, 18);
            this.lblDatosBusqueda.TabIndex = 39;
            this.lblDatosBusqueda.Text = "DatosBusqueda";
            this.lblDatosBusqueda.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblExportarExcel
            // 
            this.lblExportarExcel.Location = new System.Drawing.Point(30, 390);
            this.lblExportarExcel.Name = "lblExportarExcel";
            this.lblExportarExcel.Size = new System.Drawing.Size(93, 18);
            this.lblExportarExcel.TabIndex = 40;
            this.lblExportarExcel.Text = "Exportar a EXCEL:";
            // 
            // lblExportarPdf
            // 
            this.lblExportarPdf.Location = new System.Drawing.Point(199, 390);
            this.lblExportarPdf.Name = "lblExportarPdf";
            this.lblExportarPdf.Size = new System.Drawing.Size(82, 18);
            this.lblExportarPdf.TabIndex = 41;
            this.lblExportarPdf.Text = "Exportar a PDF:";
            // 
            // Diario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 465);
            this.Controls.Add(this.lblExportarPdf);
            this.Controls.Add(this.lblExportarExcel);
            this.Controls.Add(this.lblDatosBusqueda);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEXCEL);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnDetallesEntreDias);
            this.Controls.Add(this.radDateTimeDiaFinal);
            this.Controls.Add(this.radDateTimeDiaInicial);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.cBoxUsu);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.TimePickerCalendario);
            this.Controls.Add(this.btnDetalles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 500);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "Diario";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(900, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diario";
            this.ThemeName = "Windows7";
            this.Load += new System.EventHandler(this.Diario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimePickerCalendario)).EndInit();
            this.grpDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCuadroInfo.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCuadroInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimeDiaInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimeDiaFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetallesEntreDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEXCEL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDatosBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblExportarExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblExportarPdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnDetalles;
        private Telerik.WinControls.UI.RadDateTimePicker TimePickerCalendario;
        private System.Windows.Forms.GroupBox grpDatos;
        private Telerik.WinControls.UI.RadGridView gridCuadroInfo;
        private System.Windows.Forms.ComboBox cBoxUsu;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimeDiaInicial;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimeDiaFinal;
        private Telerik.WinControls.UI.RadButton btnDetallesEntreDias;
        private Telerik.WinControls.UI.RadButton btnPdf;
        private Telerik.WinControls.UI.RadButton btnEXCEL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private Telerik.WinControls.UI.RadLabel lblFecha;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel lblDatosBusqueda;
        private Telerik.WinControls.UI.RadLabel lblExportarExcel;
        private Telerik.WinControls.UI.RadLabel lblExportarPdf;
        private Telerik.WinControls.Themes.Windows7Theme windows7Theme1;


    }
}