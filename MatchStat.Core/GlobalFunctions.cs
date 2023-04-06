using Autofac;
using DependencyInjector.DI;

namespace MatchStat.Core
{
    public static class GlobalFunctions
    {
        private static ILifetimeScope? Container { get; set; }

        //public static bool IsRunTime = false;
        public static T? GetInstance<T>() where T : notnull
        {
            try
            {
                if(Container == null)
                {
                    return default;
                }
                var dependency = Container.Resolve<T>();
                return dependency;
            }
            catch(Exception ex)
            {
                return default;
            }
        }

        public static void RegisterDependencies()
        {
            Container = ContainerConfig.Configure();
            //Container.BeginLifetimeScope();
        }

    }
}

