namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public string SingleWord;
    public string MultipleWords;

    public void SetInputWord(string singleWord)
    {
      SingleWord = singleWord.ToLower();
    }
    public void SetMultipleWords(string multipleWords)
    {
      MultipleWords = multipleWords.ToLower();
    }
  }
}