using MatchStat.Core;
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

namespace MatchStat.UI.Windows
{
    public partial class GoalRecordWindow : Form
    {
        
        //private Goal? goal
        //{
        //    get { return goalBindingSource.DataSource as Goal; }
        //    set { this.goalBindingSource.DataSource = value; }
        //}
        public GoalRecordWindow()
        {
            InitializeComponent();
        }
        private Goal[] GetGoals()
        {
            using (var context = new FootballInfoContext())
            {
                var goal = context.Goals.ToArray();
                return goal;
            }
        }
        private void LoadGoals()
        {
            var goals = GetGoals();
            this.goalBindingSource.DataSource = goals;
        }
        private string GetPlayerFullName(int playerId)
        {
            using (var context = new FootballInfoContext())
            {
                var playerName = context.Players.FirstOrDefault(p => p.Id == playerId);
                if (playerName != null)
                {
                    return playerName.FullName;
                }
                return "";
            }
        }
        private string GetMatchName(int matchId)
        {
            using(var context = new FootballInfoContext())
            {
                var matchName = context.MatchDetails.FirstOrDefault(p => p.Id == matchId);
                if (matchName != null)
                {
                    return matchName.MatchName;
                }
                return string.Empty;
            }
            
        }


        private void DataGridView1_cellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Index == 0)
            {
                int playerId;
                if (int.TryParse(e.Value?.ToString(), out playerId))
                {
                    e.Value = GetPlayerFullName(playerId);
                }
               
            }
            if (dataGridView1.Columns[e.ColumnIndex].Index == 1)
            {
                int matchId;
                if (int.TryParse(e.Value?.ToString(), out matchId))
                {
                    e.Value = GetMatchName(matchId);
                }

            }
        }

        private void button_CreateGoal_Click(object sender, EventArgs e)
        {
            GoalRecordInput goalFrm = new GoalRecordInput();
            goalFrm.SaveGoal += GoalSaved;
            goalFrm.ShowDialog();
        }
        private void GoalSaved(object sender, EventArgs e)
        {
            var goalRecordInput = sender as GoalRecordInput;

            var eventArgs = e as GoalSavedEventArguments;
            var savedMatch = eventArgs?.SavedGoals;

            goalRecordInput?.Close();
            LoadGoals();
        }


        private void GoalRecordWindow_Load(object sender, EventArgs e)
        {
            LoadGoals();
        }
    }
}
