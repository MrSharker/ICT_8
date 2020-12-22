using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        private static void Print(AutoBase av)
        {
            Console.WriteLine(av.ToString());
        }
        static void Main(string[] args)
        {
            Renault reno = new Renault("Рено", "Renault LOGAN Active", 499.0);
            Print(reno);
            AutoBase myreno = new MediaNAV(reno, "Навигация");
            Print(myreno);
            AutoBase newmyReno = new SystemSecurity(new MediaNAV(reno, "Навигация"),
            "Безопасность");
            Print(newmyReno);

            Dodge Pol = new Dodge("Dodge", "Dodge Challenger SRT-8", 700.0);
            Print(Pol);
            AutoBase PolWalwer = new MediaNAV(Pol, "Закись азота");
            Print(PolWalwer);
            AutoBase SuperPolWalwer = new SystemSecurity(new MediaNAV(Pol, "Закись азота"),
            "Шесть тысяч лошадей под капотом");
            Print(SuperPolWalwer);
            AutoBase SuperMegaPolWalwer = new Beauty(new SystemSecurity(new MediaNAV(Pol, "Закись азота"),
            "Шесть тысяч лошадей под капотом"), "Подсветка дисков");
            Print(SuperMegaPolWalwer);
            AutoBase SuperGiperMegaPolWalwer = new Sell(new Beauty(new SystemSecurity(new MediaNAV(Pol, "Закись азота"),
            "Шесть тысяч лошадей под капотом"), "Подсветка дисков"), "");
            Print(SuperGiperMegaPolWalwer);
            System.Console.ReadKey();

            //Был изучен паттерн Декоратор. Был добавлен новый класс Dodge и новые функциональные возможности.
        }
    }
}
