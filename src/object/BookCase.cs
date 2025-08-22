using System;

namespace Library{
  public sealed class BookCase{

    private static List<Game>? _gameShelf;
    public static List<Game> GameShelf {
      get{
        return _gameShelf ??= new List<Game>();
      }
      set{ 
        _gameShelf = value;
      }
		}

    public static void AddGameToShelf(Game newGame){
      bool foundSame = false;
      foreach(Game game in GameShelf){
        if ((game.Title == newGame.Title) && (game.System == newGame.System)){
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
    
    private static List<Book>? _bookShelf;
    public static List<Book> BookShelf {
      get {
        return _bookShelf ??= new List<Book>();
      }
      set {
        BookShelf = value;
      }
		}
    
    public static void AddBookToShelf(Book newBook){
      foreach(Book book in BookShelf){
        if (!(book.Title == newBook.Title)){
          BookShelf.Add(newBook);
        }
      }
    }
   
    private static List<Manga>? _mangaShelf;
    public static List<Manga> MangaShelf {
      get{
        return _mangaShelf ??= new List<Manga>();
      }
      set{
        MangaShelf = value;
      }
		}
    
    public static void AddMangaToShelf(Manga newManga){
      foreach(Manga Manga in MangaShelf){
        
      }
    }
  }
}