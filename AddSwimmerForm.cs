using ComputerScienceInternalAssessment.Models;
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
    public partial class AddSwimmerForm : Form
    {
        /*
        public AddSwimmerForm(EditSwimmerListForm edswF)
        {
            InitializeComponent();
            this.ed = edswF;
        }
        */

        //public static AddSwimmerForm instance;

        //public SwimmerListForm LF { get; set; }

        SwimmerListForm instance;


        public AddSwimmerForm(SwimmerListForm edSLF)
        {
            InitializeComponent();
            this.instance = edSLF;
        }

        public AddSwimmerForm()
        {
            InitializeComponent();
        }

        //public EditSwimmerListForm ed { get; set; }


        private void AddSwimmerForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToScreen();
            this.ControlBox = false;
        }

        private void BackToEditSwimmerListFormBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
           // this.Close();
           // SwimmerListForm sl = new SwimmerListForm();
            //sl.Show();
        }

        private void SwimmerListHelpBtn_Click(object sender, EventArgs e)
        {

        }

        //groupbox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name
        //var buttons = this.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);

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

        //private int swGoalTimeMin;
        //private int swGoalTimeSec;
        //private int swGoalTimeMil;

        private bool swTimeMinSelected = false;
        private bool swTimeSecSelected = false;
        private bool swTimeMilSelected = false;

        //private int swTimeMin;
        //private int swTimeSec;
        //private int swTimeMil;

        private bool swFirstNameSelected = false;
        public String swFirstName = "";

        private bool swLastNameSelected = false;
        public String swLastName = "";

        public bool check = true;
        public String swGT;
        public String swT;
        private String answer;


        // GRADE ------------------------------------------------------------
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

        //Gender ----------------------------------------------
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

        //Stroke ----------------------------------------------------
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

        //Distance -------------------------------------------------------------
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

        //Swimmer Goal Time -----------------------------------------
        private void SwimmerGoalTimeMinTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (SwimmerGoalTimeMinTxtBox != null)
            {
                swGoalTimeMinSelected = true;
                String stTimeMil = SwimmerGoalTimeMinTxtBox.Text;
                //swTimeMil = Convert.ToInt32(stTimeMil);
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
                String stTimeMil = SwimmerGoalTimeSecTxtBox.Text;
                //swTimeMil = Convert.ToInt32(stTimeMil);
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
                String stTimeMil = SwimmerGoalTimeMilTxtBox.Text;
                //swTimeMil = Convert.ToInt32(stTimeMil);
            }
            else
            {
                swGoalTimeMilSelected = false;
            }
        }

        //Swimmer Time ------------------------------------------------------
        private void SwimmerTimeMinTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (SwimmerTimeMinTxtBox != null)
            {
                swTimeMinSelected = true;
                String stTimeMil = SwimmerTimeMinTxtBox.Text;
                //swTimeMil = Convert.ToInt32(stTimeMil);
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
                String stTimeMil = SwimmerTimeSecTxtBox.Text;
                //swTimeMil = Convert.ToInt32(stTimeMil);
            }
            else
            {
                swTimeSecSelected = false;
            }
        }

        private void SwimmerTimeMilTxtBox_TextChanged(object sender, EventArgs e)
        {
            /*if (!char.IsNumber(e.KeyChar))
             {
                 e.Handled = true;
             }
            */

            if (SwimmerTimeMilTxtBox != null)
            { 
                    swTimeMilSelected = true;
                    String stTimeMil = SwimmerTimeMilTxtBox.Text;
                    //swTimeMil = Convert.ToInt32(stTimeMil);
            }
            else 
            { 
                    swTimeMilSelected = false;   
            }
        }

        //Swimmer Name -----------------------------------------------------
        /*
        private void FirstNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            if(FirstNameTxtBox != null)
            {
                swFirstNameSelected = true;
                //swFirstName = FirstNameTxtBox.Text;
            }
        }

        private void LastNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (LastNameTxtBox != null)
            {
                swLastNameSelected = true;
                //swLastName = LastNameTxtBox.Text;
            }
        }
        */

        //##############################################################################################################
        //ADD SWIMMER BUTTON **********************************************************************************************

        private void AddSwimmerBtn_Click(object sender, EventArgs e)
        {

            //List<Swimmer> swimmers = new List<Swimmer>();
            /* Swimmer s = new Swimmer()
             {
                 FirstName = "Robin",
                 LastName = "Hood",
                 Grade = "10",
                 Gender = "M",
                 SwimmerEvent = "100 fr",
                 GoalTime = "50.98",
                 Time = "49.67"
             };
             swimmers.Add(s);
             EditSwimmerListDataGridView.Rows.Add(swimmer.FirstName, swimmer.LastName, swimmer.Grade, swimmer.Gender, swimmer.SwimmerEvent, swimmer.GoalTime, swimmer.Time);
         */
            SwimmerListForm f = new SwimmerListForm();

            /*
             * swGoalTimeMin = Convert.ToInt32(SwimmerGoalTimeMinTxtBox);
            swGoalTimeSec = Convert.ToInt32(SwimmerGoalTimeSecTxtBox);
            swGoalTimeMil = Convert.ToInt32(SwimmerGoalTimeMilTxtBox);

            swTimeMin = Convert.ToInt32(SwimmerTimeMinTxtBox);
            swTimeSec = Convert.ToInt32(SwimmerTimeSecTxtBox);
            swTimeMil = Convert.ToInt32(SwimmerTimeMilTxtBox);
            */

            //checkSelected();
            //check = true;
            
            //combineSwGT();
            //combineSWT();

            check = checkInfo();

            if (check == true)
            {
                answer = "Swimmer added.";
                //var ed = (SwimmerListForm)this.Owner;


                SwimmerListForm ed = new SwimmerListForm(this);

                swEvent = swDistance + " " + swStroke;
                combineSwGT();
                combineSWT();


                /*Swimmer s = new Swimmer()
                {
                    FirstName = swFirstName,
                    LastName = swLastName,
                    Grade = swGrade,
                    Gender = swGender,
                    SwimmerEvent = swEvent,
                    GoalTime = combineSwGT(),
                    Time = combineSWT()
                };
                */

                //SwimmerListForm.instance.swimmers.Add(s);
                //this.Visible = false;

                //SwimmerListForm.SwimmerListDataGridView.Rows.Add(swFirstName, swLastName, swGrade, swGender, swEvent, combineSwGT(), combineSWT());


                //ENDED HERE!!!!!!
                //ed.Show();

                MessageBox.Show(answer + swT + swGT);
                //ed.swimmers.Add(s);
                //this.Hide();

                //ed.Show();
                //sendData();
                this.Hide();
            }
            else { 
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
            if((swGoalTimeMinSelected == true) && (swGoalTimeSecSelected == true) && (swGoalTimeMilSelected == true)){
                if ((SwimmerGoalTimeSecTxtBox.TextLength == 1))
                {
                    SwimmerGoalTimeSecTxtBox.Text = "0" + SwimmerGoalTimeSecTxtBox.Text;
                }
                if ((SwimmerGoalTimeMilTxtBox.TextLength == 1))
                {
                    SwimmerGoalTimeMilTxtBox.Text = "0" + SwimmerGoalTimeMilTxtBox.Text;
                }

                //swGoalTimeMin = Convert.ToInt32(SwimmerGoalTimeMinTxtBox.Text);
                //swGoalTimeSec = Convert.ToInt32(SwimmerGoalTimeSecTxtBox.Text);
                //swGoalTimeMil = Convert.ToInt32(SwimmerGoalTimeMilTxtBox.Text);

                swGT = SwimmerGoalTimeMinTxtBox.Text + ":" + SwimmerGoalTimeSecTxtBox.Text + "." + SwimmerGoalTimeMilTxtBox.Text;
            }

            if((swGoalTimeMinSelected == false) && (swGoalTimeSecSelected == true) && (swGoalTimeMilSelected == true))
            {
                if ((SwimmerGoalTimeSecTxtBox.TextLength == 1))
                {
                    SwimmerGoalTimeSecTxtBox.Text = "0" + SwimmerGoalTimeSecTxtBox.Text;
                }
                if ((SwimmerGoalTimeMilTxtBox.TextLength == 1))
                {
                    SwimmerGoalTimeMilTxtBox.Text = "0" + SwimmerGoalTimeMilTxtBox.Text;
                }

                //swGoalTimeSec = Convert.ToInt32(SwimmerGoalTimeSecTxtBox.Text);
                //swGoalTimeMil = Convert.ToInt32(SwimmerGoalTimeMilTxtBox.Text);

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

                //swTimeMin = Convert.ToInt32(SwimmerTimeMinTxtBox.Text);
                //swTimeSec = Convert.ToInt32(SwimmerTimeSecTxtBox.Text);
                //swTimeMil = Convert.ToInt32(SwimmerTimeMilTxtBox.Text);

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

                //swTimeSec = Convert.ToInt32(SwimmerTimeSecTxtBox.Text);
                //swTimeMil = Convert.ToInt32(SwimmerTimeMilTxtBox.Text);

                swT = SwimmerTimeSecTxtBox.Text + "." + SwimmerTimeMilTxtBox.Text;
            }

            return swT;
        }

        private void SwimmerGoalTimeMinTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                MessageBox.Show("please enter digits only");
                e.Handled = true;
            }

            if((SwimmerGoalTimeMinTxtBox.TextLength == 1) && (e.KeyChar == (char)Keys.Back))
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


        // 100 fly, 100 bk, 100 br, 200 IM

        //Test that every field is filled out.
        //Test that certain events aren't combined.
        //Allow for swTimeMin field to be blank in a certain case.
        //Allow for swGTMin to be blank in a certain case.
        //if check is true then add the information to the tempswimmerlist.
        //close this form.
        //open updated edit swimmer list page.

    }
}
