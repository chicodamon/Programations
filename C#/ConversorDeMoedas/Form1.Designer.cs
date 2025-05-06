namespace ConversorDeMoedas
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
            input_textbox = new TextBox();
            cb_currency_original = new ComboBox();
            cb_currency_destination = new ComboBox();
            btn_convert = new Button();
            lbl_result = new Label();
            SuspendLayout();
            // 
            // input_textbox
            // 
            input_textbox.BackColor = SystemColors.ButtonFace;
            input_textbox.Font = new Font("Segoe UI", 18F);
            input_textbox.Location = new Point(21, 17);
            input_textbox.Name = "input_textbox";
            input_textbox.Size = new Size(484, 39);
            input_textbox.TabIndex = 0;
            input_textbox.Text = "0";
            input_textbox.TextAlign = HorizontalAlignment.Right;
            // 
            // cb_currency_original
            // 
            cb_currency_original.FormattingEnabled = true;
            cb_currency_original.Location = new Point(21, 73);
            cb_currency_original.Name = "cb_currency_original";
            cb_currency_original.Size = new Size(234, 23);
            cb_currency_original.TabIndex = 1;
            // 
            // cb_currency_destination
            // 
            cb_currency_destination.FormattingEnabled = true;
            cb_currency_destination.Location = new Point(271, 73);
            cb_currency_destination.Name = "cb_currency_destination";
            cb_currency_destination.Size = new Size(234, 23);
            cb_currency_destination.TabIndex = 2;
            // 
            // btn_convert
            // 
            btn_convert.Location = new Point(21, 111);
            btn_convert.Name = "btn_convert";
            btn_convert.Size = new Size(484, 29);
            btn_convert.TabIndex = 3;
            btn_convert.Text = "Converter";
            btn_convert.UseVisualStyleBackColor = true;
            btn_convert.Click += btn_convert_Click;
            // 
            // lbl_result
            // 
            lbl_result.AutoSize = true;
            lbl_result.Font = new Font("Segoe UI", 18F);
            lbl_result.Location = new Point(137, 152);
            lbl_result.Name = "lbl_result";
            lbl_result.Size = new Size(123, 32);
            lbl_result.TabIndex = 4;
            lbl_result.Text = "Resultado:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(531, 193);
            Controls.Add(lbl_result);
            Controls.Add(btn_convert);
            Controls.Add(cb_currency_destination);
            Controls.Add(cb_currency_original);
            Controls.Add(input_textbox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Conversor de Moeadas - Francisco";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox input_textbox;
        private ComboBox cb_currency_original;
        private ComboBox cb_currency_destination;
        private Button btn_convert;
        private Label lbl_result;
    }
}
