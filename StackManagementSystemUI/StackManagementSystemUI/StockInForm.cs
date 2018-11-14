using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StackManagementSystemUI.StockInModels;
using StackManagementSystemUI.StackInBLL;
using StackManagementSystemUI.StockInBLL;
using StackManagementSystemUI.StockInBLL;
using StackManagementSystemUI.StockInBLL;
using StackManagementSystemUI.StockInBLL;




namespace StackManagementSystemUI
{
    public partial class StockInForm : Form
    {
        public StockInForm()
        {
            InitializeComponent();
        }
      
        StackInCompanyManager companyManager = new StackInCompanyManager();
        StockInCategoryManager categoryManager = new StockInCategoryManager();
        StockInItemManager itemManager = new StockInItemManager();
        StockInSelectedItemManager selectedItemmanager = new StockInSelectedItemManager();
    



        private void StockInForm_Load(object sender, EventArgs e)
        {

            DataTable dt = companyManager.GetCompanyNames();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                companyStockInComboBox.Items.Add(dt.Rows[i]["Name"]);
            }
        }

        private void companyStockInComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoryStockInComboBox.Text = "";
            categoryStockInComboBox.Items.Clear();
            reorderStockInLavelTextBox.Text = "";
            availableQuantityStockInTextBox.Text = "";
            itemStockInComboBox.Text = "";

            string selectedCompany = companyStockInComboBox.Text;

            DataTable dt = categoryManager.GetCategoryNames(selectedCompany);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                categoryStockInComboBox.Items.Add(dt.Rows[i]["Category"]);

            }
        }


        private void categoryStockInComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemStockInComboBox.Text = "";
            itemStockInComboBox.Items.Clear();
            reorderStockInLavelTextBox.Text = "";
            availableQuantityStockInTextBox.Text = "";


            string selectedCategory = categoryStockInComboBox.Text;

            DataTable dt = itemManager.GetItems(selectedCategory);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                itemStockInComboBox.Items.Add(dt.Rows[i]["Item"]);

            }
        }

        private void itemStockInComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seletedItem = itemStockInComboBox.Text;

            DataTable dt = selectedItemmanager.GetReorderLevel_and_AvailableQuantity(seletedItem);
            reorderStockInLavelTextBox.Text = Convert.ToString(dt.Rows[0]["ReorderLabel"]);
            availableQuantityStockInTextBox.Text = Convert.ToString(dt.Rows[0]["AvailableQuantity"]);

            int presentvalue = Convert.ToInt32(availableQuantityStockInTextBox.Text);
            int reorderLevel = Convert.ToInt32(reorderStockInLavelTextBox.Text);

            if (presentvalue <= reorderLevel)
            {
                MessageBox.Show("Your stock is limited !! Please stock in fast !");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            StockIn stockInObj = new StockIn();
            stockInObj.ItemName = itemStockInComboBox.Text;
            stockInObj.previousQuantity = Convert.ToInt32(availableQuantityStockInTextBox.Text);
            stockInObj.stockInQuantity = Convert.ToInt32(stockInQuantityTextBox.Text);
            availableQuantityStockInTextBox.Text = (stockInObj.previousQuantity + stockInObj.stockInQuantity).ToString();

            StockInManager stockInManager = new StockInManager();
            string stockInInfo = stockInManager.StockInQuantity(stockInObj);
            MessageBox.Show(stockInInfo);
        }

       

    }
}
