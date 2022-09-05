using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace MoodAnaylserTest

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AnalyseMood()
        {
            Moodanalyser moodAnalyzer = new Moodanalyser();
            string message = "I am in Sad Mood";
            string ExpectedOutput = "SAD";

            string result = moodAnalyzer.AnalyseMood(message);

            Assert.AreEqual(result, ExpectedOutput);

        }
    }
}