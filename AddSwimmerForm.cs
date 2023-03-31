using System;
using System.Windows.Forms;

namespace ComputerScienceInternalAssessment
{
    public partial class AddSwimmerForm : Form
    {
        //Helps with passing all values set with this form back to the SwimmerListForm.
        SwimmerListForm instance;

        //Instantiates the Form.
        public AddSwimmerForm(SwimmerListForm edSLF)
        {
            InitializeComponent();
            this.instance = edSLF;
        }

        //Old constructor.
        public AddSwimmerForm()
        {
            InitializeComponent();
        }

        //Restricts the user from changing the size of the form.
        private void AddSwimmerForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToScreen();
            this.ControlBox = false;
        }

        //Allows the user to go back to the SwimmerListForm without adding a new swimmer to the SwimmerListDataGridView.
        private void BackToEditSwimmerListFormBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Help button.
        private void SwimmerListHelpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No fields can be left blank.\n" + "You must have a first name, a last name, a grade, a gender, a stroke, a distance, a goal time, and a time.\n" + "You can only type characters into the First and Last Name fields.\n" + "You can only type digits into the goal time and time fields. \n" + "Click the add button when you have complete all the fields to add the swimmer to the SwimmerListDataGridView.");
        }

        //Variables that are used to verify that the data is in the correct format
        //and the share the data with the SwimmerListForm to be added to the SwimmerListDataGridView.
        private bool swFirstNameSelected = false;
        public String swFirstName = "";

        private bool swLastNameSelected = false;
        public String swLastName = "";

        private bool swGradeSelected = false;
        public String swGrade = "";

        private bool swGenderSelected = false;
        public String swGender = "";

        private bool swStrokeSelected = false;
        public String swStroke = "";

        private bool swDistanceSelected = false;
        public String swDistance = "";

        public String swEvent = "";

        private bool swGoalTimeMinSelected = false;
        private bool swGoalTimeSecSelected = false;
        private bool swGoalTimeMilSelected = false;

        private bool swTimeMinSelected = false;
        private bool swTimeSecSelected = false;
        private bool swTimeMilSelected = false;

        public bool check = true;
        public String swGT;
        public String swT;
        private String answer;

        // *********************************************************************************
        // GRADE: Used to determine which radio button in the Grade group is selected.
        private void NinthGradeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
           swGradeSelected = true;
           swGrade = "9";
        }

        private void TenthGradeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
           swGradeSelected = true;
           swGrade = "10";
        }

        private void EleventhGradeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
          swGradeSelected = true;
          swGrade = "11";
        }

        private void TwelthGradeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
          swGradeSelected = true;
          swGrade = "12";
        }

        // *********************************************************************************
        //Gender: Used to determine which radio button in the Gender group is selected.
        private void MaleRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
          swGenderSelected = true;
          swGender = "M";
        }

        private void FemaleRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
          swGenderSelected = true;
          swGender = "F";
        }

        // *********************************************************************************
        //Stroke: Used to determine which radio button in the Stroke group is selected.
        private void FlyStrRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
           swStrokeSelected = true;
           swStroke = "fl";
        }

        private void BackStrRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
          swStrokeSelected = true;
          swStroke = "bk";
        }

        private void BreastStrRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
           swStrokeSelected = true;
           swStroke = "br";
        }

        private void FreeStrRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
           swStrokeSelected = true;
           swStroke = "fr";
        }

        private void IMstrRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
           swStrokeSelected = true;
           swStroke = "IM";
        }

        // *********************************************************************************
        //Distance: Used to determine which radio button in the Distance group is selected.
        private void Dist50RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
           swDistanceSelected = true;
           swDistance = "50";
        }

        private void Dist100RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
           swDistanceSelected = true;
           swDistance = "100";
        }

        private void Dist200RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
           swDistanceSelected = true;
            swDistance = "200";
        }

        private void Dist500RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
           swDistanceSelected = true;
           swDistance = "500";
        }

        // *********************************************************************************
        //Swimmer Goal Time: Determines if the user has typed a value into the goal time boxes.
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

        // *********************************************************************************
        //Swimmer Time: Determines if the user has typed a value into the time boxes.
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

        // *********************************************************************************
        //ADD SWIMMER BUTTON.
        private void AddSwimmerBtn_Click(object sender, EventArgs e)
        {
            //Verifies if the data in the form is in the correct format.
            check = checkInfo();

            //Structures the message that will be presented to the user.
            if (check == true)
            {
                answer = "Swimmer added.";
                
                swEvent = swDistance + " " + swStroke;
                combineSwGT();
                combineSWT();

                MessageBox.Show(answer);

                this.Hide();
            }

            //Shows the user what is wrong with their formatting.
            else 
            { 
                    MessageBox.Show(answer);
            }
        }

        //Checks if the data is in the correct format.
        public bool checkInfo()
        {
            answer = "";
            bool conditionOne = checkSelectedName();
            bool conditionTwo = checkSelectedGrade();
            bool conditionThree = checkGenderSelected();
            bool conditionFour = checkStrokeSelected();
            bool conditionFive = checkDistanceSelected();
            bool conditionSix = checkEvent();
            bool conditionSeven = checkGT();
            bool conditionEight = checkTime();

            if (conditionOne == false)
            {
                return false;
            }
            else if (conditionTwo == false){
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
        }

        //Checks if the first and last name fields have data correctly entered into them.
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

        //Checks if the user selected a grade for the swimmer.
        private bool checkSelectedGrade()
        {
            if (swGradeSelected == false)
            {
                answer += "Please select a grade. ";
                return false;
            }
            else
            {
                return true;
            }
        }

        //Checks if the user selected a gender for the swimmer.
        private bool checkGenderSelected()
        {
            if(swGenderSelected == false)
            {
                answer += "Please select a gender. ";
                return false;
            }
            else
            {
                return true;
            }
        }

        //Checks if the user selected a distance for the swimmer.
        private bool checkDistanceSelected()
        {
            if(swDistanceSelected == false)
            {
                answer += "Please select a distance. ";
                return false;
            }
            else
            {
                return true;
            }
        }

        //Checks if the user selected a stroke for the swimmer.
        private bool checkStrokeSelected()
        {
            if(swStrokeSelected == false)
            {
                answer += "Please select a stroke. ";
                return false;
            }
            else
            {
                return true;
            }
        }

        //Checks if the distance and stroke combination is a possible high school event.
        private bool checkEvent()
        {
            if((swDistance != "100") && (swStroke == "fl") && (swDistanceSelected == true))
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

        //Checks if the swimmer Goal time is in the correct format.
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
            if((swGoalTimeMinSelected == true) && (swGoalTimeSecSelected == true) && (swGoalTimeMilSelected == true)){
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

            if((swGoalTimeMinSelected == false) && (swGoalTimeSecSelected == true) && (swGoalTimeMilSelected == true))
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

        //Combines the swimmer time into the correct format for the SwimmerListDataGridView on the SwimmerListForm.
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

        //Restricts the user to only typing digits in the minutes box for the swimmer goal time.
        private void SwimmerGoalTimeMinTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                MessageBox.Show("Please enter digits only.");
                e.Handled = true;
            }

            if((SwimmerGoalTimeMinTxtBox.TextLength == 1) && (e.KeyChar == (char)Keys.Back))
            {
                SwimmerGoalTimeMinTxtBox.Text = string.Empty;
                swGoalTimeMinSelected = false;
            }
        }

        //Restricts the user to only typing digits in the seconds box for the swimmer goal time.
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

        //Restricts the user to only typing digits in the milliseconds box for the swimmer goal time.
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

        //Restricts the user to only typing digits in the minutes box for the swimmer time. 
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

        //Restrics the user to only typing digits in the seconds box for the swimmer time.
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

        //Restricts the user to only typing digits in the milliseconds box for the swimmer time.
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
    }
}
