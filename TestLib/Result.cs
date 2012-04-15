using System;

namespace TestLib
{
    [Serializable]
    public class Result
    {
        public int NumberOfQuestions { get; set; }
        public int TrueAnsweredCountOfQuestions { get; set; }
        public double PercentOfTrueAnswers { get; set; }
        public Person PersonOfResultingTest { get; set; }
        public bool IsCompletedInTime { get; set; }
        public DateTime DateOfCreating { get; set; }
        public TestInfo ThemeOfTest { get; set; }

        public Result()
        {
            PersonOfResultingTest = new Person();
            DateOfCreating = new DateTime();
            ThemeOfTest = new TestInfo();
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} Created {3} {4}",
                PersonOfResultingTest.Name,
                PersonOfResultingTest.SubName,
                PersonOfResultingTest.Group,
                DateOfCreating.ToShortDateString(),
                DateOfCreating.ToShortTimeString());
        }
    }
}
