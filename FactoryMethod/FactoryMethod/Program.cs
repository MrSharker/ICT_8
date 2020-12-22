using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        private static void Print(TransportService compTax, double distg)
        {
            Console.WriteLine("Компания {0}, расстояние {1}, стоимость: {2}",
            compTax.ToString(), distg, compTax.CostTransportation(distg));
        }

        static void Main(string[] args)
        {
            TransportCompany trCom = new TaxiTransCom("Служба такси");
            TransportService compService = trCom.Create("Такси", 1);
            double dist = 15.5;
            Print(compService, dist);

            TransportCompany gCom = new ShipTransCom("Служба перевозок");
            compService = gCom.Create("Грузоперевозки", 2);
            double distg = 150.5;
            Print(compService, distg);

            TransportCompany drTrCom = new DrunkTaxiTransCom("Служба пьяного такси");
            compService = drTrCom.Create("Пьяное такси", 3);
            double distdr = 100.5;
            Print(compService, distdr);
            System.Console.ReadKey();

            //Создана новая услуга "Пьяный водитель" и новая компания. Трудоёскость по внесению новых классов не значительная.
        }
    }
}
