

namespace InterfaceDesign.Test
{
    using InterfaceDesign.Public.Domain2;
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Ninject;
    using InterfaceDesign.Public.Domain1;
    using Ninject.MockingKernel.Moq;

    [TestClass]
    public class TestStep5
    {
        static StandardKernel _kernel = new StandardKernel();
        static MoqMockingKernel _mockingKernel = new MoqMockingKernel();

        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            var service2Moq = _mockingKernel.GetMock<ISupportUseCase2>();
            service2Moq.Setup(moq => moq.UseCase2()).Returns(42);

            _kernel.Bind<ISupportUseCase2>().ToConstant(service2Moq.Object);
            _kernel.Rebind<ISupportUseCase1>().To<Step5.Domain1.Service1>();
        }

        [TestMethod]
        public void _01_TestService2()
        {
            _kernel.Rebind<ISupportUseCase2>().To<Step5.Domain2.Service2>();
            var service2 = _kernel.Get<ISupportUseCase2>();
            int retVal = service2.UseCase2();
            Assert.IsTrue(retVal == 1);
        }



        [TestMethod]
        public void _02_TestService1_MockTheService2()
        {            
            var service1 = _kernel.Get<ISupportUseCase1>();
            int retVal = service1.UseCase1();
            Assert.IsTrue(retVal == 1);
        }
    }
}
