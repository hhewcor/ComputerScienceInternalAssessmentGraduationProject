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
            col.Text = "Edit";
            col.Name = "Edit Swimmer";
            EditSwimmerListDataGridView.Columns.Add(col);

            DataGridViewButtonColumn col2 = new DataGridViewButtonColumn();
            col2.UseColumnTextForButtonValue = true;
            col2.Text = "Delete";
            col2.Name = "Delete Swimmer";
            EditSwimmerListDataGridView.Columns.Add(col2);

            copyData();

            EditSwimmerListDataGridView.AllowUserToAddRows = false;

            //AddRows();

        }


        public void copyData()
        {
            SwimmerListForm f = new SwimmerListForm();
            foreach (var swimmer in f.GetSwimmerList())
            {
                EditSwimmerListDataGridView.Rows.Add(swimmer.FirstName, swimmer.LastName, swimmer.Grade, swimmer.Gender, swimmer.SwimmerEvent, swimmer.GoalTime, swimmer.Time);
            }
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

        private void EditSwimmerListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Swimmer[] swimmers = f.GetSwimmerList().ToArray();
            if ((e.ColumnIndex == this.EditSwimmerListDataGridView.Columns["Edit Swimmer"].Index) && (e.RowIndex >= 0))
            {
                try
                {

                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }

            if ((e.ColumnIndex == this.EditSwimmerListDataGridView.Columns["Delete Swimmer"].Index) && (e.RowIndex >= 0))
            {
                try
                {

                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }


        private void FilterNinthGradeBtn_Click(object sender, EventArgs e)
        {
            string word = "9";

            foreach (DataGridViewRow row in EditSwimmerListDataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if ((cell.ColumnIndex == 2) && (cell.Value != word)) //Set your Column Index
                    {
                        row.Visible = false;
                    }
                }
            }
            EditSwimmerListDataGridView.AllowUserToAddRows = true;
        }

        private void FilterTenthGradeBtn_Click(object sender, EventArgs e)
        {
            string word = "10";

            foreach (DataGridViewRow row in EditSwimmerListDataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if ((cell.ColumnIndex == 2) && (cell.Value != word)) //Set your Column Index
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void FilterEleventhGradeBtn_Click(object sender, EventArgs e)
        {
            string word = "11";

            foreach (DataGridViewRow row in EditSwimmerListDataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if ((cell.ColumnIndex == 2) && (cell.Value != word)) //Set your Column Index
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void FilterTwelthGradeBtn_Click(object sender, EventArgs e)
        {
            string word = "12";

            foreach (DataGridViewRow row in EditSwimmerListDataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if ((cell.ColumnIndex == 2) && (cell.Value != word)) //Set your Column Index
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void FilterMaleBtn_Click(object sender, EventArgs e)
        {
            string word = "M";

            foreach (DataGridViewRow row in EditSwimmerListDataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if ((cell.ColumnIndex == 3) && (cell.Value != word)) //Set your Column Index
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void FilterFemaleBtn_Click(object sender, EventArgs e)
        {
            string word = "F";

            foreach (DataGridViewRow row in EditSwimmerListDataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if ((cell.ColumnIndex == 3) && (cell.Value != word)) //Set your Column Index
                    {
                        row.Visible = false;

                    }
                }
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in EditSwimmerListDataGridView.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
