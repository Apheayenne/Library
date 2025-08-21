using System;
using System.IO;


namespace Library{
  namespace Save{
    public class FileWriter{
      
      
      
      public void Writer(string filePath){
        List<T> shelf;
        switch(filePath){
          case "gameshelf.txt":
            shelf = BookCase.GameShelf;
          case "bookshelf.txt":
            shelf = BookCase.BookShelf;
          case "mangashelf.txt":
            shelf = BookCase.MangaShelf;
          default:
            shelf = null;
        }
        
        // TODO: if Shelf == null, throw Exception.
        
        using (StreamWriter writer = new StreamWriter(filePath)){
          foreach(List<T> obj in shelf){
            obj.
          }
        }
      }
    }
  }
}