// ----------------------------------------------------------------------------
//
// - Introducing a "service locator" (Static one, to spare a context for the demo)
// - Usage of registration in production and test to mock the dependencies
// - Talk about the evil "new" keyword.
//
// ----------------------------------------------------------------------------


namespace InterfaceDesignConsoleApp.Step3
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


                var service2 = Public.Step3.Locator.Resolve<Public.Domain2.ISupportUseCase2>();
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