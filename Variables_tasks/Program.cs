using System.Runtime.InteropServices;
using Variables_tasks.Task1;
using Variables_tasks.Task3;


namespace Variables_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BootstrapTask3 task3 = new BootstrapTask3();
            task3.Run();

            BootstrapTask3_a.Run(); //Второй вариант решение третьей задачи
        }
    }
}
