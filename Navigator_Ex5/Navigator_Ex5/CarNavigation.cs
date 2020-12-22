using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigator_Ex5
{
    class CarNavigation : StrategyNavigation
    {
        public CarNavigation()
        {
            Title = "Автомобильный маршрут";
        }
        public override string ToString()
        {
            return Title;
        }

        public override void FindRoute(int pos1, int pos2, int[] route)
        {

            if (Math.Abs(pos1 - pos2) > 1)
            {
                route[0] = (pos2 + pos1) / 2;
            }

        }

        public override void ShowMap()
        {
            Console.WriteLine("1, 2, 3, 4, 5, 6, 7, 8, 9, 10");
        }
    }
}
