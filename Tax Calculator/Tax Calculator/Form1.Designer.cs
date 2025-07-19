namespace Tax_Calculator
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
            GroupBox IncomeInformationBox;
            Label LabelEIPaid;
            Label LabelCPPPaid;
            TextBoxEIPaid = new TextBox();
            TextBoxCPP = new TextBox();
            TextBoxGrossIncome = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            LabelGrossIncome = new Label();
            LabelSelectYear = new Label();
            ComboBoxSelectTaxYear = new ComboBox();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            ComboBoxSelectProvince = new ComboBox();
            LabelSelectProvince = new Label();
            IncomeInformationBox = new GroupBox();
            LabelEIPaid = new Label();
            LabelCPPPaid = new Label();
            IncomeInformationBox.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // IncomeInformationBox
            // 
            IncomeInformationBox.Controls.Add(TextBoxEIPaid);
            IncomeInformationBox.Controls.Add(TextBoxCPP);
            IncomeInformationBox.Controls.Add(TextBoxGrossIncome);
            IncomeInformationBox.Controls.Add(label3);
            IncomeInformationBox.Controls.Add(label2);
            IncomeInformationBox.Controls.Add(label4);
            IncomeInformationBox.Controls.Add(LabelEIPaid);
            IncomeInformationBox.Controls.Add(LabelCPPPaid);
            IncomeInformationBox.Controls.Add(LabelGrossIncome);
            IncomeInformationBox.Location = new Point(12, 166);
            IncomeInformationBox.Name = "IncomeInformationBox";
            IncomeInformationBox.Size = new Size(266, 153);
            IncomeInformationBox.TabIndex = 7;
            IncomeInformationBox.TabStop = false;
            // 
            // TextBoxEIPaid
            // 
            TextBoxEIPaid.Location = new Point(130, 93);
            TextBoxEIPaid.Name = "TextBoxEIPaid";
            TextBoxEIPaid.Size = new Size(100, 23);
            TextBoxEIPaid.TabIndex = 4;
            TextBoxEIPaid.TextChanged += GrossIncomeInput_TextChanged;
            TextBoxEIPaid.KeyPress += GrossIncomeInput_KeyPress;
            // 
            // TextBoxCPP
            // 
            TextBoxCPP.Location = new Point(130, 57);
            TextBoxCPP.Name = "TextBoxCPP";
            TextBoxCPP.Size = new Size(100, 23);
            TextBoxCPP.TabIndex = 4;
            TextBoxCPP.TextChanged += CPPPaidInput_TextChanged;
            TextBoxCPP.KeyPress += CPPPaidInput_KeyPress;
            // 
            // TextBoxGrossIncome
            // 
            TextBoxGrossIncome.Location = new Point(130, 22);
            TextBoxGrossIncome.Name = "TextBoxGrossIncome";
            TextBoxGrossIncome.Size = new Size(100, 23);
            TextBoxGrossIncome.TabIndex = 4;
            TextBoxGrossIncome.TextChanged += CPPPaidInput_TextChanged;
            TextBoxGrossIncome.KeyPress += GrossIncomeInput_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 96);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 6;
            label3.Text = "$";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 60);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 6;
            label2.Text = "$";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(111, 25);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 6;
            label4.Text = "$";
            // 
            // LabelEIPaid
            // 
            LabelEIPaid.AutoSize = true;
            LabelEIPaid.Location = new Point(17, 96);
            LabelEIPaid.Name = "LabelEIPaid";
            LabelEIPaid.Size = new Size(42, 15);
            LabelEIPaid.TabIndex = 5;
            LabelEIPaid.Text = "EI Paid";
            // 
            // LabelCPPPaid
            // 
            LabelCPPPaid.AutoSize = true;
            LabelCPPPaid.Location = new Point(17, 60);
            LabelCPPPaid.Name = "LabelCPPPaid";
            LabelCPPPaid.Size = new Size(55, 15);
            LabelCPPPaid.TabIndex = 5;
            LabelCPPPaid.Text = "CPP Paid";
            // 
            // LabelGrossIncome
            // 
            LabelGrossIncome.AutoSize = true;
            LabelGrossIncome.Location = new Point(17, 25);
            LabelGrossIncome.Name = "LabelGrossIncome";
            LabelGrossIncome.Size = new Size(79, 15);
            LabelGrossIncome.TabIndex = 5;
            LabelGrossIncome.Text = "Gross Income";
            // 
            // LabelSelectYear
            // 
            LabelSelectYear.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            LabelSelectYear.AutoSize = true;
            LabelSelectYear.Location = new Point(17, 12);
            LabelSelectYear.Name = "LabelSelectYear";
            LabelSelectYear.Size = new Size(83, 15);
            LabelSelectYear.TabIndex = 1;
            LabelSelectYear.Text = "Select Tax Year";
            // 
            // ComboBoxSelectTaxYear
            // 
            ComboBoxSelectTaxYear.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ComboBoxSelectTaxYear.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxSelectTaxYear.FormattingEnabled = true;
            ComboBoxSelectTaxYear.Items.AddRange(new object[] { "2020", "2021", "2022", "2023", "2024", "2025", "2026" });
            ComboBoxSelectTaxYear.Location = new Point(130, 9);
            ComboBoxSelectTaxYear.Name = "ComboBoxSelectTaxYear";
            ComboBoxSelectTaxYear.Size = new Size(83, 23);
            ComboBoxSelectTaxYear.TabIndex = 0;
            ComboBoxSelectTaxYear.SelectedIndexChanged += SelectTaxYear_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(ComboBoxSelectTaxYear);
            panel1.Controls.Add(LabelSelectYear);
            panel1.Location = new Point(8, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(232, 42);
            panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(357, 136);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(ComboBoxSelectProvince);
            panel2.Controls.Add(LabelSelectProvince);
            panel2.Location = new Point(8, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(337, 42);
            panel2.TabIndex = 3;
            // 
            // ComboBoxSelectProvince
            // 
            ComboBoxSelectProvince.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ComboBoxSelectProvince.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxSelectProvince.FormattingEnabled = true;
            ComboBoxSelectProvince.Items.AddRange(new object[] { "British Columbia", "Alberta", "Saskatchewan", "Manitoba", "Ontario", "Quebec", "New Brunswick", "Nova Scotia", "Prince Edward Island", "Newfoundland and Labridor" });
            ComboBoxSelectProvince.Location = new Point(130, 9);
            ComboBoxSelectProvince.Name = "ComboBoxSelectProvince";
            ComboBoxSelectProvince.Size = new Size(183, 23);
            ComboBoxSelectProvince.TabIndex = 0;
            ComboBoxSelectProvince.SelectedIndexChanged += ComboBoxSelectProvince_SelectedIndexChanged;
            // 
            // LabelSelectProvince
            // 
            LabelSelectProvince.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            LabelSelectProvince.AutoSize = true;
            LabelSelectProvince.Location = new Point(17, 12);
            LabelSelectProvince.Name = "LabelSelectProvince";
            LabelSelectProvince.Size = new Size(87, 15);
            LabelSelectProvince.TabIndex = 1;
            LabelSelectProvince.Text = "Select Province";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 603);
            Controls.Add(IncomeInformationBox);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            IncomeInformationBox.ResumeLayout(false);
            IncomeInformationBox.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label LabelSelectYear;
        private ComboBox ComboBoxSelectTaxYear;
        private Panel panel1;
        private GroupBox groupBox1;
        private Panel panel2;
        private ComboBox ComboBoxSelectProvince;
        private Label LabelSelectProvince;
        private TextBox TextBoxGrossIncome;
        private Label LabelGrossIncome;
        private Label label4;
        private GroupBox IncomeInformationBox;
        private TextBox TextBoxEIPaid;
        private TextBox TextBoxCPP;
        private Label label3;
        private Label label2;
    }
}
