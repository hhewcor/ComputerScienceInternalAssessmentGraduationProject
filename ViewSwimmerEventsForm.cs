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
    public partial class ViewSwimmerEventsForm : Form
    {
        public ViewSwimmerEventsForm()
        {
            InitializeComponent();
        }

        private void ViewSwimmerEventsForm_Load(object sender, EventArgs e)
        {

        }

        private void BackToSwimmerListFormBtn_Click(object sender, EventArgs e)
        {
            var SwimmerListForm = new SwimmerListForm();
            this.Hide();
            SwimmerListForm.Show();
        }

        private void EditSwimmerEventsFormBtn_Click(object sender, EventArgs e)
        {
            var EditSwimmerEventsForm = new EditSwimmerEventsForm();
            this.Hide();
            EditSwimmerEventsForm.Show();
        }
    }
}
