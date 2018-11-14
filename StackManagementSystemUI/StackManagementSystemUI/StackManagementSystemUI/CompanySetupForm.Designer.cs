namespace StackManagementSystemUI
{
    partial class CompanySetupForm
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
            this.companyDataGridView = new System.Windows.Forms.DataGridView();
            this.CompanyNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // companyDataGridView
            // 
            this.companyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companyDataGridView.Location = new System.Drawing.Point(25, 95);
            this.companyDataGridView.Name = "companyDataGridView";
            this.companyDataGridView.Size = new System.Drawing.Size(313, 195);
            this.companyDataGridView.TabIndex = 7;
            this.companyDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.companyDataGridView_CellContentClick);
            // 
            // CompanyNameTextBox
            // 
            this.CompanyNameTextBox.Location = new System.Drawing.Point(99, 17);
            this.CompanyNameTextBox.Name = "CompanyNameTextBox";
            this.CompanyNameTextBox.Size = new System.Drawing.Size(170, 20);
            this.CompanyNameTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(275, 17);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(63, 20);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(263, 66);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 8;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // CompanySetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 302);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.companyDataGridView);
            this.Controls.Add(this.CompanyNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Name = "CompanySetupForm";
            this.Text = "CompanySetupForm";
            this.Load += new System.EventHandler(this.CompanySetupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView companyDataGridView;
        private System.Windows.Forms.TextBox CompanyNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button editButton;
    }
}