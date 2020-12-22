using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Receiver receiver = new Receiver(true, true, true);
            PaymentHandler bankPaymentHandler = new BankPaymentHandler();
            PaymentHandler moneyPaymentHandler = new MoneyPaymentHandler();
            PaymentHandler paypalPaymentHandler = new PayPalPaymentHandler();

            bankPaymentHandler.Successor = moneyPaymentHandler;
            moneyPaymentHandler.Successor = paypalPaymentHandler;

            bankPaymentHandler.Handle(receiver);
            System.Console.ReadKey();

            //Была реализована систему отправки определенной суммы денег.

        }
    }
}
