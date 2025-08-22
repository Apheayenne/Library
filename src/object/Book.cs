using System;
using System.Reflection;

namespace Library {
  public class Book(string title, string author, string? series, int? number, bool isRead = false) : Item(title, author){
    
    public string? Series { get; private set; } = series;
    public int? BookNumber { get; private set; } = number;
    public bool IsRead { get; set; } = isRead;

    public override string ToString() {
      return $"{Title}, by {Author}, series {Series} book {BookNumber}";
    }
    
    public string Save(){
      return $"{Title}|{Author}|{Series}|{BookNumber}|{IsRead}";
		}

  }
}