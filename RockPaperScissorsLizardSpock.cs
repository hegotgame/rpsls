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
        public bool game = false;

        private void GetNames()
        {
            Player1 = new Player();
            Player2 = new Player();
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
            game = true;
        }
        private void GetPicks()
        {
            if (game == false)
            {
                GetNames();
            }

            Console.WriteLine(Player1.name + ",");
            int p1p = DisplayMenu();
            Player1.pick = p1p;


            if (Player2.name == "Artie Intel")
            {
                Random random = new Random();
                int ai_pick = random.Next(0, 5);
                Player2.pick = ai_pick;
            }
            else
            {
                Console.WriteLine(Player2.name + ",");
                int p2p = DisplayMenu();
                Player2.pick = p2p;
            }
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

        private int PlayRound()
        {
            GetPicks();
            int[,] solutionSpace = new int[5, 5]
            {
               { 0,1,2,2,1 },
               { 2,0,1,1,2 },
               { 1,2,0,2,1 },
               { 1,2,1,0,2 },
               { 2,1,2,1,0 }
            };

            int game = solutionSpace[Player2.pick, Player1.pick];
            return game;
        }
        public int ScoreRound()
        {
            int score = PlayRound();
            if (score == 1)
            {
                Player1.wins++;
                Console.WriteLine(Player1.name + " won this round, and their score is: " + Player1.wins);
            }
            else if (score == 2)
            {
                Player2.wins++;
                Console.WriteLine(Player2.name + " won this round, and their score is: " + Player2.wins);
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
            Scoreboard();
            return score;
        }
        private void Scoreboard()
        {
            Console.WriteLine(Player1.name + ": won " + Player1.wins);
            Console.WriteLine(Player2.name + ": won " + Player2.wins);
            if (Player1.wins == 2 || Player2.wins == 2)
            {
                Console.WriteLine("***Congrats!!!!!***");
                Console.WriteLine("End of Game");
                Console.ReadLine();
            }
            else
            {
                ScoreRound();
            }
        }
        }
    }