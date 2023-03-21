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

        public bool check = true;
        private String answer;

        //ENDED HERE
        public bool checkInfo()
        {
            answer = "";
            //bool conditionOne = checkSelectedName();
            //bool conditionTwo = checkSelectedGrade();
            // bool conditionThree = checkGenderSelected();
            // bool conditionFour = checkStrokeSelected();
            // bool conditionFive = checkDistanceSelected();
            // bool conditionSix = checkEvent();
            // bool conditionSeven = checkGT();
            // bool conditionEight = checkTime();

            /*
            if (conditionOne == false)
            {
                return false;
            }
            else if (conditionTwo == false)
            {
                return false;
            }
            else if (conditionThree == false)
            {
                return false;
            }
            else if (conditionFour == false)
            {
                return false;
            }
            else if (conditionFive == false)
            {
                return false;
            }
            else if (conditionSix == false)
            {
                return false;
            }
            else if (conditionSeven == false)
            {
                return false;
            }
            else if (conditionEight == false)
            {
                return false;
            }
            else
            {
                return true;
            }
            */
            return false;
        }
    

        private void BackToSwimmerListFormBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
