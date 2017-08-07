using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassAlong
{
    class PaperScissorsRockLizardSpock
    {
        private void GenerateMatrix()
        {
            List<string> instructors = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };

            List<List<string>> collectionInstructors = new List<List<string>>();
            collectionInstructors.Add(instructors);
            Console.WriteLine(collectionInstructors[0][0]);
            Console.WriteLine(collectionInstructors[0][5]);


            int[,] gameBoard = new int[5, 5]
            {
               { 0,1,2,2,1 },
               { 2,0,1,1,2 },
               { 1,2,0,2,1 },
               { 1,2,1,0,2 },
               { 2,1,2,1,0 }
            };
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