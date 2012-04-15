using System;
using System.Windows.Forms;
using TestLib;

namespace NTest.StatProcessing_files
{
    public partial class StatisticViewer : Form
    {
        ResultList List;

        public StatisticViewer()
        {
            InitializeComponent();
            try
            {
                List = List.Deserializing(MainForm.PathToStats);
            }
            catch
            {
                List = new ResultList();
            }
            finally
            {
                foreach (var i in List.ListResult)
                {
                    ResultListBox.Items.Add(i);
                }
            }
        }

        private void ExitBtnClick(object sender, EventArgs e)
        {
            Close();
        }

        private void ResultListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
           InfoText.Text = SetStringToInfo((Result)ResultListBox.SelectedItem);
        }

        private string SetStringToInfo(Result result)
        {
            string toReturn;
            try
            {
                toReturn = string.Format("Person: {8} {9} {10} \nTest completed in time: {0}\nAnswered on {1} from {2} questions.\nPercent of true answers is {3}.\nTheme of Test is {4}.\nSection of Theme is {5}.\nAbout Test:\n{6}\nTime for Test is {7} seconds.\n",
                    result.IsCompletedInTime.ToString(),
                    result.TrueAnsweredCountOfQuestions.ToString(),
                    result.NumberOfQuestions.ToString(),
                    (result.PercentOfTrueAnswers * 100).ToString(),
                    result.ThemeOfTest.Info,
                    result.ThemeOfTest.Section,
                    result.ThemeOfTest.Description,
                    result.ThemeOfTest.EstimateTime,
                    result.PersonOfResultingTest.Name,
                    result.PersonOfResultingTest.SubName,
                    result.PersonOfResultingTest.Group
                    );
            }
            catch
            {
                toReturn = null;
            }
            return toReturn;
        }

        private void RemoveBtnClick(object sender, EventArgs e)
        {
            List.ListResult.Remove((Result)ResultListBox.SelectedItem);
            ResultListBox.Items.Remove(ResultListBox.SelectedItem);            
            List.Serializing(MainForm.PathToStats);
        }
    }
}
