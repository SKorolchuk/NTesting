using System;

namespace TestLib
{
    [Serializable]
    public class Answer
    {
        public string Info { get; set; }
        public string UID { get; set; }
        public override string ToString()
        {
            return UID;
        }
    }
}
