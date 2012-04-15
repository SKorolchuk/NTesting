using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TestLib;
using System.Threading;
using System.Threading.Tasks;

namespace NTest.TestProcessing_files
{
    public partial class ProcessingTestForm : Form
    {
        public Result CurrentResult { get; set; }
        public int CurrentNumQuestion { get; set; }
        public string SelectedVatiant { get; set; }
        public Test ProcessingTest { get; set; }
        public Question CurrentQuestion { get; set; }
        public List<List<Answer>> SelectedAnswers = new List<List<Answer>>();
        public List<Answer> CurrentQuestionSelectedAnswers = new List<Answer>();
        public bool IsTestCompleted { get; set; }

        public ProcessingTestForm(object input, string fName, string lName, string @group)
        {
            if (!(input is Test))
            {
                MessageBox.Show(@"Selected item isn't be a Test...
Come back and select property Test.", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
            else
            {
                CurrentResult = new Result
                                    {
                                        PersonOfResultingTest = {Group = @group, Name = fName, SubName = lName},
                                        DateOfCreating = DateTime.Now
                                    };
                CurrentResult.ThemeOfTest.GetTestInfo((Test)input);
                ProcessingTest = (Test)input;
                CurrentResult.NumberOfQuestions = ProcessingTest.QuestionArray.Count;
                CurrentNumQuestion = 0;
                SelectedVatiant = "";
                CurrentQuestion = ProcessingTest.QuestionArray[CurrentNumQuestion];
                InitializeComponent();
                button1.Click -= Button1Click;
                button1.Click += StartProcessing;
                IsTestCompleted = false;    
            }
        }

        private void LoadQuestion(Question thisQuestion)
        {
            label1.Text = String.Format("{0}{1}", "Question #", CurrentNumQuestion+1);
            QuestionText.Text = thisQuestion.Info;
            VariantList.Items.Clear();
            foreach (var i in thisQuestion.AnsArray)
            {
                VariantList.Items.Add(i);
            }
        }

        private void TimeTick()
        {
            CurrentResult.IsCompletedInTime = true;
            var i = ProcessingTest.EstimateTime;
            while (!IsTestCompleted)
            {
                if ((i < 0) && CurrentResult.IsCompletedInTime)
                {
                    TimeLabel.ForeColor = System.Drawing.Color.Red;
                    CurrentResult.IsCompletedInTime = false;
                }
                TimeLabel.Text = i.ToTime();
                Thread.Sleep(1000);
                i--;
            }
        }

        private void Button1Click(object sender, EventArgs e)
        {            
            if ((ProcessingTest.QuestionArray.Count - 1) > CurrentNumQuestion)
            {
                SelectedAnswers.Add(CurrentQuestionSelectedAnswers);
                CurrentQuestionSelectedAnswers = new List<Answer>();
                CurrentNumQuestion++;
                CurrentQuestion = ProcessingTest.QuestionArray[CurrentNumQuestion];
                LoadQuestion(CurrentQuestion);
                TrueSelector.Checked = false;
                AnswerText.Text = "";
                label3.Text = @"Selected variant is";
            }
            else
            {
                    SelectedAnswers.Add(CurrentQuestionSelectedAnswers);
                    CurrentQuestionSelectedAnswers = new List<Answer>();
                    ShowStats();
                    Close();
            }
        }

        private void ShowStats()
        {
            Hide();
            var result = new ShowStatForm(ProcessingTest, SelectedAnswers, CurrentResult);
            result.ShowDialog();
        }

        private void VariantListSelectedIndexChanged(object sender, EventArgs e)
        {
            AnswerText.Text = ((Answer)VariantList.SelectedItem).Info;
            label3.Text = String.Format("Selected variant is {0}", ((Answer)VariantList.SelectedItem).UID);
            TrueSelector.Checked = SearchItem((Answer)VariantList.SelectedItem);
        }

        private bool SearchItem(Answer input)
        {
            return CurrentQuestionSelectedAnswers.Any(i => i == input);
        }

        private void TrueSelectorCheckedChanged(object sender, EventArgs e)
        {
            if (TrueSelector.Checked)
            {
                CurrentQuestionSelectedAnswers.Add((Answer)VariantList.SelectedItem);
            }
            if (TrueSelector.Checked == false)
            {
                CurrentQuestionSelectedAnswers.Remove((Answer)VariantList.SelectedItem);
            }
        }

        private void StartProcessing(object sender, EventArgs e)
        {
                button1.Text = @"Next";
                label1.Enabled = true;
                label2.Enabled = true;
                label3.Enabled = true;
                TimeLabel.Enabled = true;
                QuestionText.Enabled = true;
                AnswerText.Enabled = true;
                VariantList.Enabled = true;
                TrueSelector.Enabled = true;
                Task.Factory.StartNew(TimeTick);
                LoadQuestion(CurrentQuestion);
                button1.Click -= StartProcessing;
                button1.Click += Button1Click;
                return;
        }
    }
}
