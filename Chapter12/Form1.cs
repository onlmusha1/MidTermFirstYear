using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter12
{
    public partial class Form1 : Form
    {
        private List<BankAccount> accounts;
        BindingSource binder = new BindingSource();
        private int randInt;
        public Form1()
        {
            InitializeComponent();

            this.accounts = new List<BankAccount>();
            this.randInt = 0;
            dataGridView1.DataSource = this.binder;

            this.rdoChecking.Checked = true;


            //INITALIZE EMPTY LABELS
            lblErrorOutput.Text = "";
            LblAccountNum.Text = "";
            this.lblSuccess.Text = "";
            this.LblErrorAccounts.Text = "";
            this.LblSuccessWithdraw.Text = "";
            this.LblSuccessDeposit.Text = "";
            this.setNewAccountNum();
        }

        private double checking;
        private double savings;
        private void button1_Click(object sender, EventArgs e)
        {
            lblErrorOutput.Text = "";
            this.lblSuccess.Text = "";
            bool cont = true;
            if (string.IsNullOrWhiteSpace(txtBoxFirstName.Text))
            {
                lblErrorOutput.Text += "First name can not be empty!\n"; cont = false;
            }
            if (string.IsNullOrWhiteSpace(txtBoxLastName.Text))
            {
                lblErrorOutput.Text += "Last name can not be empty!\n"; cont = false;
            }

            if (double.TryParse(txtBoxCheckingBal.Text, out checking) == false)
            {
                lblErrorOutput.Text += "Checking start balance must be a number!\n"; cont = false;
            }
            else { checking = int.Parse(txtBoxCheckingBal.Text); }

            if (double.TryParse(txtBoxSavings.Text, out savings) == false)
            {
                lblErrorOutput.Text += "Savings start balance must be a number!\n"; cont = false;
            }
            else
            {
                savings = int.Parse(txtBoxSavings.Text);
            }

            if (cont)
            {
                string tempName = txtBoxFirstName.Text + txtBoxLastName.Text;
                BankAccount temp = new BankAccount(checking, savings, int.Parse(LblAccountNum.Text), tempName);
                if (string.IsNullOrWhiteSpace(temp.EMsg))
                {
                    accounts.Add(temp);
                    this.setNewAccountNum();
                    binder.Add(temp);
                    this.lblSuccess.Text = "Success!";
                }
                else
                {
                    lblErrorOutput.Text += temp.EMsg + "\n";
                }
            }



        }
        private void setNewAccountNum()
        {
            Random rand = new Random();
            this.randInt = rand.Next(1000000, 9999999);
            Parallel.ForEach(accounts, BankAccount =>
            {
                if (this.randInt == BankAccount.AccountNumber)
                {
                    this.setNewAccountNum();
                }
            });
            LblAccountNum.Text = "" + this.randInt;
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            this.LblErrorAccounts.Text = "";
            this.LblSuccessWithdraw.Text = "";
            this.LblSuccessDeposit.Text = "";
            int selectedAccount;
            double withdrawAmt;
            KeyValuePair<string, bool> tempReturn;
            selectedAccount = dataGridView1.CurrentCell.RowIndex;
            if (string.IsNullOrWhiteSpace(txtBoxWithdraw.Text) || double.TryParse(txtBoxWithdraw.Text, out withdrawAmt) == false)
            {
                LblErrorAccounts.Text = "Please input a valid number to withdraw.";
            }
            else if (dataGridView1.CurrentCell is null)
            {
                LblErrorAccounts.Text = "Please select an account from the table below!";
            }
            else
            {
                withdrawAmt = double.Parse(txtBoxWithdraw.Text);
                if (rdoChecking.Checked == true)
                {
                    
                    tempReturn = accounts[selectedAccount].withdrawChecking(withdrawAmt);
                    if (tempReturn.Value == false)
                    {
                        LblErrorAccounts.Text = tempReturn.Key;
                    }
                    else
                    {
                        LblSuccessWithdraw.Text = tempReturn.Key;
                    }
                    binder.ResetBindings(false);
                }
                else
                {
                    tempReturn = accounts[selectedAccount].withdrawSavings(withdrawAmt);
                    if (tempReturn.Value == false)
                    {
                        LblErrorAccounts.Text = tempReturn.Key;
                    }
                    else
                    {
                        LblSuccessWithdraw.Text = tempReturn.Key;
                    }
                    binder.ResetBindings(false);
                }
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            this.LblErrorAccounts.Text = "";
            this.LblSuccessDeposit.Text = "";
            this.LblSuccessWithdraw.Text = "";
            int selectedAccount;
            double depositAmt;
            KeyValuePair<string, bool> tempReturn;
            selectedAccount = dataGridView1.CurrentCell.RowIndex;
            if (string.IsNullOrWhiteSpace(txtBoxDeposit.Text) || double.TryParse(txtBoxDeposit.Text, out depositAmt) == false)
            {
                LblErrorAccounts.Text = "Please input a valid number to withdraw.";
            }
            else if (dataGridView1.CurrentCell is null)
            {
                LblErrorAccounts.Text = "Please select an account from the table below!";
            }
            else
            {
                depositAmt = double.Parse(txtBoxDeposit.Text);
                if (rdoChecking.Checked == true)
                {
                    tempReturn = accounts[selectedAccount].depositChecking(depositAmt);
                    if (tempReturn.Value == false)
                    {
                        LblErrorAccounts.Text = tempReturn.Key;
                    }
                    else
                    {
                        LblSuccessDeposit.Text = tempReturn.Key;
                    }
                    binder.ResetBindings(false);
                }
                else
                {
                    tempReturn = accounts[selectedAccount].depositSavings(depositAmt);
                    if (tempReturn.Value == false)
                    {
                        LblErrorAccounts.Text = tempReturn.Key;
                    }
                    else
                    {
                        LblSuccessDeposit.Text = tempReturn.Key;
                    }
                    binder.ResetBindings(false);
                }
            }
        }
    }
}
