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
    public bool StringCheck()
    {
      return false;
    }
  }
}