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
            constructEditSwimmerListDataGridView();
        }

        private void EditSwimmerListForm_Load(object sender, EventArgs e)
        {

        }

        private void constructEditSwimmerListDataGridView()
        {

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
