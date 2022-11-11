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
    public partial class CalculateTimesForm : Form
    {
        public CalculateTimesForm()
        {
            InitializeComponent();
        }

        private void CalculateTimesForm_Load(object sender, EventArgs e)
        {

        }

        private void BackToStartBtn_Click(object sender, EventArgs e)
        {
            var StartForm = new StartForm();
            this.Hide();
            StartForm.Show();
        }

        private void CalculateResultsFormBtn_Click(object sender, EventArgs e)
        {
            var CalculateResultsForm = new CalculateResultsForm();
            this.Hide();
            CalculateResultsForm.Show();
        }
    }
}
