using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StackManagementSystemUI.CategoryModels;
using StackManagementSystemUI.CategoryBLL;


namespace StackManagementSystemUI
{
    public partial class CategorySetupForm : Form
    {
        int indexRow;
        string updateName = "";


        CategoryUpdate updateCatgObj = new CategoryUpdate();
        public CategorySetupForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (saveButton.Text=="Save")
            {
                Category categoryObj = new Category();
                categoryObj.CategoryName = nameCategoryTextBox.Text;
                if (categoryObj.CategoryName == "")
                {
                    MessageBox.Show("Empty value not accepted !");
                    return;
                }


                CategoryManager catgMangObj = new CategoryManager();
                bool categoryInfo = catgMangObj.SaveCatgoryInfo(categoryObj);
                if (categoryInfo == true)
                {
                    MessageBox.Show("Category Name Saved !");
                }
                else
                {
                    MessageBox.Show("Category name already exist !");
                    return;
                }

                DataTable DT = catgMangObj.CategoryDataTable();
                categoryDataGridView.DataSource = DT;
            }
        

            if (saveButton.Text == "Update")
            {
                saveButton.Text="Save";
                DataGridViewRow newDataRow = categoryDataGridView.Rows[indexRow];
                updateCatgObj.CategoryUpdateName = nameCategoryTextBox.Text;


                CategoryUpdateManager categUpdMangObj=new CategoryUpdateManager();
                bool updateCatgInfo = categUpdMangObj.CategoryUpdateName(updateCatgObj);
                if (updateCatgInfo==true)
                {
                    newDataRow.Cells[1].Value = updateCatgObj.CategoryUpdateName;
                    MessageBox.Show("Category Updated");
                    return;
                }
                else
                {
                    MessageBox.Show("Category already exist !");
                    return;
                }


            }

        }

        private void categoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            saveButton.Text = "Update";
            indexRow = e.RowIndex;
            DataGridViewRow row = categoryDataGridView.Rows[indexRow];
            nameCategoryTextBox.Text = row.Cells[1].Value.ToString();
            updateCatgObj.CategoryPreviousName = row.Cells[1].Value.ToString();
        }


    }
}
