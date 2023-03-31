﻿// <auto-generated />
using System;
using MatchStat.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MatchStat.DataModel.Migrations
{
    [DbContext(typeof(FootballInfoContext))]
    [Migration("20230331070559_my_match_sp")]
    partial class my_match_sp
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MatchStat.DataModel.DataModels.Field", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Field", (string)null);
                });

            modelBuilder.Entity("MatchStat.DataModel.DataModels.Goal", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<int>("MatchId")
                        .HasColumnType("int")
                        .HasColumnName("MatchID");

                    b.Property<int>("NumberOfGoal")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int")
                        .HasColumnName("PlayerID");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("Goal", (string)null);
                });

            modelBuilder.Entity("MatchStat.DataModel.DataModels.Match", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<int>("FieldId")
                        .HasColumnType("int")
                        .HasColumnName("FieldID");

                    b.Property<int>("Team1Id")
                        .HasColumnType("int")
                        .HasColumnName("Team1ID");

                    b.Property<int>("Team2Id")
                        .HasColumnType("int")
                        .HasColumnName("Team2ID");

                    b.Property<int>("TeamOneScore")
                        .HasColumnType("int");

                    b.Property<int>("TeamTwoScore")
                        .HasColumnType("int");

                    b.Property<int?>("TournamentId")
                        .HasColumnType("int")
                        .HasColumnName("TournamentID");

                    b.HasKey("Id");

                    b.HasIndex("FieldId");

                    b.HasIndex("Team1Id");

                    b.HasIndex("Team2Id");

                    b.HasIndex("TournamentId");

                    b.ToTable("Match", (string)null);
                });

            modelBuilder.Entity("MatchStat.DataModel.DataModels.MatchDetail", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("FieldId")
                        .HasColumnType("int");

                    b.Property<string>("FieldName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Team1Id")
                        .HasColumnType("int");

                    b.Property<string>("Team1Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Team2Id")
                        .HasColumnType("int");

                    b.Property<string>("Team2Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamOneScore")
                        .HasColumnType("int");

                    b.Property<int>("TeamTwoScore")
                        .HasColumnType("int");

                    b.Property<int?>("TournamentId")
                        .HasColumnType("int");

                    b.Property<string>("TournamentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable((string)null);

                    b.ToView("MatchesView", (string)null);
                });

            modelBuilder.Entity("MatchStat.DataModel.DataModels.MyMatchStoredProcedure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("FieldId")
                        .HasColumnType("int");

                    b.Property<int>("Team1Id")
                        .HasColumnType("int");

                    b.Property<int>("Team2Id")
                        .HasColumnType("int");

                    b.Property<int>("TeamOneScore")
                        .HasColumnType("int");

                    b.Property<int>("TeamTwoScore")
                        .HasColumnType("int");

                    b.Property<int?>("TournamentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MatchStoredProcedure");
                });

            modelBuilder.Entity("MatchStat.DataModel.DataModels.Player", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("date")
                        .HasColumnName("DOB");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamId")
                        .HasColumnType("int")
                        .HasColumnName("TeamID");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Player", (string)null);
                });

            modelBuilder.Entity("MatchStat.DataModel.DataModels.Team", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)");

                    b.HasKey("Id");

                    b.ToTable("Team", (string)null);
                });

            modelBuilder.Entity("MatchStat.DataModel.DataModels.TeamTournament", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("TeamId")
                        .HasColumnType("int")
                        .HasColumnName("TeamID");

                    b.Property<int>("TournamentId")
                        .HasColumnType("int")
                        .HasColumnName("TournamentID");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.HasIndex("TournamentId");

                    b.ToTable("TeamTournaments");
                });

            modelBuilder.Entity("MatchStat.DataModel.DataModels.Tournament", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.ToTable("Tournament", (string)null);
                });

            modelBuilder.Entity("MatchStat.DataModel.DataModels.Goal", b =>
                {
                    b.HasOne("MatchStat.DataModel.DataModels.Player", "Player")
                        .WithMany("Goals")
                        .HasForeignKey("PlayerId")
                        .IsRequired()
                        .HasConstraintName("FK_Goal_Player");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("MatchStat.DataModel.DataModels.Match", b =>
                {
                    b.HasOne("MatchStat.DataModel.DataModels.Field", "Field")
                        .WithMany("Matches")
                        .HasForeignKey("FieldId")
                        .IsRequired()
                        .HasConstraintName("FK_Match_Field");

                    b.HasOne("MatchStat.DataModel.DataModels.Team", "Team1")
                        .WithMany("MatchTeam1s")
                        .HasForeignKey("Team1Id")
                        .IsRequired()
                        .HasConstraintName("FK_Match_Team");

                    b.HasOne("MatchStat.DataModel.DataModels.Team", "Team2")
                        .WithMany("MatchTeam2s")
                        .HasForeignKey("Team2Id")
                        .IsRequired()
                        .HasConstraintName("FK_Match_Team1");

                    b.HasOne("MatchStat.DataModel.DataModels.Tournament", "Tournament")
                        .WithMany("Matches")
                        .HasForeignKey("TournamentId")
                        .HasConstraintName("FK_Match_Tournament");

                    b.Navigation("Field");

                    b.Navigation("Team1");

                    b.Navigation("Team2");

                    b.Navigation("Tournament");
                });

            modelBuilder.Entity("MatchStat.DataModel.DataModels.Player", b =>
                {
                    b.HasOne("MatchStat.DataModel.DataModels.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId")
                        .IsRequired()
                        .HasConstraintName("FK_Player_Team");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("MatchStat.DataModel.DataModels.TeamTournament", b =>
                {
                    b.HasOne("MatchStat.DataModel.DataModels.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .IsRequired()
                        .HasConstraintName("FK_TeamTournament_Team");

                    b.HasOne("MatchStat.DataModel.DataModels.Tournament", "Tournament")
                        .WithMany()
                        .HasForeignKey("TournamentId")
                        .IsRequired()
                        .HasConstraintName("FK_TeamTournament_Tournament");

                    b.Navigation("Team");

                    b.Navigation("Tournament");
                });

            modelBuilder.Entity("MatchStat.DataModel.DataModels.Field", b =>
                {
                    b.Navigation("Matches");
                });

            modelBuilder.Entity("MatchStat.DataModel.DataModels.Player", b =>
                {
                    b.Navigation("Goals");
                });

            modelBuilder.Entity("MatchStat.DataModel.DataModels.Team", b =>
                {
                    b.Navigation("MatchTeam1s");

                    b.Navigation("MatchTeam2s");

                    b.Navigation("Players");
                });

            modelBuilder.Entity("MatchStat.DataModel.DataModels.Tournament", b =>
                {
                    b.Navigation("Matches");
                });
#pragma warning restore 612, 618
        }
    }
}
