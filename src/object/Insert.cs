using System;

namespace Library{
  public static class Insert{
    public static void InsertGame() {
      Console.Write("What is Title: ");
      string title = Console.ReadLine();
      Console.Write("Who is the Developer: ");
      string author = Console.ReadLine();
      Console.Write("Who is the Publisher: ");
      string publisher = Console.ReadLine();
      Console.Write("Which system is it for: ");
      string system = Console.ReadLine();
      
      Game game = new Game(title, author, publisher, system);
      Console.WriteLine(game.ToString());
    }
    
    public static void InsertBook() {
      Console.WriteLine("Inserting Book");
    }
    
    public static void InsertManga(){
      Console.WriteLine("Inserting Manga");
    }
  }
}