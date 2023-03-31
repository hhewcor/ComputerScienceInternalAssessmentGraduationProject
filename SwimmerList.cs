using System;
using System.ComponentModel;
using System.Windows.Forms;

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
            col.Name = "Calculate Time";
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

        //Event triggers when the user clicks on a button inside the SwimmerListDataGridView.
        private void SwimmerListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Creates a 2D array the size of the SwimmerListDataGridView.
            string[,] dataValue = new string[SwimmerListDataGridView.Rows.Count, SwimmerListDataGridView.Columns.Count];

            //Loops through the rows of SwimmerListDataGridView.
            foreach (DataGridViewRow row in SwimmerListDataGridView.Rows)
            {
                //Gets index of row.
                int i = row.Index;

                //Loops through the columns of SwimmerListDataGridView.
                foreach (DataGridViewColumn col in SwimmerListDataGridView.Columns)
                {
                    //getting index of column
                    int j = col.Index;
                    //add all the rows and column to 2D Array
                    dataValue[row.Index, col.Index] = SwimmerListDataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }

            //Gets the row index of the Calculate Time column for when the user clicks on the view button to calculate the time
            //of a particular swimmer.
            if ((e.ColumnIndex == SwimmerListDataGridView.Columns["Calculate Time"].Index) && (e.RowIndex >= 0))
            {
                try
                {
                    //Variables
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

                    //Adds the values from the swimmer goal time that was split up by the ':' and '.' .
                    for (int x = 0; x < splitGoalTime.Length; x++)
                    {
                        test += splitGoalTime[x];
                    }

                    //Adds the values from the Swimmer time that was split up by the ':' and '.'.
                    for (int y = 0; y < splitTime.Length; y++)
                    {
                        test2 += splitTime[y];
                    }

                    //Determines whether the goal time or the swimmer time was greater. Used to determine if the swimmer gained/dropped/or swam the same time.
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

                    //Sets up the message displayed in the message box once calculations are done.
                    defaultAnswer = SwimmerFn + " " + SwimmerLn + " swam " + SwimmerTime + " in the " + Swimmerevt + ".\n" + "Their goal time was " + SwimmerGoalTime + "." + "\n" + "They ";

                    //If the minute/second of the swimmer time is greater than the minute/second of the goal time, the swimmer gained time.
                    if (int.Parse(splitTime[0]) > int.Parse(splitGoalTime[0]))
                    {
                        dropGain = "gained";
                        answer = defaultAnswer + dropGain + " " + finish + ".";
                    }

                    //If the minute/second of the swimmer time is less than the minute/second of the goal time, then the swimmer droped time.
                    if (int.Parse(splitTime[0]) < int.Parse(splitGoalTime[0]))
                    {
                        dropGain = "dropped";
                        answer = defaultAnswer + dropGain + " " + finish + ".";
                    }

                    //If the minute/second of the swimmer time equals the minute/second of the goal time, needed to verify the second/millisecond.
                    if (int.Parse(splitTime[0]) == int.Parse(splitGoalTime[0]))
                    {
                        //If the second/millisecond of the swimmer time is greater than the second/millisecond of the goal time, then the swimmer gained time.
                        if (int.Parse(splitTime[1]) > int.Parse(splitGoalTime[1]))
                        {
                            dropGain = "gained";
                            answer = defaultAnswer + dropGain + " " + finish + ".";
                        }
                        //If the second/millisecond of the swimmer time is less than the second/millisecond of the goal time, then the swimmer dropped time.
                        if (int.Parse(splitTime[1]) < int.Parse(splitGoalTime[1]))
                        {
                            dropGain = "dropped";
                            answer = defaultAnswer + dropGain + " " + finish + ".";
                        }
                        //If the second/millisecond of the swimmer time is equal to the second/millisecond of the goal time, then swimmer didn't drop or gain time.
                        if ((int.Parse(splitTime[1]) == int.Parse(splitGoalTime[1])) && (splitTime.Length == 2))
                        {
                            answer = defaultAnswer + "didn't drop or gain time.";
                        }

                        //If the second of the swimmer time is equal to the second of the goal time.
                        if ((int.Parse(splitTime[1]) == int.Parse(splitGoalTime[1])) && (splitTime.Length == 3))
                        {
                            //If the millisecond of swimmer time is greater than the millisecond of goal time, then the swimmer gained time.
                            if (int.Parse(splitTime[2]) > int.Parse(splitGoalTime[2]))
                            {
                                dropGain = "gained";
                                answer = defaultAnswer + dropGain + " " + finish + ".";
                            }

                            //If the millisecond of swimmer time is less than the millisecond of goal time, then the swimmer dropped time.
                            if (int.Parse(splitTime[2]) < int.Parse(splitGoalTime[2]))
                            {
                                dropGain = "dropped";
                                answer = defaultAnswer + dropGain + " " + finish + ".";
                            }

                            //If the millisecond of swimmer time is equal to the millisecond of goal time, then the swimmer didn't drop or gain time.
                            if (int.Parse(splitTime[2]) == int.Parse(splitGoalTime[2]))
                            {
                                answer = defaultAnswer + "didn't drop or gain time.";
                            }
                        }
                    }
                    //Prints the calculation for the swimmer.
                    MessageBox.Show(answer);
                }
                //Catch used if there is an instance that I didn't think of when calculating whether a swimmer gained/dropped/ or remained at the same time.
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }

            //Gets the row index of the Edit Swimmer column for when the user clicks on the edit button to change the values
            //of a particular swimmer.
            else if ((e.ColumnIndex == SwimmerListDataGridView.Columns["Edit Swimmer"].Index) && (e.RowIndex >= 0))
            {
                try
                {
                    //Variables
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

                    //Opens a modal of the EditSwimmer Form. Sends all the current data of the particular swimmer row to the form. Only one instance of this form is created.
                    EditSwimmerForm edForm = new EditSwimmerForm(this, SwimmerFn, SwimmerLn, SwimmerGrd, SwimmerGnd, stroke, distance, SwimmerGoalTime, SwimmerTime);
                    edForm.checkEdit = edForm.checkInfo();
                    edForm.ShowDialog();

                    //Not performed unless the data was inputted into the form correctly, and the form was actually changed.
                    if (edForm.checkEdit == true && edForm.change == true)
                    {
                        //Updates the SwimmerListDataGridView
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
                //Catch used if there is an instance I didn't think of when passing data between the SwimmerListForm and the EditSwimmerForm.
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }

            //Gets the row index of the Delete Swimmer column for when the user clicks on the delete button to remove a swimmer from the SwimmerDataGridView.
            else if ((e.ColumnIndex == SwimmerListDataGridView.Columns["Delete Swimmer"].Index) && (e.RowIndex >= 0))
            {
                try
                {
                    //Creates MessageBox as a modal that confirms whether the user wishes to delete the swimmer.
                    DialogResult dialogResult = MessageBox.Show("Do you wish to delete this swimmer?", "Delete Swimmer Confirmation", MessageBoxButtons.YesNo);

                    //Removes the swimmer if the user clicks yes.
                    if (dialogResult == DialogResult.Yes)
                    {
                        SwimmerListDataGridView.Rows.Remove(SwimmerListDataGridView.Rows[e.RowIndex]);
                    }
                }
                //Catch used if situation occurs that I didn't predict for removing a swimmer from the SwimmerListDataGridView.
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }

        //When user clicks on the Back button, the SwimmerListForm is hidden and the user is returned to the StartForm.
        private void BackToStartBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm stForm = new StartForm();
            stForm.Show();
        }

        //Help button.
        private void SwimmerListHelpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ADD SWIMMER: Click on the Add Swimmer button. \n" + "EDIT: Click on the Edit Button under the column name Edit Swimmer to edit the values of the selected swimmer. \n" + "DELETE: Click on the Delete Button under the column name Delete Swimmer to remove the selected swimmer from the DataGridView.\n" + "SEARCH: Click on the FirstName criteria to find all instances of the name typed into the search bar." + " Click on the LastName criteria to find all instances of the name typed into the search bar." + " Click on the FirstAndLastName criteria to find one specific name from the DataGridView. *Name must be separated by a space. \n" + "RESET SEARCH: Click on the Clear button. \n" + "FILTER: Click on any of the pink buttons. To reset the filters click on the Reset button.\n" + "\n" + "*NOTE: A swimmer must be added before you can edit, delete, search, or filter the list.");
        }

        //Int that helps keep track of whether the SwimmerListDataGridView has had all of its rows hidden.
        private int rowCount = 0;

        //When user clicks on the SearchSwimmerNameBtn, the SearchTxtBox is verified before filtering the SwimmerListDataGridView.
        private void SearchSwimmerNameBtn_Click(object sender, EventArgs e)
        {
            //Verifies if the SwimmerListDataGridView is empty.
            if (SwimmerListDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Please add some swimmers.");
            }
            //Verifies that the search bar isn't empty and the search criteria is selected.
            else if (((FirstNameRadioBtn.Checked == false) && (LastNameRadioBtn.Checked == false) && (FirstAndLastNameBtn.Checked == false)) && (SearchTxt.Text == string.Empty))
            {
                MessageBox.Show("Please enter a name and select a search criteria.");
            }
            //Verifies that the search bar isn't empty
            else if(SearchTxt.Text == String.Empty)
            {
                MessageBox.Show("Please enter a name in the search bar.");
            }

            //Verifies that a search criteria was selected.
            else if((FirstNameRadioBtn.Checked == false) && (LastNameRadioBtn.Checked == false) && (FirstAndLastNameBtn.Checked == false))
            {
                MessageBox.Show("Please select a search criteria.");
            }
            else
            {
                //Word to be found.
                string word = SearchTxt.Text;

                //Performs the FirstName search criteria option.
                if ((FirstNameRadioBtn.Checked == true) && (word != string.Empty))
                {
                    //Sorts the first names by ascending order.
                    SwimmerListDataGridView.Sort(SwimmerListDataGridView.Columns[0], ListSortDirection.Ascending);

                    //Loops through the SwimmerListDataGridView to hide any rows whose first name doesn't equal the name being searched.
                    foreach (DataGridViewRow row in SwimmerListDataGridView.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if ((cell.ColumnIndex == 0) && !(String.Equals(cell.Value, word))) //Set your Column Index
                            {
                                row.Visible = false;
                                rowCount += 1;
                            }
                        }
                    }

                    //Checks if all the rows in SwimmerListDataGridView had been hidden to determine what message should be presented to the user.
                    if(rowCount == SwimmerListDataGridView.Rows.Count)
                    {
                        MessageBox.Show("Swimmer(s) with first name " + word + " not found.");
                    }
                    else
                    {
                        MessageBox.Show("Swimmer(s) with first name " + word + " found.");
                    }
                }

                //Performs the LastName search criteria option.
                if ((LastNameRadioBtn.Checked == true) && (word != string.Empty))
                {
                    //Sorts the last names by ascending order.
                    SwimmerListDataGridView.Sort(SwimmerListDataGridView.Columns[1], ListSortDirection.Ascending);

                    //Loops through the SwimmerListDataGridView to hide any rows whose last names doesn't equal the name being searched.
                    foreach (DataGridViewRow row in SwimmerListDataGridView.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if ((cell.ColumnIndex == 1) && !(String.Equals(cell.Value, word))) //Set your Column Index
                            {
                                row.Visible = false;
                                rowCount += 1;
                            }
                        }
                    }

                    //Checks if all rows in SwimmerListDataGridView had been hidden to determine what message should be presented to the user.
                    if (rowCount == SwimmerListDataGridView.Rows.Count)
                    {
                        MessageBox.Show("Swimmer(s) with last name " + word + " not found.");
                    }
                    else
                    {
                        MessageBox.Show("Swimmer(s) with last name " + word + " found.");
                    }
                }

                //Performs the FirstAndLastName search criteria option.
                if ((FirstAndLastNameBtn.Checked == true) && (word != string.Empty))
                {
                    //Sorts the first names by ascending order.
                    SwimmerListDataGridView.Sort(SwimmerListDataGridView.Columns[0], ListSortDirection.Ascending);

                    //Creates a String array the size of the Rows in SwimmerListDataGridView.
                    String[] names = new string[SwimmerListDataGridView.Rows.Count];

                    //Fills the String array names with a concatenated First and Last Name.
                    foreach (DataGridViewRow row in SwimmerListDataGridView.Rows)
                    {
                        //getting index of row
                        int i = row.Index;
                        
                        names[row.Index] = SwimmerListDataGridView.Rows[i].Cells[0].Value.ToString() + " " + SwimmerListDataGridView.Rows[i].Cells[1].Value.ToString();
                    }

                    //Binary searches to find the location of the name being searched if it exists within the names String array.
                    int location = binarySearch(names, word);

                    //If the name doesn't exist within the SwimmerListDataGridView, informs the user that the name doesn't exist.
                    if(location == -1)
                    {
                        MessageBox.Show("Swimmer with first and last name " + word + " not found.");
                    }
                    //If the name exists within the SwimmerListDataGridView, hides all rows that are not the name being searched for.
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
                }
            }
        }

        //Method to sort through a String array to find the desired string. l = min r = max m = middle
        static int binarySearch(String[] arr, String x)
        {
            int min = 0, max = arr.Length - 1;
            while (min <= max)
            {
                int middle = min + (max - min) / 2;

                int result = x.CompareTo(arr[middle]);

                // Check if String x is present at middle
                if (result == 0)
                    return middle;

                // If String x greater, ignore left half.
                if (result > 0)
                    min = middle + 1;

                // If String x is smaller, ignore right half.
                else
                    max = middle - 1;
            }

            //Returns -1 if the string isn't in the DataGridView.
            return -1;
        }

        //Filters swimmers in the ninth grade in the SwimmerListDataGridView.
        private void FilterNinthGradeBtn_Click(object sender, EventArgs e)
        {
            string word = "9";

            foreach (DataGridViewRow row in SwimmerListDataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if ((cell.ColumnIndex == 2) && (cell.Value != word))
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        //Filters swimmers in the tenth grade in the SwimmerListDataGridView.
        private void FilterTenthGradeBtn_Click(object sender, EventArgs e)
        {
            string word = "10";

            foreach (DataGridViewRow row in SwimmerListDataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if ((cell.ColumnIndex == 2) && (cell.Value != word))
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        //Filters swimmers in the eleventh grade in the SwimmerListDataGridView.
        private void FilterEleventhGradeBtn_Click(object sender, EventArgs e)
        {
            string word = "11";

            foreach (DataGridViewRow row in SwimmerListDataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if ((cell.ColumnIndex == 2) && (cell.Value != word))
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        //Filters swimmers in the twelth grade in the SwimmerListDataGridView.
        private void FilterTwelthGradeBtn_Click(object sender, EventArgs e)
        {
            string word = "12";

            foreach (DataGridViewRow row in SwimmerListDataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if ((cell.ColumnIndex == 2) && (cell.Value != word))
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        //Filters swimmers that are male in the SwimmerListDataGridView.
        private void FilterMaleBtn_Click(object sender, EventArgs e)
        {
            string word = "M";

            foreach (DataGridViewRow row in SwimmerListDataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if ((cell.ColumnIndex == 3) && (cell.Value != word))
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        //Filters swimmers that are female in the SwimmerListDataGridView.
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

        //Clears all filters on the SwimmerListDataGridView.
        private void resetBtn_Click(object sender, EventArgs e)
        {
            resetGrid();
        }

        //Makes all hidden rows in the SwimmerListDataGridView visible.
        private void resetGrid()
        {
            foreach (DataGridViewRow row in SwimmerListDataGridView.Rows)
            {
                row.Visible = true;
            }
        }

        //Opens the AddSwimmerForm when the user clicks on the AddSwimmer button.
        private void AddSwimmerBtn_Click(object sender, EventArgs e)
        {
            //Opens a modal form.
            AddSwimmerForm swForm = new AddSwimmerForm(this);
            swForm.ShowDialog();

            //Verifies that all information has been verified on the form before adding the swimmer to the SwimmerListDataGridView.
            swForm.check = swForm.checkInfo();
            if (swForm.check == true)
            {
                SwimmerListDataGridView.Rows.Add(swForm.swFirstName, swForm.swLastName, swForm.swGrade, swForm.swGender, swForm.swEvent, swForm.swGT, swForm.swT);
            }
            else
            {
                swForm.Dispose();
            }
        }

        //Restricts the user to only typing characters and the backspace.
        private void SearchTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                MessageBox.Show("Please type letters only.");
                e.Handled = true;
            }
        }

        //Resets the SwimmerListDataGridView and clears the Search criteria and Search bar.
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            resetGrid();
            SearchTxt.Text = string.Empty;

            FirstNameRadioBtn.Checked = false;
            LastNameRadioBtn.Checked = false;
            FirstAndLastNameBtn.Checked = false;
    
            rowCount = 0;
        }

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