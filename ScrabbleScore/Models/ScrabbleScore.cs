using System;
using System.Linq;
using System.Collections.Generic;

namespace ScrabbleScore.Models
{
  public static class ScrabbleScore
  {
    static IDictionary<char, int> dict = 
      new Dictionary<char, int>()
      {
        {'A',1},
        {'E',1},
        {'I',1},
        {'O',1},
        {'U',1},
        {'L',1},
        {'N',1},
        {'R',1},
        {'S',1},
        {'T',1},
        {'D',2},
        {'G',2},
        {'B',3},
        {'C',3},
        {'M',3},
        {'P',3},
        {'F',4},
        {'H',4},
        {'V',4},
        {'W',4},
        {'Y',4},
        {'K',5},
        {'X',8},
        {'J',8},
        {'Q',10},
        {'Z',10}
      };

    public static int GiveScrabbleScore(string word)
    {
      char[] letter = word.ToCharArray();
      int score = 0;
      for(int i = 0; i < letter.Length; i++)
      {
        char j = letter[i];
        score = score + dict[j];
      }
      return score;
    }
    public static void Main()
    {
      Console.WriteLine("Please enter a String:");
      string userInputword = Console.ReadLine();
      Console.WriteLine("You Scored: "+ GiveScrabbleScore(userInputword.ToUpper()));
    }

  }
}
