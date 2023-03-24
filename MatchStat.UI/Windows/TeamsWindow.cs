using MatchStat.Database;
using MatchStat.DataModel.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchStat.UI
{
    public partial class TeamsWindow : Form
    {
        public TeamsWindow()
        {
            InitializeComponent();
        }
        private Team? team
        {
            get
            {
                return this.teamBindingSource.DataSource as Team;
            }
            set { this.teamBindingSource.DataSource = value; }

        }
        private List<Team> GetTeams()
        {
            using (var context = new FootballInfoContext())
            {
                var team = context.Teams.ToList();
                return team;
            }
        }
        private void LoadTeams()
        {
            var teams = GetTeams();
            teamBindingSource.DataSource = teams;
        }
        private void Teams_Load(object sender, EventArgs e)
        {
            LoadTeams();
        }
        private void AddTeamToDatabase(Team t)
        {
            using (var context = new FootballInfoContext())
            {
                context.Teams.Add(t);
                context.SaveChanges();
                LoadTeams();
                teamName.Clear();

            }
            LoadTeams();
        }

        private void createbutton_Click(object sender, EventArgs e)
        {
            if (team != null)
            {
                AddTeamToDatabase(team);
            }
        }

        //private int GetNextID()
        //{
        //    var allTeams = teamBindingSource.DataSource as List<Team>;
        //    var maximumId = allTeams != null && allTeams.Any() ? allTeams.Max(x => x.Id) : 0;
        //    return maximumId + 1;
        //}

        private void deleteTeamButton_Click(object sender, EventArgs e)
        {
            var currentlySelected = teamBindingSource.Current as Team;
            if (currentlySelected != null)
            {
                using (var context = new FootballInfoContext())
                {
                    context.Teams.Remove(currentlySelected);
                    context.SaveChanges();
                    LoadTeams();
                }
            }
        }
    }
}
