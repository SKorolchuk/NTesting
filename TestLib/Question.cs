using System;
using System.Collections.Generic;

namespace TestLib
{
    [Serializable]
    public class Question
    {
        public List<Answer> AnsArray { get; set; }
        public string Info { get; set; }
        public List<string> TrueAnswers { get; set; }
        public Question()
        {
            AnsArray = new List<Answer>();
            TrueAnswers = new List<string>();
        }
    }
}
