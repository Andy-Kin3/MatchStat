using Autofac;

namespace MatchStat.Core
{
    public static class GlobalFunctions
    {
        public static bool IsRunTime = false;

        public static ILifetimeScope? Container { get; set; }

        public static void RegisterDependencies()
        {
            GlobalFunctions.Container = ContainerConfig.Configure().BeginLifetimeScope(); ;
        }
    }

}

