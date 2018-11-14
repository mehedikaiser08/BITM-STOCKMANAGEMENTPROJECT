namespace StackManagementSystemUI
{
    partial class StockInForm
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
            this.saveButton = new System.Windows.Forms.Button();
            this.availableQuantityStockInTextBox = new System.Windows.Forms.TextBox();
            this.reorderStockInLavelTextBox = new System.Windows.Forms.TextBox();
            this.companyStockInComboBox = new System.Windows.Forms.ComboBox();
            this.categoryStockInComboBox = new System.Windows.Forms.ComboBox();
            this.quantityTextBox = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.itemStockComBox = new System.Windows.Forms.Label();
            this.itemStockInComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stockInQuantityTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(235, 216);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // availableQuantityStockInTextBox
            // 
            this.availableQuantityStockInTextBox.Location = new System.Drawing.Point(117, 143);
            this.availableQuantityStockInTextBox.Name = "availableQuantityStockInTextBox";
            this.availableQuantityStockInTextBox.Size = new System.Drawing.Size(193, 20);
            this.availableQuantityStockInTextBox.TabIndex = 16;
            // 
            // reorderStockInLavelTextBox
            // 
            this.reorderStockInLavelTextBox.Location = new System.Drawing.Point(117, 107);
            this.reorderStockInLavelTextBox.Name = "reorderStockInLavelTextBox";
            this.reorderStockInLavelTextBox.Size = new System.Drawing.Size(193, 20);
            this.reorderStockInLavelTextBox.TabIndex = 15;
            // 
            // companyStockInComboBox
            // 
            this.companyStockInComboBox.FormattingEnabled = true;
            this.companyStockInComboBox.Location = new System.Drawing.Point(117, 12);
            this.companyStockInComboBox.Name = "companyStockInComboBox";
            this.companyStockInComboBox.Size = new System.Drawing.Size(193, 21);
            this.companyStockInComboBox.TabIndex = 14;
            this.companyStockInComboBox.SelectedIndexChanged += new System.EventHandler(this.companyStockInComboBox_SelectedIndexChanged);
            // 
            // categoryStockInComboBox
            // 
            this.categoryStockInComboBox.FormattingEnabled = true;
            this.categoryStockInComboBox.Location = new System.Drawing.Point(117, 45);
            this.categoryStockInComboBox.Name = "categoryStockInComboBox";
            this.categoryStockInComboBox.Size = new System.Drawing.Size(193, 21);
            this.categoryStockInComboBox.TabIndex = 13;
            this.categoryStockInComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryStockInComboBox_SelectedIndexChanged);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.AutoSize = true;
            this.quantityTextBox.Location = new System.Drawing.Point(19, 150);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(92, 13);
            this.quantityTextBox.TabIndex = 12;
            this.quantityTextBox.Text = "Available Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Reorder Lavel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Company";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Category";
            // 
            // itemStockComBox
            // 
            this.itemStockComBox.AutoSize = true;
            this.itemStockComBox.Location = new System.Drawing.Point(21, 83);
            this.itemStockComBox.Name = "itemStockComBox";
            this.itemStockComBox.Size = new System.Drawing.Size(27, 13);
            this.itemStockComBox.TabIndex = 18;
            this.itemStockComBox.Text = "Item";
            // 
            // itemStockInComboBox
            // 
            this.itemStockInComboBox.FormattingEnabled = true;
            this.itemStockInComboBox.Location = new System.Drawing.Point(117, 75);
            this.itemStockInComboBox.Name = "itemStockInComboBox";
            this.itemStockInComboBox.Size = new System.Drawing.Size(193, 21);
            this.itemStockInComboBox.TabIndex = 19;
            this.itemStockInComboBox.SelectedIndexChanged += new System.EventHandler(this.itemStockInComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Stock In Quantity";
            // 
            // stockInQuantityTextBox
            // 
            this.stockInQuantityTextBox.Location = new System.Drawing.Point(117, 178);
            this.stockInQuantityTextBox.Name = "stockInQuantityTextBox";
            this.stockInQuantityTextBox.Size = new System.Drawing.Size(193, 20);
            this.stockInQuantityTextBox.TabIndex = 21;
            // 
            // StockInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 261);
            this.Controls.Add(this.stockInQuantityTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.itemStockInComboBox);
            this.Controls.Add(this.itemStockComBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.availableQuantityStockInTextBox);
            this.Controls.Add(this.reorderStockInLavelTextBox);
            this.Controls.Add(this.companyStockInComboBox);
            this.Controls.Add(this.categoryStockInComboBox);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StockInForm";
            this.Text = "StockInForm";
            this.Load += new System.EventHandler(this.StockInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox availableQuantityStockInTextBox;
        private System.Windows.Forms.TextBox reorderStockInLavelTextBox;
        private System.Windows.Forms.ComboBox companyStockInComboBox;
        private System.Windows.Forms.ComboBox categoryStockInComboBox;
        private System.Windows.Forms.Label quantityTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label itemStockComBox;
        private System.Windows.Forms.ComboBox itemStockInComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stockInQuantityTextBox;
    }
}