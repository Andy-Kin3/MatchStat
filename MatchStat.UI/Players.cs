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
using System.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;

namespace MatchStat.UI
{
    public partial class Players : Form
    {
        public Players()
        {
            InitializeComponent();
        }

        private List<Player> GetPlayer()
        {
            using(var context = new FootballInfoContext())
            {
                var player = context.Players.ToList();
                return player; 
            }
        }
        private List<Team> GetTeams()
        {
            using(var context = new FootballInfoContext())
            {
                var teams = context.Teams.ToList();
                return teams;
            }
        }

        private void LoadPlayers()
        {
            var players = this.GetPlayer();
            playerBindingSource.DataSource = players;
            var teams = this.GetTeams();
            teamBindingSource.DataSource = teams;
            GetTeamName(teamCbo.SelectedValue as int?);
        }

        public string GetTeamName(int? teamId)
        {
            if (teamId != null)
            {
                using (var context = new FootballInfoContext())
                {

                    var myTeamName = context.Teams.FirstOrDefault(t => t.Id == teamId);
                    if (myTeamName != null)
                    {
                        return myTeamName.Name;
                    }
                }
            }
            return string.Empty;     
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "TeamName")
            {
                var teamId = e.Value as int?;
                e.Value = GetTeamName(teamId);
            }
        }
        private int GetNextId()
        {
            var allPlayers = playerBindingSource.DataSource as List<Player>;
            var maximumId = allPlayers != null && allPlayers.Any() ? allPlayers.Max(x => x.Id) : 0;
            var returnValue = maximumId + 1;
            return returnValue;
        }

        private void createPlayerButton_Click(object sender, EventArgs e)
        {
            var player = new Player
            {
                FirstName = playerFirstName.Text.ToString(),
                LastName = playerLastName.Text.ToString(),
                Dob = DateTime.Parse(dateOfBirth.Text),
                Id = GetNextId(),
                TeamId = Convert.ToInt32(teamCbo.SelectedValue)
            };
            using (var context = new FootballInfoContext())
            {
                context.Players.Add(player);
                context.SaveChanges();
                LoadPlayers();
                playerFirstName.Clear();
                playerLastName.Clear();
            }
        }

        private void Players_Load(object sender, EventArgs e)
        {
            LoadPlayers();
        }

        private void deletePlayerButton_Click(object sender, EventArgs e)
        {
            var currentlySelected = playerBindingSource.Current as Player;
            if (currentlySelected != null)
            {
                using (var context = new FootballInfoContext())
                {
                    context.Players.Remove(currentlySelected);
                    context.SaveChanges();
                    LoadPlayers();
                }
            }
        }
    }
}
