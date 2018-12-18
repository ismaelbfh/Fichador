namespace ControlHoras
{
    partial class Form1
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
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.cBoxListado = new Telerik.WinControls.UI.RadCheckedDropDownList();
            this.DateDiaPicker = new Telerik.WinControls.UI.RadDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBoxListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDiaPicker)).BeginInit();
            this.SuspendLayout();
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(216, 178);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(56, 38);
            this.radButton1.TabIndex = 0;
            this.radButton1.Text = "radButton1";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // cBoxListado
            // 
            this.cBoxListado.Location = new System.Drawing.Point(56, 111);
            this.cBoxListado.Name = "cBoxListado";
            this.cBoxListado.Size = new System.Drawing.Size(125, 20);
            this.cBoxListado.TabIndex = 2;
            this.cBoxListado.Text = "radCheckedDropDownList1";
            // 
            // DateDiaPicker
            // 
            this.DateDiaPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateDiaPicker.Location = new System.Drawing.Point(56, 37);
            this.DateDiaPicker.MaxDate = new System.DateTime(2016, 7, 18, 0, 0, 0, 0);
            this.DateDiaPicker.Name = "DateDiaPicker";
            this.DateDiaPicker.Size = new System.Drawing.Size(164, 20);
            this.DateDiaPicker.TabIndex = 15;
            this.DateDiaPicker.TabStop = false;
            this.DateDiaPicker.Text = "18/07/2016";
            this.DateDiaPicker.Value = new System.DateTime(2016, 7, 18, 0, 0, 0, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.DateDiaPicker);
            this.Controls.Add(this.cBoxListado);
            this.Controls.Add(this.radButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBoxListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDiaPicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadCheckedDropDownList cBoxListado;
        private Telerik.WinControls.UI.RadDateTimePicker DateDiaPicker;
    }
}