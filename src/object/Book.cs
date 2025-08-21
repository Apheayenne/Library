using System;

namespace Library {
  public class Book(string title, string author, string series, int number) : Item(title, author){
    
    public string Series { get; private set; }
    public int BookNumber { get; private set; }
    public bool IsRead { get; private set; }
    
    public Book(string title, string author, string series, int number, bool isRead = false) : base(title, author){
      Series = series;
      BookNumber = number;
      IsRead = isRead;
      BookCase.BookShelf.Add();
    }
    
    public void UpdateIsRead(bool isRead) {
      IsRead = isRead;
    }

    public override string ToString() {
      return $"{Title}, by {Author}, series {Series} book {BookNumber}";
    }
    
    public 

  }
}