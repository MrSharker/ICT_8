using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigator_Ex5
{
    abstract class StrategyNavigation
    {
        public string Title { get; set; }

        public abstract void ShowMap();
        public abstract void FindRoute(int pos1, int pos2, int[] route);
    }
}
