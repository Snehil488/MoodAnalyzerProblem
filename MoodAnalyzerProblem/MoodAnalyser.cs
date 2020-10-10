﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerProblem
{
    class MoodAnalyser
    {
        public string AnalyseMood(string message)
        {
            if (message.Contains("sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}
