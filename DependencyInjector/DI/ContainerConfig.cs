using Autofac;
using MatchStat.Interfaces.Interfaces;
using MatchStat.Repositories.Repositories;

namespace DependencyInjector.DI
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<GoalRepository>().As<IGoalRepository>();
            builder.RegisterType<FieldRepository>().As<IFieldsRepository>();
            builder.RegisterType<MatchDetailsRepository>().As<IMatchesRepository>();
            builder.RegisterType<PlayersRepository>().As<IPlayersRepository>();
            builder.RegisterType<TeamsRepository>().As<ITeamsRepository>();
            builder.RegisterType<TournamentsRepository>().As<ITournamentsRepository>();
            builder.RegisterType<TeamTournamentRepository>().As<ITeamTournamentsRepository>();


            return builder.Build();
        }
    }
}
