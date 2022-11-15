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
    public partial class SwimmerListForm : Form
    {
        public SwimmerListForm()
        {
            InitializeComponent();
            
        }

        private void SwimmerListForm_Load(object sender, EventArgs e)
        {
            
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

        private void SwimmerListDataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Need to add the swimmer exclusive information into the form.
            var ViewSwimmerEventsForm = new ViewSwimmerEventsForm();
            this.Hide();
            ViewSwimmerEventsForm.Show();
        }
    }
}
