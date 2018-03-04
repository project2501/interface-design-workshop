namespace InterfaceDesign
{
    using InterfaceDesign.Public;
    using InterfaceDesign.Public.Domain1;
    using InterfaceDesign.Public.Domain2;
    using Ninject;
    using System;

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
            Public.Step3.Locator.Register<Public.Domain1.ISupportUseCase1>(new Step3.Domain1.Service1());

            var service3_1 = Public.Step3.Locator.Resolve<Public.Domain1.ISupportUseCase1>();
            service3_1.UseCase1();

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Step 4");
            Console.WriteLine("=========================");

            Public.Step4.Locator.Register<Public.Domain2.ISupportUseCase2>(new Step4.Domain2.Service2());
            var useCase2 = Public.Step4.Locator.Resolve<Public.Domain2.ISupportUseCase2>();
            Public.Step4.Locator.Register<Public.Domain1.ISupportUseCase1>(new Step4.Domain1.Service1(useCase2));

            var service4_1 = Public.Step3.Locator.Resolve<Public.Domain1.ISupportUseCase1>();
            service4_1.UseCase1();

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Step 5");
            Console.WriteLine("=========================");

            var kernel = new StandardKernel();
            kernel.Load(new Ninject.Modules.INinjectModule[] { new Bindings()});
            
            var useCase1Impl = kernel.Get<ISupportUseCase1>();
            var useCase2Impl = kernel.Get<ISupportUseCase2>();
            useCase1Impl.UseCase1();

            Console.WriteLine(Environment.NewLine);

            Console.ReadKey();
        }
    }
}
