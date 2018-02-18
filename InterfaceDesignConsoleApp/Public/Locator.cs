
namespace InterfaceDesignConsoleApp.Public
{
    namespace Step3
    {
        using System;
        using System.Collections.Generic;
        
        /// <summary>
        /// Static Service Locator.
        /// It is just static because of the demo-simplicity.
        /// </summary>
        public static class Locator
        {
            static Dictionary<Type, object> container = new Dictionary<Type, object>();
            

            public static void Register<T>(object implementation)
            {
                container.Add(typeof(T), implementation);
            }

            public static T Resolve<T>()
            {
                object service;
                if (container.TryGetValue(typeof(T), out service))
                {
                    return (T)service;
                }

                System.Diagnostics.Debug.WriteLine(String.Format("No type registration for the interface '{0}'", typeof(T).FullName));

                return default(T);
            }
        }
    }

    namespace Step4
    {
        using System;
        using System.Collections.Generic;

        /// <summary>
        /// Static Service Locator.
        /// It is just static because of the demo-simplicity.
        /// </summary>
        public static class Locator
        {
            static Dictionary<Type, object> container = new Dictionary<Type, object>();


            public static void Register<T>(object implementation)
            {
                container.Add(typeof(T), implementation);
            }

            public static T Resolve<T>()
            {
                object service;
                if (container.TryGetValue(typeof(T), out service))
                {
                    return (T)service;
                }

                System.Diagnostics.Debug.WriteLine(String.Format("No type registration for the interface '{0}'", typeof(T).FullName));

                return default(T);
            }
        }
    }
}
