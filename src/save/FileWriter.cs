using System;
using System.IO;

namespace Library{

  // Used for Visual Studio
  //private readonly string _logPath = Directory.GetParent(System.IO.Directory.GetCurrentDirectory())
  //    .Parent.Parent.FullName;

  // Used for VSCode 
    
    
  public class FileWriter
  {
    private readonly bool isVSCode = true;
    private readonly string _logPath;
    private readonly object _lock = new object();
    public FileWriter(string logPath)
    {
      _logPath = logPath;

      string prjPath = GetProjectPath();
      if (Directory.Exists(prjPath)){
        Directory.CreateDirectory(prjPath);
      }
    }

    public void Write(string message)
    {
      var logEntry = $"{DateTime.Now:MM-dd-yyyy HH:mm:ss} {message}";
      lock (_lock)
      {
        File.AppendAllText(Path.Combine(GetProjectPath(), _logPath), logEntry + Environment.NewLine);
      }
    }
    private string GetProjectPath()
    {
      return isVSCode ? Path.Combine(
            Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).FullName, @"Library\src\save\data")
        : Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
    }
  }
}