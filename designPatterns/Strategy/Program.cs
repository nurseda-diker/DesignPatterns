using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.calculatorBase= new Before2010CreditCalculatorBase();
            customerManager.SaveCredit();

            Console.ReadLine();
        }
    }

    abstract class CreditCalculatorBase
    {
        public abstract void Calculate();
    }

    class Before2010CreditCalculatorBase : CreditCalculatorBase
    {
        public override void Calculate()
        {
            Console.WriteLine("Credit calculated using before 2010");
        }
    }

    class After2010CreditCalculatorBase : CreditCalculatorBase
    {
        public override void Calculate()
        {
            Console.WriteLine("Credit calculated after 2010");
        }
    }

    class CustomerManager
    {
        public CreditCalculatorBase calculatorBase { get; set; }
        public void SaveCredit()
        {
            Console.WriteLine("Customer manager business");
            calculatorBase.Calculate();
        }
    }




}
