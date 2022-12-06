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
    public partial class ExportSwimmerListForm : Form
    {
        public ExportSwimmerListForm()
        {
            InitializeComponent();
        }

        private void ExportSwimmerListForm_Load(object sender, EventArgs e)
        {

        }

        private void BackToSwimmerListFormBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SwimmerListForm swimmerList = new SwimmerListForm();
            swimmerList.Show();
        }
    }
}
