using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDesignConsoleApp.Step1.Domain1
{
    class Service1
    {
        internal int UseCase1()
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

namespace InterfaceDesignConsoleApp.Step1.Domain2
{
    class Service2
    {
        internal int UseCase2()
        {
            Console.WriteLine("[Invoked] Serive2.UseCase2");

            System.Threading.Thread.Sleep(250); // act like you do something

            Console.WriteLine("[Done] Serive2.UseCase2");
            return 1;
        }
    }
}