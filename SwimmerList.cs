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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using TreeView = System.Windows.Forms.TreeView;

namespace ComputerScienceInternalAssessment
{
    public partial class SwimmerListForm : Form
    {
        //Initializes the form and sets up SwimmerListDataGridView.
        public SwimmerListForm()
        {
            InitializeComponent();
            ConstructSwimmerListDataGridView();
        }

        //Disables user controls to change the sizing of the form and the maximize/minimize.
        private void SwimmerListForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToScreen();
            this.ControlBox = false;
        }

        //Creates the SwimmerListDataGridView.
        private void ConstructSwimmerListDataGridView()
        {
            //Adds seven columns to SwimmerListDataGridView.
            SwimmerListDataGridView.ColumnCount = 7;

            //Sets the name of the seven columns of SwimmerListDataGridView.
            SwimmerListDataGridView.Columns[0].Name = "First Name";
            SwimmerListDataGridView.Columns[1].Name = "Last Name";
            SwimmerListDataGridView.Columns[2].Name = "Grade";
            SwimmerListDataGridView.Columns[3].Name = "Gender";
            SwimmerListDataGridView.Columns[4].Name = "Event";
            SwimmerListDataGridView.Columns[5].Name = "Goal Time";
            SwimmerListDataGridView.Columns[6].Name = "Swimmer Time";

            //Autosizes the columns to show all the text.
            SwimmerListDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Adds to the SwimmerListDataGridView a clickable button that allows the user to compare the goal time and actual time of the swimmer.
            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "VIEW";
            col.Name = "Compare Time";
            SwimmerListDataGridView.Columns.Add(col);

            //Adds to the SwimmerListDataGridView a clickable button that allows the user to edit the fields of the swimmer.
            DataGridViewButtonColumn col2 = new DataGridViewButtonColumn();
            col2.UseColumnTextForButtonValue = true;
            col2.Text = "Edit";
            col2.Name = "Edit Swimmer";
            SwimmerListDataGridView.Columns.Add(col2);

            //Adds to the SwimmerListDataGridView a clickable button that allows the user to delete the swimmer from SwimmerListDataGridView.
            DataGridViewButtonColumn col3 = new DataGridViewButtonColumn();
            col3.UseColumnTextForButtonValue = true;
            col3.Text = "Delete";
            col3.Name = "Delete Swimmer";
            SwimmerListDataGridView.Columns.Add(col3);

            //Disables the filter that allows a user to sort based on column the SwimmerListDataGridView. (ascending/descending)
            foreach (DataGridViewColumn column in SwimmerListDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void SwimmerListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Creates a 2D array the size of the SwimmerListDataGridView
            string[,] dataValue = new string[SwimmerListDataGridView.Rows.Count, SwimmerListDataGridView.Columns.Count];

            //loop through the rows of SwimmerListDataGridView
            foreach (DataGridViewRow row in SwimmerListDataGridView.Rows)
            {
                //getting index of row
                int i = row.Index;

                //loop through the columns of SwimmerListDataGridView
                foreach (DataGridViewColumn col in SwimmerListDataGridView.Columns)
                {
                    //getting index of column
                    int j = col.Index;
                    //add all the rows and column to 2D Array
                    dataValue[row.Index, col.Index] = SwimmerListDataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }

            //TODO: FIX Wording of GOAL TIME Drop Gain.
            //
            if ((e.ColumnIndex == SwimmerListDataGridView.Columns["Compare Time"].Index) && (e.RowIndex >= 0))
            {
                try
                {
                    string SwimmerFn = dataValue[e.RowIndex, 0];
                    string SwimmerLn = dataValue[e.RowIndex, 1];
                    string Swimmerevt = dataValue[e.RowIndex, 4];
                    string SwimmerGoalTime = dataValue[e.RowIndex, 5];
                    string SwimmerTime = dataValue[e.RowIndex, 6];
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

                    MessageBox.Show(answer);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }

            else if ((e.ColumnIndex == SwimmerListDataGridView.Columns["Edit Swimmer"].Index) && (e.RowIndex >= 0))
            {
                try
                {
                    int rowIndex = e.RowIndex;
                    string SwimmerFn = dataValue[e.RowIndex, 0];
                    string SwimmerLn = dataValue[e.RowIndex, 1];
                    string SwimmerGrd = dataValue[e.RowIndex, 2];
                    string SwimmerGnd = dataValue[e.RowIndex, 3];
                    string Swimmerevt = dataValue[e.RowIndex, 4];
                    string SwimmerGoalTime = dataValue[e.RowIndex, 5];
                    string SwimmerTime = dataValue[e.RowIndex, 6];

                    string[] splitEvent = Swimmerevt.Split(' ');

                    String distance = splitEvent[0];
                    String stroke = splitEvent[1];

                    EditSwimmerForm edForm = new EditSwimmerForm(this, SwimmerFn, SwimmerLn, SwimmerGrd, SwimmerGnd, stroke, distance, SwimmerGoalTime, SwimmerTime);
                    edForm.checkEdit = edForm.checkInfo();
                    edForm.ShowDialog();

                    if (edForm.checkEdit == true)
                    {
                        SwimmerListDataGridView[0, rowIndex].Value = edForm.swFirstName;
                        SwimmerListDataGridView[1, rowIndex].Value = edForm.swLastName;
                        SwimmerListDataGridView[2, rowIndex].Value = edForm.swGrade;
                        SwimmerListDataGridView[3, rowIndex].Value = edForm.swGender;
                        SwimmerListDataGridView[4, rowIndex].Value = edForm.swEvent;
                        SwimmerListDataGridView[5, rowIndex].Value = edForm.swGT;
                        SwimmerListDataGridView[6, rowIndex].Value = edForm.swT;
                    }
                    else
                    {
                        edForm.Dispose();
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }

            else if ((e.ColumnIndex == SwimmerListDataGridView.Columns["Delete Swimmer"].Index) && (e.RowIndex >= 0))
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Do you wish to delete this swimmer?", "Delete Swimmer Confirmation", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        SwimmerListDataGridView.Rows.Remove(SwimmerListDataGridView.Rows[e.RowIndex]);
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }

        private void BackToStartBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm stForm = new StartForm();
            stForm.Show();
        }

        //ENDED HERE ON CODE REVIEW.
        private void SwimmerListHelpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PLACE HOLDER");
        }

        private bool FirstNameOptionSelected = false;
        private bool LastNameOptionSelected = false;
        private bool FirstAndLastNameOptionSelected = false;
        private bool OptionsSelected = true;

        private void SearchSwimmerNameBtn_Click(object sender, EventArgs e)
        {
            if (SwimmerListDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Please add some swimmers.");
            }
            else if (((FirstNameRadioBtn.Checked == false) && (LastNameRadioBtn.Checked == false) && (FirstAndLastNameBtn.Checked == false)) && (SearchTxt.Text == string.Empty))
            {
                MessageBox.Show("Please enter a name and select a search criteria.");
            }
            else if(SearchTxt.Text == String.Empty)
            {
                MessageBox.Show("Please enter a name in the search bar.");
            }
            else if((FirstNameRadioBtn.Checked == false) && (LastNameRadioBtn.Checked == false) && (FirstAndLastNameBtn.Checked == false))
            {
                MessageBox.Show("Please select a search criteria.");
            }
            else
            {
                string word = SearchTxt.Text;
                if ((FirstNameRadioBtn.Checked == true) && (word != string.Empty))
                {
                    //resetGrid();
                    SwimmerListDataGridView.Sort(SwimmerListDataGridView.Columns[0], ListSortDirection.Ascending);

                    foreach (DataGridViewRow row in SwimmerListDataGridView.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if ((cell.ColumnIndex == 0) && !(String.Equals(cell.Value, word))) //Set your Column Index
                            {
                                row.Visible = false;
                            }
                        }
                    }
                }

                if ((LastNameRadioBtn.Checked == true) && (word != string.Empty))
                {
                    //resetGrid();
                    SwimmerListDataGridView.Sort(SwimmerListDataGridView.Columns[1], ListSortDirection.Ascending);

                    foreach (DataGridViewRow row in SwimmerListDataGridView.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if ((cell.ColumnIndex == 1) && !(String.Equals(cell.Value, word))) //Set your Column Index
                            {
                                row.Visible = false;
                            }
                        }
                    }
                }

                if ((FirstAndLastNameBtn.Checked == true) && (word != string.Empty))
                {
                    //string input = SearchTxt.Text;

                    //string[] split = word.Split(' ');
                    SwimmerListDataGridView.Sort(SwimmerListDataGridView.Columns[0], ListSortDirection.Ascending);

                    //String[] valuesFirstName = new String[SwimmerListDataGridView.Rows.Count];
                    //String[] valuesLastName = new String[SwimmerListDataGridView.Rows.Count];
                    String[] names = new string[SwimmerListDataGridView.Rows.Count];

                    foreach (DataGridViewRow row in SwimmerListDataGridView.Rows)
                    {
                        //getting index of row
                        int i = row.Index;
                        //valuesFirstName[row.Index] = SwimmerListDataGridView.Rows[i].Cells[0].Value.ToString();
                        //valuesLastName[row.Index] = SwimmerListDataGridView.Rows[i].Cells[1].Value.ToString();
                        names[row.Index] = SwimmerListDataGridView.Rows[i].Cells[0].Value.ToString() + " " + SwimmerListDataGridView.Rows[i].Cells[1].Value.ToString();
                    }

                    //SwimmerListDataGridView.Sort(SwimmerListDataGridView.Columns[1], ListSortDirection.Ascending);

                    //if (SwimmerListDataGridView.Rows[])

                    int location = binarySearch(names, word);

                    if(location == -1)
                    {
                        MessageBox.Show("Swimmer with first and last name " + word + " not found.");
                    }
                    else
                    {
                        MessageBox.Show("Swimmer with first and last name " + word + " found.");
                        foreach (DataGridViewRow row in SwimmerListDataGridView.Rows)
                        {
                            int ind = row.Index;
                            if (!(ind == location))
                            {
                                SwimmerListDataGridView.Rows[ind].Visible = false;
                            }
                        }
                    }
                    //int locationLastName = binarySearch(valuesLastName, split[1]);
                }
            }
        }

        /*
         * SwimmerListDataGridView.Sort(SwimmerListDataGridView.Columns[0], ListSortDirection.Ascending);

                String[] values = new String[SwimmerListDataGridView.Rows.Count];

                foreach (DataGridViewRow row in SwimmerListDataGridView.Rows)
                {
                    //getting index of row
                    int i = row.Index;
                    values[row.Index] = SwimmerListDataGridView.Rows[i].Cells[0].Value.ToString();
                }

                int location = binarySearch(values, SearchTxt.Text);

                if (location == -1)
                {
                    MessageBox.Show("Value not found.");
                }
                else
                {
                    foreach (DataGridViewRow row in SwimmerListDataGridView.Rows)
                    {
                        int ind = row.Index;
                        if (ind != location)
                        {
                            SwimmerListDataGridView.Rows[ind].Visible = false;
                        }
                    }
                }
        */

            /*String[] values = new String[SwimmerListDataGridView.Rows.Count];

                foreach (DataGridViewRow row in SwimmerListDataGridView.Rows)
                {
                    //getting index of row
                    int i = row.Index;
                    values[row.Index] = SwimmerListDataGridView.Rows[i].Cells[0].Value.ToString();
                }

                int location = binarySearch(values, SearchTxt.Text);

                if(location == -1)
                {
                    MessageBox.Show("Value not found.");
                }
                else
                {
                    foreach (DataGridViewRow row in SwimmerListDataGridView.Rows)
                    {
                        int ind = row.Index;
                        if(ind != location)
                        {
                            SwimmerListDataGridView.Rows[ind].Visible = false;
                        }
                    }
                    //SwimmerListDataGridView.Rows[location].Visible = true;
                }
            }
            */

        static int binarySearch(String[] arr, String x)
        {
            int l = 0, r = arr.Length - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;

                int res = x.CompareTo(arr[m]);

                // Check if x is present at mid
                if (res == 0)
                    return m;

                // If x greater, ignore left half
                if (res > 0)
                    l = m + 1;

                // If x is smaller, ignore right half
                else
                    r = m - 1;
            }

            return -1;
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

        private void resetBtn_Click(object sender, EventArgs e)
        {
            resetGrid();
        }

        private void resetGrid()
        {
            foreach (DataGridViewRow row in SwimmerListDataGridView.Rows)
            {
                row.Visible = true;
            }
        }

        private void AddSwimmerBtn_Click(object sender, EventArgs e)
        {
            //this.Close();
            //AddSwimmerForm swForm = new AddSwimmerForm();
            AddSwimmerForm swForm = new AddSwimmerForm(this);
            //SwimmerListDataGridView.Rows.Add(swForm.SendData());
            swForm.ShowDialog();
            swForm.check = swForm.checkInfo();
            if (swForm.check == true)
            {
                SwimmerListDataGridView.Rows.Add(swForm.swFirstName, swForm.swLastName, swForm.swGrade, swForm.swGender, swForm.swEvent, swForm.swGT, swForm.swT);
            }
            else
            {
                swForm.Dispose();
            }
            //if(swForm.)
            //swForm.VisibleChanged += formVisibleChanged;
        }

        private void SearchTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                MessageBox.Show("Please type letters only.");
                e.Handled = true;
                //swFirstNameSelected = true;
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            resetGrid();
            SearchTxt.Text = string.Empty;
            FirstNameRadioBtn.Checked = false;
            FirstNameOptionSelected = false;

            LastNameRadioBtn.Checked = false;
            LastNameOptionSelected = false;

            FirstAndLastNameBtn.Checked = false;
            FirstAndLastNameOptionSelected = false;

            OptionsSelected = false;
        }

        private void FirstNameRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            FirstNameOptionSelected = true;
            LastNameOptionSelected = false;
            FirstAndLastNameOptionSelected = false;
            OptionsSelected = true;
        }

        private void LastNameRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            LastNameOptionSelected= true;
            FirstNameOptionSelected = false;
            FirstNameOptionSelected = false;
            OptionsSelected = true;
        }

        private void FirstAndLastNameBtn_CheckedChanged(object sender, EventArgs e)
        {
            FirstAndLastNameOptionSelected = true;
            FirstNameOptionSelected = false;
            LastNameOptionSelected = false;
            OptionsSelected = true;
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

        /*
        private void formVisibleChanged(object sender, EventArgs e)
        {
            AddSwimmerForm swForm = (AddSwimmerForm)sender;
            if (!swForm.Visible)
            {
                SwimmerListDataGridView.Rows.Add();
                swForm.Dispose();
            }
        }
        */

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

        /*
        //Test Data
        public List<Swimmer> GetSwimmerList()
        {
            // List<Swimmer> swimmers = new List<Swimmer>();
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
            swimmers.Add(s);

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
            swimmers.Add(s);

            return swimmers;
        }
        */
    }
    }