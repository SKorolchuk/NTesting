using System;
using System.Linq;
using System.Windows.Forms;
using TestLib;

namespace NTest
{
    public partial class AddinNewTheme : Form
    { 
        public bool Finished { get; set; }
        public int CurrentQuestionId { get; set; }
        public int Count { get; set; }
        public Question CurrentQuestion { get; set; }
        public Test CurrentTest { get; set; }
        public AddinNewTheme(string theme, string section, int count)
        {
            Finished = false;
            CurrentTest = new Test();
            CurrentQuestion = new Question();
            CurrentTest.Section = section;
            CurrentTest.Info = theme;
            Count = count;
            CurrentQuestionId = 1;
            InitializeComponent();
            label1.Text = String.Format("Question #{0}", CurrentQuestionId);
        }

        private void Button1Click(object sender, EventArgs e)
        {
            if (!SearchItem(listBox2, listBox1.SelectedItem))
                {
                    listBox2.Items.Add(listBox1.SelectedItem);
                    CurrentQuestion.TrueAnswers.Add(((Answer)listBox1.SelectedItem).UID);
                }
        }

        private void Button2Click(object sender, EventArgs e)
        {
           var addAns = new AddAnsDialog();
           addAns.ShowDialog();
           if (!addAns.Finished) return;
            var i = new Answer {Info = addAns.CurrentAns.Info, UID = addAns.CurrentAns.UID};
            listBox1.Items.Add(i);
           CurrentQuestion.AnsArray.Add(i);
        }

        private void Button3Click(object sender, EventArgs e)
        {
            if (!VerifyForm()) return;
            CurrentQuestion.Info = TitleText.Text;
            CurrentTest.QuestionArray.Add(CurrentQuestion);
            if (CurrentQuestionId < Count)
            {
                CurrentQuestionId++;
                CurrentQuestion = new Question();
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                label1.Text = String.Format("Question #{0}", CurrentQuestionId);
                TitleText.Text = "";
            }
            else
            {
                MessageBox.Show(@"All questions are configured. We prepared to save test.");
                Finished = true;
                Close();
            }
        }

        bool VerifyForm()
        {
            return TitleText.Text.Length >= 1 && (listBox1.Items.Count >= 1 && listBox2.Items.Count >= 1);
        }

        private void Button4Click(object sender, EventArgs e)
        {
            RemoveSelectedItem(listBox1, listBox1.SelectedItem);
        }

        private void Button5Click(object sender, EventArgs e)
        {
            RemoveSelectedItem(listBox2, listBox2.SelectedItem);
        }

        void RemoveSelectedItem(ListBox currentList, object selectedItem)
        {
            currentList.Items.Remove(selectedItem);
            if (selectedItem is string)
            {
                if (currentList == listBox2) CurrentQuestion.TrueAnswers.Remove((string)selectedItem);
            }
            if (selectedItem is Answer)
            {
                if (currentList == listBox1) CurrentQuestion.AnsArray.Remove((Answer)selectedItem);
            }
        }

        bool SearchItem(ListBox currentListBox, object item)
        {
            return currentListBox.Items.Cast<object>().Any(i => i == item);
        }
    }
}
