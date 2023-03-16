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
    public partial class MatchRecordWindow : Form
    {
        public MatchRecordWindow()
        {
            InitializeComponent();
        }
        private MatchDetail? matchDetail
        {
            get { return this.matchDetailBindingSource.DataSource as MatchDetail; }
            set { this.matchDetailBindingSource.DataSource = value; }
        }

        private MatchDetail[] GetMatchDetail()
        {
            using (var context = new FootballInfoContext())
            {
                var marches = context.MatchDetails.ToArray();
                return marches;
            }
        }
        private void LoadMatchRecords()
        {
            this.matchDetailBindingSource.DataSource = GetMatchDetail();
        }

        private void MatchRecordWindow_Load(object sender, EventArgs e)
        {
            LoadMatchRecords();
        }
    }
}
