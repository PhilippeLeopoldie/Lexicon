using System;

namespace ConsoleApp;

public static class Utilities
{
    public static async Task ShowConsoleAnimation()
    {
        /*for (int i = 0; i < 10; i++)
        {
            Console.Write("| -");
            await Task.Delay(50);
            Console.Write("\b\b\b");
            Console.Write("/ \\");
            await Task.Delay(50);
            Console.Write("\b\b\b");
            Console.Write("- |");
            await Task.Delay(50);
            Console.Write("\b\b\b");
            Console.Write("\\ /");
            await Task.Delay(50);
            Console.Write("\b\b\b");
        }*/

        string[] animations = ["| -", "/ \\", "- |", "\\ /"];
        for (int i = 0; i < 10; i++) 
        {
            foreach (string s in animations)
            {
                Console.Write(s);
                await Task.Delay(50);
                Console.Write("\b\b\b");
            }
        }
        Console.WriteLine();
    }
}

