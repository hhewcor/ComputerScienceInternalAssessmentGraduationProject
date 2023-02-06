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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TreeView = System.Windows.Forms.TreeView;

namespace ComputerScienceInternalAssessment
{
    public partial class SwimmerListForm : Form
    {
        //private readonly DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

        // DataTable _dt = new DataTable();
        // bool isXML = false;


        public SwimmerListForm()
        {
            InitializeComponent();
           // ConstructTreeView();
            ConstructSwimmerListDataGridView();

        }

        private void SwimmerListForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToScreen();
            this.ControlBox = false;
        }

        private void ConstructSwimmerListDataGridView()
        {
            //add columns
            SwimmerListDataGridView.ColumnCount = 7;

            SwimmerListDataGridView.Columns[0].Name = "First Name";
            //SwimmerListDataGridView.Columns[0].ReadOnly = true;

            SwimmerListDataGridView.Columns[1].Name = "Last Name";
            // SwimmerListDataGridView.Columns[1].ReadOnly = true;

            SwimmerListDataGridView.Columns[2].Name = "Grade";
            //SwimmerListDataGridView.Columns[2].ReadOnly = true;

            SwimmerListDataGridView.Columns[3].Name = "Gender";
            //SwimmerListDataGridView.Columns[3].ReadOnly = true;

            SwimmerListDataGridView.Columns[4].Name = "Event";

            SwimmerListDataGridView.Columns[5].Name = "Goal Time";

            SwimmerListDataGridView.Columns[6].Name = "Swimmer Time";

            SwimmerListDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //addButtonColumn();

            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "VIEW";
            col.Name = "Compare Time";
            SwimmerListDataGridView.Columns.Add(col);

            foreach (DataGridViewColumn column in SwimmerListDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            AddRows();

        }

        private void AddRows()
        {
            foreach (var swimmer in GetSwimmerList())
            {
                SwimmerListDataGridView.Rows.Add(swimmer.FirstName, swimmer.LastName, swimmer.Grade, swimmer.Gender, swimmer.SwimmerEvent, swimmer.GoalTime, swimmer.Time);
            }
        }

        /*
        private void AddButtonColumn()
        {
            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "VIEW";
            col.Name = "SwimmerEvents";
            SwimmerListDataGridView.Columns.Add(col);
        }
        */

        private void SwimmerListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Swimmer[] swimmers = GetSwimmerList().ToArray();
            if ((e.ColumnIndex == this.SwimmerListDataGridView.Columns["Compare Time"].Index) && (e.RowIndex >= 0))
            {
                try
                {
                    string SwimmerFn = swimmers[e.RowIndex].FirstName;
                    string SwimmerLn = swimmers[e.RowIndex].LastName;
                    string Swimmerevt = swimmers[e.RowIndex].SwimmerEvent;
                    string SwimmerGoalTime = swimmers[e.RowIndex].GoalTime;
                    string SwimmerTime = swimmers[e.RowIndex].Time;
                    String dropGain = "";
                    String test = "";
                    String test2 = "";
                    decimal subtract;
                    string sign = "";

                    string[] splitGoalTime = SwimmerGoalTime.Split(':', '.');
                    string[] splitTime = SwimmerTime.Split(':', '.');


                    

                    if (int.Parse(splitTime[0]) > int.Parse(splitGoalTime[0]))
                    {
                        dropGain = "gained";
                        sign = "+";
                    }
                    if (int.Parse(splitTime[0]) < int.Parse(splitGoalTime[0]))
                    {
                        dropGain = "dropped";
                        //sign = "-";
                    }
                    //if(int.Parse(splitTime[]))

           

                    for (int x = 0; x < splitGoalTime.Length; x++)
                    {
                        test += splitGoalTime[x];
                    }

                    for (int y = 0; y < splitTime.Length; y++)
                    {
                        test2 += splitTime[y];
                    }

                    subtract = decimal.Parse(test2) - decimal.Parse(test);
                    string finish = (subtract / 100).ToString();

                    MessageBox.Show(SwimmerFn + " " + SwimmerLn + " " + dropGain + " hjafdjhklasdjh seconds" + " in " + Swimmerevt + " from their goal time of " + SwimmerGoalTime + ". This is a " + finish + " difference.");
                    //MessageBox.Show(subtract + " " + finish);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
                /*this.Hide();
                ViewSwimmerEventsForm EventsForm = new ViewSwimmerEventsForm();
                EventsForm.Show();
                */
            }
        }

        //This will generate a generic list for testing purposes.
        //Need to fix so that the user can add and remove swimmers.
        //Also need to add the criteria that Grade can only be integers
        //Also need to add the criteria that Gender can only be one letter long.


        public List<Swimmer> GetSwimmerList()
        {
            
          //  List<SwimmerMeetModel> SwimmerMeet = new List<SwimmerMeetModel>();
            List<Swimmer> swimmers = new List<Swimmer>();
           // List<>

            /*SwimmerMeetModel m = new SwimmerMeetModel()
            {
                SwimmerMeetName = "Rabbit Sprintoff",
                SwimmerMeetDate = "1 / 13 / 22",
                SwimmerResultName = "500 Free",
                SwimmerResultTime = "8:34.21"
            };
            */
            

            Swimmer s = new Swimmer()
            {
                FirstName = "Robin",
                LastName = "Hood",
                Grade = "10",
                Gender = "M",
                SwimmerEvent = "100 fr",
                GoalTime = "50.98",
                Time = "51.23"
            };
            swimmers.Add(s);

            //swimmers.Add(m);

            s = new Swimmer()
            {
                FirstName = "Bat",
                LastName = "Man",
                Grade = "11",
                Gender = "M",
                SwimmerEvent = "100 fl",
                GoalTime = "55.31",
                Time = "56.22"
            };
            swimmers.Add(s);
            s = new Swimmer()
            {
                FirstName = "Princess",
                LastName = "Leia",
                Grade = "12",
                Gender = "F",
                SwimmerEvent = "100 br",
                GoalTime = "1:05.93",
                Time = "1:07.81"
            };
            swimmers.Add(s);
            s = new Swimmer()
            {
                FirstName = "Princess",
                LastName = "Peach",
                Grade = "9",
                Gender = "F",
                SwimmerEvent = "200 IM",
                GoalTime = "2:17.65",
                Time = "2:15.26"
            };
            swimmers.Add(s);
            s = new Swimmer()
            {
                FirstName = "Spider",
                LastName = "Man",
                Grade = "9",
                Gender = "M",
                SwimmerEvent = "50 fr",
                GoalTime = "22.15",
                Time = "21.82"
            };
            

            /*immerMeetModel m = new SwimmerMeetModel();
            m = new SwimmerMeetModel()
            {

            };
            */

            swimmers.Add(s);
            return swimmers;
        }

        private void BackToStartBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm stForm = new StartForm();
            stForm.Show();
        }

