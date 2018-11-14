using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StackManagementSystemUI.ViewModels;
using StackManagementSystemUI.ViewBLL;

namespace StackManagementSystemUI
{
    public partial class ViewSalesForm : Form
    {
        public ViewSalesForm()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            ViewInfo viewObj = new ViewInfo();
            viewObj.FromDate = dateTimePickerStart.Value;
            viewObj.ToDate = dateTimePickerEnd.Value;

            try
            {

                ViewSellsManager managObj = new ViewSellsManager();
                DataTable dt = new DataTable();
                
                dt = managObj.ViewInfo(viewObj);
               
                if (dt.Rows.Count == 0)
                {
                    viewSalesDataGridView.Rows.Clear();
                    MessageBox.Show("No item sold between date "+viewObj.FromDate+" and "+viewObj.ToDate);
                    return;
                }
                viewSalesDataGridView.DataSource = dt;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }

        private void damageButton_Click(object sender, EventArgs e)
        {
            ViewInfo viewObj = new ViewInfo();
            viewObj.FromDate = dateTimePickerStart.Value;
            viewObj.ToDate = dateTimePickerEnd.Value;

            try
            {

                DamageManager damgMangObj = new DamageManager();
                DataTable dt = new DataTable();

                dt = damgMangObj.DamageInfo(viewObj);

                if (dt.Rows.Count == 0)
                {
                    viewSalesDataGridView.Rows.Clear();
                    MessageBox.Show("No item sold between date " + viewObj.FromDate + " and " + viewObj.ToDate);
                    return;
                }
                viewSalesDataGridView.DataSource = dt;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void lostButton_Click(object sender, EventArgs e)
        {
            ViewInfo viewObj = new ViewInfo();
            viewObj.FromDate = dateTimePickerStart.Value;
            viewObj.ToDate = dateTimePickerEnd.Value;

            try
            {

                LostManager lostMangObj = new LostManager();
                DataTable dt = new DataTable();

                dt = lostMangObj.LostInfo(viewObj);

                if (dt.Rows.Count == 0)
                {
                    viewSalesDataGridView.Rows.Clear();
                    MessageBox.Show("No item sold between date " + viewObj.FromDate + " and " + viewObj.ToDate);
                    return;
                }
                viewSalesDataGridView.DataSource = dt;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
