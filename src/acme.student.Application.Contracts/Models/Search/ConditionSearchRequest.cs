using System;
using System.Collections.Generic;
using System.Text;

namespace acme.student.Models.Search
{
    public class ConditionSearchRequest
    {
        public string keyword { get; set; }
        public int skipCount { get; set; }
        public int maxResutlCount { get; set; }
    }
}
