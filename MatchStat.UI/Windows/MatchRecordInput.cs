﻿using MatchStat.DataModel.DataModels;
using MatchStat.DataModel.EntityTypeConfigurartion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchStat.UI.Windows
{
    public partial class MatchRecordInput : Form
    {
        public MatchRecordInput()
        {
            InitializeComponent();
        }
        private MatchDetail? matchDetail
        {
            get { return this.matchDetailBindingSource.DataSource as MatchDetail; }
            set { this.matchDetailBindingSource.DataSource = value; }
        }
        private Team[] GetTeams()
        {
            using (var context = new FootballInfoContext())
            {
                var teams = context.Teams.ToArray();
                return teams;
            }
        }
        private Fields[] GetFields()
        {
            using (var context = new FootballInfoContext())
            {
                var fields = context.Fields.ToArray();
                return fields;
            }
        }
        private Tournament[] GetTournaments()
        {
            using (var context = new FootballInfoContext())
            {
                var tournaments = context.Tournaments.OrderBy(t => t.Name).ToArray();
                return tournaments;
            }
        }
        private MatchDetail[] GetMatches()
        {
            using (var context = new FootballInfoContext())
            {
                var matches = context.MatchDetails.OrderBy(m => m.Id).ToArray();
                return matches;
            }
        }
        private void MatchRecordInput_Load(object sender, EventArgs e)
        {
            var teams = GetTeams();
            this.teamBindingSource.DataSource = teams;
            this.teamBindingSource1.DataSource = teams;
            this.tournamentBindingSource.DataSource = GetTournaments();
            this.fieldsBindingSource.DataSource = GetFields();
            LoadMatches();
        }

        private void LoadMatches()
        {
            var match = GetMatches();
            this.matchDetailBindingSource.DataSource = match;
        }
        private void SaveMatchToDB(MatchDetail matchs)
        {
            using (var context = new FootballInfoContext())
            {
                var m = matchs;
                if (m.Id == 0)
                {
                    m.Id = GetMatchNextId();
                }
                context.MatchDetails.Add(m);
                context.SaveChanges();
            }
        }
        private int GetMatchNextId()
        {
            var allMatches = this.matchDetailBindingSource.DataSource as MatchDetail[];
            var maximumId = allMatches != null && allMatches.Any() ? allMatches.Max(m => m.Id) : 0;
            var nextIdValue = maximumId + 1;
            return nextIdValue;
        }

        private void saveMatchButton_Click(object sender, EventArgs e)
        {
            SaveMatchToDB(matchDetail);
        }
    }
}