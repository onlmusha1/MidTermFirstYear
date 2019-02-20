namespace Chapter12
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl = new System.Windows.Forms.TabControl();
            this.ActiveAccounts = new System.Windows.Forms.TabPage();
            this.txtBoxDeposit = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.txtBoxWithdraw = new System.Windows.Forms.TextBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.LblErrorAccounts = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CreateAccount = new System.Windows.Forms.TabPage();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblErrorOutput = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxSavings = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxCheckingBal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.LblAccountNum = new System.Windows.Forms.Label();
            this.LblSuccessWithdraw = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoChecking = new System.Windows.Forms.RadioButton();
            this.rdoSavings = new System.Windows.Forms.RadioButton();
            this.LblSuccessDeposit = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.ActiveAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.CreateAccount.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.ActiveAccounts);
            this.TabControl.Controls.Add(this.CreateAccount);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(551, 528);
            this.TabControl.TabIndex = 0;
            // 
            // ActiveAccounts
            // 
            this.ActiveAccounts.Controls.Add(this.LblSuccessDeposit);
            this.ActiveAccounts.Controls.Add(this.groupBox1);
            this.ActiveAccounts.Controls.Add(this.LblSuccessWithdraw);
            this.ActiveAccounts.Controls.Add(this.txtBoxDeposit);
            this.ActiveAccounts.Controls.Add(this.btnDeposit);
            this.ActiveAccounts.Controls.Add(this.txtBoxWithdraw);
            this.ActiveAccounts.Controls.Add(this.btnWithdraw);
            this.ActiveAccounts.Controls.Add(this.LblErrorAccounts);
            this.ActiveAccounts.Controls.Add(this.label8);
            this.ActiveAccounts.Controls.Add(this.label9);
            this.ActiveAccounts.Controls.Add(this.dataGridView1);
            this.ActiveAccounts.Location = new System.Drawing.Point(4, 22);
            this.ActiveAccounts.Name = "ActiveAccounts";
            this.ActiveAccounts.Size = new System.Drawing.Size(543, 502);
            this.ActiveAccounts.TabIndex = 0;
            this.ActiveAccounts.Text = "Active Accounts";
            this.ActiveAccounts.UseVisualStyleBackColor = true;
            // 
            // txtBoxDeposit
            // 
            this.txtBoxDeposit.Location = new System.Drawing.Point(338, 192);
            this.txtBoxDeposit.Name = "txtBoxDeposit";
            this.txtBoxDeposit.Size = new System.Drawing.Size(183, 20);
            this.txtBoxDeposit.TabIndex = 17;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(257, 189);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnDeposit.TabIndex = 16;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // txtBoxWithdraw
            // 
            this.txtBoxWithdraw.Location = new System.Drawing.Point(88, 191);
            this.txtBoxWithdraw.Name = "txtBoxWithdraw";
            this.txtBoxWithdraw.Size = new System.Drawing.Size(165, 20);
            this.txtBoxWithdraw.TabIndex = 15;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(7, 187);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(75, 25);
            this.btnWithdraw.TabIndex = 14;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // LblErrorAccounts
            // 
            this.LblErrorAccounts.AutoSize = true;
            this.LblErrorAccounts.ForeColor = System.Drawing.Color.Red;
            this.LblErrorAccounts.Location = new System.Drawing.Point(244, 107);
            this.LblErrorAccounts.Name = "LblErrorAccounts";
            this.LblErrorAccounts.Size = new System.Drawing.Size(88, 13);
            this.LblErrorAccounts.TabIndex = 13;
            this.LblErrorAccounts.Text = "LblErrorAccounts";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(173, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Active Accounts View";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(69, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(414, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "First National Bank Of Nerds (FNBON)";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 217);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(537, 282);
            this.dataGridView1.TabIndex = 0;
            // 
            // CreateAccount
            // 
            this.CreateAccount.Controls.Add(this.lblSuccess);
            this.CreateAccount.Controls.Add(this.label7);
            this.CreateAccount.Controls.Add(this.lblErrorOutput);
            this.CreateAccount.Controls.Add(this.button1);
            this.CreateAccount.Controls.Add(this.label6);
            this.CreateAccount.Controls.Add(this.label5);
            this.CreateAccount.Controls.Add(this.txtBoxSavings);
            this.CreateAccount.Controls.Add(this.label4);
            this.CreateAccount.Controls.Add(this.txtBoxCheckingBal);
            this.CreateAccount.Controls.Add(this.label3);
            this.CreateAccount.Controls.Add(this.txtBoxLastName);
            this.CreateAccount.Controls.Add(this.label2);
            this.CreateAccount.Controls.Add(this.label1);
            this.CreateAccount.Controls.Add(this.txtBoxFirstName);
            this.CreateAccount.Controls.Add(this.LblAccountNum);
            this.CreateAccount.Location = new System.Drawing.Point(4, 22);
            this.CreateAccount.Name = "CreateAccount";
            this.CreateAccount.Size = new System.Drawing.Size(543, 502);
            this.CreateAccount.TabIndex = 1;
            this.CreateAccount.Text = "Create New Account";
            this.CreateAccount.UseVisualStyleBackColor = true;
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.Location = new System.Drawing.Point(74, 369);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(58, 13);
            this.lblSuccess.TabIndex = 14;
            this.lblSuccess.Text = "lblSuccess";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(73, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "New Account Number : ";
            // 
            // lblErrorOutput
            // 
            this.lblErrorOutput.AutoSize = true;
            this.lblErrorOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorOutput.ForeColor = System.Drawing.Color.Red;
            this.lblErrorOutput.Location = new System.Drawing.Point(73, 385);
            this.lblErrorOutput.Name = "lblErrorOutput";
            this.lblErrorOutput.Size = new System.Drawing.Size(108, 20);
            this.lblErrorOutput.TabIndex = 12;
            this.lblErrorOutput.Text = "lblErrorOutput";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(176, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "New User Request Screen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(414, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "First National Bank Of Nerds (FNBON)";
            // 
            // txtBoxSavings
            // 
            this.txtBoxSavings.Location = new System.Drawing.Point(77, 326);
            this.txtBoxSavings.Name = "txtBoxSavings";
            this.txtBoxSavings.Size = new System.Drawing.Size(409, 20);
            this.txtBoxSavings.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(198, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Savings Start Balance";
            // 
            // txtBoxCheckingBal
            // 
            this.txtBoxCheckingBal.Location = new System.Drawing.Point(77, 280);
            this.txtBoxCheckingBal.Name = "txtBoxCheckingBal";
            this.txtBoxCheckingBal.Size = new System.Drawing.Size(409, 20);
            this.txtBoxCheckingBal.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Checking Start Balance";
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(77, 200);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(409, 20);
            this.txtBoxLastName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(77, 154);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(409, 20);
            this.txtBoxFirstName.TabIndex = 1;
            // 
            // LblAccountNum
            // 
            this.LblAccountNum.AutoSize = true;
            this.LblAccountNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAccountNum.Location = new System.Drawing.Point(306, 223);
            this.LblAccountNum.Name = "LblAccountNum";
            this.LblAccountNum.Size = new System.Drawing.Size(122, 20);
            this.LblAccountNum.TabIndex = 0;
            this.LblAccountNum.Text = "LblAccountNum";
            // 
            // LblSuccessWithdraw
            // 
            this.LblSuccessWithdraw.AutoSize = true;
            this.LblSuccessWithdraw.Location = new System.Drawing.Point(111, 175);
            this.LblSuccessWithdraw.Name = "LblSuccessWithdraw";
            this.LblSuccessWithdraw.Size = new System.Drawing.Size(107, 13);
            this.LblSuccessWithdraw.TabIndex = 18;
            this.LblSuccessWithdraw.Text = "LblSuccessWithdraw";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoSavings);
            this.groupBox1.Controls.Add(this.rdoChecking);
            this.groupBox1.Location = new System.Drawing.Point(3, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 86);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Checking or Savings";
            // 
            // rdoChecking
            // 
            this.rdoChecking.AutoSize = true;
            this.rdoChecking.Location = new System.Drawing.Point(7, 20);
            this.rdoChecking.Name = "rdoChecking";
            this.rdoChecking.Size = new System.Drawing.Size(70, 17);
            this.rdoChecking.TabIndex = 0;
            this.rdoChecking.TabStop = true;
            this.rdoChecking.Text = "Checking";
            this.rdoChecking.UseVisualStyleBackColor = true;
            // 
            // rdoSavings
            // 
            this.rdoSavings.AutoSize = true;
            this.rdoSavings.Location = new System.Drawing.Point(7, 44);
            this.rdoSavings.Name = "rdoSavings";
            this.rdoSavings.Size = new System.Drawing.Size(63, 17);
            this.rdoSavings.TabIndex = 1;
            this.rdoSavings.TabStop = true;
            this.rdoSavings.Text = "Savings";
            this.rdoSavings.UseVisualStyleBackColor = true;
            // 
            // LblSuccessDeposit
            // 
            this.LblSuccessDeposit.AutoSize = true;
            this.LblSuccessDeposit.Location = new System.Drawing.Point(375, 175);
            this.LblSuccessDeposit.Name = "LblSuccessDeposit";
            this.LblSuccessDeposit.Size = new System.Drawing.Size(98, 13);
            this.LblSuccessDeposit.TabIndex = 20;
            this.LblSuccessDeposit.Text = "LblSuccessDeposit";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(574, 546);
            this.Controls.Add(this.TabControl);
            this.Name = "Form1";
            this.TabControl.ResumeLayout(false);
            this.ActiveAccounts.ResumeLayout(false);
            this.ActiveAccounts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.CreateAccount.ResumeLayout(false);
            this.CreateAccount.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage ActiveAccounts;
        private System.Windows.Forms.TabPage CreateAccount;
        private System.Windows.Forms.Label LblAccountNum;
        private System.Windows.Forms.TextBox txtBoxSavings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxCheckingBal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.Label lblErrorOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.TextBox txtBoxDeposit;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.TextBox txtBoxWithdraw;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label LblErrorAccounts;
        private System.Windows.Forms.Label LblSuccessWithdraw;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoSavings;
        private System.Windows.Forms.RadioButton rdoChecking;
        private System.Windows.Forms.Label LblSuccessDeposit;
    }
}

