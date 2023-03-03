using MatchStat.DataModel.DataModels;

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

            FillList(matches);
        }

        private List<Matches> GetMatches()
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

            var matches = new Matches
            {
                Date = DateTime.Parse(matchDateTimePicker.Text),
                Team1Id = Convert.ToInt32(team1Cbo.SelectedValue),
                Team2Id = Convert.ToInt32(team2Cbo.SelectedValue),
                TournamentId = Convert.ToInt32(tourCbo.SelectedValue),
                FieldId = Convert.ToInt32(fieldcbo.SelectedValue),
                Id = GetNextID()
            };
            using (var context =  new FootballInfoContext())
            {
                Add(Convert.ToDateTime(matchDateTimePicker.Text), team1Cbo.Text, team2Cbo.Text, tourCbo.Text, fieldcbo.Text);
                context.Matches.Add(matches);
                context.SaveChanges();
                LoadMatches();
            }

            LoadMatches();
        }
        private void Add(DateTime matchDate, string team1, string team2, string tournament, string field)
        {
            
            string[] row = {Convert.ToString(matchDate.TimeOfDay), team1, team2, tournament, field };
            ListViewItem item = new ListViewItem(row);
            listView1.Items.Add(item);
        }
        private void FillList(List<Matches> myMatch)
        {
            listView1.Items.Clear();
            
            foreach(var match in myMatch)
            {
                string[] row = { Convert.ToString(match.Date.TimeOfDay), Convert.ToString(match.Team1Id), Convert.ToString(match.Team2Id), Convert.ToString(match.TournamentId), Convert.ToString(match.FieldId) };
                listView1.Items.Add(new ListViewItem(row));
            }
        }

        private int GetNextID()
        {
            var allMatches = matchBindingSource.DataSource as List<Matches>;
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

            var allMatches = matchBindingSource.DataSource as List<Matches>;
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

    }
}
