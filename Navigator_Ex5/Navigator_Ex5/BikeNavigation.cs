using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigator_Ex5
{
    class BikeNavigation : StrategyNavigation
    {
        public BikeNavigation()
        {
            Title = "Велосипедный маршрут";
        }
        public override string ToString()
        {
            return Title;
        }

        public override void FindRoute(int pos1, int pos2, int[] route)
        {

            if (Math.Abs(pos1 - pos2) >= 4)
            {
                route[0] = Math.Min(pos1, pos2) + 2;
                route[1] = Math.Max(pos1, pos2) - 2;
            }
            if (Math.Abs(pos1 - pos2) == 3)
            {
                route[0] = Math.Max(pos1, pos2) + 2;
            }


        }

        public override void ShowMap()
        {
            Console.WriteLine("1, 2, 3, 4, 5, 6, 7, 8, 9, 10");
        }
    }
}
