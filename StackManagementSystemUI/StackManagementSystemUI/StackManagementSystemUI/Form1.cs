using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackManagementSystemUI
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CategorySetupForm catgForm = new CategorySetupForm();
            catgForm.Show();
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CompanySetupForm companySetupForm = new CompanySetupForm();
            companySetupForm.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ItemForm itemForm=new ItemForm();
            itemForm.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StockInForm stockInForm=new StockInForm();
            stockInForm.Show();
            
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StockOutForm stockOutForm=new StockOutForm();
            stockOutForm.Show();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SearchForm serForm=new SearchForm();
            serForm.Show();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewSalesForm viewSalesForm=new ViewSalesForm();
            viewSalesForm.Show();
        }
    }
}
