using System;

namespace Hi_Lo_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hilo. ");
            Console.WriteLine($"Guess numbers between 1 and {HiloGame.Maximum}. ");
            HiloGame.Hint();
            while (HiloGame.GetPot() > 0)
            {
                Console.WriteLine("Press h for higher, l for lower or ? to buy a hint,");
                Console.WriteLine($"or any other key to quit with {HiloGame.GetPot()}. ");
                char key = Console.ReadKey(true).KeyChar;
                if (key == 'h')
                    HiloGame.Guess(true);
                else if (key == 'l')
                    HiloGame.Guess(false);
                else if (key == '?')
                    HiloGame.Hint();
                else
                    return;
            }
            Console.WriteLine("The pot is empty. Bye!");
        }

    }
}
