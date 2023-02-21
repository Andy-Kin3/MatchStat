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

        private void LoadPlayers()
        {
            var players = this.GetPlayer();
            playerBindingSource.DataSource = players;
        }

        private int GetNextId()
        {
            var allPlayers = playerBindingSource.DataSource as List<Tournament>;
            var maximumId = allPlayers != null && allPlayers.Any() ? allPlayers.Max(x => x.Id) : 0;
            return maximumId + 1;
        }

        private void createPlayerButton_Click(object sender, EventArgs e)
        {
            var player = new Player
            {
                FirstName = playerFirstName.Text.ToString(),
                LastName = playerLastName.Text.ToString(),
                Dob = DateTime.Parse(dateOfBirth.Text),
                Id= GetNextId(),
            };
            using (var context = new FootballInfoContext())
            {
                context.Players.Add(player);
                context.SaveChanges();
                LoadPlayers();
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
