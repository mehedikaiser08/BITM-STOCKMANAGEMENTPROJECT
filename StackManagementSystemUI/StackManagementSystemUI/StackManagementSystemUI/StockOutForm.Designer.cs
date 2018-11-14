namespace StackManagementSystemUI
{
    partial class StockOutForm
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
            this.stockOutQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.itemStockOutComboBox = new System.Windows.Forms.ComboBox();
            this.itemStockComBox = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.availableQuantityStockOutTextBox = new System.Windows.Forms.TextBox();
            this.reorderStockOutLavelTextBox = new System.Windows.Forms.TextBox();
            this.companyStockOutComboBox = new System.Windows.Forms.ComboBox();
            this.categoryStockOutComboBox = new System.Windows.Forms.ComboBox();
            this.quantityTextBox = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sellButton = new System.Windows.Forms.Button();
            this.damageButton = new System.Windows.Forms.Button();
            this.lostButton = new System.Windows.Forms.Button();
            this.stockOutDataGridView = new System.Windows.Forms.DataGridView();
            this.sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // stockOutQuantityTextBox
            // 
            this.stockOutQuantityTextBox.Location = new System.Drawing.Point(215, 189);
            this.stockOutQuantityTextBox.Name = "stockOutQuantityTextBox";
            this.stockOutQuantityTextBox.Size = new System.Drawing.Size(193, 20);
            this.stockOutQuantityTextBox.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Stock Out Quantity";
            // 
            // itemStockOutComboBox
            // 
            this.itemStockOutComboBox.FormattingEnabled = true;
            this.itemStockOutComboBox.Location = new System.Drawing.Point(215, 86);
            this.itemStockOutComboBox.Name = "itemStockOutComboBox";
            this.itemStockOutComboBox.Size = new System.Drawing.Size(193, 21);
            this.itemStockOutComboBox.TabIndex = 32;
            this.itemStockOutComboBox.SelectedIndexChanged += new System.EventHandler(this.itemStockOutComboBox_SelectedIndexChanged);
            // 
            // itemStockComBox
            // 
            this.itemStockComBox.AutoSize = true;
            this.itemStockComBox.Location = new System.Drawing.Point(153, 89);
            this.itemStockComBox.Name = "itemStockComBox";
            this.itemStockComBox.Size = new System.Drawing.Size(27, 13);
            this.itemStockComBox.TabIndex = 31;
            this.itemStockComBox.Text = "Item";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(333, 215);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 30;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // availableQuantityStockOutTextBox
            // 
            this.availableQuantityStockOutTextBox.Location = new System.Drawing.Point(215, 154);
            this.availableQuantityStockOutTextBox.Name = "availableQuantityStockOutTextBox";
            this.availableQuantityStockOutTextBox.Size = new System.Drawing.Size(193, 20);
            this.availableQuantityStockOutTextBox.TabIndex = 29;
            // 
            // reorderStockOutLavelTextBox
            // 
            this.reorderStockOutLavelTextBox.Location = new System.Drawing.Point(215, 118);
            this.reorderStockOutLavelTextBox.Name = "reorderStockOutLavelTextBox";
            this.reorderStockOutLavelTextBox.Size = new System.Drawing.Size(193, 20);
            this.reorderStockOutLavelTextBox.TabIndex = 28;
            // 
            // companyStockOutComboBox
            // 
            this.companyStockOutComboBox.FormattingEnabled = true;
            this.companyStockOutComboBox.Location = new System.Drawing.Point(215, 23);
            this.companyStockOutComboBox.Name = "companyStockOutComboBox";
            this.companyStockOutComboBox.Size = new System.Drawing.Size(193, 21);
            this.companyStockOutComboBox.TabIndex = 27;
            this.companyStockOutComboBox.SelectedIndexChanged += new System.EventHandler(this.companyStockOutComboBox_SelectedIndexChanged);
            // 
            // categoryStockOutComboBox
            // 
            this.categoryStockOutComboBox.FormattingEnabled = true;
            this.categoryStockOutComboBox.Location = new System.Drawing.Point(215, 56);
            this.categoryStockOutComboBox.Name = "categoryStockOutComboBox";
            this.categoryStockOutComboBox.Size = new System.Drawing.Size(193, 21);
            this.categoryStockOutComboBox.TabIndex = 26;
            this.categoryStockOutComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryStockOutComboBox_SelectedIndexChanged);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.AutoSize = true;
            this.quantityTextBox.Location = new System.Drawing.Point(112, 157);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(92, 13);
            this.quantityTextBox.TabIndex = 25;
            this.quantityTextBox.Text = "Available Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Reorder Lavel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Company";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Category";
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(289, 498);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(58, 23);
            this.sellButton.TabIndex = 36;
            this.sellButton.Text = "Sell";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // damageButton
            // 
            this.damageButton.Location = new System.Drawing.Point(367, 498);
            this.damageButton.Name = "damageButton";
            this.damageButton.Size = new System.Drawing.Size(60, 23);
            this.damageButton.TabIndex = 37;
            this.damageButton.Text = "Damage";
            this.damageButton.UseVisualStyleBackColor = true;
            this.damageButton.Click += new System.EventHandler(this.damageButton_Click);
            // 
            // lostButton
            // 
            this.lostButton.Location = new System.Drawing.Point(445, 498);
            this.lostButton.Name = "lostButton";
            this.lostButton.Size = new System.Drawing.Size(54, 23);
            this.lostButton.TabIndex = 38;
            this.lostButton.Text = "Lost";
            this.lostButton.UseVisualStyleBackColor = true;
            this.lostButton.Click += new System.EventHandler(this.lostButton_Click);
            // 
            // stockOutDataGridView
            // 
            this.stockOutDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockOutDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sl,
            this.item,
            this.category,
            this.company,
            this.quantity});
            this.stockOutDataGridView.Location = new System.Drawing.Point(12, 254);
            this.stockOutDataGridView.Name = "stockOutDataGridView";
            this.stockOutDataGridView.Size = new System.Drawing.Size(526, 238);
            this.stockOutDataGridView.TabIndex = 35;
            // 
            // sl
            // 
            this.sl.HeaderText = "SL";
            this.sl.Name = "sl";
            // 
            // item
            // 
            this.item.HeaderText = "Item";
            this.item.Name = "item";
            // 
            // category
            // 
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            // 
            // company
            // 
            this.company.HeaderText = "Company";
            this.company.Name = "company";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Stock OutQuantity";
            this.quantity.Name = "quantity";
            // 
            // StockOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 533);
            this.Controls.Add(this.lostButton);
            this.Controls.Add(this.damageButton);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.stockOutDataGridView);
            this.Controls.Add(this.stockOutQuantityTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.itemStockOutComboBox);
            this.Controls.Add(this.itemStockComBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.availableQuantityStockOutTextBox);
            this.Controls.Add(this.reorderStockOutLavelTextBox);
            this.Controls.Add(this.companyStockOutComboBox);
            this.Controls.Add(this.categoryStockOutComboBox);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StockOutForm";
            this.Text = "StockOutForm";
            this.Load += new System.EventHandler(this.StockOutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockOutDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stockOutQuantityTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox itemStockOutComboBox;
        private System.Windows.Forms.Label itemStockComBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox availableQuantityStockOutTextBox;
        private System.Windows.Forms.TextBox reorderStockOutLavelTextBox;
        private System.Windows.Forms.ComboBox companyStockOutComboBox;
        private System.Windows.Forms.ComboBox categoryStockOutComboBox;
        private System.Windows.Forms.Label quantityTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Button damageButton;
        private System.Windows.Forms.Button lostButton;
        private System.Windows.Forms.DataGridView stockOutDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn company;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
    }
}