using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TipCalculator
{
    public class UserInterface
    {
        ICustomConsole _print;

        //Constructor using DEPENDENCY INJECTION
        public UserInterface(ICustomConsole console)
        {
            _print = console;
        }

        TipRepo _tipRepo = new TipRepo();

        bool isRunning = true;

        public void Start()
        {
            while (isRunning)
            {
                Console.Clear();

                _print.AskUserForTotalBill();

                decimal totalBill = Convert.ToDecimal(Console.ReadLine());

                decimal totalBillWithTipIncluded = _tipRepo.CalculateTip(totalBill);

                _print.PrintTotalBillWithTip(totalBillWithTipIncluded);

                Console.ReadKey();
            }
        }

        //
    }

    // LANGUAGE CLASSES THAT IMPLEMENT THE INTERFACE ICustomConsole

    public class English : ICustomConsole
    {
        public void AskUserForTotalBill()
        {
            Console.Write("What was your total bill? : $");
        }

        public void PrintTotalBillWithTip(decimal totalBillWithTipIncluded)
        {
            Console.WriteLine("Your total bill with a 15% tip is $" + totalBillWithTipIncluded + ".");
        }
    }

    public class Espanol : ICustomConsole
    {
        public void AskUserForTotalBill()
        {
            Console.Write("¿Cuál fue su factura total? : $");
        }

        public void PrintTotalBillWithTip(decimal totalBillWithTipIncluded)
        {
            Console.WriteLine("Su factura total con una propina del 15% es $" + totalBillWithTipIncluded + ".");
        }
    }

    public class Mandarin : ICustomConsole
    {
        public void AskUserForTotalBill()
        {
            Console.Write("你的總賬單是多少？ : $");
        }

        public void PrintTotalBillWithTip(decimal totalBillWithTipIncluded)
        {
            Console.WriteLine("15% 小費的總賬單是 $" + totalBillWithTipIncluded + ".");
        }
    }

    public class Hindi : ICustomConsole
    {
        public void AskUserForTotalBill()
        {
            Console.Write("आपका कुल बिल क्या था? : $");
        }

        public void PrintTotalBillWithTip(decimal totalBillWithTipIncluded)
        {
            Console.WriteLine("15 % टिप के साथ आपका कुल बिल है $" + totalBillWithTipIncluded + ".");
        }
    }

    public class French : ICustomConsole
    {
        public void AskUserForTotalBill()
        {
            Console.Write("Quelle était votre facture totale ? : $");
        }

        public void PrintTotalBillWithTip(decimal totalBillWithTipIncluded)
        {
            Console.WriteLine("Votre facture totale avec un pourboire de 15 % est $" + totalBillWithTipIncluded + ".");
        }
    }

    public class Deutsch : ICustomConsole
    {
        public void AskUserForTotalBill()
        {
            Console.Write("Wie hoch war Ihre Gesamtrechnung? : $");
        }

        public void PrintTotalBillWithTip(decimal totalBillWithTipIncluded)
        {
            Console.WriteLine("Ihre Gesamtrechnung mit 15 % Trinkgeld ist $" + totalBillWithTipIncluded + ".");
        }
    }

    public class Bengali : ICustomConsole
    {
        public void AskUserForTotalBill()
        {
            Console.Write("আপনার মোট বিল কত ছিল? : $");
        }

        public void PrintTotalBillWithTip(decimal totalBillWithTipIncluded)
        {
            Console.WriteLine("15% টিপ সহ আপনার মোট বিল $" + totalBillWithTipIncluded + ".");
        }
    }

    //
}