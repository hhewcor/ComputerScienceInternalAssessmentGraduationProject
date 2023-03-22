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

        //SwimmerListForm instance;
        int index;
        SwimmerListForm instance;
        String swFirstName;
        String swLastName;
        String swGrd;
        String swGnd;
        String swStroke;
        String swDistance;

        String swGT;
        String swT;

        /*String swGTMin;
        String swGTSec;
        String swGTMil;
        String swTMin;
        String swTSec;
        String swTMil;
        */

        //rowIndex, this, SwimmerFn, SwimmerLn, SwimmerGrd, SwimmerGnd, stroke, distance, sGTMin, sGTSec, sGTMil, sTMin, sTSec, sTMil

        //Convert String of times to ints to avoid errors later.
        public EditSwimmerForm(int i, SwimmerListForm edL, String fn, String ln, String grd, String gd, String str, String dist, String swimmerGoalTime, String swimmerTime)
        {
            InitializeComponent();
            this.index = i;
            this.instance = edL;
            this.swFirstName = fn;
            this.swGrd = grd;
            this.swGnd = gd;
            this.swStroke = str;
            this.swDistance = dist;
            this.swGT = swimmerGoalTime;
            this.swT = swimmerTime;

            /*
            this.swGTMin = swGTM;
            this.swGTSec = swGTS;
            this.swGTMil = swGTML;
            this.swTMin = swTM;
            this.swTSec = swTS;
            this.swTMil = swTML;
            */
            
            //DataGridViewRow row = this.instance.SwimmerListDataGridView.Rows[e.RowIndex];
            //txtID.Text = row.Cells[0].Value.ToString();
            //FirstNameTxtBox.Text = t;
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
