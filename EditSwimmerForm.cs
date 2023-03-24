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
        //int index;
        SwimmerListForm instance;
        String swFirstName;
        String swLastName;
        String swGrade;
        String swGender;
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
        public EditSwimmerForm(SwimmerListForm edL, String fn, String ln, String grd, String gd, String str, String dist, String swimmerGoalTime, String swimmerTime)
        {
            InitializeComponent();
            //this.index = i;
            this.instance = edL;
            this.swFirstName = fn;
            this.swLastName = ln;
            this.swGrade = grd;
            this.swGender = gd;
            this.swStroke = str;
            this.swDistance = dist;
            this.swGT = swimmerGoalTime;
            this.swT = swimmerTime;

            string[] splitGoalTime = swimmerGoalTime.Split(':', '.');
            string[] splitTime = swimmerTime.Split(':', '.');

            int length = splitGoalTime.Length;

            if (splitGoalTime.Length == 3)
            {
                SwimmerGoalTimeMinTxtBox.Text = splitGoalTime[0];
                SwimmerGoalTimeSecTxtBox.Text = splitGoalTime[1];
                SwimmerGoalTimeMilTxtBox.Text = splitGoalTime[2];
            }
            else if (splitGoalTime.Length == 2)
            {
                SwimmerGoalTimeMinTxtBox.Text = "";
                SwimmerGoalTimeSecTxtBox.Text = splitGoalTime[0];
                SwimmerGoalTimeMilTxtBox.Text = splitGoalTime[1];
            }

            if (splitTime.Length == 3)
            {
                SwimmerTimeMinTxtBox.Text = splitTime[0];
                SwimmerTimeSecTxtBox.Text = splitTime[1];
                SwimmerTimeMilTxtBox.Text = splitTime[2];
            }
            else if (splitTime.Length == 2)
            {
                SwimmerTimeMinTxtBox.Text = "";
                SwimmerTimeSecTxtBox.Text = splitTime[0];
                SwimmerTimeMilTxtBox.Text = splitTime[1];
            }

            setVariables();
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

        private bool swFirstNameSelected = true;
        private bool swLastNameSelected = true;
        private bool swGradeSelected = true;
        private bool swGenderSelected = true;
        private bool swStrokeSelected = true;
        private bool swDistanceSelected = true;

        private bool swGoalTimeMinSelected = true;
        private bool swGoalTimeSecSelected = true;
        private bool swGoalTimeMilSelected = true;

        private bool swTimeMinSelected = true;
        private bool swTimeSecSelected = true;
        private bool swTimeMilSelected = true;

        public bool checkEdit = true;
        public String swEvent = "";

        private void setVariables()
        {
            FirstNameTxtBox.Text = swFirstName;
            LastNameTxtBox.Text = swLastName;

            //Sets grade level
            if(swGrade == "9")
            {
                NinthGradeRadioBtn.Checked = true;
            }
            else if(swGrade == "10")
            {
                TenthGradeRadioBtn.Checked = true;
            }
            else if(swGrade == "11")
            {
                EleventhGradeRadioBtn.Checked = true;
            }
            else if(swGrade == "12")
            {
                TwelthGradeRadioBtn.Checked = true;
            }


            //Set gender
            if(swGender == "M")
            {
                MaleRadioBtn.Checked = true;
            }
            else if(swGender == "F")
            {
                FemaleRadioBtn.Checked = true;
            }

            //Set stroke
            if(swStroke == "fl")
            {
                FlyStrRadioBtn.Checked = true;
            }
            else if(swStroke == "bk")
            {
                BackStrRadioBtn.Checked = true;
            }
            else if(swStroke == "br")
            {
                BreastStrRadioBtn.Checked = true;
            }
            else if(swStroke == "fr")
            {
                FreeStrRadioBtn.Checked = true;
            }
            else if (swStroke == "IM")
            {
                IMstrRadioBtn.Checked = true;
            }

            //Set Distance
            if(swDistance == "50")
            {
                Dist50RadioBtn.Checked = true;
            }
            else if(swDistance == "100")
            {
                Dist100RadioBtn.Checked = true;
            }
            else if(swDistance == "200")
            {
                Dist200RadioBtn.Checked = true;
            }
            else if(swDistance == "500")
            {
                Dist500RadioBtn.Checked = true;
            }
        }




        //public bool check = true;
        private String answer;

        //ENDED HERE
        private void UpdateSwimmerBtn_Click(object sender, EventArgs e)
        {
            checkEdit = checkInfo();

            if (checkEdit == true)
            {
                answer = "Swimmer Updated.";

                swEvent = swDistance + " " + swStroke;
                combineSwGT();
                combineSWT();

                MessageBox.Show(answer + swT + swGT);
                //ed.swimmers.Add(s);
                //this.Hide();

                //ed.Show();
                //sendData();
                this.Hide();
            }
            else
            {
                MessageBox.Show(answer);

                /*this.Hide();
                EditSwimmerListForm edsl = new EditSwimmerListForm();
                MessageBox.Show("Swimmer added.");
                edsl.Show();
                */
                //f.addSwimmerRow(swFirstName, swLastName, swGrade, swGender, swEvent, )
            }

            //f.addSwimmerRow()

    }

        //ENDED HERE
        public bool checkInfo()
        {
            answer = "";
            bool conditionOne = checkSelectedName();
            bool conditionTwo = checkEvent();
            bool conditionThree = checkGT();
            bool conditionFour = checkTime();

            
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
            else
            {
                return true;
            }
            
            //return true;
        }

        private bool checkSelectedName()
        {
            swFirstName = FirstNameTxtBox.Text;
            swLastName = LastNameTxtBox.Text;

            if (string.IsNullOrEmpty(swFirstName) || string.IsNullOrEmpty(swLastName))
            {
                answer += "Please add a first and last name. ";
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool checkEvent()
        {
            if ((swDistance != "100") && (swStroke == "fl") && (swDistanceSelected == true))
            {
                answer += "Swimmers cannot swim " + swDistance + " " + swStroke + ", only 100 fly. Please change the field. ";
                return false;
            }
            else if ((swDistance != "100") && (swStroke == "bk") && (swDistanceSelected == true))
            {
                answer += "Swimmers cannot swim " + swDistance + " " + swStroke + ", only 100 back. Please change the field. ";
                return false;
            }
            else if ((swDistance != "100") && (swStroke == "br") && (swDistanceSelected == true))
            {
                answer += "Swimmers cannot swim " + swDistance + " " + swStroke + ", only 100 breast. Please change the field. ";
                return false;
            }
            else if ((swDistance != "200") && (swStroke == "IM") && (swDistanceSelected == true))
            {
                answer += "Swimmers cannot swim " + swDistance + " " + swStroke + ", only 200 IM. Please change the field. ";
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool checkGT()
        {
            if ((swGoalTimeMinSelected == false) && (swGoalTimeSecSelected == false) && (swGoalTimeMilSelected == false))
            {
                answer += "Please check that you have entered a goal time in the correct format. ";
                return false;
            }
            else if ((swGoalTimeMinSelected == false) && (swGoalTimeSecSelected == false) && (swGoalTimeMilSelected == true))
            {
                answer += "Please check that you have entered a goal time in the correct format. ";
                return false;
            }
            else if ((swGoalTimeMinSelected == false) && (swGoalTimeSecSelected == true) && (swGoalTimeMilSelected == false))
            {
                answer += "Please check that you have entered a goal time in the correct format. ";
                return false;
            }
            else if ((swGoalTimeMinSelected == true) && (swGoalTimeSecSelected == false) && (swGoalTimeMilSelected == false))
            {
                answer += "Please check that you have entered a goal time in the correct format. ";
                return false;
            }
            else if ((swGoalTimeMinSelected == true) && (swGoalTimeSecSelected == false) && (swGoalTimeMilSelected == true))
            {
                answer += "Please check that you have entered a goal time in the correct format. ";
                return false;
            }
            else if ((swGoalTimeMinSelected == true) && (swGoalTimeSecSelected == true) && (swGoalTimeMilSelected == false))
            {
                answer += "Please check that you have entered a goal time in the correct format. ";
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool checkTime()
        {
            if ((swTimeMinSelected == false) && (swTimeSecSelected == false) && (swTimeMilSelected == false))
            {
                answer += "Please check that you have entered a time in the correct format. ";
                return false;
            }
            else if ((swTimeMinSelected == false) && (swTimeSecSelected == false) && (swTimeMilSelected == true))
            {
                answer += "Please check that you have entered a time in the correct format. ";
                return false;
            }
            else if ((swTimeMinSelected == false) && (swTimeSecSelected == true) && (swTimeMilSelected == false))
            {
                answer += "Please check that you have entered a time in the correct format. ";
                return false;
            }
            else if ((swTimeMinSelected == true) && (swTimeSecSelected == false) && (swTimeMilSelected == false))
            {
                answer += "Please check that you have entered a time in the correct format. ";
                return false;
            }
            else if ((swTimeMinSelected == true) && (swTimeSecSelected == false) && (swTimeMilSelected == true))
            {
                answer += "Please check that you have entered a time in the correct format. ";
                return false;
            }
            else if ((swTimeMinSelected == true) && (swTimeSecSelected == true) && (swTimeMilSelected == false))
            {
                answer += "Please check that you have entered a time in the correct format. ";
                return false;
            }
            else
            {
                return true;
            }
        }

        public String combineSwGT()
        {
            if ((swGoalTimeMinSelected == true) && (swGoalTimeSecSelected == true) && (swGoalTimeMilSelected == true))
            {
                if ((SwimmerGoalTimeSecTxtBox.TextLength == 1))
                {
                    SwimmerGoalTimeSecTxtBox.Text = "0" + SwimmerGoalTimeSecTxtBox.Text;
                }
                if ((SwimmerGoalTimeMilTxtBox.TextLength == 1))
                {
                    SwimmerGoalTimeMilTxtBox.Text = "0" + SwimmerGoalTimeMilTxtBox.Text;
                }

                swGT = SwimmerGoalTimeMinTxtBox.Text + ":" + SwimmerGoalTimeSecTxtBox.Text + "." + SwimmerGoalTimeMilTxtBox.Text;
            }

            if ((swGoalTimeMinSelected == false) && (swGoalTimeSecSelected == true) && (swGoalTimeMilSelected == true))
            {
                if ((SwimmerGoalTimeSecTxtBox.TextLength == 1))
                {
                    SwimmerGoalTimeSecTxtBox.Text = "0" + SwimmerGoalTimeSecTxtBox.Text;
                }
                if ((SwimmerGoalTimeMilTxtBox.TextLength == 1))
                {
                    SwimmerGoalTimeMilTxtBox.Text = "0" + SwimmerGoalTimeMilTxtBox.Text;
                }

                swGT = SwimmerGoalTimeSecTxtBox.Text + "." + SwimmerGoalTimeMilTxtBox.Text;
            }

            return swGT;
        }

        public String combineSWT()
        {
            if ((swTimeMinSelected == true) && (swTimeSecSelected == true) && (swTimeMilSelected == true))
            {
                if ((SwimmerTimeSecTxtBox.TextLength == 1))
                {
                    SwimmerTimeSecTxtBox.Text = "0" + SwimmerTimeSecTxtBox.Text;
                }
                if ((SwimmerTimeMilTxtBox.TextLength == 1))
                {
                    SwimmerTimeMilTxtBox.Text = "0" + SwimmerTimeMilTxtBox.Text;
                }

                swT = SwimmerTimeMinTxtBox.Text + ":" + SwimmerTimeSecTxtBox.Text + "." + SwimmerTimeMilTxtBox.Text;
            }

            if ((swTimeMinSelected == false) && (swTimeSecSelected == true) && (swTimeMilSelected == true))
            {
                if ((SwimmerTimeSecTxtBox.TextLength == 1))
                {
                    SwimmerTimeSecTxtBox.Text = "0" + SwimmerTimeSecTxtBox.Text;
                }
                if ((SwimmerTimeMilTxtBox.TextLength == 1))
                {
                    SwimmerTimeMilTxtBox.Text = "0" + SwimmerTimeMilTxtBox.Text;
                }

                swT = SwimmerTimeSecTxtBox.Text + "." + SwimmerTimeMilTxtBox.Text;
            }

            return swT;
        }

        private void BackToSwimmerListFormBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void NinthGradeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            swGrade = "9";
        }

        private void TenthGradeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            swGrade = "10";
        }

        private void EleventhGradeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            swGrade = "11";
        }

        private void TwelthGradeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            swGrade = "12";
        }

        private void MaleRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            swGender = "M";
        }

        private void FemaleRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            swGender = "F";
        }

        private void FlyStrRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            swStroke = "fl";
        }

        private void BackStrRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            swStroke = "bk";
        }

        private void BreastStrRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            swStroke = "br";
        }

        private void FreeStrRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            swStroke = "fr";
        }

        private void IMstrRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            swStroke = "IM";
        }

        private void Dist50RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            swDistance = "50";
        }

        private void Dist100RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            swDistance = "100";
        }

        private void Dist200RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            swDistance = "200";
        }

        private void Dist500RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            swDistance = "500";
        }

        private void FirstNameTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                MessageBox.Show("please enter letters only");
                e.Handled = true;
            }

            if ((FirstNameTxtBox.TextLength == 1) && (e.KeyChar == (char)Keys.Back))
            {
                FirstNameTxtBox.Text = string.Empty;
                swFirstNameSelected = false;
            }
        }

        private void LastNameTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '-')))
            {
                MessageBox.Show("please enter letters only");
                e.Handled = true;
            }

            if ((LastNameTxtBox.TextLength == 1) && (e.KeyChar == (char)Keys.Back))
            {
                LastNameTxtBox.Text = string.Empty;
                swLastNameSelected = false;
            }
        }

        private void SwimmerGoalTimeMinTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                MessageBox.Show("please enter digits only");
                e.Handled = true;
            }

            if ((SwimmerGoalTimeMinTxtBox.TextLength == 1) && (e.KeyChar == (char)Keys.Back))
            {
                SwimmerGoalTimeMinTxtBox.Text = string.Empty;
                swGoalTimeMinSelected = false;
            }
        }

        private void SwimmerGoalTimeSecTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                MessageBox.Show("please enter digits only");
                e.Handled = true;
            }

            if ((SwimmerGoalTimeSecTxtBox.TextLength == 1) && (e.KeyChar == (char)Keys.Back))
            {
                SwimmerGoalTimeSecTxtBox.Text = string.Empty;
                swGoalTimeSecSelected = false;
            }
        }

        private void SwimmerGoalTimeMilTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                MessageBox.Show("please enter digits only");
                e.Handled = true;
            }

            if ((SwimmerGoalTimeMilTxtBox.TextLength == 1) && (e.KeyChar == (char)Keys.Back))
            {
                SwimmerGoalTimeMilTxtBox.Text = string.Empty;
                swGoalTimeMilSelected = false;
            }
        }

        private void SwimmerTimeMinTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                MessageBox.Show("please enter digits only");
                e.Handled = true;
            }

            if ((SwimmerTimeMinTxtBox.TextLength == 1) && (e.KeyChar == (char)Keys.Back))
            {
                SwimmerTimeMinTxtBox.Text = string.Empty;
                swTimeMinSelected = false;
            }
        }

        private void SwimmerTimeSecTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                MessageBox.Show("please enter digits only");
                e.Handled = true;
            }

            if ((SwimmerTimeSecTxtBox.TextLength == 1) && (e.KeyChar == (char)Keys.Back))
            {
                SwimmerTimeSecTxtBox.Text = string.Empty;
                swTimeSecSelected = false;
            }
        }

        private void SwimmerTimeMilTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                MessageBox.Show("please enter digits only");
                e.Handled = true;
            }

            if ((SwimmerTimeMilTxtBox.TextLength == 1) && (e.KeyChar == (char)Keys.Back))
            {
                SwimmerTimeMilTxtBox.Text = string.Empty;
                swTimeMilSelected = false;
            }
        }

        private void SwimmerGoalTimeMinTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (SwimmerGoalTimeMinTxtBox != null)
            {
                swGoalTimeMinSelected = true;
            }
            else
            {
                swGoalTimeMinSelected = false;
            }
        }

        private void SwimmerGoalTimeSecTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (SwimmerGoalTimeSecTxtBox != null)
            {
                swGoalTimeSecSelected = true;
            }
            else
            {
                swGoalTimeSecSelected = false;
            }
        }

        private void SwimmerGoalTimeMilTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (SwimmerGoalTimeMilTxtBox != null)
            {
                swGoalTimeMilSelected = true;
            }
            else
            {
                swGoalTimeMilSelected = false;
            }
        }

        private void SwimmerTimeMinTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (SwimmerTimeMinTxtBox != null)
            {
                swTimeMinSelected = true;
            }
            else
            {
                swTimeMinSelected = false;
            }
        }

        private void SwimmerTimeSecTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (SwimmerTimeSecTxtBox != null)
            {
                swTimeSecSelected = true;
            }
            else
            {
                swTimeSecSelected = false;
            }
        }

        private void SwimmerTimeMilTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (SwimmerTimeMilTxtBox != null)
            {
                swTimeMilSelected = true;
            }
            else
            {
                swTimeMilSelected = false;
            }
        }
    }
}
