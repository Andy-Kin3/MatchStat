using MatchStat.Database;
using MatchStat.DataModel.DataModels;
using MatchStat.Interfaces.Interfaces;
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
        IFieldsRepository _fieldsRepository;
        public FieldsWindow(IFieldsRepository fieldRepo)
        {
            InitializeComponent();
            _fieldsRepository = fieldRepo;
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
        private void LoadField()
        {
            fieldBindingSource.DataSource = _fieldsRepository.GetAll();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            _fieldsRepository.Add(field);
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
                _fieldsRepository.Delete(currentlySelected);
            }
        }
    }
}
