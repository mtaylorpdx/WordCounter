namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public string SingleWord {set;get;}
    public string MultipleWords {set;get;}

    public RepeatCounter(string word)
    {
      SingleWord = word.ToLower();
    }
    public RepeatCounter(string word, string sentence) : this(word)
    {
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
        if ((char.IsLetter(letter) == false && (letter != ' ')))
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
    public string RemovePunctuation(string inputString)
    {
      foreach(char letter in inputString)
      {
        if (char.IsPunctuation(letter))
        {
          inputString = inputString.Replace(letter, ' ');
        }
      }
      return inputString;
    }
    public string[] SplitString(string sentence)
    {
      string[] splitString = sentence.Split(' ');
      return splitString;
    }
    public int AddCount(string[] array)
    {
      int count = 0;
      foreach(string word in array)
      {
        if (word == SingleWord)
        {
          count++;
        }
      }
      return count;
    }
  }
}