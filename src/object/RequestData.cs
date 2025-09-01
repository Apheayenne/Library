using System;

namespace Library{
  public static class RequestData{

		public static void RequestGame(){
      string title = getUserInput("What is the Title: ");
      string developer = getUserInput("Who is the Developer: ");
      string publisher = getUserInput("Who is the Publisher: ");
      string system = getUserInput("Which System is it for: ");

      Insert.InsertGame(title, developer, publisher, system);
		}
    
    public static void RequestBook(){
      string title = getUserInput("What is the Title: ");
      string author = getUserInput("Who is the Author: ");

      Console.WriteLine("Is this book in a Series (yes/no): ");
      bool isSeries = Console.ReadLine()?.Trim().ToLower() == "yes";

      string? series = null;
      int? volume = null;

      if(isSeries){
        series = getUserInput("What is the Series Name: ");
        Console.Write("What book number is it: ");
        if (int.TryParse(Console.ReadLine(), out int number)){
          volume = number;
        }
      }
      Console.WriteLine("Have you read this book: ");
      bool bookRead = Console.ReadLine()?.Trim().ToLower() == "yes";

      Insert.InsertBook(title, author, series, volume, bookRead);
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