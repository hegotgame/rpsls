using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            RockPaperScissorsLizardSpock run = new RockPaperScissorsLizardSpock();
            int userInput = 0;
            do
            {
                userInput = RockPaperScissorsLizardSpock.DisplayMenu();
            } while (userInput != 6);
            /*          PayCalculator run = new PayCalculator();
                        string PayRate = run.RunPayCalculator();
                        fizzbuzz letsFizzBuzz = new fizzbuzz();
                        string PlayFizzBuzz = letsFizzBuzz.LetsPlay();
                        ClockRadio TurnRadioOn = new ClockRadio();
                        string Radio = TurnRadioOn.MyVirtualClockRadio();
                        Adventure turn = new Adventure();
                        string Turn = turn.Crossroads();
            */
        }
    }
}
