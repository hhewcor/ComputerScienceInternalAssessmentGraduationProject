using ImportExportData.Events;
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

    public delegate void UpdateSwimmerListDataGridViewHandler(object sender, UpdateSwimmerListDataGridViewEventArgs e);

    //public event UpdateSwimmerListDataGridViewHandler UpdateDataGridView;
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

        private void ImportXMLBtn_Click(object sender, EventArgs e)
        {

        }

        private void ImportExcelBtn_Click(object sender, EventArgs e)
        {

        }

        private void SelectExcelFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();

            openDialog.Title = "Select an Excel File";

            openDialog.Filter = "Excel 7.0 (*.xlsx)|*.xlsx" + "|" +
                                "Excel (*.xls)|*.xls" + "|" +
                                "CSV (*.csv)|*.csv" + "|" +
                                "All Files (*.*)|*.*";

            //fix
            /*if(openDialog.ShowDialog() == DialogResult.OK)
            {
               // fileName = openDialog.FileName;
                //this.ExcelFileNameTxtBox.Text = _file;
            }*/
        }

        private void SelectXMLFileBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
