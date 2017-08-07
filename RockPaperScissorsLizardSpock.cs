using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class RockPaperScissorsLizardSpock
    {
        static public int DisplayMenu()
        {
            Console.WriteLine("Make your choice!");
            Console.WriteLine();
            Console.WriteLine("1. Rock");
            Console.WriteLine("2. Paper");
            Console.WriteLine("3. Scissors");
            Console.WriteLine("4. Lizard");
            Console.WriteLine("5. Spock");
            Console.WriteLine("6. Quit");
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
        static public int AI_Picks()
        {
            int AI = DisplayMenu();
            return AI;
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

            int game = gameBoard[Player1_Picks(), Player2_Picks()];
            return game;
        }
        private int ScoreRound()
        {

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
}