namespace WindowsFormsApp3
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
            this.test1PromptLabel = new System.Windows.Forms.Label();
            this.test2PromptLabel = new System.Windows.Forms.Label();
            this.test3PromptLabel = new System.Windows.Forms.Label();
            this.test1TextBox = new System.Windows.Forms.TextBox();
            this.test2TextBox = new System.Windows.Forms.TextBox();
            this.test3TextBox = new System.Windows.Forms.TextBox();
            this.OutputDescriptionLabel = new System.Windows.Forms.Label();
            this.AverageLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // test1PromptLabel
            // 
            this.test1PromptLabel.AutoSize = true;
            this.test1PromptLabel.Location = new System.Drawing.Point(116, 54);
            this.test1PromptLabel.Name = "test1PromptLabel";
            this.test1PromptLabel.Size = new System.Drawing.Size(40, 13);
            this.test1PromptLabel.TabIndex = 0;
            this.test1PromptLabel.Text = "Test 1 ";
            // 
            // test2PromptLabel
            // 
            this.test2PromptLabel.AutoSize = true;
            this.test2PromptLabel.Location = new System.Drawing.Point(116, 87);
            this.test2PromptLabel.Name = "test2PromptLabel";
            this.test2PromptLabel.Size = new System.Drawing.Size(37, 13);
            this.test2PromptLabel.TabIndex = 1;
            this.test2PromptLabel.Text = "Test 2";
            // 
            // test3PromptLabel
            // 
            this.test3PromptLabel.AutoSize = true;
            this.test3PromptLabel.Location = new System.Drawing.Point(116, 119);
            this.test3PromptLabel.Name = "test3PromptLabel";
            this.test3PromptLabel.Size = new System.Drawing.Size(37, 13);
            this.test3PromptLabel.TabIndex = 2;
            this.test3PromptLabel.Text = "Test 3";
            // 
            // test1TextBox
            // 
            this.test1TextBox.Location = new System.Drawing.Point(233, 51);
            this.test1TextBox.Name = "test1TextBox";
            this.test1TextBox.Size = new System.Drawing.Size(100, 20);
            this.test1TextBox.TabIndex = 3;
            // 
            // test2TextBox
            // 
            this.test2TextBox.Location = new System.Drawing.Point(233, 84);
            this.test2TextBox.Name = "test2TextBox";
            this.test2TextBox.Size = new System.Drawing.Size(100, 20);
            this.test2TextBox.TabIndex = 4;
            // 
            // test3TextBox
            // 
            this.test3TextBox.Location = new System.Drawing.Point(233, 116);
            this.test3TextBox.Name = "test3TextBox";
            this.test3TextBox.Size = new System.Drawing.Size(100, 20);
            this.test3TextBox.TabIndex = 5;
            // 
            // OutputDescriptionLabel
            // 
            this.OutputDescriptionLabel.AutoSize = true;
            this.OutputDescriptionLabel.Location = new System.Drawing.Point(116, 153);
            this.OutputDescriptionLabel.Name = "OutputDescriptionLabel";
            this.OutputDescriptionLabel.Size = new System.Drawing.Size(105, 13);
            this.OutputDescriptionLabel.TabIndex = 6;
            this.OutputDescriptionLabel.Text = "Average Test Score:";
            // 
            // AverageLabel
            // 
            this.AverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AverageLabel.Location = new System.Drawing.Point(233, 148);
            this.AverageLabel.Name = "AverageLabel";
            this.AverageLabel.Size = new System.Drawing.Size(100, 23);
            this.AverageLabel.TabIndex = 7;
            this.AverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(49, 217);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(121, 23);
            this.CalculateButton.TabIndex = 8;
            this.CalculateButton.Text = "Calculate Sale Price";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(233, 217);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(393, 217);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 276);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.AverageLabel);
            this.Controls.Add(this.OutputDescriptionLabel);
            this.Controls.Add(this.test3TextBox);
            this.Controls.Add(this.test2TextBox);
            this.Controls.Add(this.test1TextBox);
            this.Controls.Add(this.test3PromptLabel);
            this.Controls.Add(this.test2PromptLabel);
            this.Controls.Add(this.test1PromptLabel);
            this.Name = "Form1";
            this.Text = "Test Average Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label test1PromptLabel;
        private System.Windows.Forms.Label test2PromptLabel;
        private System.Windows.Forms.Label test3PromptLabel;
        private System.Windows.Forms.TextBox test1TextBox;
        private System.Windows.Forms.TextBox test2TextBox;
        private System.Windows.Forms.TextBox test3TextBox;
        private System.Windows.Forms.Label OutputDescriptionLabel;
        private System.Windows.Forms.Label AverageLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

