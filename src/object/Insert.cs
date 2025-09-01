using System;

namespace Library{
  public static class Insert
  {
    public static void InsertGame(string inTitle, string inDeveloper, string inPublisher, string inSystem) {
      BookCase.AddGameToShelf(new Game(inTitle, inDeveloper, inPublisher, inSystem));
    }

    public static void InsertBook(string inTitle, string inAuthor, string? inSeries, int? inBookNumber, bool inHasRead) {
      string series = inSeries ?? "";
      int bookNumber = inBookNumber ?? 1;
      
      BookCase.AddBookToShelf(new Book(inTitle, inAuthor, inSeries!, bookNumber, inHasRead));
    }
    
    public static void InsertManga(string inTitle, string inAuthor, string inSeries, int inVolume, bool inHasRead){
      BookCase.AddBookToShelf(new Book(inTitle, inAuthor, inSeries, inVolume, inHasRead));
    }
  }
}