namespace StackManagementSystemUI
{
    partial class CategorySetupForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameCategoryTextBox = new System.Windows.Forms.TextBox();
            this.categoryDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(238, 49);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // nameCategoryTextBox
            // 
            this.nameCategoryTextBox.Location = new System.Drawing.Point(132, 23);
            this.nameCategoryTextBox.Name = "nameCategoryTextBox";
            this.nameCategoryTextBox.Size = new System.Drawing.Size(181, 20);
            this.nameCategoryTextBox.TabIndex = 2;
            // 
            // categoryDataGridView
            // 
            this.categoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryDataGridView.Location = new System.Drawing.Point(12, 91);
            this.categoryDataGridView.Name = "categoryDataGridView";
            this.categoryDataGridView.Size = new System.Drawing.Size(338, 221);
            this.categoryDataGridView.TabIndex = 3;
            this.categoryDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoryDataGridView_CellContentClick);
            // 
            // CategorySetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 336);
            this.Controls.Add(this.categoryDataGridView);
            this.Controls.Add(this.nameCategoryTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Name = "CategorySetupForm";
            this.Text = "CategorySetupForm";
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameCategoryTextBox;
        private System.Windows.Forms.DataGridView categoryDataGridView;
    }
}