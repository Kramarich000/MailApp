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
                Console.WriteLine("Введите 'register' для регистрации или 'exit' для выхода:");
                input = Console.ReadLine().ToLower();

                if (input == "exit") break;

                if (input == "register")
                {
                    mailService.RegisterUser();
                }
                else
                {
                    Console.WriteLine("Неизвестная команда.");
                }
            }
        }
    }
}
