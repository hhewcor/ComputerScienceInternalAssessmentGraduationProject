using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerScienceInternalAssessment
{
    public partial class EditSwimmerListForm : Form
    {
        public EditSwimmerListForm()
        {
            InitializeComponent();
            ConstructEditSwimmerListDataGridView();
        }

        private void EditSwimmerListForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ConstructEditSwimmerListDataGridView()
        {
            EditSwimmerListDataGridView.ColumnCount = 4;
            EditSwimmerListDataGridView.Columns[0].Name = "First Name";

            EditSwimmerListDataGridView.Columns[1].Name = "Last Name";

            EditSwimmerListDataGridView.Columns[2].Name = "Grade";

            EditSwimmerListDataGridView.Columns[3].Name = "M/F";

            EditSwimmerListDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //EditSwimmerListDataGridView.copyData();

            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "DELETE";
            col.Name = "Delete Swimmer";
            EditSwimmerListDataGridView.Columns.Add(col);
        }

        private void BackToSwimmerListFormBtn_Click(object sender, EventArgs e)
        {
            var SwimmerListForm = new SwimmerListForm();
            this.Hide();
            SwimmerListForm.Show();
        }

        private void SaveSwimmerListFormBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
