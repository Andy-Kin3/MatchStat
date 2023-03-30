using Autofac;

using MatchStat.Database;
using MatchStat.Interfaces.Database;
using MatchStat.Interfaces.Interfaces;
using MatchStat.Repositories.Repositories;
using MatchStat.UI;

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
            builder.RegisterType<FootballInfoContext>().As<IFootballInfoContext>();

            builder.RegisterType<GoalRecordWindow>().AsSelf();
            builder.RegisterType<MatchRecordWindow>().AsSelf();
            builder.RegisterType<PlayersWindow>().AsSelf();
            builder.RegisterType<TournamentStatisticsWindow>().AsSelf();
            builder.RegisterType<FieldsWindow>().AsSelf();
            builder.RegisterType<TeamTournamentsWindow>().AsSelf();
            builder.RegisterType<TeamsWindow>().AsSelf();

            return builder.Build();
        }
    }
}
