using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class DrunkDriverService : TransportService
    {
        public int Category { get; set; }
        public DrunkDriverService(string name, int cat) :
        base(name)
        {
            Category = cat;
        }
        public override double CostTransportation(double distance)
        {
            return distance * Category / 2.0;
        }
        public override string ToString()
        {
            string s = String.Format("Фирма {0}, поездка категории {1}",
            Name, Category);
            return s;
        }
    }
}
