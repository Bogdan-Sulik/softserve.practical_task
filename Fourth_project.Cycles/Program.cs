﻿using ModelsLibrary;

namespace Fourth_project.Cycles;

public class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("How many cycles do you want to watch? Please write a number:");
        int userNumber = 0;

        do
        {
            userNumber = int.TryParse(Console.ReadLine(), out int value) ? value : 0;

            if (userNumber != default)
            {
                Console.Clear();

                Random random = new Random();

                for (int i = 0; i < userNumber; i++)
                {
                    await Writer.WriteToConsole(
                        ImageAsStringConstants.BearWithOpenedEyes, random.Next(3000, 4000));

                    await Writer.WriteToConsole(ImageAsStringConstants.BearWithClosedEyes, 900);
                }
            }
            else
            {
                Console.WriteLine("Please specify a positive number that is greater than zero");
            }
        }
        while (userNumber <= 0);
    }
}