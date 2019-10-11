using System;

namespace BattleWarrior
{
    internal static class Battle
    {
        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            while (true)
            {
                if(GetAttackResult(warrior1, warrior2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
                if(GetAttackResult(warrior2, warrior2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }

        private static string GetAttackResult(Warrior warriorA, Warrior warriorB)
        {
            var warAAttkAmt = warriorA.Attack();
            var warBBlkAmt = warriorB.Block();

            var dmg2WarB = warAAttkAmt - warBBlkAmt;

            if(dmg2WarB > 0)
            {
                warriorB.Health = warriorB.Health - dmg2WarB;
            }else
                dmg2WarB = 0;

            Console.WriteLine("{0} Attacks {1} and Deals {2} Damage", warriorA.Name, warriorB.Name, dmg2WarB);

            if(warriorB.Health <= 0)
            {
                Console.WriteLine("{0} has Died and {1} is Victorious\n", warriorB.Name, warriorA.Name);

                return "Game Over";
            }else
            {
                return "Fight Again ";
            }
        }
    }
}