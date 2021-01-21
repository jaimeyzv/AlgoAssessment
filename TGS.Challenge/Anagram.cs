using System;
using System.Text.RegularExpressions;

namespace TGS.Challenge
{
  /*
        Devise a function that checks if 1 word is an anagram of another, if the words are anagrams of
        one another return true, else return false

        "Anagram": An anagram is a type of word play, the result of rearranging the letters of a word or
        phrase to produce a new word or phrase, using all the original letters exactly once; for example
        orchestra can be rearranged into carthorse.

        areAnagrams("horse", "shore") should return true
        areAnagrams("horse", "short") should return false

        NOTE: Punctuation, including spaces should be ignored, e.g.

        horse!! shore = true
        horse  !! shore = true
          horse? heroes = true

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class Anagram
    {
        public bool AreAnagrams(string word1, string word2)
        {
            if (string.IsNullOrEmpty(word1) || string.IsNullOrEmpty(word2)) 
                throw new ArgumentException();

            word1 = word1.Replace(" ", "").ToLower();
            word2 = word2.Replace(" ", "").ToLower();

            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            word1 = rgx.Replace(word1, "");
            word2 = rgx.Replace(word2, "");

            var orderedWord1 = word1.ToCharArray();
            Array.Sort(orderedWord1);
            var orderedWord2 = word2.ToCharArray();
            Array.Sort(orderedWord2);

            var value1 = new string(orderedWord1);
            var value2 = new string(orderedWord2);

            return value1 == value2;
        }
    }
}
