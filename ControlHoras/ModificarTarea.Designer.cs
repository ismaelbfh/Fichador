namespace ControlHoras
{
    partial class ModificarTarea
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
            this.DateDiaPicker = new Telerik.WinControls.UI.RadDateTimePicker();
            this.lblDiaInicio = new System.Windows.Forms.Label();
            this.radTimePickerHoraInicio = new Telerik.WinControls.UI.RadTimePicker();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnAgregar = new Telerik.WinControls.UI.RadButton();
            this.txtNombreTarea = new Telerik.WinControls.UI.RadTextBox();
            this.txtDuracion = new Telerik.WinControls.UI.RadTextBox();
            this.txtDescripcion = new Telerik.WinControls.UI.RadTextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombreTarea = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.txtUsuario = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DateDiaPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTimePickerHoraInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreTarea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // DateDiaPicker
            // 
            this.DateDiaPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateDiaPicker.Location = new System.Drawing.Point(189, 36);
            this.DateDiaPicker.MaxDate = new System.DateTime(2016, 7, 18, 0, 0, 0, 0);
            this.DateDiaPicker.Name = "DateDiaPicker";
            this.DateDiaPicker.Size = new System.Drawing.Size(164, 20);
            this.DateDiaPicker.TabIndex = 27;
            this.DateDiaPicker.TabStop = false;
            this.DateDiaPicker.Text = "18/07/2016";
            this.DateDiaPicker.Value = new System.DateTime(2016, 7, 18, 0, 0, 0, 0);
            // 
            // lblDiaInicio
            // 
            this.lblDiaInicio.AutoSize = true;
            this.lblDiaInicio.Location = new System.Drawing.Point(40, 36);
            this.lblDiaInicio.Name = "lblDiaInicio";
            this.lblDiaInicio.Size = new System.Drawing.Size(66, 13);
            this.lblDiaInicio.TabIndex = 26;
            this.lblDiaInicio.Text = "Dia de Inicio";
            // 
            // radTimePickerHoraInicio
            // 
            this.radTimePickerHoraInicio.Location = new System.Drawing.Point(189, 70);
            this.radTimePickerHoraInicio.MaxValue = new System.DateTime(9999, 12, 31, 23, 59, 59, 0);
            this.radTimePickerHoraInicio.MinValue = new System.DateTime(((long)(0)));
            this.radTimePickerHoraInicio.Name = "radTimePickerHoraInicio";
            this.radTimePickerHoraInicio.Size = new System.Drawing.Size(106, 20);
            this.radTimePickerHoraInicio.TabIndex = 25;
            this.radTimePickerHoraInicio.TabStop = false;
            this.radTimePickerHoraInicio.Text = "radTimePicker1";
            this.radTimePickerHoraInicio.Value = new System.DateTime(2016, 7, 15, 13, 29, 0, 0);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(43, 257);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 24;
            this.lblUsuario.Text = "Usuario:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(336, 287);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(77, 33);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            // 
            // txtNombreTarea
            // 
            this.txtNombreTarea.Location = new System.Drawing.Point(189, 158);
            this.txtNombreTarea.Name = "txtNombreTarea";
            this.txtNombreTarea.Size = new System.Drawing.Size(100, 20);
            this.txtNombreTarea.TabIndex = 20;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(189, 114);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(100, 20);
            this.txtDuracion.TabIndex = 19;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(189, 204);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 21;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(40, 204);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(123, 13);
            this.lblDescripcion.TabIndex = 18;
            this.lblDescripcion.Text = "Descripcion de la Tarea:";
            // 
            // lblNombreTarea
            // 
            this.lblNombreTarea.AutoSize = true;
            this.lblNombreTarea.Location = new System.Drawing.Point(40, 158);
            this.lblNombreTarea.Name = "lblNombreTarea";
            this.lblNombreTarea.Size = new System.Drawing.Size(104, 13);
            this.lblNombreTarea.TabIndex = 17;
            this.lblNombreTarea.Text = "Nombre de la Tarea:";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(40, 114);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(138, 13);
            this.lblDuracion.TabIndex = 16;
            this.lblDuracion.Text = "Duración Tarea en minutos:";
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Location = new System.Drawing.Point(40, 72);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(75, 13);
            this.lblHoraInicio.TabIndex = 15;
            this.lblHoraInicio.Text = "Hora de inicio:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(189, 255);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 22;
            // 
            // ModificarTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 332);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.DateDiaPicker);
            this.Controls.Add(this.lblDiaInicio);
            this.Controls.Add(this.radTimePickerHoraInicio);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombreTarea);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombreTarea);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.lblHoraInicio);
            this.Name = "ModificarTarea";
            this.Text = "ModificarTarea";
            this.Load += new System.EventHandler(this.ModificarTarea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DateDiaPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTimePickerHoraInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreTarea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDateTimePicker DateDiaPicker;
        private System.Windows.Forms.Label lblDiaInicio;
        private Telerik.WinControls.UI.RadTimePicker radTimePickerHoraInicio;
        private System.Windows.Forms.Label lblUsuario;
        private Telerik.WinControls.UI.RadButton btnAgregar;
        private Telerik.WinControls.UI.RadTextBox txtNombreTarea;
        private Telerik.WinControls.UI.RadTextBox txtDuracion;
        private Telerik.WinControls.UI.RadTextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombreTarea;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblHoraInicio;
        private Telerik.WinControls.UI.RadTextBox txtUsuario;
    }
}