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
            string message = "I am in sad mood.";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            //Act
            string result = moodAnalyser.AnalyseMood();
            //Assert
            Assert.AreEqual("SAD", result);
        }
        [TestMethod]
        public void Given_I_Am_In_Happy_Mood_Should_Return_HAPPY()
        {
            //Arrange
            string message = "I am in happy mood.";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            //Act
            string result = moodAnalyser.AnalyseMood();
            //Assert
            Assert.AreEqual("HAPPY", result);
        }
        [TestMethod]
        public void Given_Null_Should_Return_HAPPY()
        {
            //Arrange
            string message = null;
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            //Act
            string result = moodAnalyser.AnalyseMood();
            //Assert
            Assert.AreEqual("HAPPY", result);
        }
    }
}
