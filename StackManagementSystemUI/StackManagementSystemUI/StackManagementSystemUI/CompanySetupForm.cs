using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StackManagementSystemUI.CompanyModels;
using StackManagementSystemUI.CompanyBLL;

namespace StackManagementSystemUI
{
    public partial class CompanySetupForm : Form
    {
        int indexRow;
        UpdateComName upComObj = new UpdateComName();
        public CompanySetupForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            Company comObj = new Company();
            comObj.CompanyName = CompanyNameTextBox.Text;
            if (comObj.CompanyName == "")
            {
                MessageBox.Show("Empty value not accepted !");
                return;
            }


            CompanyManager comMangObj = new CompanyManager();
            bool companyInfo = comMangObj.SaveCompInfo(comObj);
            if (companyInfo == true)
            {
                MessageBox.Show("Company Name Saved !");
            }
            else
            {
                MessageBox.Show("Company name already exist !");
                return;
            }

            DataTable DT = comMangObj.CompanyDataTable();
            companyDataGridView.DataSource = DT;
            editButton.Enabled = true;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            saveButton.Enabled = true;
            DataGridViewRow newDataRow = companyDataGridView.Rows[indexRow];
            upComObj.CompanyUpdateName = CompanyNameTextBox.Text;

            CompanyUpdateManager comUpdMangObj = new CompanyUpdateManager();
            bool updateInfo = comUpdMangObj.UpdateCompanyName(upComObj);
            if (updateInfo == true)
            {
                newDataRow.Cells[1].Value = upComObj.CompanyUpdateName;
                MessageBox.Show("Company Updated");
                return;
            }
            else
            {
                MessageBox.Show("Company name already exist !");
                return;
            }

            editButton.Enabled = false;

        }

        private void companyDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            saveButton.Enabled = false;
            editButton.Enabled = true;
            indexRow = e.RowIndex;
            DataGridViewRow row = companyDataGridView.Rows[indexRow];
            CompanyNameTextBox.Text = row.Cells[1].Value.ToString();
            upComObj.ComPreviousName = row.Cells[1].Value.ToString();
        }

        private void CompanySetupForm_Load(object sender, EventArgs e)
        {
            editButton.Enabled = false;
        }



    }
}
