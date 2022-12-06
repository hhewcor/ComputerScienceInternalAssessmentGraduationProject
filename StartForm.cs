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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToScreen();
            this.ControlBox = false;
            

        }

        //When ViewSwimmerListBtn is clicked it will open the SwimmerList Page.
        private void ViewSwimmerListBtn_Click(object sender, EventArgs e)
        {
            var SwimmerListForm = new SwimmerListForm();
            this.Hide();
            SwimmerListForm.Show();
        }

        private void CompareTimesBtn_Click(object sender, EventArgs e)
        {
            var CompareTimesForm = new CompareTimesForm();
            this.Hide();
            CompareTimesForm.Show();
        }

        private void CalculateTimesBtn_Click(object sender, EventArgs e)
        {
            var CalculateTimesForm = new CalculateTimesForm();
            this.Hide();
            CalculateTimesForm.Show();
        }

        private void StartHelpBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
