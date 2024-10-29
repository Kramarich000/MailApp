using System.Collections.Generic;
using System.IO;

namespace MailApp
{
    public class User
    {
        public string Username { get; set; }
        public List<string> Messages { get; set; } = new List<string>();

        public User(string username)
        {
            Username = username;
        }

        public void SaveMessage(string message)
        {
            Messages.Add(message);
            File.AppendAllText("messages.txt", $"{Username}: {message}\n");
        }

        public List<string> LoadMessages()
        {
            if (File.Exists("messages.txt"))
            {
                return new List<string>(File.ReadAllLines("messages.txt"));
            }
            return new List<string>();
        }
    }
}
