using System;
using System.Windows.Forms;
using TestLib;
using NTest.TestProcessing_files;
using NTest.StatProcessing_files;

namespace NTest
{
    public partial class MainForm
    {
        public TestList ListOfTests { get; set; }
        public string Pwd;
        public static string PathToStats = "Stat.dat";
        public static string PathToSettings = "Setting.cf";
        public static string PathToTests = "List.dat";

        public MainForm()
        {
            Pwd = "1234";
            ListOfTests = new TestList();
            InitializeComponent();
            try
            {
                UpdateList();
            }
            catch (Exception ex)
            {
                if (MessageBox.Show(String.Format("{0}\nIf this the first time starting of this program, it's normal.\nDo you want to add test?", ex.Message), @"Something works not property", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) AddThemeToolStripMenuItemClick(null, null);
            }
           
        }

        private void AddThemeToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (!VerifyAdminRights()) return;
            var param1 = new ThemeParam();
            param1.ShowDialog();
            if (!param1.Finished) return;
            ListOfTests.TestArray.Add(param1.Test);
        }

        private void ExitbtnClick(object sender, EventArgs e)
        {
            Close();
        }

        private void ThemeListSelectedIndexChanged(object sender, EventArgs e)
        {
            var temp = FindTestInList();
            richTextBox1.Text = temp.Section;
            richTextBox2.Text = temp.Description;
        }

        private void RemoveThemeToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (!VerifyAdminRights()) return;
            var temp = FindTestInList();
            ListOfTests.TestArray.Remove(temp);
            ListOfTests.Serializing(PathToTests);
            UpdateList();
        }

        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateListToolStripMenuItemClick(object sender, EventArgs e)
        {
            ListOfTests.Serializing(PathToTests);
            UpdateList();
        }

        private void SelectbtnClick(object sender, EventArgs e)
        {
            if (!VerifyEnteredManProperties())
            {
                MessageBox.Show(@"Enter correct info...");
                return;
            }
            var testing1 = new ProcessingTestForm(ThemeList.SelectedItem, 
                FirstName.Text,
                LastName.Text,
                Group.Text);
            testing1.ShowDialog();
        }

        private void StatisticViewerToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (!VerifyAdminRights()) return;
            var dialog = new StatisticViewer();
            dialog.ShowDialog();
        }
    }
}
