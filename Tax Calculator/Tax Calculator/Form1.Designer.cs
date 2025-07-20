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
            Label labelTaxDeducted;
            Label labelEIPaid;
            Label labelCPPPaid;
            textBoxTaxDeducted = new TextBox();
            textBoxEIPaid = new TextBox();
            textBoxGrossIncome = new TextBox();
            textBoxCPP = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            labelGrossIncome = new Label();
            textboxIncomeTax = new TextBox();
            label4 = new Label();
            labelSelectYear = new Label();
            ComboBoxSelectTaxYear = new ComboBox();
            groupBox1 = new GroupBox();
            ComboBoxSelectProvince = new ComboBox();
            LabelSelectProvince = new Label();
            buttonCalculate = new Button();
            InputBox = new GroupBox();
            dataGridViewFederalTaxRates = new DataGridView();
            dataGridViewProvincialTaxRates = new DataGridView();
            TaxRatesGroupBox = new GroupBox();
            OutputGroupBox = new GroupBox();
            labelEffectiveTaxRate = new Label();
            labelTaxOwed = new Label();
            labelMarginalTaxRate = new Label();
            labelTotalIncomeTax = new Label();
            textBoxEffectiveTaxRate = new TextBox();
            textboxTaxOwed = new TextBox();
            textboxMarginalTaxRate = new TextBox();
            label1 = new Label();
            IncomeInformationBox = new GroupBox();
            labelTaxDeducted = new Label();
            labelEIPaid = new Label();
            labelCPPPaid = new Label();
            IncomeInformationBox.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFederalTaxRates).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProvincialTaxRates).BeginInit();
            TaxRatesGroupBox.SuspendLayout();
            OutputGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // IncomeInformationBox
            // 
            IncomeInformationBox.Controls.Add(textBoxTaxDeducted);
            IncomeInformationBox.Controls.Add(textBoxEIPaid);
            IncomeInformationBox.Controls.Add(textBoxGrossIncome);
            IncomeInformationBox.Controls.Add(textBoxCPP);
            IncomeInformationBox.Controls.Add(label5);
            IncomeInformationBox.Controls.Add(label6);
            IncomeInformationBox.Controls.Add(label3);
            IncomeInformationBox.Controls.Add(label2);
            IncomeInformationBox.Controls.Add(labelTaxDeducted);
            IncomeInformationBox.Controls.Add(labelEIPaid);
            IncomeInformationBox.Controls.Add(labelCPPPaid);
            IncomeInformationBox.Controls.Add(labelGrossIncome);
            IncomeInformationBox.Location = new Point(31, 143);
            IncomeInformationBox.Name = "IncomeInformationBox";
            IncomeInformationBox.Size = new Size(276, 153);
            IncomeInformationBox.TabIndex = 7;
            IncomeInformationBox.TabStop = false;
            // 
            // textBoxTaxDeducted
            // 
            textBoxTaxDeducted.Location = new Point(160, 124);
            textBoxTaxDeducted.Name = "textBoxTaxDeducted";
            textBoxTaxDeducted.Size = new Size(100, 23);
            textBoxTaxDeducted.TabIndex = 4;
            textBoxTaxDeducted.TextChanged += textBoxTaxDeducted_TextChanged;
            textBoxTaxDeducted.KeyPress += MoneyInput_KeyPress;
            // 
            // textBoxEIPaid
            // 
            textBoxEIPaid.Location = new Point(160, 93);
            textBoxEIPaid.Name = "textBoxEIPaid";
            textBoxEIPaid.Size = new Size(100, 23);
            textBoxEIPaid.TabIndex = 4;
            textBoxEIPaid.TextChanged += textBoxEIPaid_TextChanged;
            textBoxEIPaid.KeyPress += MoneyInput_KeyPress;
            // 
            // textBoxGrossIncome
            // 
            textBoxGrossIncome.Location = new Point(160, 22);
            textBoxGrossIncome.Name = "textBoxGrossIncome";
            textBoxGrossIncome.Size = new Size(100, 23);
            textBoxGrossIncome.TabIndex = 4;
            textBoxGrossIncome.TextChanged += textBoxGrossIncome_TextChanged;
            textBoxGrossIncome.KeyPress += MoneyInput_KeyPress;
            // 
            // textBoxCPP
            // 
            textBoxCPP.Location = new Point(160, 57);
            textBoxCPP.Name = "textBoxCPP";
            textBoxCPP.Size = new Size(100, 23);
            textBoxCPP.TabIndex = 4;
            textBoxCPP.TextChanged += textBoxCPP_TextChanged;
            textBoxCPP.KeyPress += MoneyInput_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(141, 127);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 6;
            label5.Text = "$";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(141, 25);
            label6.Name = "label6";
            label6.Size = new Size(13, 15);
            label6.TabIndex = 6;
            label6.Text = "$";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(141, 96);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 6;
            label3.Text = "$";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 60);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 6;
            label2.Text = "$";
            // 
            // labelTaxDeducted
            // 
            labelTaxDeducted.AutoSize = true;
            labelTaxDeducted.Location = new Point(17, 127);
            labelTaxDeducted.Name = "labelTaxDeducted";
            labelTaxDeducted.Size = new Size(78, 15);
            labelTaxDeducted.TabIndex = 5;
            labelTaxDeducted.Text = "Tax Deducted";
            // 
            // labelEIPaid
            // 
            labelEIPaid.AutoSize = true;
            labelEIPaid.Location = new Point(17, 96);
            labelEIPaid.Name = "labelEIPaid";
            labelEIPaid.Size = new Size(42, 15);
            labelEIPaid.TabIndex = 5;
            labelEIPaid.Text = "EI Paid";
            // 
            // labelCPPPaid
            // 
            labelCPPPaid.AutoSize = true;
            labelCPPPaid.Location = new Point(17, 60);
            labelCPPPaid.Name = "labelCPPPaid";
            labelCPPPaid.Size = new Size(55, 15);
            labelCPPPaid.TabIndex = 5;
            labelCPPPaid.Text = "CPP Paid";
            // 
            // labelGrossIncome
            // 
            labelGrossIncome.AutoSize = true;
            labelGrossIncome.Location = new Point(17, 25);
            labelGrossIncome.Name = "labelGrossIncome";
            labelGrossIncome.Size = new Size(79, 15);
            labelGrossIncome.TabIndex = 5;
            labelGrossIncome.Text = "Gross Income";
            // 
            // textboxIncomeTax
            // 
            textboxIncomeTax.Location = new Point(111, 18);
            textboxIncomeTax.Name = "textboxIncomeTax";
            textboxIncomeTax.ReadOnly = true;
            textboxIncomeTax.Size = new Size(100, 23);
            textboxIncomeTax.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(92, 21);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 6;
            label4.Text = "$";
            // 
            // labelSelectYear
            // 
            labelSelectYear.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelSelectYear.AutoSize = true;
            labelSelectYear.Location = new Point(17, 31);
            labelSelectYear.Name = "labelSelectYear";
            labelSelectYear.Size = new Size(83, 15);
            labelSelectYear.TabIndex = 1;
            labelSelectYear.Text = "Select Tax Year";
            // 
            // ComboBoxSelectTaxYear
            // 
            ComboBoxSelectTaxYear.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ComboBoxSelectTaxYear.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxSelectTaxYear.FormattingEnabled = true;
            ComboBoxSelectTaxYear.Items.AddRange(new object[] { "2020", "2021", "2022", "2023", "2024", "2025", "2026" });
            ComboBoxSelectTaxYear.Location = new Point(130, 28);
            ComboBoxSelectTaxYear.Name = "ComboBoxSelectTaxYear";
            ComboBoxSelectTaxYear.Size = new Size(83, 23);
            ComboBoxSelectTaxYear.TabIndex = 0;
            ComboBoxSelectTaxYear.SelectedIndexChanged += SelectTaxYear_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ComboBoxSelectProvince);
            groupBox1.Controls.Add(ComboBoxSelectTaxYear);
            groupBox1.Controls.Add(LabelSelectProvince);
            groupBox1.Controls.Add(labelSelectYear);
            groupBox1.Location = new Point(31, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(357, 108);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // ComboBoxSelectProvince
            // 
            ComboBoxSelectProvince.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ComboBoxSelectProvince.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxSelectProvince.FormattingEnabled = true;
            ComboBoxSelectProvince.Items.AddRange(new object[] { "British Columbia", "Alberta", "Saskatchewan", "Manitoba", "Ontario", "Quebec", "New Brunswick", "Nova Scotia", "Prince Edward Island", "Newfoundland and Labrador" });
            ComboBoxSelectProvince.Location = new Point(130, 62);
            ComboBoxSelectProvince.Name = "ComboBoxSelectProvince";
            ComboBoxSelectProvince.Size = new Size(183, 23);
            ComboBoxSelectProvince.TabIndex = 0;
            ComboBoxSelectProvince.SelectedIndexChanged += ComboBoxSelectProvince_SelectedIndexChanged;
            // 
            // LabelSelectProvince
            // 
            LabelSelectProvince.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            LabelSelectProvince.AutoSize = true;
            LabelSelectProvince.Location = new Point(17, 65);
            LabelSelectProvince.Name = "LabelSelectProvince";
            LabelSelectProvince.Size = new Size(87, 15);
            LabelSelectProvince.TabIndex = 1;
            LabelSelectProvince.Text = "Select Province";
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(191, 320);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(100, 23);
            buttonCalculate.TabIndex = 8;
            buttonCalculate.Text = "Calculate";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // InputBox
            // 
            InputBox.Location = new Point(13, 3);
            InputBox.Name = "InputBox";
            InputBox.Size = new Size(469, 362);
            InputBox.TabIndex = 9;
            InputBox.TabStop = false;
            // 
            // dataGridViewFederalTaxRates
            // 
            dataGridViewFederalTaxRates.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFederalTaxRates.Location = new Point(18, 22);
            dataGridViewFederalTaxRates.Name = "dataGridViewFederalTaxRates";
            dataGridViewFederalTaxRates.Size = new Size(193, 178);
            dataGridViewFederalTaxRates.TabIndex = 10;
            // 
            // dataGridViewProvincialTaxRates
            // 
            dataGridViewProvincialTaxRates.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProvincialTaxRates.Location = new Point(240, 22);
            dataGridViewProvincialTaxRates.Name = "dataGridViewProvincialTaxRates";
            dataGridViewProvincialTaxRates.Size = new Size(193, 178);
            dataGridViewProvincialTaxRates.TabIndex = 10;
            // 
            // TaxRatesGroupBox
            // 
            TaxRatesGroupBox.Controls.Add(dataGridViewProvincialTaxRates);
            TaxRatesGroupBox.Controls.Add(dataGridViewFederalTaxRates);
            TaxRatesGroupBox.Location = new Point(519, 3);
            TaxRatesGroupBox.Name = "TaxRatesGroupBox";
            TaxRatesGroupBox.Size = new Size(455, 210);
            TaxRatesGroupBox.TabIndex = 11;
            TaxRatesGroupBox.TabStop = false;
            // 
            // OutputGroupBox
            // 
            OutputGroupBox.Controls.Add(labelEffectiveTaxRate);
            OutputGroupBox.Controls.Add(labelTaxOwed);
            OutputGroupBox.Controls.Add(labelMarginalTaxRate);
            OutputGroupBox.Controls.Add(labelTotalIncomeTax);
            OutputGroupBox.Controls.Add(textBoxEffectiveTaxRate);
            OutputGroupBox.Controls.Add(textboxTaxOwed);
            OutputGroupBox.Controls.Add(textboxMarginalTaxRate);
            OutputGroupBox.Controls.Add(label1);
            OutputGroupBox.Controls.Add(textboxIncomeTax);
            OutputGroupBox.Controls.Add(label4);
            OutputGroupBox.Location = new Point(519, 244);
            OutputGroupBox.Name = "OutputGroupBox";
            OutputGroupBox.Size = new Size(455, 121);
            OutputGroupBox.TabIndex = 12;
            OutputGroupBox.TabStop = false;
            // 
            // labelEffectiveTaxRate
            // 
            labelEffectiveTaxRate.AutoSize = true;
            labelEffectiveTaxRate.Location = new Point(253, 79);
            labelEffectiveTaxRate.Name = "labelEffectiveTaxRate";
            labelEffectiveTaxRate.Size = new Size(98, 15);
            labelEffectiveTaxRate.TabIndex = 7;
            labelEffectiveTaxRate.Text = "Effective Tax Rate";
            // 
            // labelTaxOwed
            // 
            labelTaxOwed.AutoSize = true;
            labelTaxOwed.Location = new Point(18, 80);
            labelTaxOwed.Name = "labelTaxOwed";
            labelTaxOwed.Size = new Size(58, 15);
            labelTaxOwed.TabIndex = 7;
            labelTaxOwed.Text = "Tax Owed";
            // 
            // labelMarginalTaxRate
            // 
            labelMarginalTaxRate.AutoSize = true;
            labelMarginalTaxRate.Location = new Point(253, 21);
            labelMarginalTaxRate.Name = "labelMarginalTaxRate";
            labelMarginalTaxRate.Size = new Size(100, 15);
            labelMarginalTaxRate.TabIndex = 7;
            labelMarginalTaxRate.Text = "Marginal Tax Rate";
            // 
            // labelTotalIncomeTax
            // 
            labelTotalIncomeTax.AutoSize = true;
            labelTotalIncomeTax.Location = new Point(18, 21);
            labelTotalIncomeTax.Name = "labelTotalIncomeTax";
            labelTotalIncomeTax.Size = new Size(67, 15);
            labelTotalIncomeTax.TabIndex = 7;
            labelTotalIncomeTax.Text = "Income Tax";
            // 
            // textBoxEffectiveTaxRate
            // 
            textBoxEffectiveTaxRate.Location = new Point(359, 76);
            textBoxEffectiveTaxRate.Name = "textBoxEffectiveTaxRate";
            textBoxEffectiveTaxRate.ReadOnly = true;
            textBoxEffectiveTaxRate.Size = new Size(74, 23);
            textBoxEffectiveTaxRate.TabIndex = 4;
            // 
            // textboxTaxOwed
            // 
            textboxTaxOwed.Location = new Point(111, 76);
            textboxTaxOwed.Name = "textboxTaxOwed";
            textboxTaxOwed.ReadOnly = true;
            textboxTaxOwed.Size = new Size(100, 23);
            textboxTaxOwed.TabIndex = 4;
            // 
            // textboxMarginalTaxRate
            // 
            textboxMarginalTaxRate.Location = new Point(359, 18);
            textboxMarginalTaxRate.Name = "textboxMarginalTaxRate";
            textboxMarginalTaxRate.ReadOnly = true;
            textboxMarginalTaxRate.Size = new Size(74, 23);
            textboxMarginalTaxRate.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 79);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 6;
            label1.Text = "$";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 416);
            Controls.Add(OutputGroupBox);
            Controls.Add(TaxRatesGroupBox);
            Controls.Add(buttonCalculate);
            Controls.Add(IncomeInformationBox);
            Controls.Add(groupBox1);
            Controls.Add(InputBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            IncomeInformationBox.ResumeLayout(false);
            IncomeInformationBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFederalTaxRates).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProvincialTaxRates).EndInit();
            TaxRatesGroupBox.ResumeLayout(false);
            OutputGroupBox.ResumeLayout(false);
            OutputGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelSelectYear;
        private ComboBox ComboBoxSelectTaxYear;
        private GroupBox groupBox1;
        private ComboBox ComboBoxSelectProvince;
        private Label LabelSelectProvince;
        private TextBox textboxIncomeTax;
        private Label labelGrossIncome;
        private Label label4;
        private GroupBox IncomeInformationBox;
        private TextBox textBoxEIPaid;
        private TextBox textBoxCPP;
        private Label label3;
        private Label label2;
        private TextBox textBoxTaxDeducted;
        private Label label5;
        private Button buttonCalculate;
        private GroupBox InputBox;
        private DataGridView dataGridViewFederalTaxRates;
        private DataGridView dataGridViewProvincialTaxRates;
        private GroupBox TaxRatesGroupBox;
        private GroupBox OutputGroupBox;
        private Label labelTaxOwed;
        private Label labelTotalIncomeTax;
        private TextBox textboxTaxOwed;
        private Label label1;
        private Label labelEffectiveTaxRate;
        private Label labelMarginalTaxRate;
        private TextBox textBoxEffectiveTaxRate;
        private TextBox textboxMarginalTaxRate;
        private TextBox textBoxGrossIncome;
        private Label label6;
    }
}
