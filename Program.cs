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
                Console.WriteLine("Введите 'register' для регистрации, 'login' для входа, 'send' для отправки сообщения, 'view' для просмотра сообщений или 'exit' для выхода:");
                input = Console.ReadLine().ToLower();

                if (input == "exit") break;

                switch (input)
                {
                    case "register":
                        mailService.RegisterUser();
                        break;
                    case "login":
                        if (mailService.Login())
                        {
                            // Здесь можно продолжать работу с пользователем
                            string action;
                            while (true)
                            {
                                Console.WriteLine("Введите 'send' для отправки сообщения, 'view' для просмотра сообщений или 'logout' для выхода:");
                                action = Console.ReadLine().ToLower();
                                if (action == "logout") break;

                                switch (action)
                                {
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
                        break;
                    default:
                        Console.WriteLine("Неизвестная команда.");
                        break;
                }
            }
        }
    }
}
