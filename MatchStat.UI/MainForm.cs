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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tournamentbutton_Click(object sender, EventArgs e)
        {
           var tournamentStatistics = new TournamentStatistics();
            tournamentStatistics.Show();
        }

        private void playerButton_Click(object sender, EventArgs e)
        {
            var players = new Players();
            players.Show();
        }
        private void teamButton_Click(Object sender, EventArgs e)
        {
            var team = new Teams();
            team.Show();
        }

        private void fieldButton_Click(object sender, EventArgs e)
        {
            var fields = new Field();
            fields.Show();
        }
    }
}
