using System;

namespace Testing
{
  public static class Tests
  {
    public static void AddEntryToBookCase(){
      //Tests for verifying that all entries are added to the BookCase.
      Library.BookCase.AddGameToShelf(new Library.Game("game1", "dev1", "pub1", "1"));
      Library.BookCase.AddGameToShelf(new Library.Game("game2", "dev2", "pub2", "2"));
      Library.BookCase.AddGameToShelf(new Library.Game("game3", "dev3", "pub3", "3"));
    }
    
    public static void SameTitleDiffSystem(){
      //Tests for checking that same title with different systems works
      Library.BookCase.AddGameToShelf(new Library.Game("game1", "dev1", "pub1", "1"));
      Library.BookCase.AddGameToShelf(new Library.Game("game1", "dev1", "pub1", "2"));
    }
    
    public static void DontAddDups(){
      //Tests for checking that duplicates are not added to the the BookCase
      Library.BookCase.AddGameToShelf(new Library.Game("game1", "dev1", "pub1", "1"));
      Library.BookCase.AddGameToShelf(new Library.Game("game1", "dev1", "pub1", "1")); //Should not be added
    } 
  }
}