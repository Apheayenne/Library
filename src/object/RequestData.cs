using System;
using System.Diagnostics.SymbolStore;
using System.Security;
using System.Transactions;

namespace Library{
  public static class RequestData{

		public static void RequestGame(){
      string gameTitle = getUserInput("What is the Title: ");
      string gameAuthor = getUserInput("Who is the Developer: ");
      string gamePublisher = getUserInput("Who is the Publisher: ");
      string gameSystem = getUserInput("Which System is it for: ");

      Game game = new Game(gameTitle, gameAuthor, gamePublisher, gameSystem);
      BookCase.AddGameToShelf(game);
		}
    
    public static void RequestBook(){
      string bookTitle = getUserInput("What is the Title: ");
      string bookAuthor = getUserInput("Who is the Author: ");
      Console.WriteLine("Is this book in a Series (yes/no): ");
      bool isSeries = Console.ReadLine()?.Trim().ToLower() == "yes";

      string? bookSeries = null;
      int? bookNumber = null;

      if(isSeries){
        bookSeries = getUserInput("What is the Series Name: ");
        Console.Write("What book number is it: ");
        int.TryParse(Console.ReadLine(), out int number);
        bookNumber = number;
      }
      Console.WriteLine("Have you read this book: ");
      bool bookRead = Console.ReadLine()?.Trim().ToLower() == "yes";

      Book book = new Book(bookTitle, bookAuthor, bookSeries, bookNumber, bookRead);
      BookCase.AddBookToShelf(book);
    }
    
    public static void RequestManga(){
      string mangaTitle = getUserInput("What is the Title: ");
					string mangaAuthor = getUserInput("Who is the Author: ");
					
					Console.Write("What book number is it: ");
					int.TryParse(Console.ReadLine(), out int mangaVolume);
					
					Console.WriteLine("Have you read this book: ");
					bool mangaRead = Console.ReadLine()?.Trim().ToLower() == "yes";

					Manga manga = new Manga(mangaTitle, mangaAuthor, mangaVolume, mangaRead);
					BookCase.AddMangaToShelf(manga);
    }

    private static string getUserInput(string prompt) {
			string input;
			do {
				Console.Write(prompt);
				input = Console.ReadLine().ToString();
			} while (string.IsNullOrWhiteSpace(input));

      return input;
		}
	}
}