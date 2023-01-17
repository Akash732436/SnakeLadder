using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProblem
{
    
    public class Program
    {
        const int NoPlay = 1;
        const int Ladder = 2;
        const int Snake= 3;
        const int StartPosition = 0;
        const int EndPosition = 100;


        public static void SinglePlayer()
        {
            Console.WriteLine("Welocome to snake ladder game. (SIngle Player)");
            int DieRoleCount = 0;
            int CurrPosition = StartPosition;

            while (CurrPosition != EndPosition)
            {
                Console.WriteLine("THE PLAYER IS AT POSITION: " + CurrPosition);
                Console.WriteLine("Number Of Time Die Rolled is: " + DieRoleCount);

                Random random = new Random();
                int DieRole = random.Next(1, 7);
                DieRoleCount += 1;
                Console.WriteLine("The Die Role for next position is: " + DieRole);

                int Options = random.Next(1, 4);

                switch (Options)
                {
                    case NoPlay:
                        Console.WriteLine("Option got: No Play");
                        break;
                    case Ladder:
                        Console.WriteLine("Option got: Ladder");
                        if (CurrPosition + DieRole <= 100)
                        {
                            CurrPosition = CurrPosition + DieRole;
                        }
                        break;
                    case Snake:
                        Console.WriteLine("Option got: Snake");
                        if (CurrPosition - DieRole < 0)
                        {
                            CurrPosition = 0;
                        }
                        else CurrPosition = CurrPosition - DieRole;
                        break;
                }
                Console.WriteLine("\n\n");
            }
            Console.WriteLine("THE PLAYER IS AT POSITION: " + CurrPosition);
            Console.WriteLine("Number Of Time Die Rolled is: " + DieRoleCount);
        }

        public static void TwoPlayers()
        {
            Console.WriteLine("Welocome to snake ladder game. (Multiple Player)");
            int FirstPosition = StartPosition,SecondPosition=StartPosition;
            bool Chance = true;

            while(FirstPosition!=EndPosition || SecondPosition!=EndPosition)
            {
                if (Chance)
                {
                    Console.WriteLine("Player1 Chance");
                    Chance= false;
                    Console.WriteLine("THE PLAYER1 IS AT POSITION: " + FirstPosition);
                    
                    Random random = new Random();
                    int DieRole = random.Next(1, 7);
                    int Options = random.Next(1, 4);
                    switch (Options)
                    {
                        case NoPlay:
                            Console.WriteLine("Option got: No Play");
                            break;
                        case Ladder:
                            Console.WriteLine("Option got: Ladder");
                            if (FirstPosition + DieRole <= 100)
                            {
                                FirstPosition = FirstPosition + DieRole;
                            }
                            break;
                        case Snake:
                            Console.WriteLine("Option got: Snake");
                            if (FirstPosition - DieRole < 0)
                            {
                                FirstPosition = 0;
                            }
                            else FirstPosition = FirstPosition - DieRole;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Player2 Chance");
                    Console.WriteLine("THE PLAYER IS AT POSITION: " + SecondPosition);
                    Chance = true;
                    Random random = new Random();
                    int DieRole = random.Next(1, 7);
                    int Options = random.Next(1, 4);
                    switch (Options)
                    {
                        case NoPlay:
                            Console.WriteLine("Option got: No Play");
                            break;
                        case Ladder:
                            Console.WriteLine("Option got: Ladder");
                            if (SecondPosition + DieRole <= 100)
                            {
                                SecondPosition = SecondPosition + DieRole;
                            }
                            break;
                        case Snake:
                            Console.WriteLine("Option got: Snake");
                            if (SecondPosition - DieRole < 0)
                            {
                                SecondPosition = 0;
                            }
                            else SecondPosition = SecondPosition - DieRole;
                            break;
                    }
                }
                Console.WriteLine("\n\n");
            }

            if (FirstPosition == 100)
            {
                Console.WriteLine("Player 1 Won.");
            }
            else
            {
                Console.WriteLine("Player2 Won");
            }
             

        }

        static void Main(string[] args)
        {

            //SinglePlayer();
            TwoPlayers();
            Console.ReadLine();
        }
    }
}
