using System;
using System.Windows.Forms;
using TestLib;

namespace NTest
{
    public partial class ThemeParam : Form
    {
        public int Count { get; set; }
        public string Info { get; set; }
        public string Section { get; set; }
        public Test Test { get; set; }
        public bool Finished;
        public ThemeParam()
        {
            InitializeComponent();
        }

        private void Button1Click(object sender, EventArgs e)
        {
            if (!FormValidating()) return;
            Count = Convert.ToInt32(textBox1.Text);
            Section = textBox2.Text;
            Info = textBox3.Text;
            var dialog = new AddinNewTheme(Info, Section, Count);
            Hide();
            dialog.ShowDialog();
            if (!dialog.Finished) return;
            Test = dialog.CurrentTest;
            Test.Description = richTextBox1.Text;
            Test.EstimateTime = Convert.ToInt32(textBox4.Text);
            Finished = true;
            Close();
        }

        public bool FormValidating()
        {            
            try
            {
                if (Convert.ToInt32(textBox1.Text) < 1) throw new Exception("Count of questions is not valid");
                if (textBox2.Text.Length <= 0) throw new Exception("Incorrect data in Test properties");
                if (textBox3.Text.Length <= 0) throw new Exception("Incorrect data in Test properties");
                if (richTextBox1.Text.Length <= 0) throw new Exception("Incorrect data in Test properties");
                if (Convert.ToInt32(textBox4.Text) < 1) throw new Exception("Count of seconds is not valid");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("{0}\n{1}", ex.Message, "Retype data..."));
                return false;
            }
        }
    }
}
