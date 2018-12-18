namespace ControlHoras
{
    partial class AnadirYModificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnadirYModificar));
            this.DateDiaPickerAM = new Telerik.WinControls.UI.RadDateTimePicker();
            this.lblDiaInicio = new System.Windows.Forms.Label();
            this.radTimePickerHoraInicioAM = new Telerik.WinControls.UI.RadTimePicker();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cBoxListadoAM = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new Telerik.WinControls.UI.RadButton();
            this.txtNombreTareaAM = new Telerik.WinControls.UI.RadTextBox();
            this.txtDescripcionAM = new Telerik.WinControls.UI.RadTextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombreTarea = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.lblPrimeroFecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nmrDuracion = new System.Windows.Forms.NumericUpDown();
            this.btnInfo = new System.Windows.Forms.Button();
            this.windows7Theme1 = new Telerik.WinControls.Themes.Windows7Theme();
            ((System.ComponentModel.ISupportInitialize)(this.DateDiaPickerAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTimePickerHoraInicioAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreTareaAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcionAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDuracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // DateDiaPickerAM
            // 
            this.DateDiaPickerAM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateDiaPickerAM.Location = new System.Drawing.Point(220, 46);
            this.DateDiaPickerAM.MaxDate = new System.DateTime(2016, 7, 22, 0, 0, 0, 0);
            this.DateDiaPickerAM.Name = "DateDiaPickerAM";
            this.DateDiaPickerAM.Size = new System.Drawing.Size(100, 20);
            this.DateDiaPickerAM.TabIndex = 1;
            this.DateDiaPickerAM.TabStop = false;
            this.DateDiaPickerAM.Text = "22/07/2016";
            this.DateDiaPickerAM.Value = new System.DateTime(2016, 7, 22, 0, 0, 0, 0);
            this.DateDiaPickerAM.ValueChanged += new System.EventHandler(this.DateDiaPickerAM_ValueChanged);
            // 
            // lblDiaInicio
            // 
            this.lblDiaInicio.AutoSize = true;
            this.lblDiaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaInicio.Location = new System.Drawing.Point(50, 46);
            this.lblDiaInicio.Name = "lblDiaInicio";
            this.lblDiaInicio.Size = new System.Drawing.Size(79, 13);
            this.lblDiaInicio.TabIndex = 26;
            this.lblDiaInicio.Text = "Dia de Inicio";
            // 
            // radTimePickerHoraInicioAM
            // 
            this.radTimePickerHoraInicioAM.Location = new System.Drawing.Point(220, 80);
            this.radTimePickerHoraInicioAM.MaxValue = new System.DateTime(9999, 12, 31, 23, 59, 59, 0);
            this.radTimePickerHoraInicioAM.MinValue = new System.DateTime(((long)(0)));
            this.radTimePickerHoraInicioAM.Name = "radTimePickerHoraInicioAM";
            this.radTimePickerHoraInicioAM.Size = new System.Drawing.Size(77, 20);
            this.radTimePickerHoraInicioAM.TabIndex = 2;
            this.radTimePickerHoraInicioAM.TabStop = false;
            this.radTimePickerHoraInicioAM.Text = "radTimePicker1";
            this.radTimePickerHoraInicioAM.Value = new System.DateTime(2016, 7, 15, 13, 29, 0, 0);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(50, 260);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 13);
            this.lblUsuario.TabIndex = 24;
            this.lblUsuario.Text = "Usuario:";
            // 
            // cBoxListadoAM
            // 
            this.cBoxListadoAM.FormattingEnabled = true;
            this.cBoxListadoAM.Location = new System.Drawing.Point(220, 260);
            this.cBoxListadoAM.Name = "cBoxListadoAM";
            this.cBoxListadoAM.Size = new System.Drawing.Size(121, 21);
            this.cBoxListadoAM.TabIndex = 6;
            this.cBoxListadoAM.SelectedIndexChanged += new System.EventHandler(this.cBoxListadoAM_SelectedIndexChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(325, 310);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(110, 31);
            this.btnAceptar.TabIndex = 22;
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtNombreTareaAM
            // 
            this.txtNombreTareaAM.Location = new System.Drawing.Point(220, 168);
            this.txtNombreTareaAM.MaxLength = 20;
            this.txtNombreTareaAM.Name = "txtNombreTareaAM";
            this.txtNombreTareaAM.Size = new System.Drawing.Size(163, 20);
            this.txtNombreTareaAM.TabIndex = 4;
            // 
            // txtDescripcionAM
            // 
            this.txtDescripcionAM.Location = new System.Drawing.Point(221, 214);
            this.txtDescripcionAM.MaxLength = 50;
            this.txtDescripcionAM.Name = "txtDescripcionAM";
            this.txtDescripcionAM.Size = new System.Drawing.Size(216, 20);
            this.txtDescripcionAM.TabIndex = 5;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(50, 214);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(147, 13);
            this.lblDescripcion.TabIndex = 18;
            this.lblDescripcion.Text = "Descripcion de la Tarea:";
            // 
            // lblNombreTarea
            // 
            this.lblNombreTarea.AutoSize = true;
            this.lblNombreTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTarea.Location = new System.Drawing.Point(50, 168);
            this.lblNombreTarea.Name = "lblNombreTarea";
            this.lblNombreTarea.Size = new System.Drawing.Size(61, 13);
            this.lblNombreTarea.TabIndex = 17;
            this.lblNombreTarea.Text = "Proyecto:";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracion.Location = new System.Drawing.Point(50, 126);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(164, 13);
            this.lblDuracion.TabIndex = 16;
            this.lblDuracion.Text = "Duración Tarea en minutos:";
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraInicio.Location = new System.Drawing.Point(50, 82);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(90, 13);
            this.lblHoraInicio.TabIndex = 15;
            this.lblHoraInicio.Text = "Hora de inicio:";
            // 
            // lblPrimeroFecha
            // 
            this.lblPrimeroFecha.AutoSize = true;
            this.lblPrimeroFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lblPrimeroFecha.Location = new System.Drawing.Point(217, 16);
            this.lblPrimeroFecha.Name = "lblPrimeroFecha";
            this.lblPrimeroFecha.Size = new System.Drawing.Size(166, 13);
            this.lblPrimeroFecha.TabIndex = 28;
            this.lblPrimeroFecha.Text = "*Primero selección de fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label1.Location = new System.Drawing.Point(12, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "*Ventana de añadir/modificar una tarea";
            // 
            // nmrDuracion
            // 
            this.nmrDuracion.Location = new System.Drawing.Point(221, 124);
            this.nmrDuracion.Name = "nmrDuracion";
            this.nmrDuracion.Size = new System.Drawing.Size(39, 20);
            this.nmrDuracion.TabIndex = 3;
            // 
            // btnInfo
            // 
            this.btnInfo.Image = global::ControlHoras.Properties.Resources.Circle_question;
            this.btnInfo.Location = new System.Drawing.Point(1, 0);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(33, 43);
            this.btnInfo.TabIndex = 35;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // AnadirYModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 386);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.nmrDuracion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrimeroFecha);
            this.Controls.Add(this.DateDiaPickerAM);
            this.Controls.Add(this.lblDiaInicio);
            this.Controls.Add(this.radTimePickerHoraInicioAM);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.cBoxListadoAM);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtNombreTareaAM);
            this.Controls.Add(this.txtDescripcionAM);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombreTarea);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.lblHoraInicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(465, 421);
            this.MinimumSize = new System.Drawing.Size(465, 421);
            this.Name = "AnadirYModificar";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(465, 421);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnadirYModificar";
            this.ThemeName = "Windows7";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnadirYModificar_FormClosed);
            this.Load += new System.EventHandler(this.AnadirYModificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DateDiaPickerAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTimePickerHoraInicioAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreTareaAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcionAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDuracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDateTimePicker DateDiaPickerAM;
        private System.Windows.Forms.Label lblDiaInicio;
        private Telerik.WinControls.UI.RadTimePicker radTimePickerHoraInicioAM;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cBoxListadoAM;
        private Telerik.WinControls.UI.RadButton btnAceptar;
        private Telerik.WinControls.UI.RadTextBox txtNombreTareaAM;
        private Telerik.WinControls.UI.RadTextBox txtDescripcionAM;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombreTarea;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.Label lblPrimeroFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmrDuracion;
        private System.Windows.Forms.Button btnInfo;
        private Telerik.WinControls.Themes.Windows7Theme windows7Theme1;
    }
}