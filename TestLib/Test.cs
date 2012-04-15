using System;
using System.Collections.Generic;

namespace TestLib
{
    [Serializable]
    public class Test
    {
        public string Section { get; set; }
        public string Info { get; set; }
        public string Description { get; set; }
        public List<Question> QuestionArray { get; set; }
        public int EstimateTime { get; set; }
        public Test()
        {
            QuestionArray = new List<Question>();
        }
        public override string ToString()
        {
            return Info;
        }
    }

    [Serializable]
    public class TestInfo
    {
        public string Section { get; set; }
        public string Info { get; set; }
        public string Description { get; set; }
        public int EstimateTime { get; set; }
    }
}
