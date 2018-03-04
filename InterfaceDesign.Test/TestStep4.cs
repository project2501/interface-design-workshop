using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterfaceDesign.Test
{
    using InterfaceDesign.Public.Domain2;

    [TestClass]
    public class TestStep4
    {

        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            var service2Moq = new Moq.Mock<ISupportUseCase2>();
            service2Moq.Setup(moq => moq.UseCase2()).Returns(42);

            InterfaceDesign.Public.Step4.Locator.Register<ISupportUseCase2>(service2Moq.Object);
        }

        [TestMethod]
        public void _01_TestService2()
        {
            var service2 = new InterfaceDesign.Step4.Domain2.Service2();
            int retVal = service2.UseCase2();
            Assert.IsTrue(retVal == 1);
        }



        [TestMethod]
        public void _02_TestService1_MockTheService2()
        {
            var service2Moq = Public.Step4.Locator.Resolve<ISupportUseCase2>();
            var service1 = new InterfaceDesign.Step4.Domain1.Service1(service2Moq);
            int retVal = service1.UseCase1();
            Assert.IsTrue(retVal == 1);
        }
    }
}
