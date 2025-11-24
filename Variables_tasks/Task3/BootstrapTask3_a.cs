//Второй вариант решения третьей задачи
namespace Variables_tasks.Task3;

public class BootstrapTask3_a
{
    public static void Run()
    { 
        string userName; 
        int userAge; 
        string userZodiacSign;
        
        Console.WriteLine("Как вас зовут?");
        userName = Console.ReadLine();
        
        Console.WriteLine("Сколько вам лет?");
        userAge = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Какой ваш знак зодиака?");
        userZodiacSign = Console.ReadLine();
        
        Console.WriteLine($"Вас зовут {userName}, вам {userAge} лет, вы {userZodiacSign}.");
    }
}
