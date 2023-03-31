using System;
using System.Windows.Forms;

namespace ComputerScienceInternalAssessment
{
    public partial class EditSwimmerForm : Form
    {
        //Variables that help with passing all values set with this form back to the SwimmerListForm.
        SwimmerListForm instance;
        public String swFirstName;
        public String swLastName;
        public String swGrade;
        public String swGender;
        public String swStroke;
        public String swDistance;

        public String swGT;
        public String swT;

        public bool change;

        //Constructor
        public EditSwimmerForm(SwimmerListForm edL, String fn, String ln, String grd, String gd, String str, String dist, String swimmerGoalTime, String swimmerTime)
        {
            InitializeComponent();
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

            //Sets the swimmer goal time and swimmer time boxes in the EditSwimmerForm based on the values passed by the SwimmerListForm.
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
        }

        //Restricts the user from changing the size of the EditSwimmerForm.
        private void EditSwimmerForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToScreen();
            this.ControlBox = false;
        }

        //Variables used to verify if the data has been changed. Also used to verify if a required field is empty.
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

        //Sets the values of the form to what was passed into the form.
        private void setVariables()
        {
            FirstNameTxtBox.Text = swFirstName;
            LastNameTxtBox.Text = swLastName;

            //Sets grade level.
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


            //Sets gender.
            if(swGender == "M")
            {
                MaleRadioBtn.Checked = true;
            }
            else if(swGender == "F")
            {
                FemaleRadioBtn.Checked = true;
            }

            //Sets stroke.
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

            //Sets Distance.
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

        private String answer;

        //Updates the swimmer information on the SwimmerListForm.
        private void UpdateSwimmerBtn_Click(object sender, EventArgs e)
        {
            //Verifies if the form is formatted correctly.
            checkEdit = checkInfo();

            //If the form is verified correctly, this sets up the message that will be presented to the user.
            if (checkEdit == true)
            {
                answer = "Swimmer Updated.";

                swEvent = swDistance + " " + swStroke;
                combineSwGT();
                combineSWT();

                MessageBox.Show(answer);
                
                change = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show(answer);
            }
        }

        //Checks if the format of the data on the form is correct.
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
        }

        //Checks if the first and last name has been correctly formatted on the form.
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

        //Checks if the event selected is a possible high school event.
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

        //Checks if the goal time is in the correct format.
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

        //Checks if the swimmer time is in the correct format.
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

        //Combines the swimmer goal time to be the correct format for the SwimmerListDataGridView on the SwimmerListForm.
        public String combineSwGT()
        {
            if ((swGoalTimeMinSelected == true) && (swGoalTimeSecSelected == true) && (swGoalTimeMilSelected == true))
            {
                if (SwimmerGoalTimeSecTxtBox.TextLength == 1)
                {
                    SwimmerGoalTimeSecTxtBox.Text = "0" + SwimmerGoalTimeSecTxtBox.Text;
                }
                if (SwimmerGoalTimeMilTxtBox.TextLength == 1)
                {
                    SwimmerGoalTimeMilTxtBox.Text = "0" + SwimmerGoalTimeMilTxtBox.Text;
                }

                swGT = SwimmerGoalTimeMinTxtBox.Text + ":" + SwimmerGoalTimeSecTxtBox.Text + "." + SwimmerGoalTimeMilTxtBox.Text;
            }

            if ((swGoalTimeMinSelected == false) && (swGoalTimeSecSelected == true) && (swGoalTimeMilSelected == true))
            {
                if (SwimmerGoalTimeSecTxtBox.TextLength == 1)
                {
                    SwimmerGoalTimeSecTxtBox.Text = "0" + SwimmerGoalTimeSecTxtBox.Text;
                }
                if (SwimmerGoalTimeMilTxtBox.TextLength == 1)
                {
                    SwimmerGoalTimeMilTxtBox.Text = "0" + SwimmerGoalTimeMilTxtBox.Text;
                }

                swGT = SwimmerGoalTimeSecTxtBox.Text + "." + SwimmerGoalTimeMilTxtBox.Text;
            }

            return swGT;
        }

        //Combines the swimmer time to be the correct format for the SwimmerListDataGridView on the SwimmerListForm.
        public String combineSWT()
        {
            if ((swTimeMinSelected == true) && (swTimeSecSelected == true) && (swTimeMilSelected == true))
            {
                if (SwimmerTimeSecTxtBox.TextLength == 1)
                {
                    SwimmerTimeSecTxtBox.Text = "0" + SwimmerTimeSecTxtBox.Text;
                }
                if (SwimmerTimeMilTxtBox.TextLength == 1)
                {
                    SwimmerTimeMilTxtBox.Text = "0" + SwimmerTimeMilTxtBox.Text;
                }

                swT = SwimmerTimeMinTxtBox.Text + ":" + SwimmerTimeSecTxtBox.Text + "." + SwimmerTimeMilTxtBox.Text;
            }

            if ((swTimeMinSelected == false) && (swTimeSecSelected == true) && (swTimeMilSelected == true))
            {
                if (SwimmerTimeSecTxtBox.TextLength == 1)
                {
                    SwimmerTimeSecTxtBox.Text = "0" + SwimmerTimeSecTxtBox.Text;
                }
                if (SwimmerTimeMilTxtBox.TextLength == 1)
                {
                    SwimmerTimeMilTxtBox.Text = "0" + SwimmerTimeMilTxtBox.Text;
                }

                swT = SwimmerTimeSecTxtBox.Text + "." + SwimmerTimeMilTxtBox.Text;
            }

            return swT;
        }

