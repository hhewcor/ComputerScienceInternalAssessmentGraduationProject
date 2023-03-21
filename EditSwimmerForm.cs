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
    public partial class EditSwimmerForm : Form
    {

        SwimmerListForm instance;

        public EditSwimmerForm(SwimmerListForm sLF)
        {
            InitializeComponent();
            this.instance = sLF;
        }

        /*
        public SwimmerListForm(Swimmer s)
        {
            s
        }
        */
        //Trying to work on passing information between forms!
        private void EditSwimmerForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToScreen();
            this.ControlBox = false;
        }

        private void BackToSwimmerListFormBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
