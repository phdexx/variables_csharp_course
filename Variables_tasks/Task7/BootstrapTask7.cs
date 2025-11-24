namespace Variables_tasks.Task7;

public class BootstrapTask7
{
    public static void Run()
    {
        const int MINUTES_IN_QUEUE_PER_PERSON = 10;
        const int MINUTES_IN_ONE_HOUR = 60;
        
        Console.WriteLine("Сколько людей в очереди?");
        int peopleInQueue = Convert.ToInt32(Console.ReadLine());
        
        int totalMinutesWaiting = peopleInQueue * MINUTES_IN_QUEUE_PER_PERSON;
        int hoursWaiting = totalMinutesWaiting / MINUTES_IN_ONE_HOUR;
        int minutesWaiting = totalMinutesWaiting % MINUTES_IN_ONE_HOUR;

        Console.WriteLine($"Вы простоите в очереди {hoursWaiting} часа и {minutesWaiting} минут");
    }
}
