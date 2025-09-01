using System;

namespace Library {
  public class Item(string title, string author)
  {
    public string Title { get; set; } = title;
    public string Author { get; set; } = author;
  }
}