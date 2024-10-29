// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
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
    }
}
