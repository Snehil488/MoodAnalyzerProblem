using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;

namespace MoodAnalyzerProblemTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_I_Am_In_Sad_Mood_Should_Return_SAD()
        {
            //Arrange
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string message = "I am in sad mood.";
            //Act
            string result = moodAnalyser.AnalyseMood(message);
            //Assert
            Assert.AreEqual("SAD", result);
        }
        [TestMethod]
        public void Given_I_Am_In_Any_Mood_Should_Return_HAPPY()
        {
            //Arrange
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string message = "I am in any mood.";
            //Act
            string result = moodAnalyser.AnalyseMood(message);
            //Assert
            Assert.AreEqual("HAPPY", result);
        }
    }
}
