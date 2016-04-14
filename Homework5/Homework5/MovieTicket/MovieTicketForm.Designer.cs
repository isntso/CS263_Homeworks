namespace MovieTicket
{
    partial class MovieTicketForm
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ticketCatagory = new System.Windows.Forms.ComboBox();
            this.ticketLabel = new System.Windows.Forms.Label();
            this.sheetLabel = new System.Windows.Forms.Label();
            this.sheetTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.infoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ticketCatagory
            // 
            this.ticketCatagory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ticketCatagory.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ticketCatagory.FormattingEnabled = true;
            this.ticketCatagory.Location = new System.Drawing.Point(91, 32);
            this.ticketCatagory.Name = "ticketCatagory";
            this.ticketCatagory.Size = new System.Drawing.Size(413, 32);
            this.ticketCatagory.TabIndex = 0;
            // 
            // ticketLabel
            // 
            this.ticketLabel.AutoSize = true;
            this.ticketLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ticketLabel.Location = new System.Drawing.Point(33, 35);
            this.ticketLabel.Name = "ticketLabel";
            this.ticketLabel.Size = new System.Drawing.Size(52, 24);
            this.ticketLabel.TabIndex = 1;
            this.ticketLabel.Text = "票種:";
            // 
            // sheetLabel
            // 
            this.sheetLabel.AutoSize = true;
            this.sheetLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sheetLabel.Location = new System.Drawing.Point(33, 85);
            this.sheetLabel.Name = "sheetLabel";
            this.sheetLabel.Size = new System.Drawing.Size(52, 24);
            this.sheetLabel.TabIndex = 2;
            this.sheetLabel.Text = "張數:";
            // 
            // sheetTextBox
            // 
            this.sheetTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sheetTextBox.Location = new System.Drawing.Point(91, 81);
            this.sheetTextBox.Name = "sheetTextBox";
            this.sheetTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sheetTextBox.Size = new System.Drawing.Size(61, 33);
            this.sheetTextBox.TabIndex = 3;
            this.sheetTextBox.Text = "1";
            this.sheetTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addButton.Location = new System.Drawing.Point(174, 81);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(97, 33);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "加入清單";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // infoRichTextBox
            // 
            this.infoRichTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.infoRichTextBox.Location = new System.Drawing.Point(37, 130);
            this.infoRichTextBox.Name = "infoRichTextBox";
            this.infoRichTextBox.Size = new System.Drawing.Size(467, 168);
            this.infoRichTextBox.TabIndex = 5;
            this.infoRichTextBox.Text = "";
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.clearButton.Location = new System.Drawing.Point(407, 81);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(97, 33);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "清除清單";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // movieTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 337);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.infoRichTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.sheetTextBox);
            this.Controls.Add(this.sheetLabel);
            this.Controls.Add(this.ticketLabel);
            this.Controls.Add(this.ticketCatagory);
            this.Name = "movieTicketForm";
            this.Text = "訂票系統";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ticketCatagory;
        private System.Windows.Forms.Label ticketLabel;
        private System.Windows.Forms.Label sheetLabel;
        private System.Windows.Forms.TextBox sheetTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.RichTextBox infoRichTextBox;
        private System.Windows.Forms.Button clearButton;        
    }
}