        private void SwimmerListHelpBtn_Click(object sender, EventArgs e)
        {

        }

        private void SearchFirstNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchLastNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchSwimmerNameBtn_Click(object sender, EventArgs e)
        {

        }

        int t1 = 25;

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            this.FilterPanel.Size = new Size(this.FilterPanel.Size.Width, t1);
            Timer1.Start();
        }

        private void FilterBtn_MouseHover(object sender, EventArgs e)
        {
            t1 = 25;
            this.FilterPanel.Size = new Size(this.FilterPanel.Size.Width, t1);

        }

        private void FilterBtn_MouseLeave(object sender, EventArgs e)
        {
            Timer1.Stop();
            // t1 = 25;
            // this.FilterPanel.Size = new Size(this.FilterPanel.Size.Width, t1);
        }

        private void FilterNinthGradeBtn_Click(object sender, EventArgs e)
        {

        }

        private void FilterTenthGradeBtn_Click(object sender, EventArgs e)
        {

        }

        private void FilterEleventhGradeBtn_Click(object sender, EventArgs e)
        {

        }

        private void FilterTwelthGradeBtn_Click(object sender, EventArgs e)
        {

        }

        private void FilterMaleBtn_Click(object sender, EventArgs e)
        {

        }

        private void FilterFemaleBtn_Click(object sender, EventArgs e)
        {

        }

        private void EditSwimmerListBtn_Click(object sender, EventArgs e)
        {
            
            var EditSwimmerListForm = new EditSwimmerListForm();
            this.Hide();
            EditSwimmerListForm.Show();

        }

        /*
        private void ConstructTreeView()
        {
            foreach (var swimmer in GetSwimmerList())
            {
                TreeNode node = treeView1.Nodes.Add("root", swimmer.FirstName + " " + swimmer.LastName);
                TreeNode sub_node = node.Nodes.Add("gender", "Gender");
                sub_node.Nodes.Add("M/F", swimmer.Gender);
                sub_node = node.Nodes.Add("GT", "Goal Times");
                sub_node.Nodes.Add("50frGT", "50 Free Goal Time");
                sub_node.Nodes.Add("100frGT", "100 Free Goal Time");
                sub_node.Nodes.Add("200frGT", "200 Free Goal Time");
                sub_node.Nodes.Add("500frGT", "500 Free Goal Time");
                sub_node.Nodes.Add("100flGT", "100 Fly Goal Time");
                sub_node.Nodes.Add("100bkGT", "100 Back Goal Time");
                sub_node.Nodes.Add("100brGT", "100 Breast Goal Time");
                sub_node.Nodes.Add("200IMfrGT", "200 IM Goal Time");

                sub_node = node.Nodes.Add("ViewMeetInfo", "View Meet Info");
                TreeNode sub_sub_node = sub_node.Nodes.Add("meetDate", swimmer.SwimmerMeetDate);

                //sub_node.Nodes.Add("meetDate", SwimmerMeet.SwimmerMeetName);
                //sub_node.Nodes.Add("meetDate", swimmer.SwimmerMeetDate);
                sub_sub_node.Nodes.Add("meetName", swimmer.SwimmerMeetName);
            }
            //TreeNode treeNode = new TreeNode("Robin Hood");
           // treeView1.Nodes.Add(treeNode);
          
        }
        */
        
        /*
        private void ImportBtn_Click(object sender, EventArgs e)
        {
            var ImportForm = new ImportForm();
            this.Hide();
            ImportForm.Show();
        }

        private void ExportSwimmerListBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExportSwimmerListForm exForm = new ExportSwimmerListForm();
            exForm.Show();
        }
        */
        

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (t1 > 175)
            {
                Timer1.Stop();
            }
            else
            {
                this.FilterPanel.Size = new Size(this.FilterPanel.Size.Width, t1);
                t1 += 25;
            }
        }

        /*
        void SwimmerListDataGridView_DataBindingComplete(object sender,
        DataGridViewBindingCompleteEventArgs e)
        {
            SwimmerListDataGridView.Rows[1].Cells["MyButton"] = new DataGridViewTextBoxCell();
        }
        */
        /*
       private void SwimmerListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
       {

           //DataGridViewCellEventArgs e
           //System.Windows.FormsDataGridViewCellEventArgs e
           if (SwimmerListDataGridView.Columns[e.ColumnIndex].Name == "MyButton")
               {
                   // button clicked - do some logic
               }
               DataGridViewCell cell = (DataGridViewCell)SwimmerListDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];

           if (cell.ColumnIndex == this.SwimmerListDataGridView.Columns["SwimmerEvents"].Index) 
           {
                   this.Hide();
                   EditSwimmerListForm editForm = new EditSwimmerListForm();
                   editForm.Show();
           }
       }


       /*
        * if(Loop){
        * try{
        *          this.Hide();
                   EditSwimmerListForm editForm = new EditSwimmerListForm();
                   editForm.Show();
        * }
        * catch (Exception exception) {
        * Console.WriteLine(exception.Message);
        * }
        * }
        * */

        /* private void SwimmerListDataGridView_CellEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == SwimmerListDataGridView.Columns["View"].Index)
            {
                SwimmerListDataGridView.Columns["View"].ReadOnly = false;  // set all row as read-only
                SwimmerListDataGridView.CellClick += SwimmerListDataGridView_CellClick;
            }
       //SwimmerListDataGridView.CellClick += SwimmerListDataGridView_CellClick;
        }*/
        /*
        private void makeSwimmerListReadOnly()
        {
            SwimmerListDataGridView.AllowUserToAddRows = false;
            SwimmerListDataGridView.AllowUserToDeleteRows = false;
            SwimmerListDataGridView.ReadOnly = true;
        }
        */
    }
}