using System;

namespace MoodAnalyzerProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in sad mood.");
            Console.WriteLine(moodAnalyser.AnalyseMood());
        }
    }
}
