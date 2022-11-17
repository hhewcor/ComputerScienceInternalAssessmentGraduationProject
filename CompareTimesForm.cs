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
    public partial class CompareTimesForm : Form
    {
        public CompareTimesForm()
        {
            InitializeComponent();
        }

        private void CompareTimesForm_Load(object sender, EventArgs e)
        {

        }

        private void BackToStartFormBtn_Click(object sender, EventArgs e)
        {
            var StartForm = new StartForm();
            this.Hide();
            StartForm.Show();
        }

        private void CompareResultsBtn_Click(object sender, EventArgs e)
        {
            var CompareResultsForm = new CompareResultsForm();
            this.Hide();
            CompareResultsForm.Show();
        }
    }
}
