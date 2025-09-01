using System;
using Library;

namespace Testing
{
  // passes the 
  public class Tests()
  {
    
    public static void CreateTests()
    {
      // 
    }
    public static void AddEntryToBookCase()
    {
      //Tests for verifying that all entries are added to the BookCase.
      BookCase.AddGameToShelf(new Game("game1", "dev1", "pub1", "1"));
      BookCase.AddGameToShelf(new Game("game2", "dev2", "pub2", "2"));
      BookCase.AddGameToShelf(new Game("game3", "dev3", "pub3", "3"));
    }

    public static void SameTitleDiffSystem()
    {
      //Tests for checking that same title with different systems works
      BookCase.AddGameToShelf(new Game("game1", "dev1", "pub1", "1"));
      BookCase.AddGameToShelf(new Game("game1", "dev1", "pub1", "2"));
    }

    public static void DontAddDups()
    {
      //Tests for checking that duplicates are not added to the the BookCase
      BookCase.AddGameToShelf(new Game("game1", "dev1", "pub1", "1"));
      BookCase.AddGameToShelf(new Game("game1", "dev1", "pub1", "1")); //Should not be added
    }

    public static void SeriesNoSeries()
    {
      Insert.InsertBook("book1", "author1", "series1", 2, true);
      Insert.InsertBook("book2", "author1", null, null, false);
    }
  }
}