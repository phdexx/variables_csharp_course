namespace Variables_tasks.Task4;

public class BootstrapTask4
{
    public static void Run()
    {
        const int PICTURES_PER_ROW = 3;
        int totalPictures = 52;
        int filledRows = totalPictures / PICTURES_PER_ROW;
        int picturesOverflow = filledRows % PICTURES_PER_ROW;
        
        Console.WriteLine($"Всего заполненных рядов: {filledRows}, превышение картинок: {picturesOverflow}");
    }
}