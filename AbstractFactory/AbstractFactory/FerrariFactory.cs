using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class FerrariFactory : CarFactory
    {
        static Lazy<FerrariFactory> Ferrari_car = new Lazy<FerrariFactory>(() => new FerrariFactory());

        public static FerrariFactory MyFerrari
        {
            get
            {
                return Ferrari_car.Value;
            }
        }
        public override AbstractCar CreateCar()
        {
            return new FerrariCar("Феррари");
        }
        public override AbstractEngine CreateEngine()
        {
            return new FerrariEngine();
        }
        public override AbstractCarcase CreateCarcase()
        {
            return new FerrariCarcase();
        }
    }
}
