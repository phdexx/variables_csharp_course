namespace Variables_tasks.Task4;

public class BootstrapTask4
{
    public static void Run()
    {
        const int PICTURES_PER_ROW = 3;
        int totalPictures = 52;
        int totalRows = totalPictures / PICTURES_PER_ROW;
        int rowsOverflow = totalRows % PICTURES_PER_ROW;
        Console.WriteLine($"Всего заполненных рядов: {totalRows}, превышение картинок: {rowsOverflow}");
        
    }
}