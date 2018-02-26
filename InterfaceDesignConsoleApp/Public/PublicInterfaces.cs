namespace InterfaceDesign.Public
{
    namespace Domain1
    {
        public interface ISupportUseCase1
        {
            int UseCase1();
        }
    }

    namespace Domain2
    {
        public interface ISupportUseCase2
        {
            int UseCase2();
        }
    }

    public interface IServiceLocator
    {
        T Resolve<T>();

        void Register<T>(object implementation);
    }
}
