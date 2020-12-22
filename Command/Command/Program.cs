using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            double result = 0;

            result = calculator.Add(5);
            Console.WriteLine(result);

            result = calculator.Sub(3);
            Console.WriteLine(result);

            result = calculator.Mul(3);
            Console.WriteLine(result);

            result = calculator.Redo(2);
            Console.WriteLine(result);


            result = calculator.Div(2);
            Console.WriteLine(result);

            result = calculator.Undo(2);
            Console.WriteLine(result);

            System.Console.ReadKey();

            //Был реализован калькулятор. Были добавлены три команды(вычитание, умножение и деление).
            //Была добавлена поддержка многоуровневой отмены и повтора операций с помощью перегруженных 
            //версий методов Undo() и Redo().

        }
    }
}
