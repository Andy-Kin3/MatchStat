using ExpressMapper.Extensions;
using MatchStat.DataModel.DataModels;
using System.Data;

namespace MatchStat.UI.Windows
{
    public partial class MatchesWindow2 : Form
    {
        public MatchesWindow2()
        {
            InitializeComponent();
        }

        private MatchDetail? match
        {
            get { return this.bindingSource_matchDetail.DataSource as MatchDetail; }
            set
            {
                this.bindingSource_matchDetail.DataSource = value;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveMatchToDatabase(match);
            LoadAllMatches();
        }

        private void SaveMatchToDatabase(MatchDetail match)
        {
            using (var context = new FootballInfoContext())
            {
                var m = match.Map<MatchDetail, Match>();
                if (m.Id == 0)
                {
                    m.Id = GetNextId();
                }
                context.MatchDetail.Update(m);
                context.SaveChanges();
            }
        }

        private int GetNextId()
        {
            var allMatches = matchDetailBindingSource.DataSource as MatchDetail[];
            var maximumId = allMatches != null && allMatches.Any() ? allMatches.Max(m => m.Id) : 0;
            var nextMatchId = maximumId + 1;
            return nextMatchId;
        }

        private void MatchesWindow2_Load(object sender, EventArgs e)
        {
            var teams = GetAllTeams();
            this.team1BindingSource.DataSource = teams;
            this.team2BindingSource.DataSource = teams;
            this.tournamentBindingSource.DataSource = GetAllTournaments();
            this.fieldsBindingSource.DataSource = GetAllFields();

            LoadAllMatches();
            addButton_Click(null, null);
        }

        private void LoadAllMatches()
        {
            var matches = GetAllMatches();
            this.matchDetailBindingSource.DataSource = matches;
        }

        private MatchDetail[] GetAllMatches()
        {
            using (var context = new FootballInfoContext())
            {
                var matches = context.MatchDetails.OrderBy(m => m.Id).ToArray();
                return matches;
            }
        }

        private Fields[] GetAllFields()
        {
            using (var context = new FootballInfoContext())
            {
                return context.Fields.OrderBy(r => r.Name).ToArray();
            }
        }

        private Tournament[] GetAllTournaments()
        {
            using (var context = new FootballInfoContext())
            {
                return context.Tournaments.OrderBy(t => t.Name).ToArray();
            }
        }

        private Team[] GetAllTeams()
        {
            using (var context = new FootballInfoContext())
            {
                return context.Teams.OrderBy(t => t.Name).ToArray();
            }
        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.matchesMenu.Show(MousePosition);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.match = new MatchDetail { Date = DateTime.Now };
        }


        private void editButton_Click(object sender, EventArgs e)
        {
            var currentMatch = GetSelectedMatch();
            if (currentMatch != null)
            {
                this.match = currentMatch;
            }
        }

        private MatchDetail? GetSelectedMatch()
        {
            return this.matchDetailBindingSource.Current as MatchDetail;
        }

        private void deleteButton2_Click(object sender, EventArgs e)
        {
            var currentMatch = GetSelectedMatch();
            if (currentMatch != null)
            {
                DeleteMatch(currentMatch);
                LoadAllMatches();
            }
        }

        private void DeleteMatch(MatchDetail currentMatch)
        {
            using (var context = new FootballInfoContext())
            {
                var m = context.MatchDetails.FirstOrDefault(m => m.Id == currentMatch.Id);
                if (m != null)
                {
                    context.MatchDetails.Remove(m);
                    context.SaveChanges();
                }
            }
        }
    }
}
