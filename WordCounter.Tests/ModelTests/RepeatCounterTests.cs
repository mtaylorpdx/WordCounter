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
    [TestMethod]
    public void SpaceCheck_CheckSingleWordForOneWord_True()
    {
      RepeatCounter testCounter = new RepeatCounter("snail", "test words");
      Assert.AreEqual(true, testCounter.SpaceCheck("snail"));
    }
    [TestMethod]
    public void SpaceCheck_CheckSingleWordForOneWord_False()
    {
      RepeatCounter testCounter = new RepeatCounter("snail", "test words");
      Assert.AreEqual(false, testCounter.SpaceCheck("snail snail"));
    }
    [TestMethod]
    public void SplitString_SplitStringToArray_True()
    {
      RepeatCounter testCounter = new RepeatCounter("snail", "test words");
      string testString = "test snail pail words";
      string[] testSplit = {"test","snail","pail","words"};
      CollectionAssert.AreEqual(testSplit, testCounter.SplitString(testString));
    }
    [TestMethod]
    public void AddCount_CheckStringArrayForWordMatches_True()
    {
      RepeatCounter testCounter = new RepeatCounter("snail", "a snail with a pail is a pail snail");
      string[] testArray = testCounter.SplitString(testCounter.MultipleWords);
      Assert.AreEqual(2, testCounter.AddCount(testArray));
    }
  }
}