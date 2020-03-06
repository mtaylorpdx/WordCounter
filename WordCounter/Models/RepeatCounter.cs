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
      foreach (char letter in input)
      {
        if (char.IsLetter(letter) == false)
        {
          return false;
        }
      }
      return true;
    }
    public bool SpaceCheck(string input)
    {
      foreach (char letter in input)
      {
        if (letter == ' ')
        {
          return false;
        }
      }
      return true;
    }
    public string[] SplitString(string sentence)
    {
      string[] splitString = sentence.Split(' ');
      return splitString;
    }
    public int AddCount(string[] array)
    {
      return 0;
    }
  }
}