﻿using ComputerScienceInternalAssessment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TreeView = System.Windows.Forms.TreeView;

namespace ComputerScienceInternalAssessment
{
    public partial class SwimmerListForm : Form
    {
        private readonly DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

        // DataTable _dt = new DataTable();
        // bool isXML = false;


        public SwimmerListForm()
        {
            InitializeComponent();
            constructSwimmerListDataGridView();

        }

        private void SwimmerListForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToScreen();
            this.ControlBox = false;
        }

        private void constructSwimmerListDataGridView()
        {
            //add columns
            SwimmerListDataGridView.ColumnCount = 4;
            SwimmerListDataGridView.Columns[0].Name = "First Name";
            //SwimmerListDataGridView.Columns[0].ReadOnly = true;

            SwimmerListDataGridView.Columns[1].Name = "Last Name";
            // SwimmerListDataGridView.Columns[1].ReadOnly = true;

            SwimmerListDataGridView.Columns[2].Name = "Grade";
            //SwimmerListDataGridView.Columns[2].ReadOnly = true;

            SwimmerListDataGridView.Columns[3].Name = "M/F";
            //SwimmerListDataGridView.Columns[3].ReadOnly = true;

            SwimmerListDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //addButtonColumn();

            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "VIEW";
            col.Name = "SwimmerEvents";
            SwimmerListDataGridView.Columns.Add(col);

            addRows();

        }

        private void addRows()
        {
            foreach (var swimmer in getSwimmerList())
            {
                SwimmerListDataGridView.Rows.Add(swimmer.FirstName, swimmer.LastName, swimmer.Grade, swimmer.Gender);
            }
        }

        private void addButtonColumn()
        {
            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "VIEW";
            col.Name = "SwimmerEvents";
            SwimmerListDataGridView.Columns.Add(col);
        }

        private void swimmerListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == this.SwimmerListDataGridView.Columns["SwimmerEvents"].Index) && (e.RowIndex >= 0))
            {
                this.Hide();
                ViewSwimmerEventsForm EventsForm = new ViewSwimmerEventsForm();
                EventsForm.Show();
            }
        }

        //This will generate a generic list for testing purposes.
        //Need to fix so that the user can add and remove swimmers.
        //Also need to add the criteria that Grade can only be integers
        //Also need to add the criteria that Gender can only be one letter long.

        private List<Swimmer> getSwimmerList()
        {
            List<Swimmer> swimmers = new List<Swimmer>();
            Swimmer s = new Swimmer()
            {
                FirstName = "Robin",
                LastName = "Hood",
                Grade = "10",
                Gender = "M"

            };
            swimmers.Add(s);
            s = new Swimmer()
            {
                FirstName = "Bat",
                LastName = "Man",
                Grade = "11",
                Gender = "M"

            };
            swimmers.Add(s);
            s = new Swimmer()
            {
                FirstName = "Princess",
                LastName = "Leia",
                Grade = "12",
                Gender = "F"

            };
            swimmers.Add(s);
            s = new Swimmer()
            {
                FirstName = "Princess",
                LastName = "Peach",
                Grade = "9",
                Gender = "F"
            };
            swimmers.Add(s);
            s = new Swimmer()
            {
                FirstName = "Spider",
                LastName = "Man",
                Grade = "9",
                Gender = "M"

            };
            swimmers.Add(s);
            return swimmers;
        }

        private void BackToStartBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm stForm = new StartForm();
            stForm.Show();
        }

        private void SwimmerListHelpBtn_Click(object sender, EventArgs e)
        {

        }

        private void SearchFirstNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchLastNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchSwimmerNameBtn_Click(object sender, EventArgs e)
        {

        }

        int t1 = 25;

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            this.FilterPanel.Size = new Size(this.FilterPanel.Size.Width, t1);
            timer1.Start();
        }

        private void FilterBtn_MouseHover(object sender, EventArgs e)
        {
            t1 = 25;
            this.FilterPanel.Size = new Size(this.FilterPanel.Size.Width, t1);

        }

        private void FilterBtn_MouseLeave(object sender, EventArgs e)
        {
            timer1.Stop();
            // t1 = 25;
            // this.FilterPanel.Size = new Size(this.FilterPanel.Size.Width, t1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (t1 > 175)
            {
                timer1.Stop();
            }
            else
            {
                this.FilterPanel.Size = new Size(this.FilterPanel.Size.Width, t1);
                t1 += 25;
            }
        }

        private void FilterNinthGradeBtn_Click(object sender, EventArgs e)
        {

        }

        private void FilterTenthGradeBtn_Click(object sender, EventArgs e)
        {

        }

        private void FilterEleventhGradeBtn_Click(object sender, EventArgs e)
        {

        }

        private void FilterTwelthGradeBtn_Click(object sender, EventArgs e)
        {

        }

        private void FilterMaleBtn_Click(object sender, EventArgs e)
        {

        }

        private void FilterFemaleBtn_Click(object sender, EventArgs e)
        {

        }

        private void EditSwimmerListBtn_Click(object sender, EventArgs e)
        {
            
            var EditSwimmerListForm = new EditSwimmerListForm();
            this.Hide();
            EditSwimmerListForm.Show();

        }

        private void constructTreeView()
        {
            TreeNode treeNode = new TreeNode("Robin Hood");
            treeView1.Nodes.Add(treeNode);
          
        }

        private void ImportBtn_Click(object sender, EventArgs e)
        {
            var ImportForm = new ImportForm();
            this.Hide();
            ImportForm.Show();
        }

        private void ExportSwimmerListBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExportSwimmerListForm exForm = new ExportSwimmerListForm();
            exForm.Show();
        }

        /*
        void SwimmerListDataGridView_DataBindingComplete(object sender,
        DataGridViewBindingCompleteEventArgs e)
        {
            SwimmerListDataGridView.Rows[1].Cells["MyButton"] = new DataGridViewTextBoxCell();
        }
        */
        /*
       private void SwimmerListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
       {

           //DataGridViewCellEventArgs e
           //System.Windows.FormsDataGridViewCellEventArgs e
           if (SwimmerListDataGridView.Columns[e.ColumnIndex].Name == "MyButton")
               {
                   // button clicked - do some logic
               }
               DataGridViewCell cell = (DataGridViewCell)SwimmerListDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];

           if (cell.ColumnIndex == this.SwimmerListDataGridView.Columns["SwimmerEvents"].Index) 
           {
                   this.Hide();
                   EditSwimmerListForm editForm = new EditSwimmerListForm();
                   editForm.Show();
           }
       }


       /*
        * if(Loop){
        * try{
        *          this.Hide();
                   EditSwimmerListForm editForm = new EditSwimmerListForm();
                   editForm.Show();
        * }
        * catch (Exception exception) {
        * Console.WriteLine(exception.Message);
        * }
        * }
        * */

        /* private void SwimmerListDataGridView_CellEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == SwimmerListDataGridView.Columns["View"].Index)
            {
                SwimmerListDataGridView.Columns["View"].ReadOnly = false;  // set all row as read-only
                SwimmerListDataGridView.CellClick += SwimmerListDataGridView_CellClick;
            }
       //SwimmerListDataGridView.CellClick += SwimmerListDataGridView_CellClick;
        }*/
        /*
        private void makeSwimmerListReadOnly()
        {
            SwimmerListDataGridView.AllowUserToAddRows = false;
            SwimmerListDataGridView.AllowUserToDeleteRows = false;
            SwimmerListDataGridView.ReadOnly = true;
        }
        */
    }
}

