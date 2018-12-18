using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace ControlHoras
{
    public partial class CustomMsgBox : RadForm
    {
        public CustomMsgBox()
        {
            InitializeComponent();
        }

        static CustomMsgBox MsgBox;
        static DialogResult result = System.Windows.Forms.DialogResult.No;

        public static DialogResult Show(string Text, string Caption, string btnOk, string btnCancel)
        {
            MsgBox = new CustomMsgBox();
            MsgBox.lblMsgBox.Text = Text;
            MsgBox.btnAceptar.Text = btnOk;
            MsgBox.Text = Caption;
            MsgBox.btnCancelar.Text = btnCancel;
            result = DialogResult.No;
            MsgBox.ShowDialog();
            return result;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;
            MsgBox.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MsgBox.Close();
        }
    }
}
