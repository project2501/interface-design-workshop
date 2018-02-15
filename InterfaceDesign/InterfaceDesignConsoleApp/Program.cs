using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDesignConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var service1 = new Step1.Domain1.Service1();
            service1.UseCase1();

            Console.ReadKey();
        }
    }
}
