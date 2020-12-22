using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Client
    {
        private AbstractCar abstractCar;
        private AbstractEngine abstractEngine;
        private AbstractCarcase abstractCarcase;
        public Client(CarFactory car_factory)
        {
            abstractCar = car_factory.CreateCar();
            abstractEngine = car_factory.CreateEngine();
            abstractCarcase = car_factory.CreateCarcase();
        }
        public int RunMaxSpeed()
        {
            return abstractCar.MaxSpeed(abstractEngine);
        }
        public int RunType()
        {
            return abstractCar.Type(abstractCarcase);
        }
        public override string ToString()
        {
            return abstractCar.ToString();
        }
    }
}
