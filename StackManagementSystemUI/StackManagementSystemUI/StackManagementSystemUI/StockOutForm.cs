using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StackManagementSystemUI.ItemModels;
using StackManagementSystemUI.StcOutBLL;
using StackManagementSystemUI.StcOutDAL;
using StackManagementSystemUI.StcOutModels;



namespace StackManagementSystemUI
{
    public partial class StockOutForm : Form
    {
        public StockOutForm()
        {
            InitializeComponent();
        }
        StockOut stockOutObj = new StockOut();
        StockOutCompanyManager sOutComMangObj = new StockOutCompanyManager();
        StockOutCategoryManager sOutCatgMangObj = new StockOutCategoryManager();
        StockOutItemManager sOutItemMangObj = new StockOutItemManager();
        StockOutSelectedItemManager sOutSelecItemMangObj = new StockOutSelectedItemManager();

        private void StockOutForm_Load(object sender, EventArgs e)
        {
            DataTable dt = sOutComMangObj.GetCompanyNames();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                companyStockOutComboBox.Items.Add(dt.Rows[i]["Name"]);
            }
        }

        private void companyStockOutComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoryStockOutComboBox.Text = "";
            categoryStockOutComboBox.Items.Clear();
            reorderStockOutLavelTextBox.Text = "";
            availableQuantityStockOutTextBox.Text = "";
            itemStockOutComboBox.Text = "";

            string selectedCompany = companyStockOutComboBox.Text;

