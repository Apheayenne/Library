using System;

namespace Library {
  public class Item {
    public string Title { get; set; }
    public string Author { get; set; }

    public Item(string title, string author) {
      Title = title;
      Author = author;
    }
  }
}