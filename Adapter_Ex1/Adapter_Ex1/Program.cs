using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            ClimateControl сс1 = new ClimateControl("Климат-контроллер");

            TSensor ts = new TSensor();
            IClimate bts = new AdapterTemperature(ts);

            Console.WriteLine("\"{0}\" увеличил температуру на {1} градусов цельсия", сс1.ToString(),
            сс1.ChangeTemp(bts));
        }
    }
}
