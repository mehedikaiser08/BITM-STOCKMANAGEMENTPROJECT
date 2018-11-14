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

namespace StackManagementSystemUI
{
    public partial class StockInForm : Form
    {
        public StockInForm()
        {
            InitializeComponent();
        }

        StockInCompanyLoadManager sInComLMagObj = new StockInCompanyLoadManager();
        StockInCategoryComboManager sInCatgComboMangObj = new StockInCategoryComboManager();
        StockInItemLoadComManager sInItemLdComMangObj = new StockInItemLoadComManager();
        StockInSelectedItemManager sInSelecItemMangObj = new StockInSelectedItemManager();

        private void StockInForm_Load(object sender, EventArgs e)
        {
           
            DataTable dt = sInComLMagObj.GetCompanyNames();
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
           
            DataTable dt = sInCatgComboMangObj.GetCategoryNames(selectedCompany);

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
            
            DataTable dt = sInItemLdComMangObj.GetItemForComboBox(selectedCategory);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                itemStockInComboBox.Items.Add(dt.Rows[i]["Item"]);
                
            }

            
        }

        private void itemStockInComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seletedItem = itemStockInComboBox.Text;
            
            DataTable dt = sInSelecItemMangObj.GetReorderAndAvaQuantity(seletedItem);
            reorderStockInLavelTextBox.Text = Convert.ToString(dt.Rows[0]["ReorderLabel"]);
            availableQuantityStockInTextBox.Text = Convert.ToString(dt.Rows[0]["AvailableQuantity"]);

            int presentvalue = Convert.ToInt32(availableQuantityStockInTextBox.Text);
            int reorderLabel = Convert.ToInt32(reorderStockInLavelTextBox.Text);

            if (presentvalue <= reorderLabel)
            {
                MessageBox.Show("Your stock is limited !! Please stock in fast !");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            StockIn stockInObj=new StockIn();
            stockInObj.ItemName = itemStockInComboBox.Text;
            stockInObj.previousQuntity = Convert.ToInt32(availableQuantityStockInTextBox.Text);
            stockInObj.stockInQuantity = Convert.ToInt32(stockInQuantityTextBox.Text);
            availableQuantityStockInTextBox.Text = (stockInObj.previousQuntity + stockInObj.stockInQuantity).ToString();

            StockInManager stockInMangObj = new StockInManager();
            string stockInInfo = stockInMangObj.StockInQuantity(stockInObj);
            MessageBox.Show(stockInInfo);

        }





    }
}
