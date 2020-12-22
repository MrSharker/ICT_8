using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigator_Ex5
{
    class SightNavigation : StrategyNavigation
    {
        public SightNavigation()
        {
            Title = "Маршрут с посищением достопримечательностей";
        }
        public override string ToString()
        {
            return Title;
        }

        public override void FindRoute(int pos1, int pos2, int[] route)
        {
            int k = 0;
            if (pos1 < pos2)
            {
                for (int i = pos1 + 1; i < pos2; i++)
                {
                    route[k] = i;
                    k++;
                }
            }
            else
            {
                for (int i = pos1 - 1; i > pos2; i--)
                {
                    route[k] = i;
                    k++;
                }
            }
        }

        public override void ShowMap()
        {
            Console.WriteLine("1, 2, 3, 4, 5, 6, 7, 8, 9, 10");
        }
    }
}
