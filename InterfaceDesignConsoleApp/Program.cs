using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDesign
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


            var secondsOfDay = new int[86400];

            for (int i = 0; i < secondsOfDay.Length; i++)
            {
                // initialize
                // -1 = no register
                secondsOfDay[i] = -1;
            }


            // add 3:00

            int threeAM = 3 * 60 * 60;
            int fiveAM = 5 * 60 * 60;

            // add 3am into array with its ending (5am)
            for (int i = threeAM; i < fiveAM; i++)
            {
                secondsOfDay[i] = fiveAM; // register each second with its ending
            }

            // is 4am Rush hour?

            int fourAM = 4 * 60 * 60;

            if (secondsOfDay[fourAM] != -1)
            {
                Console.WriteLine("working");
            }
            else
            {
                Console.WriteLine("Not working");
            }


            // is 7am Rush hour?

            int sevenAM = 7 * 60 * 60;

            if (secondsOfDay[sevenAM] == -1)
            {
                Console.WriteLine("working");
            }
            else
            {
                Console.WriteLine("not working");
            }



            Console.ReadKey();
        }
    }
}
