using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StackManagementSystemUI.StockInBLL;
using StackManagementSystemUI.StockInDAL;
using StackManagementSystemUI.StockInModels;
using StackManagementSystemUI.SearchModels;
using StackManagementSystemUI.SearchBLL;

namespace StackManagementSystemUI
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            StockInCompanyLoadManager sInComLMagObj = new StockInCompanyLoadManager();
            DataTable dt = sInComLMagObj.GetCompanyNames();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                searchCompanyComboBox.Items.Add(dt.Rows[i]["Name"]);
            }
        }

        private void searchCompanyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchCategoryComboBox.Text = "";
            searchCategoryComboBox.Items.Clear();


            string selectedCompany = searchCompanyComboBox.Text;

            StockInCategoryComboManager sInCatgComboMangObj = new StockInCategoryComboManager();
            DataTable dt = sInCatgComboMangObj.GetCategoryNames(selectedCompany);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                searchCategoryComboBox.Items.Add(dt.Rows[i]["Category"]);

            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Search searchObj=new Search();
            searchObj.Company = searchCompanyComboBox.Text;
            searchObj.Category = searchCategoryComboBox.Text;


            SearchManager searchMangObj=new SearchManager();
            DataTable dt = searchMangObj.SearchInfo(searchObj);
            searchDataGridView.DataSource = dt;
        }
    }
}
