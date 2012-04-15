using System.Linq;
using System.Windows.Forms;
using TestLib;
using NTest.Main_files;

namespace NTest
{
    public partial class MainForm : Form
    {
        private Test FindTestInList()
        {
            return ListOfTests.TestArray.FirstOrDefault(i => (Test) ThemeList.SelectedItem == i);
        }

        void UpdateList()
        {
            ThemeList.Items.Clear();
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            ListOfTests = ListOfTests.Deserializing(PathToTests);
            foreach (var i in ListOfTests.TestArray)
            {
                if (i != null) ThemeList.Items.Add(i);
            }
        }

        bool VerifyAdminRights()
        {
            var verify = new VerifyForm(Pwd);
            verify.ShowDialog();
            return verify.Confirm;
        }

        bool VerifyEnteredManProperties()
        {
            return FirstName.Text.Length >= 6 && (LastName.Text.Length >= 6 && Group.Text.Length >= 3);
        }
    }
}
