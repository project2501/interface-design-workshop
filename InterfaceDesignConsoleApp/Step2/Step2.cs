﻿// ----------------------------------------------------------------------------
//
// - Introducing public interfaces
// - implementation of these new interfaces
// - But, Service1 still uses a "new" keyword for the service2 implementation,
//      which makes no difference with the mocking problem on the test side.
//
// ----------------------------------------------------------------------------


namespace InterfaceDesignConsoleApp.Step2
{
    using System;    

    namespace Domain1
    {
        class Service1 : Public.Domain1.ISupportUseCase1
        {
            public int UseCase1()
            {
                Console.WriteLine("[Invoked] Serive1.UseCase1");

                System.Threading.Thread.Sleep(250); // act like you do something

                var service2 = new Domain2.Service2();
                service2.UseCase2();

                Console.WriteLine("[Done] Serive1.UseCase1");

                return 1;
            }
        }
    }

    namespace Domain2
    {
        class Service2 : Public.Domain2.ISupportUseCase2
        {
            public int UseCase2()
            {
                Console.WriteLine("[Invoked] Serive2.UseCase2");

                System.Threading.Thread.Sleep(250); // act like you do something

                Console.WriteLine("[Done] Serive2.UseCase2");
                return 1;
            }
        }
    }

}