namespace ControlHoras
{
    partial class ControlEscaqueo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlEscaqueo));
            this.DateDiaPicker = new Telerik.WinControls.UI.RadDateTimePicker();
            this.cBoxListado = new System.Windows.Forms.ComboBox();
            this.DateDiaPicker2 = new Telerik.WinControls.UI.RadDateTimePicker();
            this.lblEntrada = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.DataGridJornada = new Telerik.WinControls.UI.RadGridView();
            this.lblPrimeroFecha = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.windows7Theme1 = new Telerik.WinControls.Themes.Windows7Theme();
            ((System.ComponentModel.ISupportInitialize)(this.DateDiaPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDiaPicker2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridJornada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridJornada.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // DateDiaPicker
            // 
            this.DateDiaPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateDiaPicker.Location = new System.Drawing.Point(167, 30);
            this.DateDiaPicker.Margin = new System.Windows.Forms.Padding(4);
            this.DateDiaPicker.MaxDate = new System.DateTime(2016, 7, 27, 0, 0, 0, 0);
            this.DateDiaPicker.Name = "DateDiaPicker";
            this.DateDiaPicker.Size = new System.Drawing.Size(148, 20);
            this.DateDiaPicker.TabIndex = 15;
            this.DateDiaPicker.TabStop = false;
            this.DateDiaPicker.Text = "01/07/2016";
            this.DateDiaPicker.Value = new System.DateTime(2016, 7, 1, 0, 0, 0, 0);
            this.DateDiaPicker.ValueChanged += new System.EventHandler(this.DateDiaPicker_ValueChanged);
            // 
            // cBoxListado
            // 
            this.cBoxListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxListado.FormattingEnabled = true;
            this.cBoxListado.Location = new System.Drawing.Point(688, 30);
            this.cBoxListado.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxListado.Name = "cBoxListado";
            this.cBoxListado.Size = new System.Drawing.Size(117, 21);
            this.cBoxListado.TabIndex = 16;
            this.cBoxListado.SelectedIndexChanged += new System.EventHandler(this.cBoxListado_SelectedIndexChanged_1);
            // 
            // DateDiaPicker2
            // 
            this.DateDiaPicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateDiaPicker2.Location = new System.Drawing.Point(413, 30);
            this.DateDiaPicker2.Margin = new System.Windows.Forms.Padding(4);
            this.DateDiaPicker2.MaxDate = new System.DateTime(2016, 7, 26, 0, 0, 0, 0);
            this.DateDiaPicker2.Name = "DateDiaPicker2";
            this.DateDiaPicker2.Size = new System.Drawing.Size(131, 20);
            this.DateDiaPicker2.TabIndex = 17;
            this.DateDiaPicker2.TabStop = false;
            this.DateDiaPicker2.Text = "26/07/2016";
            this.DateDiaPicker2.Value = new System.DateTime(2016, 7, 26, 0, 0, 0, 0);
            this.DateDiaPicker2.ValueChanged += new System.EventHandler(this.DateDiaPicker2_ValueChanged);
            // 
            // lblEntrada
            // 
            this.lblEntrada.Location = new System.Drawing.Point(61, 31);
            this.lblEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(83, 18);
            this.lblEntrada.TabIndex = 18;
            this.lblEntrada.Text = "Fecha de Inicio:";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(338, 30);
            this.radLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(55, 18);
            this.radLabel1.TabIndex = 19;
            this.radLabel1.Text = "Fecha Fin:";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(573, 30);
            this.radLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(91, 18);
            this.radLabel2.TabIndex = 20;
            this.radLabel2.Text = "Nombre Usuario:";
            // 
            // grpDatos
            // 
            this.grpDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDatos.Controls.Add(this.DataGridJornada);
            this.grpDatos.Location = new System.Drawing.Point(16, 81);
            this.grpDatos.Margin = new System.Windows.Forms.Padding(4);
            this.grpDatos.MaximumSize = new System.Drawing.Size(852, 326);
            this.grpDatos.MinimumSize = new System.Drawing.Size(852, 326);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Padding = new System.Windows.Forms.Padding(4);
            this.grpDatos.Size = new System.Drawing.Size(852, 326);
            this.grpDatos.TabIndex = 21;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Jornada";
            // 
            // DataGridJornada
            // 
            this.DataGridJornada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridJornada.Location = new System.Drawing.Point(4, 20);
            this.DataGridJornada.Margin = new System.Windows.Forms.Padding(4);
            // 
            // 
            // 
            this.DataGridJornada.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.DataGridJornada.Name = "DataGridJornada";
            this.DataGridJornada.Size = new System.Drawing.Size(844, 302);
            this.DataGridJornada.TabIndex = 0;
            this.DataGridJornada.Text = "DataGridJornada";
            // 
            // lblPrimeroFecha
            // 
            this.lblPrimeroFecha.AutoSize = true;
            this.lblPrimeroFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lblPrimeroFecha.Location = new System.Drawing.Point(389, 484);
            this.lblPrimeroFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrimeroFecha.Name = "lblPrimeroFecha";
            this.lblPrimeroFecha.Size = new System.Drawing.Size(473, 18);
            this.lblPrimeroFecha.TabIndex = 29;
            this.lblPrimeroFecha.Text = "*Ventana que te permite saver si tienes Minutos por recuperar";
            // 
            // button1
            // 
            this.button1.Image = global::ControlHoras.Properties.Resources.Circle_question;
            this.button1.Location = new System.Drawing.Point(0, -3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 43);
            this.button1.TabIndex = 31;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ControlEscaqueo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 465);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPrimeroFecha);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.DateDiaPicker2);
            this.Controls.Add(this.cBoxListado);
            this.Controls.Add(this.DateDiaPicker);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 500);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "ControlEscaqueo";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(900, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtro Tareas";
            this.ThemeName = "Windows7";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ControlEscaqueo_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DateDiaPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDiaPicker2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            this.grpDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridJornada.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridJornada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDateTimePicker DateDiaPicker;
        private System.Windows.Forms.ComboBox cBoxListado;
        private Telerik.WinControls.UI.RadDateTimePicker DateDiaPicker2;
        private Telerik.WinControls.UI.RadLabel lblEntrada;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private System.Windows.Forms.GroupBox grpDatos;
        private Telerik.WinControls.UI.RadGridView DataGridJornada;
        private System.Windows.Forms.Label lblPrimeroFecha;
        private System.Windows.Forms.Button button1;
        private Telerik.WinControls.Themes.Windows7Theme windows7Theme1;
    }
}