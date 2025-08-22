using System;

namespace Library
{
  public class Library
  {
    public static void Main()
    {
      MainLoop loop = new MainLoop();
      loop.Loop();
      //Testing.Tests.Test3();

      //Use in Visual Studio
      //string path = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;

      //Use in VSCode
      string projectPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).FullName, @"Library\src\save\data");

      FileWriter.Writer(projectPath, "gameshelf.txt");
			//FileWriter.Writer("..\\..\\..\\bookshelf.txt");
			//FileWriter.Writer("..\\..\\..\\mangashelf.txt");
		}
  }
}