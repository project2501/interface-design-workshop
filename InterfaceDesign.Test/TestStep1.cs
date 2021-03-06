﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterfaceDesign.Test
{
    [TestClass]
    public class TestStep1
    {
        [TestMethod]
        public void _02_TestService1_NoWayToMockService2()
        {
            var service1 = new InterfaceDesign.Step1.Domain1.Service1();
            int retVal = service1.UseCase1();
            Assert.IsTrue(retVal == 1);
        }

        [TestMethod]
        public void _01_TestService2()
        {
            var service2 = new InterfaceDesign.Step1.Domain2.Service2();
            int retVal = service2.UseCase2();
            Assert.IsTrue(retVal == 1);
        }
    }
}
