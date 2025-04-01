using System;
using System.Threading;

class WinHerBack
{
    static void Main()
    {
        Console.Title = "For My Love";

        // Romantic Introduction
        ShowRomanticIntro();

        Console.WriteLine("\nHey, I have something important to ask you...\n");

        Thread.Sleep(5000);

        while (true)
        {
            Console.Write("Will you be my girlfriend again? (Yes/No): ");
            string answer = Console.ReadLine()?.Trim().ToLower();

            if (answer == "yes")
            {
                Console.WriteLine("\nYou just made me the happiest person alive!");
                LoadingEffect("Processing happiness");
                Console.WriteLine("\nI promise to cherish and love you even more.");
                break;
            }
            else if (answer == "no")
            {
                Console.WriteLine("\nOh no... But I won't give up easily! Let me ask again...");
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("\nHmm... I'll take that as a 'Maybe'. Let's try again...");
                Thread.Sleep(2000);
            }
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    static void ShowRomanticIntro()
    {
        string[] introLines = {
            "Once upon a time, there was a guy who fell deeply in love with a beautiful soul...",
            "Through ups and downs, through laughter and tears, his heart always belonged to her...",
            "Even now, after everything, his heart beats only for her...",
            "And today, he must ask the most important question of all..."
        };

        foreach (string line in introLines)
        {
            Console.WriteLine(line);
            Thread.Sleep(3000); // Pause for dramatic effect
        }
    }

    static void LoadingEffect(string message)
    {
        Console.Write("\n" + message);
        for (int i = 5; i > 0; i--)
        {
            Thread.Sleep(500);
            Console.Write(".");
        }
        Console.WriteLine("\n");
    }
}
