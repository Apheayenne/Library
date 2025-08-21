using System;

namespace Library{
  public sealed class BookCase{

    public static List<Game> GameShelf {
      get{
        if(GameShelf ??= new List<Game>());
        return GameShelf;
      }
    }

    public void AddGameToShelf(Game newGame){
      bool foundSame = false;
      foreach(Game game in GameShelf){
        if ((game.Name != newGame.Name) && (game.System != newGame.System)){
          continue;
        } else { 
          foundSame = true;
          return;
        }  
      }

      if (!foundSame) {
        GameShelf.Add(newGame);
      }
    }

    public static List<Book> BookShelf {
      get {
        if (BookShelf ??= new List<Book>());
        return BookShelf;
        }
    }
    
    public void AddBookToShelf(Book newBook){
      foreach(Book book in BookShelf){
        if (!(book.Name == newBook.Name)){
          BookShelf.Add(newBook);
        }
      }
    }
   
    public static List<Manga> MangaShelf {
      get{
        MangaShelf ??= new List<Manga>();
        return MangaShelf;
      }
    }
    
    public void AddMangaToShelf(){
      foreach(Manga Manga in MangaShelf){
        of()
      }
    }
  }
}