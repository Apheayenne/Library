using System;

namespace Library {
  public class MainLoop{

    public void Loop(){
      bool continueLoop = true;

      do {
        Console.WriteLine("\nWhat do you want to insert:\n1) Game\n2) Book\n3) Manga\n4) Quit");
        string insert = Console.ReadLine().ToString();
        continueLoop = WhichInsert(insert);
      } while (continueLoop);
    }

    /*
    private bool WhichView(string insert){
      bool continueLoop = true;

      switch (insert) {
        case "Game":
        case "1":
          Insert.InsertGame();
          break;
        case "Book":
        case "2":
          Insert.InsertBook();
          break;
        case "Manga":
        case "3":
          Insert.InsertManga();
          break;
        case "Quit":
        case "4":
          continueLoop = false;
          break;
        default:
          break;
      }
      return continueLoop;
    }
    */

    private bool WhichInsert(string insert) {
      bool continueLoop = true;

      switch (insert) {
        case "Game":
        case "1":
          Insert.InsertGame();
          break;
        case "Book":
        case "2":
          Insert.InsertBook();
          break;
        case "Manga":
        case "3":
          Insert.InsertManga();
          break;
        case "Quit":
        case "4":
          continueLoop = false;
          break;
        default:
          break;
      }
      return continueLoop;
    }
  }
}