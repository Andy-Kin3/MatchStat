using Autofac;
using DependencyInjector.DI;

namespace MatchStat.Core
{
    public static class GlobalFunctions
    {
        public static bool IsRunTime = false;

        public static ILifetimeScope Container { get; set; }

        public static void RegisterDependencies()
        {
            Container = ContainerConfig.Configure().BeginLifetimeScope();
        }
    }
}

