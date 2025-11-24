using System;

namespace Variables_tasks.Task3;

public class BootstrapTask3
{
    public string UserName;
    public int UserAge;
    public string UserZodiacSign;
    
    public void Run()
    {
        Console.WriteLine("Как вас зовут?");
        UserName = Console.ReadLine();
        
        Console.WriteLine("Сколько вам лет?");
        UserAge = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Какой ваш знак зодиака?");
        UserZodiacSign = Console.ReadLine();
        
        Console.WriteLine($"Вас зовут {UserName}, вам {UserAge} лет, вы {UserZodiacSign}.");
    }
}
