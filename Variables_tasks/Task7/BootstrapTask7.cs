namespace Variables_tasks.Task7;

public class BootstrapTask7
{
    public static void Run()
    {
        const int MINUTES_IN_QUEUE_PER_PERSON = 10;
        const int MINUTES_IN_ONE_HOUR = 60;
        
        int peopleInQueue;
        int totalHoursInQueue;
        int totalMinutesInQueue;
        
        Console.WriteLine("Сколько людей в очереди?");
        peopleInQueue = Convert.ToInt32(Console.ReadLine());
        totalMinutesInQueue = peopleInQueue * MINUTES_IN_QUEUE_PER_PERSON;
        totalHoursInQueue = totalMinutesInQueue / MINUTES_IN_ONE_HOUR;
        totalMinutesInQueue = totalMinutesInQueue % MINUTES_IN_ONE_HOUR;

        Console.WriteLine($"Вы простоите в очереди {totalHoursInQueue} часа и {totalMinutesInQueue} минут");
    }
}