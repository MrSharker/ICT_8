using System;
using System.Collections.Generic;
using System.Text;

namespace Navigator_Ex5
{
    class Context
    {
        StrategyNavigation strategy;
        int pos1, pos2;
        int[] route = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public Context(StrategyNavigation strategy, int pos1, int pos2)
        {
            this.strategy = strategy;
            this.pos1 = pos1;
            this.pos2 = pos2;
        }
        public void ShowMap()
        {
            Console.WriteLine("Карта");
            strategy.ShowMap();
        }
        public void FindRoute()
        {
            strategy.FindRoute(pos1, pos2, route);
        }
        public void ShowRoute()
        {
            this.FindRoute();
            Console.WriteLine(strategy.ToString());
            Console.Write(pos1 + " ");
            for (int i = 0; i < route.Length; i++)
                if (route[i] != 0) Console.Write(route[i] + " ");
            Console.Write(pos2 + " ");
            Console.WriteLine();
        }
    }
}
