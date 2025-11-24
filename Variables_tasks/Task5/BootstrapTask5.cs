namespace Variables_tasks.Task5;

public class BootstrapTask5
{
    public static void Run()
    {
        string name = "Боббович";
        string surname = "Боб";
        string buffer = "";

        buffer = name;
        name = surname;
        surname = buffer;
        
        Console.WriteLine($"Имя: {name}, Фамилия: {surname}");
    }
}