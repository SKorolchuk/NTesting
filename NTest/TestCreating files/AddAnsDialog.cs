using System;
using System.Windows.Forms;
using TestLib;

namespace NTest
{
    public partial class AddAnsDialog : Form
    {
        public Answer CurrentAns;
        public bool Finished;
        public AddAnsDialog()
        {
            CurrentAns = new Answer();
            InitializeComponent();
            AnswerText.Text = "";
            UIDText.Text = "";
        }

        private void Button1Click(object sender, EventArgs e)
        {
            if (!VerifyForm()) return;
            CurrentAns = new Answer { Info = AnswerText.Text, UID = UIDText.Text};
            Finished = true;
            Close();
        }

        private void Button2Click(object sender, EventArgs e)
        {
            if (!VerifyForm()) return;
            Close();
        }

        bool VerifyForm()
        {
            return UIDText != null && (AnswerText != null && (AnswerText.Text.Length >= 2 && UIDText.Text.Length >= 2));
        }
    }
}
