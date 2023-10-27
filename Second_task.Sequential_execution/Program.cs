using ModelsLibrary;

namespace Second_task.Sequential_execution;

public class Program
{
    static async Task Main(string[] args)
    {
        Random random = new Random();

        await Writer.WriteToConsole("If you want to exit please press Escape Key", 4000);

        while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape))
        {
            await Writer.WriteToConsole(ImageAsStringConstants.BearWithOpenedEyes, random.Next(3000, 4000));

            await Writer.WriteToConsole(ImageAsStringConstants.BearWithClosedEyes, 900);
        }
    }
}