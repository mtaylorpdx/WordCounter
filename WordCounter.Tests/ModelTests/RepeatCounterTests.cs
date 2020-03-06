using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.TestTools{
  [TestClass]
  public class RepeatCounterTests
  {
    [TestMethod]
    public void WordCounter_SetGetWordString_String()
    {
      RepeatCounter testCounter = new RepeatCounter("test", "test words");
      Assert.AreEqual(testCounter.SingleWord, "test");
    }
    [TestMethod]
    public void WordCounter_SetGetSentenceString_String()
    {
      RepeatCounter testCounter = new RepeatCounter("test", "test words");
      Assert.AreEqual(testCounter.MultipleWords, "test words");
    }
    [TestMethod]
    public void Lowercase_MakeStringToLowercase_String()
    {
      RepeatCounter testCounter = new RepeatCounter("WoRd", "Test Words");
      Assert.AreEqual("word", testCounter.SingleWord);
    }
  }
}