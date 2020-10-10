using System;

namespace MoodAnalyzerProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            Console.WriteLine(moodAnalyser.AnalyseMood("I am in sad mood."));
        }
    }
}
