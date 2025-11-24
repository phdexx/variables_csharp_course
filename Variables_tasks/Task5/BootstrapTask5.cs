namespace Variables_tasks.Task5;

public class BootstrapTask5
{
    public static void Run()
    {
        string name = "Боббович";
        string surname = "Боб";
        
        (name, surname) = (surname, name);
        
        Console.WriteLine($"{name}, {surname}");
    }
} 