using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory ford_car = new FordFactory();
            Client c1 = new Client(ford_car);
            Console.WriteLine("Максимальная скорость {0} составляет {1} км/час, тип кузова {2}",
            c1.ToString(), c1.RunMaxSpeed(), c1.RunType());

            CarFactory audi_car = new AudiFactory();
            Client c2 = new Client(audi_car);
            Console.WriteLine("Максимальная скорость {0} составляет {1} км/час, тип кузова {2}",
            c2.ToString(), c2.RunMaxSpeed(), c2.RunType());

            FerrariFactory Ferrari_car = FerrariFactory.MyFerrari;
            Client c3 = new Client(Ferrari_car);
            Console.WriteLine("Максимальная скорость {0} составляет {1} км/час, тип кузова {2}",
            c3.ToString(), c3.RunMaxSpeed(), c3.RunType());
            System.Console.ReadKey();
            //Добавлён новый тип машин -Audi и новое абстрактное свойство кузов. 
            //При создании абстрактных классов трудоёмкость минимальная.
        }
    }
}
