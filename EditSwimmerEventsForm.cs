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
    public partial class EditSwimmerEventsForm : Form
    {
        public EditSwimmerEventsForm()
        {
            InitializeComponent();
        }

        private void EditSwimmerEventsForm_Load(object sender, EventArgs e)
        {

        }

        private void BackToViewSwimmerEventsFormBtn_Click(object sender, EventArgs e)
        {
            var ViewSwimmerEventsForm = new ViewSwimmerEventsForm();
            this.Hide();
            ViewSwimmerEventsForm.Show();
        }

        private void SaveSwimmerEventsFormBtn_Click(object sender, EventArgs e)
        {
            //Add updates to ViewSwimmerEventsForm
            var ViewSwimmerEventsForm = new ViewSwimmerEventsForm();
            this.Hide();
            ViewSwimmerEventsForm.Show();
        }
    }
}
