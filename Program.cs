using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassAlong
{
    class Program
    {
        static void Main(string[] args)
        {
            PayCalculator run = new PayCalculator();
            string PayRate = run.RunPayCalculator();
            fizzbuzz letsFizzBuzz = new fizzbuzz();
            string PlayFizzBuzz = letsFizzBuzz.LetsPlay();
            ClockRadio TurnRadioOn = new ClockRadio();
            string Radio = TurnRadioOn.MyVirtualClockRadio();
            Adventure turn = new Adventure();
            string Turn = turn.Crossroads();
        }
    }
    
}