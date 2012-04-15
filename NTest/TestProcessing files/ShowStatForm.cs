using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TestLib;

namespace NTest.TestProcessing_files
{
    public partial class ShowStatForm : Form
    {
        public Test ProcessedTest { get; set; }
        public List<List<Answer>> SelectedAnswers { get; set; }
        public Result CurrentResult { get; set; }
        public string ResultStat = string.Empty;

        public ShowStatForm(Test inputTest, List<List<Answer>> inputAnswer, Result currentResult)
        {
            ProcessedTest = inputTest;
            SelectedAnswers = inputAnswer;
            CurrentResult = currentResult;
            CurrentResult.TrueAnsweredCountOfQuestions = 0;
            ResultStat = string.Format("Greetings! You ({0} {1} {2}) completed test few seconds ago.\nYou can see stats now.\nTest have {3} questions.\nYour answering on qustions is:\n",
                CurrentResult.PersonOfResultingTest.Name,
                CurrentResult.PersonOfResultingTest.SubName,
                CurrentResult.PersonOfResultingTest.Group,
                CurrentResult.NumberOfQuestions.ToString()
                );
            foreach (var i in SelectedAnswers)
            {
                if (VerifyAnswers(SelectedAnswers.IndexOf(i), i))
                {
                    ResultStat += String.Format("Question #{0} + \n",
                    SelectedAnswers.IndexOf(i) + 1);
                    CurrentResult.TrueAnsweredCountOfQuestions++;
                }
                else ResultStat += String.Format("Question #{0} - \n",
                    SelectedAnswers.IndexOf(i) + 1);
            }

            CurrentResult.PercentOfTrueAnswers = CreateMark();
            if (CurrentResult.IsCompletedInTime) ResultStat += "You complete Test in time.\n";
            else ResultStat += "You not complete Test in time.\n";
            ResultStat += string.Format("You answered on {0} in {1} questions.\n Your Mark is {2}\n",
                CurrentResult.TrueAnsweredCountOfQuestions,
                CurrentResult.NumberOfQuestions,
                CurrentResult.PercentOfTrueAnswers*10
                );
            InitializeComponent();
            ResultText.Text = ResultStat;
            CompareResults();
        }

        bool VerifyAnswers(int index, List<Answer> currentAns)
        {
            return currentAns.Count == ProcessedTest.QuestionArray[index].TrueAnswers.Count && currentAns.All(i => FindAns(i, ProcessedTest.QuestionArray[index].TrueAnswers));
        }

        static bool FindAns(Answer ans, IEnumerable<string> trueAns)
        {
            return trueAns.Any(i => ans.UID == i);
        }

        private void Button1Click(object sender, EventArgs e)
        {
            Close();
        }

        private double CreateMark()
        {
            if (CurrentResult.IsCompletedInTime)
            {
                if ((CurrentResult.TrueAnsweredCountOfQuestions / (double)CurrentResult.NumberOfQuestions) > 0.1)
                    return CurrentResult.TrueAnsweredCountOfQuestions / (double)CurrentResult.NumberOfQuestions;
                return 0.1;
            }
            if ((CurrentResult.TrueAnsweredCountOfQuestions / (double)CurrentResult.NumberOfQuestions - 0.1) > 0.1)
                return CurrentResult.TrueAnsweredCountOfQuestions / (double)CurrentResult.NumberOfQuestions - 0.1;
            return 0.1;
        }

        private void CompareResults()
        {
            var list = new ResultList();
            try
            {
                list = list.Deserializing(MainForm.PathToStats);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                    list.ListResult.Add(CurrentResult);
                    list.Serializing(MainForm.PathToStats);
            }
        }
    }
}
