using System;
using WordCounter.Models;

namespace WordCounter
{
  public class Program
  {
    public static void Main()
    {
      Console.Write("Enter a single word: ");
      string word = Console.ReadLine();
      Console.Write("Enter a series of words: ");
      string wordList = Console.ReadLine();
      RepeatCounter counter = new RepeatCounter(word, wordList);

      int countResult = counter.AddCount(counter.SplitString(wordList));
      Console.WriteLine("Total matches: " + countResult);
    }
  }
}