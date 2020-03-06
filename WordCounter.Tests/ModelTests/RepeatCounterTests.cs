using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.TestTools{
  [TestClass]
  public class RepeatCounterTests
  {
    [TestMethod]
    public void WordCounter_SetGetString_String()
    {
      RepeatCounter testCounter = new RepeatCounter();
      string testWord = "test";
      testCounter.SetInputWord(testWord);
      Assert.AreEqual(testCounter.InputWord, "test");
    }
  }
}