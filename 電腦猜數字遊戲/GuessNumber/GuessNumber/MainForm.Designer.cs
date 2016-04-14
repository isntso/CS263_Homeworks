namespace GuessNumber
{
    partial class MainForm
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
            this.computerButton = new System.Windows.Forms.Button();
            this.manualButton = new System.Windows.Forms.Button();
            this.ATextBox = new System.Windows.Forms.TextBox();
            this.ALabel = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.BLabel = new System.Windows.Forms.Label();
            this.BTextBox = new System.Windows.Forms.TextBox();
            this.targetLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // computerButton
            // 
            this.computerButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.computerButton.Location = new System.Drawing.Point(243, 20);
            this.computerButton.Name = "computerButton";
            this.computerButton.Size = new System.Drawing.Size(122, 38);
            this.computerButton.TabIndex = 0;
            this.computerButton.Text = "電腦出題";
            this.computerButton.UseVisualStyleBackColor = true;
            this.computerButton.Click += new System.EventHandler(this.computerButton_Click);
            // 
            // manualButton
            // 
            this.manualButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.manualButton.Location = new System.Drawing.Point(243, 68);
            this.manualButton.Name = "manualButton";
            this.manualButton.Size = new System.Drawing.Size(122, 38);
            this.manualButton.TabIndex = 1;
            this.manualButton.Text = "人工出題";
            this.manualButton.UseVisualStyleBackColor = true;
            this.manualButton.Click += new System.EventHandler(this.manualButton_Click);
            // 
            // ATextBox
            // 
            this.ATextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ATextBox.Location = new System.Drawing.Point(38, 70);
            this.ATextBox.Name = "ATextBox";
            this.ATextBox.Size = new System.Drawing.Size(51, 33);
            this.ATextBox.TabIndex = 2;
            this.ATextBox.Visible = false;
            // 
            // ALabel
            // 
            this.ALabel.AutoSize = true;
            this.ALabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ALabel.Location = new System.Drawing.Point(95, 75);
            this.ALabel.Name = "ALabel";
            this.ALabel.Size = new System.Drawing.Size(23, 24);
            this.ALabel.TabIndex = 4;
            this.ALabel.Text = "A";
            this.ALabel.Visible = false;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resultTextBox.Location = new System.Drawing.Point(26, 121);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(339, 373);
            this.resultTextBox.TabIndex = 6;
            this.resultTextBox.Text = "";
            // 
            // BLabel
            // 
            this.BLabel.AutoSize = true;
            this.BLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BLabel.Location = new System.Drawing.Point(195, 75);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(22, 24);
            this.BLabel.TabIndex = 8;
            this.BLabel.Text = "B";
            this.BLabel.Visible = false;
            // 
            // BTextBox
            // 
            this.BTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTextBox.Location = new System.Drawing.Point(138, 70);
            this.BTextBox.Name = "BTextBox";
            this.BTextBox.Size = new System.Drawing.Size(51, 33);
            this.BTextBox.TabIndex = 7;
            this.BTextBox.Visible = false;
            // 
            // targetLabel
            // 
            this.targetLabel.AutoSize = true;
            this.targetLabel.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.targetLabel.Location = new System.Drawing.Point(88, 24);
            this.targetLabel.Name = "targetLabel";
            this.targetLabel.Size = new System.Drawing.Size(79, 34);
            this.targetLabel.TabIndex = 9;
            this.targetLabel.Text = "1234";
            this.targetLabel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 506);
            this.Controls.Add(this.targetLabel);
            this.Controls.Add(this.BLabel);
            this.Controls.Add(this.BTextBox);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.ALabel);
            this.Controls.Add(this.ATextBox);
            this.Controls.Add(this.manualButton);
            this.Controls.Add(this.computerButton);
            this.Name = "MainForm";
            this.Text = "電腦猜數字遊戲";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button computerButton;
        private System.Windows.Forms.Button manualButton;
        private System.Windows.Forms.TextBox ATextBox;
        private System.Windows.Forms.Label ALabel;
        private System.Windows.Forms.RichTextBox resultTextBox;
        private System.Windows.Forms.Label BLabel;
        private System.Windows.Forms.TextBox BTextBox;
        private System.Windows.Forms.Label targetLabel;
    }
}