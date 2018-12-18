namespace ControlHoras
{
    partial class Tareas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tareas));
            this.btnAnadirTarea = new Telerik.WinControls.UI.RadButton();
            this.GridTareas = new Telerik.WinControls.UI.RadGridView();
            this.cBoxListado = new System.Windows.Forms.ComboBox();
            this.btnModificar = new Telerik.WinControls.UI.RadButton();
            this.button2 = new System.Windows.Forms.Button();
            this.windows7Theme1 = new Telerik.WinControls.Themes.Windows7Theme();
            this.lblNumeroTareas = new Telerik.WinControls.UI.RadLabel();
            this.lblSumaTareas = new Telerik.WinControls.UI.RadLabel();
            this.lblEntreDias = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnadirTarea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTareas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTareas.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNumeroTareas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSumaTareas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEntreDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnadirTarea
            // 
            this.btnAnadirTarea.Location = new System.Drawing.Point(555, 286);
            this.btnAnadirTarea.Name = "btnAnadirTarea";
            this.btnAnadirTarea.Size = new System.Drawing.Size(110, 24);
            this.btnAnadirTarea.TabIndex = 0;
            this.btnAnadirTarea.Text = "Añadir Tarea";
            this.btnAnadirTarea.Click += new System.EventHandler(this.btnAnadirTarea_Click);
            // 
            // GridTareas
            // 
            this.GridTareas.Location = new System.Drawing.Point(37, 86);
            // 
            // 
            // 
            this.GridTareas.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.GridTareas.Name = "GridTareas";
            this.GridTareas.Size = new System.Drawing.Size(628, 174);
            this.GridTareas.TabIndex = 2;
            this.GridTareas.Text = "radGridView1";
            // 
            // cBoxListado
            // 
            this.cBoxListado.FormattingEnabled = true;
            this.cBoxListado.Location = new System.Drawing.Point(544, 22);
            this.cBoxListado.Name = "cBoxListado";
            this.cBoxListado.Size = new System.Drawing.Size(121, 21);
            this.cBoxListado.TabIndex = 11;
            this.cBoxListado.SelectedIndexChanged += new System.EventHandler(this.cBoxListado_SelectedIndexChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(407, 285);
            this.btnModificar.MaximumSize = new System.Drawing.Size(110, 24);
            this.btnModificar.MinimumSize = new System.Drawing.Size(110, 24);
            this.btnModificar.Name = "btnModificar";
            // 
            // 
            // 
            this.btnModificar.RootElement.MaxSize = new System.Drawing.Size(110, 24);
            this.btnModificar.RootElement.MinSize = new System.Drawing.Size(110, 24);
            this.btnModificar.Size = new System.Drawing.Size(110, 24);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // button2
            // 
            this.button2.Image = global::ControlHoras.Properties.Resources.Circle_question;
            this.button2.Location = new System.Drawing.Point(1, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 43);
            this.button2.TabIndex = 35;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblNumeroTareas
            // 
            this.lblNumeroTareas.Location = new System.Drawing.Point(96, 14);
            this.lblNumeroTareas.Name = "lblNumeroTareas";
            this.lblNumeroTareas.Size = new System.Drawing.Size(77, 18);
            this.lblNumeroTareas.TabIndex = 36;
            this.lblNumeroTareas.Text = "numeroTareas";
            // 
            // lblSumaTareas
            // 
            this.lblSumaTareas.Location = new System.Drawing.Point(96, 62);
            this.lblSumaTareas.Name = "lblSumaTareas";
            this.lblSumaTareas.Size = new System.Drawing.Size(65, 18);
            this.lblSumaTareas.TabIndex = 37;
            this.lblSumaTareas.Text = "sumaTareas";
            // 
            // lblEntreDias
            // 
            this.lblEntreDias.Location = new System.Drawing.Point(96, 38);
            this.lblEntreDias.Name = "lblEntreDias";
            this.lblEntreDias.Size = new System.Drawing.Size(53, 18);
            this.lblEntreDias.TabIndex = 37;
            this.lblEntreDias.Text = "entreDias";
            // 
            // Tareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 353);
            this.Controls.Add(this.lblEntreDias);
            this.Controls.Add(this.lblSumaTareas);
            this.Controls.Add(this.lblNumeroTareas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.cBoxListado);
            this.Controls.Add(this.GridTareas);
            this.Controls.Add(this.btnAnadirTarea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(712, 388);
            this.MinimumSize = new System.Drawing.Size(712, 388);
            this.Name = "Tareas";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(712, 388);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tareas";
            this.ThemeName = "Windows7";
            this.Load += new System.EventHandler(this.Tareas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAnadirTarea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTareas.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTareas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNumeroTareas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSumaTareas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEntreDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnAnadirTarea;
        private Telerik.WinControls.UI.RadGridView GridTareas;
        private System.Windows.Forms.ComboBox cBoxListado;
        private Telerik.WinControls.UI.RadButton btnModificar;
        private System.Windows.Forms.Button button2;
        private Telerik.WinControls.Themes.Windows7Theme windows7Theme1;
        private Telerik.WinControls.UI.RadLabel lblNumeroTareas;
        private Telerik.WinControls.UI.RadLabel lblSumaTareas;
        private Telerik.WinControls.UI.RadLabel lblEntreDias;
    }
}