using System;

namespace DiceGame
{
    class Program
    {
        private static void Main(string[] args)
        {
            var playerPoints = 0;
            var enemyPoints = 0;

            var random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice.");

                Console.ReadKey();

                var playerRandomNum = random.Next(1, 7);
                Console.WriteLine("You rolled: " + playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                var enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("Enemy rolled:" + enemyRandomNum);

                Console.WriteLine();

                if (playerRandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("Player wins this round!");
                }
                else if (playerRandomNum < enemyRandomNum)
                {
                    enemyPoints++;
                    Console.WriteLine("Enemy wins this round!");
                }
                else
                {
                    Console.WriteLine("Draw!");
                }

                Console.WriteLine();

                Console.WriteLine("The score is now:");
                Console.WriteLine("Player:" + playerPoints);
                Console.WriteLine("Enemy: " + enemyPoints);
            }

            if (playerPoints > enemyPoints)
            {
                Console.WriteLine("You win!!!");
            }
            else if (playerPoints < enemyPoints)
            {
                Console.WriteLine("You loose!!!");
            }
            else
            {
                Console.WriteLine("Draw!!!");
            }

            Console.ReadKey();
        }
    }
}