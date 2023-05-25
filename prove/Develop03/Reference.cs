using System;
using System.Collections.Generic;
using System.IO;


public class References
{
  private string _book;
  private string _chapter;

  private string _startVerse;
  private string _endVerse;
  public References(string Book, string Chapter, string StartVerse)
  {
    _book = Book;
    _chapter = Chapter;
    _startVerse = StartVerse;
    _endVerse = null;
  }
  public References(string Book, string Chapter, string StartVerse, string EndVerse)
  {
    _book = Book;
    _chapter = Chapter;
    _startVerse = StartVerse;
    _endVerse = EndVerse;
  }

  public string GetReference()
  {
    if (_endVerse == null)
        return $"{_book} {_chapter}: {_startVerse}";
    else
        return $"{_book} {_chapter}: {_startVerse} - {_endVerse}";
  }
}

