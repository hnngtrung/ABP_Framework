﻿using System;
using System.Collections.Generic;
using System.Text;

namespace acme.student.Models.Search
{
    public class ConditionSearchRequest
    {
        public string keyword { get; set; }
        public int SkipCount { get; set; }
        public int MaxResutlCount { get; set; }
    }
}
