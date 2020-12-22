using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigator_Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            StrategyNavigation navigation = new CarNavigation();
            Context context = new Context(navigation, 1, 10);
            context.ShowMap();
            context.ShowRoute();

            navigation = new PedestrianNavigation();
            context = new Context(navigation, 7, 4);
            context.ShowRoute();


            navigation = new BikeNavigation();
            context = new Context(navigation, 2, 8);
            context.ShowRoute();

            navigation = new PublicTransportNavigation();
            context = new Context(navigation, 3, 7);
            context.ShowRoute();

            navigation = new SightNavigation();
            context = new Context(navigation, 5, 2);
            context.ShowRoute();
            System.Console.ReadKey();
        }
    }
}
