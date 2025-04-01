namespace Calculator2000
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DisplayTextBox = new TextBox();
            btn_changeSignal = new Button();
            btn_0 = new Button();
            btn_dot = new Button();
            btn_percentage = new Button();
            btn_equal = new Button();
            btn_sum = new Button();
            btn_subtract = new Button();
            btn_3 = new Button();
            btn_2 = new Button();
            btn_1 = new Button();
            btn_division = new Button();
            btn_multiplication = new Button();
            btn_6 = new Button();
            btn_5 = new Button();
            btn_4 = new Button();
            btn_clearEntry = new Button();
            btn_clear = new Button();
            btn_9 = new Button();
            btn_8 = new Button();
            btn_7 = new Button();
            SuspendLayout();
            // 
            // DisplayTextBox
            // 
            DisplayTextBox.BackColor = SystemColors.ButtonShadow;
            DisplayTextBox.Font = new Font("MS Reference Sans Serif", 16F);
            DisplayTextBox.Location = new Point(22, 31);
            DisplayTextBox.Name = "DisplayTextBox";
            DisplayTextBox.ReadOnly = true;
            DisplayTextBox.Size = new Size(316, 33);
            DisplayTextBox.TabIndex = 0;
            DisplayTextBox.Text = "0";
            DisplayTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // btn_changeSignal
            // 
            btn_changeSignal.BackColor = SystemColors.ButtonShadow;
            btn_changeSignal.Location = new Point(22, 263);
            btn_changeSignal.Name = "btn_changeSignal";
            btn_changeSignal.Size = new Size(54, 46);
            btn_changeSignal.TabIndex = 1;
            btn_changeSignal.Text = "+/-";
            btn_changeSignal.UseVisualStyleBackColor = false;
            // 
            // btn_0
            // 
            btn_0.BackColor = SystemColors.ButtonShadow;
            btn_0.Location = new Point(82, 263);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(54, 46);
            btn_0.TabIndex = 2;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = false;
            btn_0.Click += btn_0_Click;
            // 
            // btn_dot
            // 
            btn_dot.BackColor = SystemColors.ButtonShadow;
            btn_dot.Location = new Point(142, 263);
            btn_dot.Name = "btn_dot";
            btn_dot.Size = new Size(54, 46);
            btn_dot.TabIndex = 3;
            btn_dot.Text = ".";
            btn_dot.UseVisualStyleBackColor = false;
            btn_dot.Click += btn_dot_Click;
            // 
            // btn_percentage
            // 
            btn_percentage.BackColor = SystemColors.ButtonShadow;
            btn_percentage.Location = new Point(284, 263);
            btn_percentage.Name = "btn_percentage";
            btn_percentage.Size = new Size(54, 46);
            btn_percentage.TabIndex = 4;
            btn_percentage.Text = "%";
            btn_percentage.UseVisualStyleBackColor = false;
            btn_percentage.Click += btn_percentage_Click;
            // 
            // btn_equal
            // 
            btn_equal.BackColor = SystemColors.ButtonShadow;
            btn_equal.Location = new Point(224, 263);
            btn_equal.Name = "btn_equal";
            btn_equal.Size = new Size(54, 46);
            btn_equal.TabIndex = 5;
            btn_equal.Text = "=";
            btn_equal.UseVisualStyleBackColor = false;
            btn_equal.Click += btn_equal_Click;
            // 
            // btn_sum
            // 
            btn_sum.BackColor = SystemColors.ButtonShadow;
            btn_sum.Location = new Point(224, 211);
            btn_sum.Name = "btn_sum";
            btn_sum.Size = new Size(54, 46);
            btn_sum.TabIndex = 10;
            btn_sum.Text = "+";
            btn_sum.UseVisualStyleBackColor = false;
            btn_sum.Click += btn_sum_Click;
            // 
            // btn_subtract
            // 
            btn_subtract.BackColor = SystemColors.ButtonShadow;
            btn_subtract.Location = new Point(284, 211);
            btn_subtract.Name = "btn_subtract";
            btn_subtract.Size = new Size(54, 46);
            btn_subtract.TabIndex = 9;
            btn_subtract.Text = "-";
            btn_subtract.UseVisualStyleBackColor = false;
            btn_subtract.Click += btn_subtract_Click;
            // 
            // btn_3
            // 
            btn_3.BackColor = SystemColors.ButtonShadow;
            btn_3.Location = new Point(142, 211);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(54, 46);
            btn_3.TabIndex = 8;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = false;
            btn_3.Click += btn_3_Click;
            // 
            // btn_2
            // 
            btn_2.BackColor = SystemColors.ButtonShadow;
            btn_2.Location = new Point(82, 211);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(54, 46);
            btn_2.TabIndex = 7;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = false;
            btn_2.Click += btn_2_Click;
            // 
            // btn_1
            // 
            btn_1.BackColor = SystemColors.ButtonShadow;
            btn_1.Location = new Point(22, 211);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(54, 46);
            btn_1.TabIndex = 6;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = false;
            btn_1.Click += btn_1_Click;
            // 
            // btn_division
            // 
            btn_division.BackColor = SystemColors.ButtonShadow;
            btn_division.Location = new Point(224, 159);
            btn_division.Name = "btn_division";
            btn_division.Size = new Size(54, 46);
            btn_division.TabIndex = 15;
            btn_division.Text = "/";
            btn_division.UseVisualStyleBackColor = false;
            btn_division.Click += btn_division_Click;
            // 
            // btn_multiplication
            // 
            btn_multiplication.BackColor = SystemColors.ButtonShadow;
            btn_multiplication.Location = new Point(284, 159);
            btn_multiplication.Name = "btn_multiplication";
            btn_multiplication.Size = new Size(54, 46);
            btn_multiplication.TabIndex = 14;
            btn_multiplication.Text = "*";
            btn_multiplication.UseVisualStyleBackColor = false;
            btn_multiplication.Click += btn_multiplication_Click;
            // 
            // btn_6
            // 
            btn_6.BackColor = SystemColors.ButtonShadow;
            btn_6.Location = new Point(142, 159);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(54, 46);
            btn_6.TabIndex = 13;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = false;
            btn_6.Click += btn_6_Click;
            // 
            // btn_5
            // 
            btn_5.BackColor = SystemColors.ButtonShadow;
            btn_5.Location = new Point(82, 159);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(54, 46);
            btn_5.TabIndex = 12;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = false;
            btn_5.Click += btn_5_Click;
            // 
            // btn_4
            // 
            btn_4.BackColor = SystemColors.ButtonShadow;
            btn_4.Location = new Point(22, 159);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(54, 46);
            btn_4.TabIndex = 11;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = false;
            btn_4.Click += btn_4_Click;
            // 
            // btn_clearEntry
            // 
            btn_clearEntry.BackColor = SystemColors.ButtonShadow;
            btn_clearEntry.Location = new Point(224, 107);
            btn_clearEntry.Name = "btn_clearEntry";
            btn_clearEntry.Size = new Size(54, 46);
            btn_clearEntry.TabIndex = 20;
            btn_clearEntry.Text = "CE";
            btn_clearEntry.UseVisualStyleBackColor = false;
            btn_clearEntry.Click += btn_clearEntry_Click;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = SystemColors.ButtonShadow;
            btn_clear.Location = new Point(284, 107);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(54, 46);
            btn_clear.TabIndex = 19;
            btn_clear.Text = "C";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_9
            // 
            btn_9.BackColor = SystemColors.ButtonShadow;
            btn_9.Location = new Point(142, 107);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(54, 46);
            btn_9.TabIndex = 18;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = false;
            btn_9.Click += btn_9_Click;
            // 
            // btn_8
            // 
            btn_8.BackColor = SystemColors.ButtonShadow;
            btn_8.Location = new Point(82, 107);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(54, 46);
            btn_8.TabIndex = 17;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = false;
            btn_8.Click += btn_8_Click;
            // 
            // btn_7
            // 
            btn_7.BackColor = SystemColors.ButtonShadow;
            btn_7.Location = new Point(22, 107);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(54, 46);
            btn_7.TabIndex = 16;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = false;
            btn_7.Click += btn_7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(364, 363);
            Controls.Add(btn_clearEntry);
            Controls.Add(btn_clear);
            Controls.Add(btn_9);
            Controls.Add(btn_8);
            Controls.Add(btn_7);
            Controls.Add(btn_division);
            Controls.Add(btn_multiplication);
            Controls.Add(btn_6);
            Controls.Add(btn_5);
            Controls.Add(btn_4);
            Controls.Add(btn_sum);
            Controls.Add(btn_subtract);
            Controls.Add(btn_3);
            Controls.Add(btn_2);
            Controls.Add(btn_1);
            Controls.Add(btn_equal);
            Controls.Add(btn_percentage);
            Controls.Add(btn_dot);
            Controls.Add(btn_0);
            Controls.Add(btn_changeSignal);
            Controls.Add(DisplayTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DisplayTextBox;
        private Button btn_changeSignal;
        private Button btn_0;
        private Button btn_dot;
        private Button btn_percentage;
        private Button btn_equal;
        private Button btn_sum;
        private Button btn_subtract;
        private Button btn_3;
        private Button btn_2;
        private Button btn_1;
        private Button btn_division;
        private Button btn_multiplication;
        private Button btn_6;
        private Button btn_5;
        private Button btn_4;
        private Button btn_clearEntry;
        private Button btn_clear;
        private Button btn_9;
        private Button btn_8;
        private Button btn_7;
    }
}
