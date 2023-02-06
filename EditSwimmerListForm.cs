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
            
            /*
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
            */

            //add columns
            EditSwimmerListDataGridView.ColumnCount = 7;

            EditSwimmerListDataGridView.Columns[0].Name = "First Name";
            //SwimmerListDataGridView.Columns[0].ReadOnly = true;

            EditSwimmerListDataGridView.Columns[1].Name = "Last Name";
            // SwimmerListDataGridView.Columns[1].ReadOnly = true;

            EditSwimmerListDataGridView.Columns[2].Name = "Grade";
            //SwimmerListDataGridView.Columns[2].ReadOnly = true;

            EditSwimmerListDataGridView.Columns[3].Name = "Gender";
            //SwimmerListDataGridView.Columns[3].ReadOnly = true;

            EditSwimmerListDataGridView.Columns[4].Name = "Event";

            EditSwimmerListDataGridView.Columns[5].Name = "Goal Time";

            EditSwimmerListDataGridView.Columns[6].Name = "Swimmer Time";

            EditSwimmerListDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //addButtonColumn();

            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "Delete";
            col.Name = "Delete Swimmer";
            EditSwimmerListDataGridView.Columns.Add(col);

            foreach (DataGridViewColumn column in EditSwimmerListDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //AddRows();
            
        }

        private void BackToSwimmerListFormBtn_Click(object sender, EventArgs e)
        {
            var SwimmerListForm = new SwimmerListForm();
            this.Hide();
            SwimmerListForm.Show();
        }

        int t1 = 25;

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            this.FilterPanel.Size = new Size(this.FilterPanel.Size.Width, t1);
            Timer1.Start();
        }

        private void FilterBtn_MouseHover(object sender, EventArgs e)
        {
            t1 = 25;
            this.FilterPanel.Size = new Size(this.FilterPanel.Size.Width, t1);

        }

        private void FilterBtn_MouseLeave(object sender, EventArgs e)
        {
            Timer1.Stop();
            // t1 = 25;
            // this.FilterPanel.Size = new Size(this.FilterPanel.Size.Width, t1);
        }

        private void SaveSwimmerListFormBtn_Click(object sender, EventArgs e)
        {

        }

        private void EditSwimmerListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
