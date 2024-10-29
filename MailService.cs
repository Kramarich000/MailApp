using System;
using System.Collections.Generic;

namespace MailApp
{
    public class MailService
    {
        private List<User> users = new List<User>();
        private User currentUser;

        public void RegisterUser()
        {
            Console.Write("Введите имя пользователя: ");
            string username = Console.ReadLine();

            if (users.Exists(u => u.Username == username))
            {
                Console.WriteLine("Пользователь с таким именем уже существует.");
                return;
            }

            Console.Write("Введите пароль: ");
            string password = Console.ReadLine();
            currentUser = new User(username, password);
            users.Add(currentUser);
            Console.WriteLine($"Пользователь {username} зарегистрирован.");
        }

        public bool Login()
        {
            Console.Write("Введите имя пользователя: ");
            string username = Console.ReadLine();
            Console.Write("Введите пароль: ");
            string password = Console.ReadLine();

            currentUser = users.Find(u => u.Username == username && u.VerifyPassword(password));
            if (currentUser != null)
            {
                Console.WriteLine($"Добро пожаловать, {currentUser.Username}!");
                return true;
            }
            else
            {
                Console.WriteLine("Неверное имя пользователя или пароль.");
                return false;
            }
        }

        public void SendMessage()
        {
            if (currentUser == null)
            {
                Console.WriteLine("Сначала выполните вход.");
                return;
            }

            Console.Write("Введите сообщение: ");
            string message = Console.ReadLine();
            currentUser.SaveMessage(message);
            Console.WriteLine("Сообщение отправлено.");
        }

        public void ViewMessages()
        {
            if (currentUser == null)
            {
                Console.WriteLine("Сначала выполните вход.");
                return;
            }

            Console.WriteLine("Ваши сообщения:");
            var messages = currentUser.LoadMessages();

            foreach (var msg in messages)
            {
                Console.WriteLine(msg);
            }
        }
    }
}
