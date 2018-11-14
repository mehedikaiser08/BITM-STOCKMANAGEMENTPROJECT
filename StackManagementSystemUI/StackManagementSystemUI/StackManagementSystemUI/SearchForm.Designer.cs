namespace StackManagementSystemUI
{
    partial class SearchForm
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
            this.searchCompanyComboBox = new System.Windows.Forms.ComboBox();
            this.searchCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchCompanyComboBox
            // 
            this.searchCompanyComboBox.FormattingEnabled = true;
            this.searchCompanyComboBox.Location = new System.Drawing.Point(196, 22);
            this.searchCompanyComboBox.Name = "searchCompanyComboBox";
            this.searchCompanyComboBox.Size = new System.Drawing.Size(193, 21);
            this.searchCompanyComboBox.TabIndex = 31;
            this.searchCompanyComboBox.SelectedIndexChanged += new System.EventHandler(this.searchCompanyComboBox_SelectedIndexChanged);
            // 
            // searchCategoryComboBox
            // 
            this.searchCategoryComboBox.FormattingEnabled = true;
            this.searchCategoryComboBox.Location = new System.Drawing.Point(196, 55);
            this.searchCategoryComboBox.Name = "searchCategoryComboBox";
            this.searchCategoryComboBox.Size = new System.Drawing.Size(193, 21);
            this.searchCategoryComboBox.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Company";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Category";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(314, 95);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 32;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchDataGridView
            // 
            this.searchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDataGridView.Location = new System.Drawing.Point(12, 142);
            this.searchDataGridView.Name = "searchDataGridView";
            this.searchDataGridView.Size = new System.Drawing.Size(605, 247);
            this.searchDataGridView.TabIndex = 33;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 423);
            this.Controls.Add(this.searchDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchCompanyComboBox);
            this.Controls.Add(this.searchCategoryComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SearchForm";
            this.Text = "Search & View Item\'s Summary";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox searchCompanyComboBox;
        private System.Windows.Forms.ComboBox searchCategoryComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView searchDataGridView;
    }
}