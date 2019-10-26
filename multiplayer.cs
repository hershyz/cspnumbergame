using System;

namespace multiplayer
{
    class Program
    {
        static int number;
        static int player1Tries = 7;
        static int player2Tries = 7;
        static int player1Points = 0;
        static int player2Points = 0;

        static Random rnd = new Random();

        static void Main(string[] args)
        {
            start();
        }

        public static void start()
        {
            player1Tries = 7;
            player2Tries = 7;
            number = rnd.Next(0, 100);

            Console.WriteLine("");
            Console.WriteLine("Player1: " + player1Points);
            Console.WriteLine("Player2: " + player2Points);
            Console.WriteLine("");

            player1();
        }

        public static void player1Win()
        {
            Console.WriteLine("Player 1 Wins!");
            player1Points++;
            Console.ReadKey();
            start();
        }

        public static void player2Win()
        {
            Console.WriteLine("Player 2 Wins!");
            player2Points++;
            Console.ReadKey();
            start();
        }

        public static void player1()
        {
            if (player1Tries == 0)
            {
                player2Win();
            }

            Console.WriteLine("Player 1:");
            Console.Write(player1Tries.ToString() + " tries remaining: ");
            int guess = Convert.ToInt32(Console.ReadLine());

            if (guess < number)
            {
                Console.WriteLine("Too low! Guess higher!");
                player1Tries--;
                player2();
            }

            if (guess > number)
            {
                Console.WriteLine("Too high! Guess lower!");
                player1Tries--;
                player2();
            }

            if (guess == number)
            {
                player1Win();
            }
        }

        public static void player2()
        {
            if (player2Tries == 0)
            {
                player1Win();
            }

            Console.WriteLine("Player 2:");
            Console.Write(player2Tries.ToString() + " tries remaining: ");
            int guess = Convert.ToInt32(Console.ReadLine());

            if (guess < number)
            {
                Console.WriteLine("Too low! Guess higher!");
                player2Tries--;
                player1();
            }

            if (guess > number)
            {
                Console.WriteLine("Too high! Guess lower!");
                player2Tries--;
                player1();
            }

            if (guess == number)
            {
                player2Win();
            }
        }
    }
}
