using ImportExportData.Events;
using System;
using System.Windows.Forms;

namespace ComputerScienceInternalAssessment
{

    //public delegate void UpdateSwimmerListDataGridViewHandler(object sender, UpdateSwimmerListDGVEventArgs e);

    //public event UpdateSwimmerListDataGridViewHandler UpdateDGV;

    //string _file = string.Empty;

    //string _file = string.Empty;
    public partial class ImportForm : Form
    {
        public ImportForm()
        {
            InitializeComponent();

            this.ExcelFileNameTxtBox.Text = "";
            this.ExcelFileNameTxtBox.Enabled = false;

            this.XMLFileNameTxtBox.Text = "";
            this.XMLFileNameTxtBox.Enabled = false;


        }

        private void ImportForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToScreen();
            this.ControlBox = false;

        }

        private void BackToSwimmerListBtn_Click(object sender, EventArgs e)
        {
            var SwimmerListForm = new SwimmerListForm();
            this.Hide();
            SwimmerListForm.Show();
        }

        private void SelectExcelFileBtn_Click(object sender, EventArgs e)
        {
            /*
            OpenFileDialog fdlg = new OpenFileDialog();

            //Set Tile of OpenFileDialog
            openDialog.Title = "Select An Excel File";

            //Set the File Filter of OpenFileDialog
            openDialog.Filter = "Excel 7.0 (*.xlsx)|*.xlsx" + "|" +
                                "Excel (*.xls)|*.xls" + "|" +
                                "CSV (*.csv)|*.csv" + "|" +
                                "All Files (*.*)|*.*";

            //Get the OK press of the Dialog Box
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                //Get Selected File
                _file = openDialog.FileName;
                this.txtFile.Text = _file;
            }
            */
        }

        private void SelectXMLFileBtn_Click(object sender, EventArgs e)
        {

        }

        private void ImportXMLBtn_Click(object sender, EventArgs e)
        {

        }

        private void ImportExcelBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
