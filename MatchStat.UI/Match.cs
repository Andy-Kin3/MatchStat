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
    public partial class Match : Form
    {
        public Match()
        {
            InitializeComponent();
        }

        private void Match_Load(object sender, EventArgs e)
        {
            LoadMatch();
        }
        private void LoadMatch()
        {
            var matches = GetMatches();
            matchBindingSource.DataSource = matches;
        }

        private object GetMatches()
        {
            using(var context = new FootballInfoContext())
            {
                var matches = context.Matches.ToList();
                return matches;
            }
        }

        private void createMatchButton_Click(object sender, EventArgs e)
        {
            var matches = new Matches
            {
                Date = DateTime.Parse(matchDateTimePicker.Text),
            };
        }
    }
}
