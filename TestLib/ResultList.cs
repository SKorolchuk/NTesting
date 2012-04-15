using System;
using System.Collections.Generic;

namespace TestLib
{
    [Serializable]
    public class ResultList
    {
        public List<Result> ListResult { get; set; }

        public ResultList()
        {
            ListResult = new List<Result>();
        }
    }
}
