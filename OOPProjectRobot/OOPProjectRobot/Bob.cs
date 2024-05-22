using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProjectRobot
{
    internal class Bob
    {
        //StartFight
        //Robot1 Robot2
        public static void StartFight(Robot robot1, Robot robot2)
        { while (true)
            {
                if (GetAttackResult(robot1, robot2) == "game over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
                if (GetAttackResult(robot2, robot1) == "game over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }

        }
        //Loop fiecare ataca sau blocheaza pana 
        //viata ajunge la 0

        public static string GetAttackResult(Robot robotA, Robot robotB) 
        {
            double robotAAtackAmt = robotA.Attack();
            double robotBBlockAmt = robotB.Block(); 
            
            double dmg2RobotB = robotAAtackAmt - robotBBlockAmt;

            if (dmg2RobotB > 0)
            {
                robotB.Healt = robotB.Healt - dmg2RobotB;
            }
            else dmg2RobotB = 0;
            Console.WriteLine($"{robotA.Name} Attacks {robotB.Name} and Deals" ,
                robotA.Name, robotB.Healt,
                dmg2RobotB);
            Console.WriteLine($"{robotB.Name} Has {robotB.Healt} \n");

            if (robotB.Healt <= 0)
            {
                Console.WriteLine($"{robotB.Name} has Died and {robotA.Name} is the Winner");
                return "game over";
            }
            else return "Fight";
                

        }

        //GetAttackResult
        //Robot1, Robot2



        //Calculeaza attack robot1 si block robot2 si damage pe care il
        //ia fiecare


    }
}