        //Returns back to the SwimmerListForm.
        private void BackToSwimmerListFormBtn_Click(object sender, EventArgs e)
        {
            change = false;
            this.Hide();
        }

        // *********************************************************************************
        //GRADE: Used to determine which radio button in the Grade group is selected.
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

        // *********************************************************************************
        //GENDER: Used to determine which radio button in the Gender group is selected.
        private void MaleRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            swGender = "M";
        }

        private void FemaleRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            swGender = "F";
        }

        // *********************************************************************************
        //Stroke: Used to determine which radio button in the Stroke group is selected.
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

        // *********************************************************************************
        //DISTANCE: Used to determine which radio button in the Distance group is selected.
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

        //Restricts the user to only typing characters in the First Name Text Box.
        private void FirstNameTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                MessageBox.Show("Please enter letters only.");
                e.Handled = true;
            }

            if ((FirstNameTxtBox.TextLength == 1) && (e.KeyChar == (char)Keys.Back))
            {
                FirstNameTxtBox.Text = string.Empty;
                swFirstNameSelected = false;
            }
        }

        //Restricts the user to only typing characters in the Last Name Text Box.
        private void LastNameTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '-')))
            {
                MessageBox.Show("Please enter letters only.");
                e.Handled = true;
            }

            if ((LastNameTxtBox.TextLength == 1) && (e.KeyChar == (char)Keys.Back))
            {
                LastNameTxtBox.Text = string.Empty;
                swLastNameSelected = false;
            }
        }

        //Restricts the user to only typing digits in the minutes box for swimmer goal time.
        private void SwimmerGoalTimeMinTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                MessageBox.Show("Please enter digits only.");
                e.Handled = true;
            }

            if ((SwimmerGoalTimeMinTxtBox.TextLength == 1) && (e.KeyChar == (char)Keys.Back))
            {
                SwimmerGoalTimeMinTxtBox.Text = string.Empty;
                swGoalTimeMinSelected = false;
            }
        }

        //Restricts the user to only typing digits in the seconds box for swimmer goal time.
        private void SwimmerGoalTimeSecTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                MessageBox.Show("Please enter digits only.");
                e.Handled = true;
            }

            if ((SwimmerGoalTimeSecTxtBox.TextLength == 1) && (e.KeyChar == (char)Keys.Back))
            {
                SwimmerGoalTimeSecTxtBox.Text = string.Empty;
                swGoalTimeSecSelected = false;
            }
        }

        //Restricts the user to only typing digits in the milliseconds box for swimmer goal time.
        private void SwimmerGoalTimeMilTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                MessageBox.Show("Please enter digits only.");
                e.Handled = true;
            }

            if ((SwimmerGoalTimeMilTxtBox.TextLength == 1) && (e.KeyChar == (char)Keys.Back))
            {
                SwimmerGoalTimeMilTxtBox.Text = string.Empty;
                swGoalTimeMilSelected = false;
            }
        }

        //Restricts the user to only typing digits in the minutes box for swimmer time.
        private void SwimmerTimeMinTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                MessageBox.Show("Please enter digits only.");
                e.Handled = true;
            }

            if ((SwimmerTimeMinTxtBox.TextLength == 1) && (e.KeyChar == (char)Keys.Back))
            {
                SwimmerTimeMinTxtBox.Text = string.Empty;
                swTimeMinSelected = false;
            }
        }

        //Restricts the user to only typing digits in the seconds box for swimmer time.
        private void SwimmerTimeSecTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                MessageBox.Show("Please enter digits only.");
                e.Handled = true;
            }

            if ((SwimmerTimeSecTxtBox.TextLength == 1) && (e.KeyChar == (char)Keys.Back))
            {
                SwimmerTimeSecTxtBox.Text = string.Empty;
                swTimeSecSelected = false;
            }
        }

        //Restricts the user to only typing digits in the milliseconds box for swimmer time.
        private void SwimmerTimeMilTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                MessageBox.Show("Please enter digits only.");
                e.Handled = true;
            }

            if ((SwimmerTimeMilTxtBox.TextLength == 1) && (e.KeyChar == (char)Keys.Back))
            {
                SwimmerTimeMilTxtBox.Text = string.Empty;
                swTimeMilSelected = false;
            }
        }

        //Verifies if a value has been entered into the minutes box for swimmer goal time.
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

        //Verifies if a value has been entered into the seconds box for swimmer goal time.
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

        //Verifies if a value has been entered into the milliseconds box for swimmer goal time.
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

        //Verifies if a value has been entered into the minutes box for swimmer time.
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

        //Verifies if a value has been entered into the seconds box for swimmer time.
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

        //Verifies if a value has been entered into the milliseconds box for swimmer time.
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

        //Help button.
        private void SwimmerListHelpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No fields can be left blank.\n" + "You must have a first name, a last name, a grade, a gender, a stroke, a distance, a goal time, and a time.\n" + "You can only type characters into the First and Last Name fields.\n" + "You can only type digits into the goal time and time fields. \n" + "Click the update button when you have complete/changed the desired fields to update the swimmer in the SwimmerListDataGridView.");
        }
    }
}
