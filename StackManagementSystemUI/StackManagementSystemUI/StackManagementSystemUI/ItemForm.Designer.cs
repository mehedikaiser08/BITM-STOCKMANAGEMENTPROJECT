namespace StackManagementSystemUI
{
    partial class ItemForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.categoryItemComboBox = new System.Windows.Forms.ComboBox();
            this.companyItemComboBox = new System.Windows.Forms.ComboBox();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.reorderLavelTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Company";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Reorder Lavel";
            // 
            // categoryItemComboBox
            // 
            this.categoryItemComboBox.FormattingEnabled = true;
            this.categoryItemComboBox.Location = new System.Drawing.Point(111, 22);
            this.categoryItemComboBox.Name = "categoryItemComboBox";
            this.categoryItemComboBox.Size = new System.Drawing.Size(193, 21);
            this.categoryItemComboBox.TabIndex = 4;
            // 
            // companyItemComboBox
            // 
            this.companyItemComboBox.FormattingEnabled = true;
            this.companyItemComboBox.Location = new System.Drawing.Point(111, 55);
            this.companyItemComboBox.Name = "companyItemComboBox";
            this.companyItemComboBox.Size = new System.Drawing.Size(193, 21);
            this.companyItemComboBox.TabIndex = 5;
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(111, 84);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(193, 20);
            this.itemNameTextBox.TabIndex = 6;
            // 
            // reorderLavelTextBox
            // 
            this.reorderLavelTextBox.Location = new System.Drawing.Point(111, 120);
            this.reorderLavelTextBox.Name = "reorderLavelTextBox";
            this.reorderLavelTextBox.Size = new System.Drawing.Size(193, 20);
            this.reorderLavelTextBox.TabIndex = 7;
            this.reorderLavelTextBox.Text = "0";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(220, 169);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 233);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.reorderLavelTextBox);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(this.companyItemComboBox);
            this.Controls.Add(this.categoryItemComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ItemForm";
            this.Text = "ItemForm";
            this.Load += new System.EventHandler(this.ItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox categoryItemComboBox;
        private System.Windows.Forms.ComboBox companyItemComboBox;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.TextBox reorderLavelTextBox;
        private System.Windows.Forms.Button saveButton;
    }
}