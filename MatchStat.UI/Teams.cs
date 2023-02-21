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
    public partial class Teams : Form
    {
        public Teams()
        {
            InitializeComponent();
        }
        private List<Team> GetTeams()
        {
            using(var context = new FootballInfoContext())
            {
                var team = context.Teams.ToList();
                return team;
            }
        }
        private void LoadTeam()
        {
            var teams = GetTeams();
            teamBindingSource.DataSource = teams;
        }
        private void Teams_Load(object sender, EventArgs e)
        {
            LoadTeam();
        }

        private void createbutton_Click(object sender, EventArgs e)
        {
            var teams = new Team()
            {
                Name = teamName.Text.ToString(),
                Id = GetNextID(),
            };
            using(var context = new FootballInfoContext())
            {
                var team = context.Teams.ToList();
                context.Teams.Add(teams);
                context.SaveChanges();
            }
        }

        private int GetNextID()
        {
            var allTeams = teamBindingSource.DataSource as List<Team>;
            var maximumId = allTeams != null && allTeams.Any() ? allTeams.Max(x => x.Id) : 0;
            return maximumId+1;

        }

        private void deleteTeamButton_Click(object sender, EventArgs e)
        {
            var currentlySelected = teamBindingSource.Current as Team;
            if (currentlySelected != null)
            {
                using (var context = new FootballInfoContext())
                {
                    context.Teams.Remove(currentlySelected);
                    context.SaveChanges();
                    LoadTeam();
                }
            }
        }
    }
}
