using MatchStat.Database;
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
    public partial class FieldsWindow : Form
    {
        public FieldsWindow()
        {
            InitializeComponent();
        }
        private Field? field
        {
            get { return this.fieldBindingSource.DataSource as Field; }
            set
            {
                this.fieldBindingSource.DataSource = value;
            }
        }

        private void Field_Load(object sender, EventArgs e)
        {
            LoadField();
        }

        private object GetField()
        {
            using (var context = new FootballInfoContext())
            {
                var fields = context.Fields.ToList();
                return fields;
            };
        }
        private void LoadField()
        {
            fieldBindingSource.DataSource = GetField();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            using (var context = new FootballInfoContext())
            {
                var f = field;
                context.Fields.Add(f);
                context.SaveChanges();
                LoadField();
                stadiumTextBox.Clear();
                countryTextBox.Clear();
            };
        }
        //private int GetNextId()
        //{
        //    var allfields = fieldBindingSource.DataSource as List<Fields>;
        //    var maximumId = allfields != null && allfields.Any() ? allfields.Max(x => x.Id) : 0;
        //    return maximumId + 1;
        //}

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var currentlySelected = fieldBindingSource.DataSource as Field;
            if (currentlySelected != null)
            {
                using (var context = new FootballInfoContext())
                {
                    context.Fields.Remove(currentlySelected);
                    context.SaveChanges();
                    LoadField();

                }
            }
        }
    }
}
