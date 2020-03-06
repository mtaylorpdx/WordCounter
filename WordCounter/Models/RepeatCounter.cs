namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public string SingleWord {set;get;}
    public string MultipleWords {set;get;}
    public RepeatCounter(string word, string sentence)
    {
      SingleWord = word.ToLower();
      MultipleWords = sentence.ToLower();
    }
    public bool StringCheck(string input)
    {
      if (string.IsNullOrEmpty(input))
      {
        return false;
      }
      return true;
    }
    public bool LetterCheck(string input)
    {
      return false;
    }
  }
}