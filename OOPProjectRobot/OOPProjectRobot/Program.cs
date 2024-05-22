using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProjectRobot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot titan = new Robot
            ("Titan", 1000, 120, 60);
            Robot hero = new Robot
            ("Bob", 1000, 120, 60);
            Bob.StartFight(titan, hero);
            Console.ReadLine();
        }
    }
}
