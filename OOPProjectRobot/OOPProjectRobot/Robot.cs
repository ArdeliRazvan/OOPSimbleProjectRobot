using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProjectRobot
{
    internal class Robot
    {
        //Nume Viata MaxAttack MaxBlock
        public string Name { get; set; } = "Robot";
        public double Healt { get; set; } = 0;
        public double AttackMax { get; set; } = 0;
        public double BlockMax { get; set; } = 0;

        //RandomNumbers
        Random rnd = new Random();

        public Robot(string name = "Robot",
            double healt = 0,
            double attackMax = 0,
            double blockMax = 0)
        {
            Name = name;
            Healt = healt;
            AttackMax = attackMax;
            BlockMax = blockMax;
        }

        // AbilitatiDeAttack AbilitatiDeBlock

        public double Attack()
        { return rnd.Next(1, (int)AttackMax); }
        public double Block()
        { return rnd.Next(1, (int)BlockMax); }

        //Attack genRandom 1 pana la max
        //Block genRandom 1 pana la max
    }
}
