using System;

namespace BattleWarrior
{
    internal static class Program
    {
        static void Main(string[] args)
        {
          var maximus = new Warrior("Maximus", 1000, 120, 40);
          var artimus = new Warrior("Artimus", 1000, 120, 40);

          Battle.StartFight(maximus, artimus);

          Console.ReadLine();
        }
    }
}
