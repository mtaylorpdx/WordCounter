using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.TestTools{
  [TestClass]
  public class RepeatCounterTests
  {
    [TestMethod]
    public void WordCounter_SetGetWordString_String()
    {
      RepeatCounter testCounter = new RepeatCounter("snail", "test words");
      Assert.AreEqual(testCounter.SingleWord, "snail");
    }
    [TestMethod]
    public void WordCounter_SetGetSentenceString_String()
    {
      RepeatCounter testCounter = new RepeatCounter("snail", "test words");
      Assert.AreEqual(testCounter.MultipleWords, "test words");
    }
    [TestMethod]
    public void Lowercase_MakeStringToLowercase_String()
    {
      RepeatCounter testCounter = new RepeatCounter("SNAIL", "Test Words");
      Assert.AreEqual("snail", testCounter.SingleWord);
    }
    [TestMethod]
    public void StringCheck_CheckStringForContent_True()
    {
      RepeatCounter testCounter = new RepeatCounter("snail", "test words");
      Assert.AreEqual(true, testCounter.StringCheck("snail"));
    }
    [TestMethod]
    public void StringCheck_CheckStringForContent_False()
    {
      RepeatCounter testCounter = new RepeatCounter("", "test words");
      Assert.AreEqual(false, testCounter.StringCheck(""));
    }
    [TestMethod]
    public void LetterCheck_CheckCharForValidLetter_True()
    {
      RepeatCounter testCounter = new RepeatCounter("snail", "test words");
      Assert.AreEqual(true, testCounter.LetterCheck("word"));
    }
    [TestMethod]
    public void LetterCheck_CheckCharForValidLetter_False()
    {
      RepeatCounter testCounter = new RepeatCounter("snail", "test words");
      Assert.AreEqual(false, testCounter.LetterCheck("sn4IL"));
    }
  }
}