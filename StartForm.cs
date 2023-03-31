using System;
using System.Windows.Forms;

namespace ComputerScienceInternalAssessment
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        //Limits the user from changing the size of the form.
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
        
        //Help button.
        private void StartHelpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TO START: Click the View Swimmer List Button." + "\n" + "TO EXIT: Click the Exit Button. ");
        }

        //Exit button. Closes the application.
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
