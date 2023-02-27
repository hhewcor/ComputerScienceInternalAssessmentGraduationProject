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

        private bool check;
        private String swGT;
        private String swT;


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
                    swGoalTimeMin = Convert.ToInt32(stGoalTimeMin);
                }
                catch (Exception exception)
                {
                    swGoalTimeMilSelected = false;
                    MessageBox.Show("Please type an integer.");
                }
            }
        }
        private void SwimmerGoalTimeSecTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (SwimmerGoalTimeSecTxtBox != null)
            {
                try
                {
                    swGoalTimeSecSelected = true;
                    String stGoalTimeSec = SwimmerGoalTimeSecTxtBox.Text;
                    swGoalTimeSec = Convert.ToInt32(stGoalTimeSec);
                }
                catch (Exception exception)
                {
                    swGoalTimeMilSelected = false;
                    MessageBox.Show("Please type an integer.");
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
                    swGoalTimeMil = Convert.ToInt32(stGoalTimeMil);
                }
                catch (Exception exception)
                {
                    swGoalTimeMilSelected = false;
                    MessageBox.Show("Please type an integer.");
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
                    swGoalTimeMinSelected = true;
                    String stTimeMin = SwimmerTimeMinTxtBox.Text;
                    swTimeMin = Convert.ToInt32(swTimeMin);
                }
                catch (Exception exception)
                {
                    swGoalTimeMilSelected = false;
                    MessageBox.Show("Please type an integer.");
                }
            }
        }

        private void SwimmerTimeSecTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (SwimmerTimeSecTxtBox != null)
            {
                try
                {
                    swGoalTimeSecSelected = true;
                    String stTimeSec = SwimmerTimeSecTxtBox.Text;
                    swTimeSec = Convert.ToInt32(swTimeSec);
                }
                catch (Exception exception)
                {
                    swGoalTimeMilSelected = false;
                    MessageBox.Show("Please type an integer.");
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
                    swGoalTimeMilSelected = true;
                    String stTimeMil = SwimmerTimeMilTxtBox.Text;
                    swTimeMil = Convert.ToInt32(swTimeMil);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Please type an integer.");
                }
            }
        }

        //Swimmer Name -----------------------------------------------------
        private void FirstNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            if(FirstNameTxtBox != null)
            {
                swFirstNameSelected = true;
                swFirstName = FirstNameTxtBox.Text;
            }
        }

        private void LastNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (LastNameTxtBox != null)
            {
                swLastNameSelected = true;
                swLastName = LastNameTxtBox.Text;
            }
        }

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

            this.checkSelected();
            this.checkEvent();

            if(check == true)
            {
                this.Hide();
                EditSwimmerListForm edsl = new EditSwimmerListForm();
                MessageBox.Show("Swimmer added.");
                edsl.Show();
                //f.addSwimmerRow(swFirstName, swLastName, swGrade, swGender, swEvent, )
               
            }
            else
            {
                MessageBox.Show("Please check that you have formatted the data correctly.");
            }
            
            //f.addSwimmerRow()
        }

        private void checkSelected()
        {
            if ((swFirstNameSelected != true) && (swLastNameSelected != true) && (swGradeSelected != true) && (swGenderSelected != true) && (swDistanceSelected != true) && (swStrokeSelected != true))
            {
                check = false;
            }
        }

        private void checkEvent()
        {
            if ((swDistanceSelected == true) && (swStrokeSelected == true))
            {
                if((swDistance != "100") && (swStroke == "fl")){
                    check = false;
                }
                if ((swDistance != "100") && (swStroke == "bk")){
                    check = false;
                }
                if ((swDistance != "100") && (swStroke == "br"))
                {
                    check = false;
                }
                if ((swDistance != "200") && (swStroke == "IM"))
                {
                    check = false;
                }
            }
            else
            {
                swEvent = swDistance + " " + swStroke;
            }
        }

        private void combine()
        {
            swEvent = swDistance + " " + swStroke;
            
            if((swGoalTimeMinSelected == true) && (swGoalTimeSecSelected == true) && (swGoalTimeMinSelected == true)){
                swGT = swGoalTimeMin + ":" + swGoalTimeSec "." + swGoalTimeMil;
            }

            if((SwimmerGoalTimeMinTxtBox == null) && (swGoalTimeSecSelected == true) && (swGoalTimeMinSelected == true))
            {
                //sw
            }

        }

       
        // 100 fly, 100 bk, 100 br, 200 IM


    }
}
