using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StackManagementSystemUI.ItemBLL;
using StackManagementSystemUI.ItemModels;

namespace StackManagementSystemUI
{
    public partial class ItemForm : Form
    {
        public ItemForm()
        {
            InitializeComponent();
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            ItemLoadCategoryManager itemLdCtgMangObj = new ItemLoadCategoryManager();
            DataTable dt = itemLdCtgMangObj.ItemLoadCategoryComboBox();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                categoryItemComboBox.Items.Add(dt.Rows[i]["Name"]);
            }


            ItemLoadCompanyManager itemLdCompMangObj=new ItemLoadCompanyManager();
            DataTable DT = itemLdCompMangObj.ItemLoadCompanyComboBox();
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                companyItemComboBox.Items.Add(DT.Rows[i]["Name"]);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Item itemObj=new Item();
            itemObj.Category = categoryItemComboBox.Text;
            itemObj.CompanyName = companyItemComboBox.Text;
            itemObj.ItemName = itemNameTextBox.Text; 
            itemObj.AvaialableQuantity = 0;

            
            if (itemObj.CompanyName == "" || itemObj.ItemName == ""||itemObj.Category=="")
            {
                MessageBox.Show("Company, Category and Item name should not be null !");
                return;
            }

            try
            {
                itemObj.ReorderLabel = Convert.ToInt32(reorderLavelTextBox.Text);

            }
            catch
            {
                MessageBox.Show("Reorder lavel must be integer number");
            }

            ItemManager itemMangObj = new ItemManager();
            string itemInfo = itemMangObj.SaveItemInfo(itemObj);
            MessageBox.Show(itemInfo);
        }
    }
}
