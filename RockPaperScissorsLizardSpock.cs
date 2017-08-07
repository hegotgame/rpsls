using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class RockPaperScissorsLizardSpock
    {
        public Player Player1;
        public Player Player2;

        public void GetNames()
        {
            Console.WriteLine("What is your gamer name, player 1?");
            Player1.name = Console.ReadLine();
            Console.WriteLine("Do you want to play against a (1) computer or (2) human?");
            string split = Console.ReadLine();
            switch (split)
            {
                case "1":
                    Console.WriteLine("Okay, Artie Intel (the computer) will face you.");
                    Player2.name = "Artie Intel";
                    break;
                case "2":
                    Console.WriteLine("What is your gamer name, player 2?");
                    Player2.name = Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Invalid response.");
                    GetNames();
                    break;
            }
            Console.WriteLine("What is your gamer name, player 2?");
            Player2.name = Console.ReadLine();
        }

        static public int DisplayMenu()
        {
            Console.WriteLine("Make your choice!");
            Console.WriteLine();
            Console.WriteLine("0. Rock");
            Console.WriteLine("1. Paper");
            Console.WriteLine("2. Scissors");
            Console.WriteLine("3. Lizard");
            Console.WriteLine("4. Spock");
            string result = Console.ReadLine();
            return Convert.ToInt32(result);
        }

        static public int Player2_Picks()
        {
            int player2 = DisplayMenu();
            return player2;
        }
        static public int Player1_Picks()
        {
            int player1 = DisplayMenu();
            return player1;
        }
        static public int PlayerPicks()
        {
            int pick = DisplayMenu();
            return pick;
        }


        private int PlayRound()
        {
            int[,] gameBoard = new int[5, 5]
            {
               { 0,1,2,2,1 },
               { 2,0,1,1,2 },
               { 1,2,0,2,1 },
               { 1,2,1,0,2 },
               { 2,1,2,1,0 }
            };

            int game = gameBoard[Player2_Picks(), Player1_Picks()];
            return game;
        }
        public int ScoreRound()
        {
            int score = PlayRound();
            if (score == 1)
            {
                Console.WriteLine("Player1 won this round.");
            }
            else if (score == 2)
            {
                Console.WriteLine("Player2 won this round.");
            }
            else if (score == 0)
            {
                Console.WriteLine("Players have tied this round.");
            }
            else
            {
                Console.WriteLine("An error occured in scoring this round.");
            }
            Console.ReadLine();
            return score;
        }
            /*
                        play1 =
                        play2 =
                        int game = gameBoard[play1, play2];

                        switch (game == 0)
                        {
                            Console.Write("Push. Play again.");
                        }
                        switch (game==1)
                        {
                            Console.Write("Player 1 wins.");
                        }
                        switch (game==2)
                        {
                            Console.Write("Player 2 wins.");
                        }


                        for (int i = 0; i < gameBoard.GetLength(0); i++)
                        {
                            for (int j = 0; j < gameBoard.GetLength(1); j++)
                            {
                                Console.Write(gameBoard[i, j]);
                            }
                            Console.Write(Environment.NewLine);
                        }
                        Console.ReadLine();
                */
        }
    }