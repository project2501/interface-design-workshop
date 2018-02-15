namespace Siemens.
    Simatic.
    Hmi.
    UnifiedArchitecture.
    API.
    Domain1
{
    public interface ISupportUseCase1
    {
        void UseCase1();
    }

    public interface ISupportUseCase2
    {
        void UseCase2();
    }
}

namespace Component1
{
    using Siemens.Simatic.Hmi.UnifiedArchitecture.API.Domain1;

    internal class Service1 : ISupportUseCase1
    {
        public void UseCase1()
        {
            System.Diagnostics.Debug.WriteLine("[Executing] Use Case 1");

            System.Threading.Thread.Sleep(250);

            System.Diagnostics.Debug.WriteLine("[Done] Use Case 1");
        }
    }
}
