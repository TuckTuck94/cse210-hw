using System;
using System.Collections.Generic;
using System.IO;

public class Scripture
{  
  // Variable (attributes) (fields)
  private List<Word> _words;

  // Constructor
  // public Scripture() {}
  public Scripture(string text)
  {
    _words = new List<Word>();
    string[] textWords = text.Split(' ');

    for (int i= 0 ; i< textWords.Length; i++)
    {
      _words.Add(new Word(textWords[i]));
    }

  }

  // Functions (methods) (behaviors)
  public List<Word> GetWords()
  {
    return _words;
  }

  // new method called GetWordsHiden
  // use for loop to iterate through each of the words.
  //    call word.GetIsvisible()
  // check using if, if the word is visible
  // return true if all words are hidden, otherwise return false
}