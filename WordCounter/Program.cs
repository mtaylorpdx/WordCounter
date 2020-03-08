using System;
using WordCounter.Models;

namespace WordCounter
{
  public class Program
  {
    public static void Main()
    {
      Console.Write("Enter a single word: ");
      string inputWord = Console.ReadLine();
      RepeatCounter counter = new RepeatCounter(inputWord);
      Console.Write("Enter a series of words: ");
      string inputSentence = Console.ReadLine();

      inputWord = counter.RemovePunctuation(inputWord);
      inputSentence = counter.RemovePunctuation(inputSentence);
      counter = new RepeatCounter(inputWord, inputSentence);

      if ((counter.StringCheck(counter.SingleWord)) && (counter.StringCheck(counter.MultipleWords)) && (counter.SpaceCheck(counter.SingleWord)) && (counter.LetterCheck(counter.MultipleWords)))
      {
        int countResult = counter.AddCount(counter.SplitString(counter.MultipleWords));
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