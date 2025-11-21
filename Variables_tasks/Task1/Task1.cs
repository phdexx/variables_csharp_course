namespace Variables_tasks.Task1;

internal class BootstrapTask1
{
    const float PI = 3.14159f;
    public int Coins = 15;
    public double DamagePerSecond = 0;
    public string CharacterName = "Bob";
    public bool IsPlayerInMute = false;
    internal string _debugText = "Working!";
    protected int Mana = 10;
    private bool _isAttacked = false;
    private char _charToDelete = '1';
    private double _damage = 15;
    
    public static void Run()
    {
        Console.WriteLine("Hello, World!");
    }
}