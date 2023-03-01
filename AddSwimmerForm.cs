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
        public AddSwimmerForm()
        {
            InitializeComponent();
        }

        private void AddSwimmerForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToScreen();
            this.ControlBox = false;
        }

        private void BackToEditSwimmerListFormBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditSwimmerListForm edsl = new EditSwimmerListForm();
            edsl.Show();
        }

        private void SwimmerListHelpBtn_Click(object sender, EventArgs e)
        {

        }

        //groupbox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name
        //var buttons = this.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);

        private bool swGradeSelected = false;
        private String swGrade = "";

        private bool swGenderSelected = false;
        private String swGender = "";

        private bool swStrokeSelected = false;
        private String swStroke = "";

        private bool swDistanceSelected = false;
        private String swDistance = "";

        private String swEvent = "";

        private bool swGoalTimeMinSelected = false;
        private bool swGoalTimeSecSelected = false;
        private bool swGoalTimeMilSelected = false;

        private int swGoalTimeMin;
        private int swGoalTimeSec;
        private int swGoalTimeMil;

        private bool swTimeMinSelected = false;
        private bool swTimeSecSelected = false;
        private bool swTimeMilSelected = false;

        private int swTimeMin;
        private int swTimeSec;
        private int swTimeMil;

        private bool swFirstNameSelected = false;
        private String swFirstName = "";

        private bool swLastNameSelected = false;
        private String swLastName = "";

        private bool check = true;
        private String swGT;
        private String swT;
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
                try
                {
                    swGoalTimeMinSelected = true;
                    String stGoalTimeMin = SwimmerGoalTimeMinTxtBox.Text;
                    //swGoalTimeMin = Convert.ToInt32(stGoalTimeMin);
                }
                catch (Exception exception)
                {
                    swGoalTimeMinSelected = false;
                }
            }
        }
        private void SwimmerGoalTimeSecTxtBox_TextChanged(object sender, EventArgs e)
        {
            
            if (SwimmerGoalTimeSecTxtBox != null )
            {
                try
                {
                    swGoalTimeSecSelected = true;
                    String stGoalTimeSec = SwimmerGoalTimeSecTxtBox.Text;
                    //swGoalTimeSec = Convert.ToInt32(stGoalTimeSec);
                }
                catch (Exception exception)
                {
                    swGoalTimeSecSelected = false;
                }
            }
        }
        private void SwimmerGoalTimeMilTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (SwimmerGoalTimeMilTxtBox != null)
            {
                try
                {
                    swGoalTimeMilSelected = true;
                    String stGoalTimeMil = SwimmerGoalTimeMilTxtBox.Text;
                    //swGoalTimeMil = Convert.ToInt32(stGoalTimeMil);
                }
                catch (Exception exception)
                {
                    swGoalTimeMilSelected = false;
                }
            }
        }

        //Swimmer Time ------------------------------------------------------
        private void SwimmerTimeMinTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (SwimmerTimeMinTxtBox != null)
            {
                try
                {
                    swTimeMinSelected = true;
                    String stTimeMin = SwimmerTimeMinTxtBox.Text;
                    //swTimeMin = Convert.ToInt32(stTimeMin);
                }
                catch (Exception exception)
                {
                    swTimeMinSelected = false;
                }
            }
        }

        private void SwimmerTimeSecTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (SwimmerTimeSecTxtBox != null)
            {
                try
                {
                    swTimeSecSelected = true;
                    String stTimeSec = SwimmerTimeSecTxtBox.Text;
                    //swTimeSec = Convert.ToInt32(stTimeSec);
                }
                catch (Exception exception)
                {
                    swTimeSecSelected = false;
                }
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
                try
                {
                    swTimeMilSelected = true;
                    String stTimeMil = SwimmerTimeMilTxtBox.Text;
                    //swTimeMil = Convert.ToInt32(stTimeMil);
                }
                catch (Exception exception)
                {
                    swTimeMilSelected = false;   
                }
            }
        }

        //Swimmer Name -----------------------------------------------------
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

            swFirstName = FirstNameTxtBox.Text;
            swLastName = LastNameTxtBox.Text;

            /*
             * swGoalTimeMin = Convert.ToInt32(SwimmerGoalTimeMinTxtBox);
            swGoalTimeSec = Convert.ToInt32(SwimmerGoalTimeSecTxtBox);
            swGoalTimeMil = Convert.ToInt32(SwimmerGoalTimeMilTxtBox);

            swTimeMin = Convert.ToInt32(SwimmerTimeMinTxtBox);
            swTimeSec = Convert.ToInt32(SwimmerTimeSecTxtBox);
            swTimeMil = Convert.ToInt32(SwimmerTimeMilTxtBox);
            */

            //checkSelected();
            check = true;
            checkEvent();
            combineSwGT();
            combineSWT();
            


            if (check == true)
            {
                MessageBox.Show(answer);
            }
            else { 
                    MessageBox.Show("Please check that you have formatted the data correctly.");
               
                /*this.Hide();
                EditSwimmerListForm edsl = new EditSwimmerListForm();
                MessageBox.Show("Swimmer added.");
                edsl.Show();
                */
                //f.addSwimmerRow(swFirstName, swLastName, swGrade, swGender, swEvent, )
            }
            
            //f.addSwimmerRow()
        }

        private void checkSelected()
        {
            
          /*  if ((swFirstNameSelected == false) && (swLastNameSelected == false) && (swGradeSelected == false) && (swGenderSelected == false) && (swDistanceSelected == false) && (swStrokeSelected == false))
            {
                check = false;
            }
          */
            
        }

        private void checkEvent()
        {
            
                if((swDistance != "100") && (swStroke == "fl")){
                    check = false;
                }
                else if ((swDistance != "100") && (swStroke == "bk")){
                    check = false;
                }
                else if ((swDistance != "100") && (swStroke == "br"))
                {
                    check = false;
                }
                else if ((swDistance != "200") && (swStroke == "IM"))
                {
                    check = false;
                }
            
        }

        private void combineSwGT()
        {
            swEvent = swDistance + " " + swStroke;
            
            if((swGoalTimeMinSelected == true) && (swGoalTimeSecSelected == true) && (swGoalTimeMinSelected == true)){
                swGT = swGoalTimeMin + ":" + swGoalTimeSec + "." + swGoalTimeMil;
            }

            else if((SwimmerGoalTimeMinTxtBox == null) && (swGoalTimeSecSelected == true) && (swGoalTimeMinSelected == true))
            {
                swGT = swGoalTimeSec + "." + swGoalTimeMil;
            }

            answer = swEvent + " " + swGT;
        }


        //ENDED HERE!!
        private void combineSWT()
        {
            if ((swTimeMinSelected == true) && (swTimeSecSelected == true) && (swTimeMinSelected == true))
            {
                swTimeMin = Convert.ToInt32(SwimmerGoalTimeMinTxtBox.Text);
                //FIX

                swT = swTimeMin + ":" + swTimeSec + "." + swTimeMil;
            }

            else if ((SwimmerTimeMinTxtBox == null) && (swTimeSecSelected == true) && (swTimeMinSelected == true))
            {
                swT = swTimeSec + "." + swTimeMil;
            }

            answer = answer + " " + swT + ".";
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
            }
        }

        private void SwimmerGoalTimeSecTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                MessageBox.Show("please enter digits only");
                e.Handled = true;
            }
        }

        private void SwimmerGoalTimeMilTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                MessageBox.Show("please enter digits only");
                e.Handled = true;
            }

        }

        private void SwimmerTimeMinTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                MessageBox.Show("please enter digits only");
                e.Handled = true;
            }
        }

        private void SwimmerTimeSecTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                MessageBox.Show("please enter digits only");
                e.Handled = true;
            }
        }

        private void SwimmerTimeMilTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                MessageBox.Show("please enter digits only");
                e.Handled = true;
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