            DataTable dt = sOutCatgMangObj.GetCategoryNames(selectedCompany);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                categoryStockOutComboBox.Items.Add(dt.Rows[i]["Category"]);

            }
        }

        private void categoryStockOutComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemStockOutComboBox.Text = "";
            itemStockOutComboBox.Items.Clear();
            reorderStockOutLavelTextBox.Text = "";
            availableQuantityStockOutTextBox.Text = "";


            string selectedCategory = categoryStockOutComboBox.Text;

            DataTable dt = sOutItemMangObj.GetItemForComboBox(selectedCategory);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                itemStockOutComboBox.Items.Add(dt.Rows[i]["Item"]);

            }
        }

        private void itemStockOutComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string seletedItem = itemStockOutComboBox.Text;

            DataTable dt = sOutSelecItemMangObj.GetReorderAndAvaQuantity(seletedItem);
            reorderStockOutLavelTextBox.Text = Convert.ToString(dt.Rows[0]["ReorderLabel"]);
            availableQuantityStockOutTextBox.Text = Convert.ToString(dt.Rows[0]["AvailableQuantity"]);

            int presentvalue = Convert.ToInt32(availableQuantityStockOutTextBox.Text);
            int reorderLabel = Convert.ToInt32(reorderStockOutLavelTextBox.Text);

            if (presentvalue <= reorderLabel)
            {
                MessageBox.Show("Your stock is limited !! Please stock in fast !");
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            try
            {
                stockOutObj.Company = companyStockOutComboBox.Text;
                stockOutObj.Category = categoryStockOutComboBox.Text;
                stockOutObj.Item = itemStockOutComboBox.Text;
                stockOutObj.ReorderLabel = Convert.ToInt32(reorderStockOutLavelTextBox.Text);
                stockOutObj.AvailableQuantity = Convert.ToInt32(availableQuantityStockOutTextBox.Text);
                stockOutObj.StockOutQuantity = Convert.ToInt32(stockOutQuantityTextBox.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
            
            StockOutManager stoutMangObj=new StockOutManager();
            string stockOutInfo = stoutMangObj.StockOutInfo(stockOutObj);
            if (stockOutInfo!="")
            {
                MessageBox.Show(stockOutInfo);
                return;
            }




            for (int i = 0; i < stockOutDataGridView.Rows.Count; i++)

                if (Convert.ToString(stockOutDataGridView.Rows[i].Cells[1].Value) == stockOutObj.Item)
                {
                    if (stockOutObj.AvailableQuantity==10)
                    {
                        MessageBox.Show("Your current amount is " + stockOutObj.AvailableQuantity + " stock in fast!");
                    }
                    if (stockOutObj.AvailableQuantity>=stockOutObj.StockOutQuantity)
                    {
                        stockOutDataGridView.Rows[i].Cells[4].Value = (Convert.ToInt32(stockOutDataGridView.Rows[i].Cells[4].Value.ToString()) + stockOutObj.StockOutQuantity);
                        availableQuantityStockOutTextBox.Text = (stockOutObj.AvailableQuantity - stockOutObj.StockOutQuantity).ToString();
                    }
                    else
                    {
                        MessageBox.Show("No sufficient amount. Your current amount is "+stockOutObj.AvailableQuantity);
                    }
                    return;
                }

            if (stockOutObj.AvailableQuantity==10)
            {
                MessageBox.Show("Your current amount is " + stockOutObj.AvailableQuantity + " stock in fast!");
            }
            if (stockOutObj.AvailableQuantity>=stockOutObj.StockOutQuantity)
            {
                stockOutDataGridView.Rows.Add();
                int row = stockOutDataGridView.Rows.Count - 2;
                stockOutDataGridView["sl", row].Value = row+1;
                stockOutDataGridView["item", row].Value = stockOutObj.Item;
                stockOutDataGridView["category", row].Value = stockOutObj.Category;
                stockOutDataGridView["company", row].Value = stockOutObj.Company;
                stockOutDataGridView["quantity", row].Value = stockOutObj.StockOutQuantity;

                availableQuantityStockOutTextBox.Text = (stockOutObj.AvailableQuantity - stockOutObj.StockOutQuantity).ToString();
            }
            else
            {
                MessageBox.Show("No sufficient amount. Your current amount is "+stockOutObj.AvailableQuantity);
            }
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            try
            {
                StockOutItem stcOutItmObj = new StockOutItem();
                StockOutSellManager sellManager = new StockOutSellManager();

                for (int i = 0; i < stockOutDataGridView.Rows.Count - 1; i++)
                {
                    stcOutItmObj.Item = stockOutDataGridView.Rows[i].Cells[1].Value.ToString();
                    stcOutItmObj.Category = stockOutDataGridView.Rows[i].Cells[2].Value.ToString();
                    stcOutItmObj.Company = stockOutDataGridView.Rows[i].Cells[3].Value.ToString();
                    stcOutItmObj.StockOutQuantity = Convert.ToInt32(stockOutDataGridView.Rows[i].Cells[4].Value.ToString());
                    stcOutItmObj.Id = Convert.ToInt32(1);
                    stcOutItmObj.SellDate = DateTime.Today;

                    bool sellInfo = sellManager.SellItem(stcOutItmObj);
                    if (sellInfo == false)
                    {
                        MessageBox.Show("Save Failed");
                        return;
                    }
                }

                stockOutDataGridView.Rows.Clear();
                stockOutDataGridView.Refresh();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }

        private void damageButton_Click(object sender, EventArgs e)
        {
            try
            {
                StockOutItem stcOutItmObj = new StockOutItem();
                StockOutSellManager sellManager = new StockOutSellManager();

                for (int i = 0; i < stockOutDataGridView.Rows.Count - 1; i++)
                {
                    stcOutItmObj.Item = stockOutDataGridView.Rows[i].Cells[1].Value.ToString();
                    stcOutItmObj.Category = stockOutDataGridView.Rows[i].Cells[2].Value.ToString();
                    stcOutItmObj.Company = stockOutDataGridView.Rows[i].Cells[3].Value.ToString();
                    stcOutItmObj.StockOutQuantity = Convert.ToInt32(stockOutDataGridView.Rows[i].Cells[4].Value.ToString());
                    stcOutItmObj.Id = Convert.ToInt32(2);
                    stcOutItmObj.SellDate = DateTime.Today;

                    bool sellInfo = sellManager.SellItem(stcOutItmObj);
                    if (sellInfo == false)
                    {
                        MessageBox.Show("Save Failed");
                        return;
                    }
                }

                stockOutDataGridView.Rows.Clear();
                stockOutDataGridView.Refresh();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void lostButton_Click(object sender, EventArgs e)
        {
            try
            {
                StockOutItem stcOutItmObj = new StockOutItem();
                StockOutSellManager sellManager = new StockOutSellManager();

                for (int i = 0; i < stockOutDataGridView.Rows.Count - 1; i++)
                {
                    stcOutItmObj.Item = stockOutDataGridView.Rows[i].Cells[1].Value.ToString();
                    stcOutItmObj.Category = stockOutDataGridView.Rows[i].Cells[2].Value.ToString();
                    stcOutItmObj.Company = stockOutDataGridView.Rows[i].Cells[3].Value.ToString();
                    stcOutItmObj.StockOutQuantity = Convert.ToInt32(stockOutDataGridView.Rows[i].Cells[4].Value.ToString());
                    stcOutItmObj.Id = Convert.ToInt32(3);
                    stcOutItmObj.SellDate = DateTime.Today;

                    bool sellInfo = sellManager.SellItem(stcOutItmObj);
                    if (sellInfo == false)
                    {
                        MessageBox.Show("Save Failed");
                        return;
                    }
                }

                stockOutDataGridView.Rows.Clear();
                stockOutDataGridView.Refresh();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        
    }
}
