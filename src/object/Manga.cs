using System;

namespace Library {
  public class Manga(string title, string author, int volume, bool isRead = false) : Item(title, author) {
    public int VolumeNumber { get; private set; } = volume;
    public bool IsRead { get; private set; } = isRead;

    public void UpdateIsRead(bool isRead) {
      IsRead = isRead;
    }

    public override string ToString() {
      return $"{Title}, by {Author}, volume {VolumeNumber}";
    }

		public string Save() {
			return $"{Title}|{Author}|{VolumeNumber}|{IsRead}";
		}
	}
}