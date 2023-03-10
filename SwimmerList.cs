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

        public static List<Swimmer> swimmers;
        public ListBox lb = new ListBox();

        Dictionary<string, Swimmer> swList = new Dictionary<string, Swimmer>();
        //public List<Swimmer> sw;

        public static SwimmerListForm instance;

        public SwimmerListForm()
        {
            InitializeComponent();
            swimmers = new List<Swimmer>();
            instance = this;

            listBox1 = lb;

            // ConstructTreeView();
            ConstructSwimmerListDataGridView();

        }

        private void SwimmerListForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToScreen();
            this.ControlBox = false;
        }

        /*
        public SwimmerListForm SWLF { get; set; }

        public EditSwimmerListForm(SwimmerListForm swLF)
        {
            InitializeComponent();
            this.SwimmerListForm = swLF;
        }
        */

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

            DataGridViewButtonColumn col2 = new DataGridViewButtonColumn();
            col2.UseColumnTextForButtonValue = true;
            col2.Text = "Edit";
            col2.Name = "Edit Swimmer";
            SwimmerListDataGridView.Columns.Add(col2);

            DataGridViewButtonColumn col3 = new DataGridViewButtonColumn();
            col3.UseColumnTextForButtonValue = true;
            col3.Text = "Delete";
            col3.Name = "Delete Swimmer";
            SwimmerListDataGridView.Columns.Add(col3);

            foreach (DataGridViewColumn column in SwimmerListDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //this.addSwimmerRow("Test", "Test", "10", "F", "test", "1:01.92", "2:04.81");
            loadRows();

        }

        private void loadRows()
        {
            SwimmerListDataGridView.Rows.Clear();
            //listView1.Items.AddRange(swimmers);
            //this.addSwimmerRow("Test", "Test", "10", "F", "test", "1:01.92", "2:04.81");
            /*
            foreach (Swimmer s in GetSwimmerList())
            {
                SwimmerListDataGridView.Rows.Add(s.FirstName, s.LastName, s.Grade, s.Gender, s.SwimmerEvent, s.GoalTime, s.Time); ;
            }
            */

            foreach (var kvp in swList)
            {
                SwimmerListDataGridView.Rows.Add("Key = {0}, Value = {1}", kvp.Value);
            }
            //this.addSwimmerRow("Test", "Test", "10", "F", "test", "1:01.92", "2:04.81");
        }

        public void addSwimmerRow(String fn, String ln, String grd, String gd, String evt, String gt, String tm)
        {
            
            Swimmer s = new Swimmer()
            {
                FirstName = fn,
                LastName = ln,
                Grade = grd,
                Gender = gd,
                SwimmerEvent = evt,
                GoalTime = gt,
                Time = tm
            };
            swList.Add(s.FirstName + " " + s.LastName, s);
            //SwimmerListDataGridView.Rows.Add(fn, ln, grd, gd, evt, gt, tm);
            //this.loadRows();
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
                    int part = 0;
                    string defaultAnswer = "";
                    string answer = "";
                    string finish = "";

                    string[] splitGoalTime = SwimmerGoalTime.Split(':', '.');
                    string[] splitTime = SwimmerTime.Split(':', '.');

                    for (int x = 0; x < splitGoalTime.Length; x++)
                    {
                        test += splitGoalTime[x];
                    }

                    for (int y = 0; y < splitTime.Length; y++)
                    {
                        test2 += splitTime[y];
                    }

                    subtract = decimal.Parse(test2) - decimal.Parse(test);



                    if (subtract >= 1000 || subtract <= -1000)
                    {
                        part = Convert.ToInt32(subtract) / 1000;
                        finish = ((subtract - (part * 1000)) / 100).ToString();
                    }
                    else
                    {
                        subtract /= 100;
                        finish = subtract.ToString();
                    }


                    defaultAnswer = SwimmerFn + " " + SwimmerLn + " swam " + SwimmerTime + " in the " + Swimmerevt + ".\n" + "Their goal time was " + SwimmerGoalTime + "." + "\n" + "They ";

                    if (int.Parse(splitTime[0]) > int.Parse(splitGoalTime[0]))
                    {
                        dropGain = "gained";
                        answer = defaultAnswer + dropGain + " " + finish + ".";
                    }
                    if (int.Parse(splitTime[0]) < int.Parse(splitGoalTime[0]))
                    {
                        dropGain = "dropped";
                        answer = defaultAnswer + dropGain + " " + finish + ".";
                    }
                    if (int.Parse(splitTime[0]) == int.Parse(splitGoalTime[0]))
                    {
                        if (int.Parse(splitTime[1]) > int.Parse(splitGoalTime[1]))
                        {
                            dropGain = "gained";
                            answer = defaultAnswer + dropGain + " " + finish + ".";
                        }
                        if (int.Parse(splitTime[1]) < int.Parse(splitGoalTime[1]))
                        {
                            dropGain = "dropped";
                            answer = defaultAnswer + dropGain + " " + finish + ".";
                        }
                        if ((int.Parse(splitTime[1]) == int.Parse(splitGoalTime[1])) && (splitTime.Length == 2))
                        {
                            answer = defaultAnswer + "didn't drop or gain time.";
                        }
                        if ((int.Parse(splitTime[1]) == int.Parse(splitGoalTime[1])) && (splitTime.Length == 3))
                        {
                            if (int.Parse(splitTime[2]) > int.Parse(splitGoalTime[2]))
                            {
                                dropGain = "gained";
                                answer = defaultAnswer + dropGain + " " + finish + ".";
                            }
                            if (int.Parse(splitTime[2]) < int.Parse(splitGoalTime[2]))
                            {
                                dropGain = "dropped";
                                answer = defaultAnswer + dropGain + " " + finish + ".";
                            }
                            if (int.Parse(splitTime[2]) == int.Parse(splitGoalTime[2]))
                            {
                                answer = defaultAnswer + "didn't drop or gain time.";
                            }
                        }
                    }

                    //SwimmerFn + " " + SwimmerLn + " " + dropGain + " " + finish + " in " + Swimmerevt + " from their goal time of " + SwimmerGoalTime + ". This is a " + sign + " " + finish + " difference from their time of " + SwimmerTime + ".";
                    // SwimmerFn + " " + SwimmerLn + " swam " + SwimmerTime + "in the " Swimmerevt + "\n" + "Their goal time was " + SwimmerGoalTime + ".\n" + "This is a " + finish + " " + dropGain + ".";
                    //if(int.Parse(splitTime[])

                    MessageBox.Show(answer);
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
           // List<Swimmer> swimmers = new List<Swimmer>();
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
                Time = "49.67"
            };
            swimmers.Add(s);
            swList.Add(s.FirstName + " " + s.LastName, s);

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
            swList.Add(s.FirstName + " " + s.LastName, s);

            s = new Swimmer()
            {
                FirstName = "James",
                LastName = "Bond",
                Grade = "12",
                Gender = "M",
                SwimmerEvent = "50 fr",
                GoalTime = "20.31",
                Time = "20.31"
            };
            swimmers.Add(s);

            swList.Add(s.FirstName + " " + s.LastName, s);
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

            swList.Add(s.FirstName + " " + s.LastName, s);

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

            swList.Add(s.FirstName + " " + s.LastName, s);

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

            swimmers.Add(s);

            swList.Add(s.FirstName + " " + s.LastName, s);

            s = new Swimmer()
            {
                FirstName = "Ant",
                LastName = "Man",
                Grade = "11",
                Gender = "M",
                SwimmerEvent = "50 fr",
                GoalTime = "25.13",
                Time = "25.13"
            };
            swimmers.Add(s);

            swList.Add(s.FirstName + " " + s.LastName, s);

            s = new Swimmer()
            {
                FirstName = "Romeo",
                LastName = "Montague",
                Grade = "12",
                Gender = "M",
                SwimmerEvent = "500 fr",
                GoalTime = "5:24.81",
                Time = "5:24.91"
            };
            swimmers.Add(s);

            swList.Add(s.FirstName + " " + s.LastName, s);

            s = new Swimmer()
            {
                FirstName = "Katniss",
                LastName = "Everdeen",
                Grade = "10",
                Gender = "F",
                SwimmerEvent = "500 fr",
                GoalTime = "5:42.67",
                Time = "5:42.42"
            };
            swimmers.Add(s);

            swList.Add(s.FirstName + " " + s.LastName, s);

            s = new Swimmer()
            {
                FirstName = "Hermione",
                LastName = "Granger",
                Grade = "9",
                Gender = "F",
                SwimmerEvent = "200 IM",
                GoalTime = "2:25.39",
                Time = "2:25.39"
            };
            swimmers.Add(s);

            swList.Add(s.FirstName + " " + s.LastName, s);

            s = new Swimmer()
            {
                FirstName = "Elle",
                LastName = "Woods",
                Grade = "11",
                Gender = "F",
                SwimmerEvent = "100 bk",
                GoalTime = "1:02.31",
                Time = "1:02.92"
            };
            swimmers.Add(s);

            swList.Add(s.FirstName + " " + s.LastName, s);

            s = new Swimmer()
            {
                FirstName = "Regina",
                LastName = "George",
                Grade = "11",
                Gender = "F",
                SwimmerEvent = "200 fr",
                GoalTime = "2:03.82",
                Time = "1:59.82"
            };
            swimmers.Add(s);

            swList.Add(s.FirstName + " " + s.LastName, s);

            s = new Swimmer()
            {
                FirstName = "Jack",
                LastName = "Sparrow",
                Grade = "10",
                Gender = "M",
                SwimmerEvent = "200 fr",
                GoalTime = "1:59.35",
                Time = "2:07.35"
            };
            swimmers.Add(s);

            swList.Add(s.FirstName + " " + s.LastName, s);


            s = new Swimmer()
            {
                FirstName = "Sherlock",
                LastName = "Holmes",
                Grade = "12",
                Gender = "M",
                SwimmerEvent = "200 fr",
                GoalTime = "1:59.35",
                Time = "2:03.82"
            };

            /*
            SwimmerMeetModel m = new SwimmerMeetModel();
            m = new SwimmerMeetModel()
            {

            };
            */
            

            swimmers.Add(s);

            swList.Add(s.FirstName + " " + s.LastName, s);


            return swimmers;
        }


        /*public static explicit operator SwimmerListForm(Form v)
        {
            throw new NotImplementedException();
        }
        */

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
            foreach (DataGridViewRow row in SwimmerListDataGridView.Rows)
            {
                row.Visible = true;
            }
            SwimmerListDataGridView.Sort(SwimmerListDataGridView.Columns[0], ListSortDirection.Ascending);

        }

        private void SearchLastNameTxt_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in SwimmerListDataGridView.Rows)
            {
                row.Visible = true;
            }
            SwimmerListDataGridView.Sort(SwimmerListDataGridView.Columns[1], ListSortDirection.Ascending);
        }

        private void SearchSwimmerNameBtn_Click(object sender, EventArgs e)
        {

        }

        private void FilterNinthGradeBtn_Click(object sender, EventArgs e)
        {
            string word = "9";

            foreach (DataGridViewRow row in SwimmerListDataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if ((cell.ColumnIndex == 2) && (cell.Value != word)) //Set your Column Index
                    {
                        row.Visible = false;
                    }
                }
            }
        }


        /*public String CopyData()
        {
            string response = "";
            for (int x = 0; x < SwimmerListDataGridView.Rows.Count; x++)
            {
                for (int y = 0; y < SwimmerListDataGridView.Columns.Count; y++)
                {
                    if (SwimmerListDataGridView.Rows[x].Cells[y].Value.ToString() != null)
                    {
                        response = SwimmerListDataGridView.Rows[x].Cells[y].Value.ToString();
                        return response;
                    }
                }
            }
        }
        */


        private void FilterTenthGradeBtn_Click(object sender, EventArgs e)
        {
            string word = "10";

            foreach (DataGridViewRow row in SwimmerListDataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if ((cell.ColumnIndex == 2) && (cell.Value != word)) //Set your Column Index
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void FilterEleventhGradeBtn_Click(object sender, EventArgs e)
        {
            string word = "11";

            foreach (DataGridViewRow row in SwimmerListDataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if ((cell.ColumnIndex == 2) && (cell.Value != word)) //Set your Column Index
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void FilterTwelthGradeBtn_Click(object sender, EventArgs e)
        {
            string word = "12";

            foreach (DataGridViewRow row in SwimmerListDataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if ((cell.ColumnIndex == 2) && (cell.Value != word)) //Set your Column Index
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void FilterMaleBtn_Click(object sender, EventArgs e)
        {
            string word = "M";

            foreach (DataGridViewRow row in SwimmerListDataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if ((cell.ColumnIndex == 3) && (cell.Value != word)) //Set your Column Index
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void FilterFemaleBtn_Click(object sender, EventArgs e)
        {
            string word = "F";

            foreach (DataGridViewRow row in SwimmerListDataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if ((cell.ColumnIndex == 3) && (cell.Value != word)) //Set your Column Index
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        /*
        private void EditSwimmerListBtn_Click(object sender, EventArgs e)
        {
            
            EditSwimmerListForm EditSwimmer = new EditSwimmerListForm();
            EditSwimmer.Owner = this;
            try
            {
                this.Hide();
                EditSwimmer.ShowDialog();
            }
            finally
            {
                EditSwimmer.Dispose();
            }
            //this.Hide();
            //EditSwimmerListForm.Show();
            

            EditSwimmerListForm EditSwimmer = new EditSwimmerListForm(this);
            this.Hide();
            EditSwimmer.Show();
        }
            */

        private void resetBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in SwimmerListDataGridView.Rows)
            {
                row.Visible = true;
            }
        }

        private void AddSwimmerBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            //AddSwimmerForm swForm = new AddSwimmerForm();
            var swForm = new AddSwimmerForm();
            swForm.Show();
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