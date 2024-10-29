
using System;

namespace MailApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var mailService = new MailService();
            string input;

            Console.WriteLine("Добро пожаловать в почтовое приложение!");

            while (true)
            {
                Console.WriteLine("Введите 'register' для регистрации, 'send' для отправки сообщения, 'view' для просмотра сообщений или 'exit' для выхода:");
                input = Console.ReadLine().ToLower();

                if (input == "exit") break;

                switch (input)
                {
                    case "register":
                        mailService.RegisterUser();
                        break;
                    case "send":
                        mailService.SendMessage();
                        break;
                    case "view":
                        mailService.ViewMessages();
                        break;
                    default:
                        Console.WriteLine("Неизвестная команда.");
                        break;
                }
            }
        }
    }
}

