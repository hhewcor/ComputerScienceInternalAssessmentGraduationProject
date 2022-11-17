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
    public partial class CompareResultsForm : Form
    {
        public CompareResultsForm()
        {
            InitializeComponent();
        }

        private void CompareResultsForm_Load(object sender, EventArgs e)
        {

        }

        private void BackToCompareTimesFormBtn_Click(object sender, EventArgs e)
        {
            var CompareTimesForm = new CompareTimesForm();
            this.Hide();
            CompareTimesForm.Show();
        }
    }
}
