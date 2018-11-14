using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StackManagementSystemUI.LoginModels;
using StackManagementSystemUI.LoginBLL;
using StackManagementSystemUI;
using StackManagementSystemUI.SearchBLL;

namespace StackManagementSystemUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void loginButton_Click_1(object sender, EventArgs e)
        {
            Access accessObj = new Access();
            accessObj.UserName = userNameTextBox.Text;
            accessObj.Password = passTextBox.Text;
            if (accessObj.UserName == "" || accessObj.Password == "")
            {
                MessageBox.Show("Give correct user name and password");
                return;
            }

            AccessManager accMangObj = new AccessManager();
            bool login = accMangObj.AccessInfo(accessObj);
            if (login == true)
            {
                //To active account creation part
                groupBox1.Enabled = true;

                userNameTextBox.Text = "";
                passTextBox.Text = "";
                HomePage homePage = new HomePage();
                homePage.Show();
            }
            else
            {
                //To inactive account creation part
                groupBox1.Enabled = false;

                userNameTextBox.Text = "";
                passTextBox.Text = "";
                MessageBox.Show("User name and password not found !\n Create account first.");
                return;
            }
        }

        private void createButton_Click_1(object sender, EventArgs e)
        {
            Account accounObj = new Account();
            accounObj.Name = accountNameTextBox.Text;
            accounObj.Email = accountEmailTextBox.Text;
            accounObj.UserName = accountUserTextBox.Text;
            accounObj.Password = accountPasswordTextBox.Text;
            if (accounObj.Name == "" || accounObj.Email == "" || accounObj.UserName == "" || accounObj.Password == "")
            {
                MessageBox.Show("No empty field is accepted. ");
                return;
            }

            if (accounObj.Password.Length < 6)
            {
                MessageBox.Show("Passsword should be greater than or equal six character");
                return;
            }

            AccountManager accuntManagerObj = new AccountManager();
            bool accountInfo = accuntManagerObj.AccountInfo(accounObj);
            if (accountInfo == true)
            {
                accountNameTextBox.Text = "";
                accountEmailTextBox.Text = "";
                accountUserTextBox.Text = "";
                accountPasswordTextBox.Text = "";

                MessageBox.Show("Account created successfully !");
            }
            else
            {
                MessageBox.Show("Same user and password already exist");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //To inactive account creation part
            groupBox1.Enabled = false;
        }
    }
}
