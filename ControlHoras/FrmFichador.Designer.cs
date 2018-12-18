namespace ControlHoras
{
    partial class FrmFichador
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFichador));
            this.lblNombre = new Telerik.WinControls.UI.RadLabel();
            this.lblEntrada = new Telerik.WinControls.UI.RadLabel();
            this.lblSalida = new Telerik.WinControls.UI.RadLabel();
            this.lblHoraEntrada = new Telerik.WinControls.UI.RadLabel();
            this.lblHoraSalida = new Telerik.WinControls.UI.RadLabel();
            this.btnEntrada = new Telerik.WinControls.UI.RadButton();
            this.btnSalida = new Telerik.WinControls.UI.RadButton();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.windows7Theme1 = new Telerik.WinControls.Themes.Windows7Theme();
            ((System.ComponentModel.ISupportInitialize)(this.lblNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHoraEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHoraSalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 210);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(2, 2);
            this.lblNombre.TabIndex = 1;
            // 
            // lblEntrada
            // 
            this.lblEntrada.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrada.Location = new System.Drawing.Point(36, 60);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(101, 22);
            this.lblEntrada.TabIndex = 2;
            this.lblEntrada.Text = "Hora Entrada:";
            // 
            // lblSalida
            // 
            this.lblSalida.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalida.Location = new System.Drawing.Point(36, 132);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(89, 22);
            this.lblSalida.TabIndex = 2;
            this.lblSalida.Text = "Hora Salida:";
            // 
            // lblHoraEntrada
            // 
            this.lblHoraEntrada.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraEntrada.Location = new System.Drawing.Point(181, 60);
            this.lblHoraEntrada.Name = "lblHoraEntrada";
            this.lblHoraEntrada.Size = new System.Drawing.Size(45, 22);
            this.lblHoraEntrada.TabIndex = 2;
            this.lblHoraEntrada.Text = " ----";
            // 
            // lblHoraSalida
            // 
            this.lblHoraSalida.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraSalida.Location = new System.Drawing.Point(181, 135);
            this.lblHoraSalida.Name = "lblHoraSalida";
            this.lblHoraSalida.Size = new System.Drawing.Size(45, 22);
            this.lblHoraSalida.TabIndex = 2;
            this.lblHoraSalida.Text = " ----";
            // 
            // btnEntrada
            // 
            this.btnEntrada.Location = new System.Drawing.Point(343, 57);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(110, 24);
            this.btnEntrada.TabIndex = 3;
            this.btnEntrada.Text = "Fichar Entrada";
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.Location = new System.Drawing.Point(343, 133);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(110, 24);
            this.btnSalida.TabIndex = 3;
            this.btnSalida.Text = "Fichar Salida";
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // button1
            // 
            this.button1.Image = global::ControlHoras.Properties.Resources.Circle_question;
            this.button1.Location = new System.Drawing.Point(-1, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 43);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_tick);
            // 
            // FrmFichador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 238);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.lblHoraSalida);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.lblHoraEntrada);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFichador";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fichador";
            this.ThemeName = "Windows7";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmFichador_FormClosed);
            this.Load += new System.EventHandler(this.FrmFichador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lblNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHoraEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHoraSalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel lblNombre;
        private Telerik.WinControls.UI.RadLabel lblEntrada;
        private Telerik.WinControls.UI.RadLabel lblSalida;
        private Telerik.WinControls.UI.RadLabel lblHoraEntrada;
        private Telerik.WinControls.UI.RadLabel lblHoraSalida;
        private Telerik.WinControls.UI.RadButton btnEntrada;
        private Telerik.WinControls.UI.RadButton btnSalida;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private Telerik.WinControls.Themes.Windows7Theme windows7Theme1;

    }
}