namespace BasicCalculator
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
            this.UserInputText = new System.Windows.Forms.TextBox();
            this.CalculationsResultsText = new System.Windows.Forms.Label();
            this.ButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.DotButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.MultiplicationButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.DELButton = new System.Windows.Forms.Button();
            this.Cbutton = new System.Windows.Forms.Button();
            this.CEButton = new System.Windows.Forms.Button();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInputText
            // 
            this.UserInputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInputText.Location = new System.Drawing.Point(13, 13);
            this.UserInputText.Name = "UserInputText";
            this.UserInputText.Size = new System.Drawing.Size(294, 20);
            this.UserInputText.TabIndex = 0;
            // 
            // CalculationsResultsText
            // 
            this.CalculationsResultsText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculationsResultsText.Location = new System.Drawing.Point(13, 40);
            this.CalculationsResultsText.Name = "CalculationsResultsText";
            this.CalculationsResultsText.Size = new System.Drawing.Size(294, 23);
            this.CalculationsResultsText.TabIndex = 1;
            this.CalculationsResultsText.Text = "Please enter an  equation and press enter or =";
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsPanel.ColumnCount = 4;
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.Controls.Add(this.EqualsButton, 3, 4);
            this.ButtonsPanel.Controls.Add(this.DotButton, 2, 4);
            this.ButtonsPanel.Controls.Add(this.ZeroButton, 1, 4);
            this.ButtonsPanel.Controls.Add(this.PlusButton, 3, 3);
            this.ButtonsPanel.Controls.Add(this.ThreeButton, 2, 3);
            this.ButtonsPanel.Controls.Add(this.TwoButton, 1, 3);
            this.ButtonsPanel.Controls.Add(this.OneButton, 0, 3);
            this.ButtonsPanel.Controls.Add(this.MinusButton, 3, 2);
            this.ButtonsPanel.Controls.Add(this.SixButton, 2, 2);
            this.ButtonsPanel.Controls.Add(this.FiveButton, 1, 2);
            this.ButtonsPanel.Controls.Add(this.FourButton, 0, 2);
            this.ButtonsPanel.Controls.Add(this.MultiplicationButton, 3, 1);
            this.ButtonsPanel.Controls.Add(this.NineButton, 2, 1);
            this.ButtonsPanel.Controls.Add(this.EightButton, 1, 1);
            this.ButtonsPanel.Controls.Add(this.SevenButton, 0, 1);
            this.ButtonsPanel.Controls.Add(this.DivideButton, 3, 0);
            this.ButtonsPanel.Controls.Add(this.DELButton, 2, 0);
            this.ButtonsPanel.Controls.Add(this.Cbutton, 1, 0);
            this.ButtonsPanel.Controls.Add(this.CEButton, 0, 0);
            this.ButtonsPanel.Location = new System.Drawing.Point(13, 66);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.RowCount = 5;
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ButtonsPanel.Size = new System.Drawing.Size(294, 267);
            this.ButtonsPanel.TabIndex = 2;
            // 
            // EqualsButton
            // 
            this.EqualsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EqualsButton.Location = new System.Drawing.Point(222, 215);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(69, 49);
            this.EqualsButton.TabIndex = 19;
            this.EqualsButton.Text = "=";
            this.EqualsButton.UseVisualStyleBackColor = true;
            this.EqualsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // DotButton
            // 
            this.DotButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DotButton.Location = new System.Drawing.Point(149, 215);
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(67, 49);
            this.DotButton.TabIndex = 18;
            this.DotButton.Text = ".";
            this.DotButton.UseVisualStyleBackColor = true;
            this.DotButton.Click += new System.EventHandler(this.DotButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZeroButton.Location = new System.Drawing.Point(76, 215);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(67, 49);
            this.ZeroButton.TabIndex = 17;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlusButton.Location = new System.Drawing.Point(222, 162);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(69, 47);
            this.PlusButton.TabIndex = 15;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThreeButton.Location = new System.Drawing.Point(149, 162);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(67, 47);
            this.ThreeButton.TabIndex = 14;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            this.ThreeButton.Click += new System.EventHandler(this.ThreeButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TwoButton.Location = new System.Drawing.Point(76, 162);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(67, 47);
            this.TwoButton.TabIndex = 13;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            this.TwoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OneButton.Location = new System.Drawing.Point(3, 162);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(67, 47);
            this.OneButton.TabIndex = 12;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinusButton.Location = new System.Drawing.Point(222, 109);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(69, 47);
            this.MinusButton.TabIndex = 11;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SixButton.Location = new System.Drawing.Point(149, 109);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(67, 47);
            this.SixButton.TabIndex = 10;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            this.SixButton.Click += new System.EventHandler(this.SixButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiveButton.Location = new System.Drawing.Point(76, 109);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(67, 47);
            this.FiveButton.TabIndex = 9;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            this.FiveButton.Click += new System.EventHandler(this.FiveButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FourButton.Location = new System.Drawing.Point(3, 109);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(67, 47);
            this.FourButton.TabIndex = 8;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            this.FourButton.Click += new System.EventHandler(this.FourButton_Click);
            // 
            // MultiplicationButton
            // 
            this.MultiplicationButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MultiplicationButton.Location = new System.Drawing.Point(222, 56);
            this.MultiplicationButton.Name = "MultiplicationButton";
            this.MultiplicationButton.Size = new System.Drawing.Size(69, 47);
            this.MultiplicationButton.TabIndex = 7;
            this.MultiplicationButton.Text = "X";
            this.MultiplicationButton.UseVisualStyleBackColor = true;
            this.MultiplicationButton.Click += new System.EventHandler(this.MultiplicationButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NineButton.Location = new System.Drawing.Point(149, 56);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(67, 47);
            this.NineButton.TabIndex = 6;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = true;
            this.NineButton.Click += new System.EventHandler(this.NineButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EightButton.Location = new System.Drawing.Point(76, 56);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(67, 47);
            this.EightButton.TabIndex = 5;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            this.EightButton.Click += new System.EventHandler(this.EightButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SevenButton.Location = new System.Drawing.Point(3, 56);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(67, 47);
            this.SevenButton.TabIndex = 4;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            this.SevenButton.Click += new System.EventHandler(this.SevenButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DivideButton.Location = new System.Drawing.Point(222, 3);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(69, 47);
            this.DivideButton.TabIndex = 3;
            this.DivideButton.Text = "%";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // DELButton
            // 
            this.DELButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DELButton.Location = new System.Drawing.Point(149, 3);
            this.DELButton.Name = "DELButton";
            this.DELButton.Size = new System.Drawing.Size(67, 47);
            this.DELButton.TabIndex = 2;
            this.DELButton.Text = "DEL";
            this.DELButton.UseVisualStyleBackColor = true;
            this.DELButton.Click += new System.EventHandler(this.DELButton_Click);
            // 
            // Cbutton
            // 
            this.Cbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cbutton.Location = new System.Drawing.Point(76, 3);
            this.Cbutton.Name = "Cbutton";
            this.Cbutton.Size = new System.Drawing.Size(67, 47);
            this.Cbutton.TabIndex = 1;
            this.Cbutton.Text = "C";
            this.Cbutton.UseVisualStyleBackColor = true;
            // 
            // CEButton
            // 
            this.CEButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CEButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEButton.Location = new System.Drawing.Point(3, 3);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(67, 47);
            this.CEButton.TabIndex = 0;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = true;
            this.CEButton.Click += new System.EventHandler(this.CEButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.EqualsButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CEButton;
            this.ClientSize = new System.Drawing.Size(319, 345);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.CalculationsResultsText);
            this.Controls.Add(this.UserInputText);
            this.MaximumSize = new System.Drawing.Size(580, 600);
            this.MinimumSize = new System.Drawing.Size(270, 300);
            this.Name = "Form1";
            this.Text = "Basic Calculator";
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInputText;
        private System.Windows.Forms.Label CalculationsResultsText;
        private System.Windows.Forms.TableLayoutPanel ButtonsPanel;
        private System.Windows.Forms.Button CEButton;
        private System.Windows.Forms.Button EqualsButton;
        private System.Windows.Forms.Button DotButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button MultiplicationButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button DELButton;
        private System.Windows.Forms.Button Cbutton;
    }
}

