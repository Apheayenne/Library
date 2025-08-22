using System;

namespace Library
{
  public class Library
  {
    public static void Main()
    {
      MainLoop loop = new MainLoop();
      loop.Loop();
      
      FileWriter.Writer("gameshelf.txt");
			//FileWriter.Writer("..\\..\\..\\bookshelf.txt");
			//FileWriter.Writer("..\\..\\..\\mangashelf.txt");
		}
  }
}