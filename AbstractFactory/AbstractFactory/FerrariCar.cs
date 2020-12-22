using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class FerrariCar : AbstractCar
    {
        public FerrariCar(string name)
        {
            Name = name;
        }
        public override int MaxSpeed(AbstractEngine engine)
        {
            int ms = engine.max_speed;
            return ms;
        }
        public override int Type(AbstractCarcase carcase)
        {
            int t = carcase.type;
            return t;
        }
        public override string ToString()
        {
            return "Автомобиль " + Name;

        }
    }
}
