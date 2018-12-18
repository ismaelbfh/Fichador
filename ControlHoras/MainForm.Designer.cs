namespace ControlHoras
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarDiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validarseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUserConectado = new Telerik.WinControls.UI.RadLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.windows7Theme1 = new Telerik.WinControls.Themes.Windows7Theme();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblUserConectado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichadorToolStripMenuItem,
            this.consultarDiasToolStripMenuItem,
            this.validarseToolStripMenuItem,
            this.tareasToolStripMenuItem,
            this.controlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(861, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichadorToolStripMenuItem
            // 
            this.fichadorToolStripMenuItem.AutoToolTip = true;
            this.fichadorToolStripMenuItem.Name = "fichadorToolStripMenuItem";
            this.fichadorToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.fichadorToolStripMenuItem.Text = "Fichador";
            this.fichadorToolStripMenuItem.ToolTipText = "Ficha tus horas";
            this.fichadorToolStripMenuItem.Click += new System.EventHandler(this.fichadorToolStripMenuItem_Click);
            // 
            // consultarDiasToolStripMenuItem
            // 
            this.consultarDiasToolStripMenuItem.Name = "consultarDiasToolStripMenuItem";
            this.consultarDiasToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.consultarDiasToolStripMenuItem.Text = "Consultar Dias";
            this.consultarDiasToolStripMenuItem.ToolTipText = "Consultas días trabajados";
            this.consultarDiasToolStripMenuItem.Click += new System.EventHandler(this.consultarDiasToolStripMenuItem_Click);
            // 
            // validarseToolStripMenuItem
            // 
            this.validarseToolStripMenuItem.Name = "validarseToolStripMenuItem";
            this.validarseToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.validarseToolStripMenuItem.Text = "Validarse";
            this.validarseToolStripMenuItem.ToolTipText = "Cambia permisos usuarios";
            this.validarseToolStripMenuItem.Click += new System.EventHandler(this.validarseToolStripMenuItem_Click);
            // 
            // tareasToolStripMenuItem
            // 
            this.tareasToolStripMenuItem.Name = "tareasToolStripMenuItem";
            this.tareasToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.tareasToolStripMenuItem.Text = "Tareas";
            this.tareasToolStripMenuItem.ToolTipText = "Información de Tareas";
            this.tareasToolStripMenuItem.Click += new System.EventHandler(this.tareasToolStripMenuItem_Click);
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.controlToolStripMenuItem.Text = "Filtro Tareas";
            this.controlToolStripMenuItem.ToolTipText = "Recuperar Horas";
            this.controlToolStripMenuItem.Click += new System.EventHandler(this.controlToolStripMenuItem_Click);
            // 
            // lblUserConectado
            // 
            this.lblUserConectado.Location = new System.Drawing.Point(0, 27);
            this.lblUserConectado.Name = "lblUserConectado";
            this.lblUserConectado.Size = new System.Drawing.Size(55, 18);
            this.lblUserConectado.TabIndex = 3;
            this.lblUserConectado.Text = "radLabel1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(861, 488);
            this.Controls.Add(this.lblUserConectado);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ThemeName = "Windows7";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblUserConectado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarDiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validarseToolStripMenuItem;
        private Telerik.WinControls.UI.RadLabel lblUserConectado;
        private System.Windows.Forms.ToolStripMenuItem tareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private Telerik.WinControls.Themes.Windows7Theme windows7Theme1;
    }
}

