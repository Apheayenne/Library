using System;
using System.IO;

//TODO: Consoles are not writing all entries
namespace Library{
  public class FileWriter{
      
    public static void Writer(string filePath){
      string path = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
			using (StreamWriter writer = new StreamWriter(Path.Combine(path, filePath))){
        if (filePath == "gameshelf.txt") {
          foreach (Game game in BookCase.GameShelf){
						Console.WriteLine(game.Save());
            writer.WriteLine(game.Save());
					}
				} else if (filePath == "bookshelf.txt") {
					foreach (Book book in BookCase.BookShelf) {
						Console.WriteLine(book.Save());
						//writer.WriteLine(book.Save());
					}
				} else if (filePath == "mangashelf.txt") {
					foreach (Manga manga in BookCase.MangaShelf) {
						Console.WriteLine(manga.Save());
						//writer.WriteLine(manga.Save());
					}
				}
      }
    }
  }
}