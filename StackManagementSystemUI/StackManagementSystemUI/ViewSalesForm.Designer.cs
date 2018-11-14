namespace StackManagementSystemUI
{
    partial class ViewSalesForm
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
            this.sellsInfoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.viewSalesDataGridView = new System.Windows.Forms.DataGridView();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.damageButton = new System.Windows.Forms.Button();
            this.lostButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewSalesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sellsInfoButton
            // 
            this.sellsInfoButton.BackColor = System.Drawing.Color.White;
            this.sellsInfoButton.Location = new System.Drawing.Point(55, 90);
            this.sellsInfoButton.Name = "sellsInfoButton";
            this.sellsInfoButton.Size = new System.Drawing.Size(75, 23);
            this.sellsInfoButton.TabIndex = 0;
            this.sellsInfoButton.Text = "Sells List";
            this.sellsInfoButton.UseVisualStyleBackColor = false;
            this.sellsInfoButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "From Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "To Date";
            // 
            // viewSalesDataGridView
            // 
            this.viewSalesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewSalesDataGridView.Location = new System.Drawing.Point(12, 142);
            this.viewSalesDataGridView.Name = "viewSalesDataGridView";
            this.viewSalesDataGridView.Size = new System.Drawing.Size(379, 199);
            this.viewSalesDataGridView.TabIndex = 5;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStart.Location = new System.Drawing.Point(130, 18);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStart.TabIndex = 6;
            this.dateTimePickerStart.Value = new System.DateTime(2018, 11, 12, 0, 0, 0, 0);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(130, 53);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEnd.TabIndex = 7;
            // 
            // damageButton
            // 
            this.damageButton.BackColor = System.Drawing.Color.White;
            this.damageButton.Location = new System.Drawing.Point(155, 90);
            this.damageButton.Name = "damageButton";
            this.damageButton.Size = new System.Drawing.Size(75, 23);
            this.damageButton.TabIndex = 8;
            this.damageButton.Text = "Damage List";
            this.damageButton.UseVisualStyleBackColor = false;
            this.damageButton.Click += new System.EventHandler(this.damageButton_Click);
            // 
            // lostButton
            // 
            this.lostButton.BackColor = System.Drawing.Color.White;
            this.lostButton.Location = new System.Drawing.Point(255, 90);
            this.lostButton.Name = "lostButton";
            this.lostButton.Size = new System.Drawing.Size(75, 23);
            this.lostButton.TabIndex = 9;
            this.lostButton.Text = "Lost List";
            this.lostButton.UseVisualStyleBackColor = false;
            this.lostButton.Click += new System.EventHandler(this.lostButton_Click);
            // 
            // ViewSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 392);
            this.Controls.Add(this.lostButton);
            this.Controls.Add(this.damageButton);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.viewSalesDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sellsInfoButton);
            this.Name = "ViewSalesForm";
            this.Text = "View Sales Between Two Dates";
            ((System.ComponentModel.ISupportInitialize)(this.viewSalesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sellsInfoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView viewSalesDataGridView;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Button damageButton;
        private System.Windows.Forms.Button lostButton;
    }
}