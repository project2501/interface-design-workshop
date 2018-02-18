using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDesignConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Step 1");
            Console.WriteLine("=========================");

            var service1_1 = new Step1.Domain1.Service1();
            service1_1.UseCase1();

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Step 2");
            Console.WriteLine("=========================");

            var service2_1 = new Step2.Domain1.Service1();
            service2_1.UseCase1();

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Step 3");
            Console.WriteLine("=========================");

            Public.Step3.Locator.Register<Public.Domain2.ISupportUseCase2>(new Step3.Domain2.Service2());

            var service3_1 = new Step3.Domain1.Service1();
            service3_1.UseCase1();

            Console.WriteLine(Environment.NewLine);

            Console.ReadKey();
        }
    }
}
