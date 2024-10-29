public void SendMessage()
{
    if (currentUser == null)
    {
        Console.WriteLine("Сначала зарегистрируйтесь.");
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
        Console.WriteLine("Сначала зарегистрируйтесь.");
        return;
    }

    Console.WriteLine("Ваши сообщения:");
    var messages = currentUser.LoadMessages();

    foreach (var msg in messages)
    {
        Console.WriteLine(msg);

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
