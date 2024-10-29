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

            currentUser = new User(username);
            users.Add(currentUser);
            Console.WriteLine($"Пользователь {username} зарегистрирован.");
        }
    }
}
