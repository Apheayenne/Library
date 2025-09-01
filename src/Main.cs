using System;

namespace Library
{
  public class Library
  {
    public static void Main()
    {
      MainLoop loop = new MainLoop();

      // Passes a file name to constructor.
      Testing.Tests tests = new Testing.Tests();

      // true:  using VSCode
      // false: using Visual Studio
      Save(true);
      
    }

    public static void TestCases(int[] tests)
    {
      foreach (int testCase in tests){
        switch (testCase){
          case 1:
            Testing.Tests.AddEntryToBookCase();
            break;
          case 2:
            Testing.Tests.SameTitleDiffSystem();
            break;
          case 3:
            Testing.Tests.DontAddDups();
            break;
          case 4:
            Testing.Tests.SeriesNoSeries();
            break;
        }
      }
      Testing.Tests.AddEntryToBookCase();
      Testing.Tests.SameTitleDiffSystem();
      Testing.Tests.DontAddDups();
      Testing.Tests.SeriesNoSeries();
    }

    public static void Save(bool isVSCode)
    {
      //FileWriter.Writer("gameshelf.txt");
      //FileWriter.Writer("bookshelf.txt");
      //FileWriter.Writer("mangashelf.txt");
    }
  }
}