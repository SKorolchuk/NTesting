using System;
using System.Windows.Forms;

namespace NTest.Main_files
{
    public partial class VerifyForm : Form
    {
        private string _pass;
        public bool Confirm { get; set; }

        public VerifyForm(string psw)
        {
            InitializeComponent();
            _pass = psw;
            Confirm = false;
        }

        private void Button2Click(object sender, EventArgs e)
        {
            Confirm = PwdText.Text == _pass;
            Close();
        }

        private void Button1Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
