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

      if ((counter.StringCheck(word)) && (counter.StringCheck(wordList)) && (counter.SpaceCheck(word)) && (counter.LetterCheck(wordList)))
      {
        int countResult = counter.AddCount(counter.SplitString(wordList));
        Console.WriteLine("Total matches: " + countResult);
      }
      else
      {
        Console.WriteLine("Please enter both a single word and a sentence.");
        Main();
      }
    }
  }
}