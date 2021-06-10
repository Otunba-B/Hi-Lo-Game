using System;

namespace Hi_Lo_Game
{
    static class HiloGame
    {
        public const int Maximum = 10;
        private  static Random random = new Random();
        private static int currentNumber = random.Next(1, 11);
        private static int pot = 10;

        public static int GetPot() { return pot; }
        public static void Guess(bool higher)
        {
            var nextNumber = random.Next(1, Maximum + 1);

            if (higher && nextNumber >= currentNumber || higher && nextNumber <= currentNumber)
            {
                Console.WriteLine(" You guessed right! ");
                pot++;
            }

            else
            {
                Console.WriteLine(" Bad Luck, you guessed wrong. ");
                pot--;
            }
            currentNumber = nextNumber;
            Console.WriteLine($"The current number is {currentNumber}");
        }

        public static void Hint()
        {
            var half = Maximum / 2;
            if (currentNumber > half)
                Console.WriteLine($" The number is at least {half}");
            else
                Console.WriteLine($"The number is at most {half}");
            pot--;
        }
    }
}