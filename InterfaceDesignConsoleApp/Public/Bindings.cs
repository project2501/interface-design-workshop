using InterfaceDesign.Public.Domain1;
using InterfaceDesign.Public.Domain2;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDesign.Public
{
    class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<ISupportUseCase1>().To<Step5.Domain1.Service1>();
            Bind<ISupportUseCase2>().To<Step5.Domain2.Service2>();
        }
    }
}
