using System;
using System.Collections.Generic;

namespace Library {
  public class Game : Item {
    public Game(string title, string author, string publisher, string system) : base(title, author)
    {
      Publisher = publisher;
      System = system;      
    }
    
    public string Publisher { get; private set; }
    public string System { get; private set; }

    public override string ToString() {
      return $"{Title}, by {Author} for {System}";
    }
  }
}