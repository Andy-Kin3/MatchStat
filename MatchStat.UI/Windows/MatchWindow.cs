using MatchStat.DataModel.DataModels;

namespace MatchStat.UI
{
    public partial class MatchWindow : Form
    {
        public MatchWindow()
        {
            InitializeComponent();
        }

        private void Match_Load(object sender, EventArgs e)
        {
            LoadMatches();
            listView1.BackColor= Color.Turquoise;
        }
        private void LoadMatches()
        {
            var matches = this.GetMatches();
            matchBindingSource.DataSource = matches;
            var myTeam = this.GetTeams();
            teamBindingSource.DataSource = myTeam;
            var Dteam = this.GetTeams();
            teamBindingSource1.DataSource = Dteam;
            var field = this.GetFields();
            fieldsBindingSource.DataSource = field;
            var myTournament = this.GetTournament();
            tournamentBindingSource.DataSource = myTournament;

            FillListView(matches);
        }

        private List<Match> GetMatches()
        {
            using (var context = new FootballInfoContext())
            {
                var matches = context.Matches.ToList();
                return matches;
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
        private List<Fields> GetFields()
        {
            using(var context = new FootballInfoContext())
            {
                var fields = context.Fields.ToList();
                return fields;
            }
        }
        private List<Tournament> GetTournament()
        {
            using(var context = new FootballInfoContext())
            {
                var tournament = context.Tournaments.ToList();
                return tournament;
            }
        }

        private void CreateMatchButton_Click(object sender, EventArgs e)
        {

            var matches = new Match
            {
                Date = matchDateTimePicker.Value,
                Team1Id = Convert.ToInt32(team1Cbo.SelectedValue),
                Team2Id = Convert.ToInt32(team2Cbo.SelectedValue),
                TournamentId = Convert.ToInt32(tourCbo.SelectedValue),
                FieldId = Convert.ToInt32(fieldcbo.SelectedValue),
                TeamOneScore = Convert.ToInt32(teamOneScore.Value),
                TeamTwoScore = Convert.ToInt32(teamTwoScore.Value),
                Id = GetNextID()
            };
            using (var context =  new FootballInfoContext())
            {
                Add(Convert.ToDateTime(matchDateTimePicker.Text), team1Cbo.Text, team2Cbo.Text, tourCbo.Text, fieldcbo.Text);
                 
                context.Matches.Add(matches);
                context.SaveChanges();
            }

            LoadMatches();
        }
        private void Add(DateTime matchDate, string team1, string team2, string tournament, string field)
        {
            
            string[] row = {Convert.ToString(matchDate.TimeOfDay), team1, team2, tournament, field };
            ListViewItem item = new ListViewItem(row);
            listView1.Items.Add(item);
        }
        private void FillListView(List<Match> myMatch)
        {
            listView1.Items.Clear();
            
            foreach(var match in myMatch)
            {
                string[] row = { Convert.ToString(match.Date), GetMatchesToBePlayed(match.Team1Id, match.Team2Id), GetTournamentName(match.TournamentId), GetFieldName(match.FieldId) };
                listView1.Items.Add(new ListViewItem(row));
            }
        }

        private string GetFieldName(int fieldId)
        {
            using (var context = new FootballInfoContext())
            {
                var field = context.Fields.FirstOrDefault(t => t.Id == fieldId);
                if (field != null)
                {
                    return field.Name;
                }
                return null;
            }
        }

        private string GetTournamentName(int? tournamentId)
        {
            using (var context = new FootballInfoContext())
            {
                var tournament = context.Tournaments.FirstOrDefault(t => t.Id == tournamentId);
                if (tournament != null)
                {
                    return tournament.Name;
                }
                return null;
            }
        }

        private string GetMatchesToBePlayed(int teamId, int team2Id)
        {
            using (var context = new FootballInfoContext())
            {
                var team = context.Teams.FirstOrDefault(t => t.Id.Equals(teamId));
                var team2 = context.Teams.FirstOrDefault(t => t.Id.Equals(team2Id));
                if (team != null && team2 != null)
                {
                    return $"{team.Name}  VS  {team2.Name}";
                }
                return string.Empty;
            }
        }

        private int GetNextID()
        {
            var allMatches = matchBindingSource.DataSource as List<Match>;
            var maximumId = allMatches != null && allMatches.Any() ? allMatches.Max(e => e.Id) : 0;
            var nextId = maximumId + 1;
            return nextId;
        }

        private void DeleteMatchButton_Click(object sender, EventArgs e)
        {
            var focussedItemIndex = listView1.FocusedItem?.Index;
            if(focussedItemIndex.HasValue == false)
            {
                return;
            }

            var allMatches = matchBindingSource.DataSource as List<Match>;
            if(allMatches == null || allMatches.Any() == false)
            {
                return;
            }

            var matchToDelete = allMatches[focussedItemIndex.Value];
            if(matchToDelete != null)
            {
                using(var context = new FootballInfoContext())
                {
                    context.Matches.Remove(matchToDelete);
                    context.SaveChanges();
                    LoadMatches();
                }
            }
        }

        private void listciew1_clicked(object sender, MouseEventArgs e)
        {
            matchDateTimePicker.Text = listView1.SelectedItems[0].SubItems[0].Text;
            tourCbo.Text = listView1.SelectedItems[0].SubItems[2].Text;
            fieldcbo.Text = listView1.SelectedItems[0].SubItems[3].Text;
        }
    }
}
