namespace ModelsLibrary;

public class Writer
{
    public static async Task WriteToConsole(string message, int interval)
    {
        Console.WriteLine(message);

        await Task.Run(() => Thread.Sleep(interval));

        Console.Clear();
    }
}