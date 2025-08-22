using System;
using System.Collections.Generic;

namespace Library {
  public class Game(string title, string author, string publisher, string system) : Item(title, author){
	  	public string Publisher { get; private set; } = publisher;
  		public string System { get; private set; } = system;

    public override string ToString() {
      return $"{Title}, by {Author} for {System}";
    }

		public string Save() {
			return $"{Title}|{Author}|{Publisher}|{System}";
		}
	}
}