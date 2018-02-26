// ----------------------------------------------------------------------------
//
// Demostrate hard-coupling and difficulties to write (unit) test.
//
// ----------------------------------------------------------------------------

namespace InterfaceDesign.Step1
{
    using System;

    namespace Domain1
    {
        class Service1
        {
            internal int UseCase1()
            {
                Console.WriteLine("[Invoked] Serice1.UseCase1");

                System.Threading.Thread.Sleep(250); // act like you do something

                var service2 = new Domain2.Service2();
                service2.UseCase2();

                Console.WriteLine("[Done] Serice1.UseCase1");

                return 1;
            }
        }
    }

    namespace Domain2
    {
        class Service2
        {
            internal int UseCase2()
            {
                Console.WriteLine("[Invoked] Serice2.UseCase2");

                System.Threading.Thread.Sleep(250); // act like you do something

                Console.WriteLine("[Done] Serice2.UseCase2");
                return 1;
            }
        }
    }
}