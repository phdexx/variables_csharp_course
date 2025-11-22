namespace Variables_tasks.Task6;

public class BootstrapTask6
{
    public static void Run()
    {
        int playerGold;
        int playerCrystals;
        int crystalPrice = 5;
        
        Console.WriteLine("Введите колличество золота у игрока");
        playerGold = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Сколько кристалов вы хотите купить? Цена за 1 кристал: 5 золотых");
        playerCrystals = Convert.ToInt32(Console.ReadLine());
        playerGold -= crystalPrice * playerCrystals;
        Console.WriteLine($"Ваши кристалы : {playerCrystals}, остаток золота: {playerGold}");
        
    }
}