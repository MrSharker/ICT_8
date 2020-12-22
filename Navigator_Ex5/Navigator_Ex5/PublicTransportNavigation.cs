using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigator_Ex5
{
    class PublicTransportNavigation : StrategyNavigation
    {
        public PublicTransportNavigation()
        {
            Title = "Маршрут через общественный транспорт";
        }
        public override string ToString()
        {
            return Title;
        }

        public override void FindRoute(int pos1, int pos2, int[] route)
        {

        }

        public override void ShowMap()
        {
            Console.WriteLine("1, 2, 3, 4, 5, 6, 7, 8, 9, 10");
        }
    }
}
