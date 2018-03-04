
namespace InterfaceDesign.Step4
{
    using System;

    namespace Domain1
    {
        class Service1 : Public.Domain1.ISupportUseCase1
        {
            Public.Domain2.ISupportUseCase2 m_useCase2;

            public Service1(Public.Domain2.ISupportUseCase2 useCase2)
            {
                if (useCase2 == null)
                {
                    throw new ArgumentNullException("useCase2");
                }

                m_useCase2 = useCase2;
            }

            public int UseCase1()
            {
                Console.WriteLine("[Invoked] Service1.UseCase1");

                System.Threading.Thread.Sleep(250); // act like you do something

                m_useCase2.UseCase2();

                Console.WriteLine("[Done] Service1.UseCase1");

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
                    Console.WriteLine("[Invoked] Service2.UseCase2");

                    System.Threading.Thread.Sleep(250); // act like you do something

                    Console.WriteLine("[Done] Service2.UseCase2");
                    return 1;
                }
            }
        }
    }
    
