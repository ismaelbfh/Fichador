namespace ControlHoras
{
    partial class ListarUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarUsuarios));
            this.rdGridUsuarios = new Telerik.WinControls.UI.RadGridView();
            this.btnGuardar = new Telerik.WinControls.UI.RadButton();
            this.btnSalir = new Telerik.WinControls.UI.RadButton();
            this.button1 = new System.Windows.Forms.Button();
            this.windows7Theme1 = new Telerik.WinControls.Themes.Windows7Theme();
            ((System.ComponentModel.ISupportInitialize)(this.rdGridUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdGridUsuarios.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // rdGridUsuarios
            // 
            this.rdGridUsuarios.Location = new System.Drawing.Point(63, 26);
            // 
            // 
            // 
            this.rdGridUsuarios.MasterTemplate.AllowAddNewRow = false;
            this.rdGridUsuarios.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rdGridUsuarios.Name = "rdGridUsuarios";
            this.rdGridUsuarios.ShowNoDataText = false;
            this.rdGridUsuarios.Size = new System.Drawing.Size(559, 157);
            this.rdGridUsuarios.TabIndex = 0;
            this.rdGridUsuarios.Text = "rdGridUsuarios";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(162, 228);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 24);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(441, 228);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 24);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // button1
            // 
            this.button1.Image = global::ControlHoras.Properties.Resources.Circle_question;
            this.button1.Location = new System.Drawing.Point(0, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 43);
            this.button1.TabIndex = 34;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(743, 324);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.rdGridUsuarios);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(751, 359);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(751, 359);
            this.Name = "ListarUsuarios";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(751, 359);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios y Permisos";
            this.ThemeName = "Windows7";
            this.Load += new System.EventHandler(this.ListarUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rdGridUsuarios.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdGridUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rdGridUsuarios;
        private Telerik.WinControls.UI.RadButton btnGuardar;
        private Telerik.WinControls.UI.RadButton btnSalir;
        private System.Windows.Forms.Button button1;
        private Telerik.WinControls.Themes.Windows7Theme windows7Theme1;
    }
}