namespace Third_project.User_input;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Is bear sleeping? Press ‘{UserInputConstants.PositiveResponse}’ if he is:");

        bool isPositiveResponse = string.Equals(Console.ReadLine(),
            UserInputConstants.PositiveResponse, StringComparison.OrdinalIgnoreCase);

        string bearImage = isPositiveResponse
            ? ImageAsStringConstants.BearWithOpenedEyes 
            : ImageAsStringConstants.BearWithClosedEyes;

        Console.WriteLine(bearImage);
    }
}
