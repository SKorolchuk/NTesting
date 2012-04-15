using System;
using System.Collections.Generic;

namespace TestLib
{
    [Serializable]
    public class TestList
    {
        public List<Test> TestArray { get; set; }
        public TestList()
        {
            TestArray = new List<Test>();
        }
    }
}
