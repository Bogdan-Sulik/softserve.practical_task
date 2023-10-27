namespace Second_task.Sequential_execution;

public class Program
{
    static async Task Main(string[] args)
    {
        Random random = new Random();

        await WriteToConsole("If you want to exit please press Escape Key", 4000);

        while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape))
        {
            await WriteToConsole(ImageAsStringConstants.BearWithOpenedEyes, random.Next(3000, 4000));

            await WriteToConsole(ImageAsStringConstants.BearWithClosedEyes, 900);
        }
    }

    public static async Task WriteToConsole(string message, int interval)
    {
        Console.WriteLine(message);

        await Task.Run(() => Thread.Sleep(interval));

        Console.Clear();
    }
}