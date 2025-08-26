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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            textboxTaxDeducted = new TextBox();
            textboxEIPremiums = new TextBox();
            textboxGrossIncome = new TextBox();
            textboxCPP = new TextBox();
            labelTaxDeductedDollarSign = new Label();
            labelGrossIncomeDollarSign = new Label();
            labelEIPremiumsDollarSign = new Label();
            labelCPPContributionsDollarSign = new Label();
            labelGrossIncome = new Label();
            textboxFederalTax = new TextBox();
            labelFederalTaxDollarSign = new Label();
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
            labelProvincialMarginalTaxRatePercentSign = new Label();
            labelProvincialMarginalTaxRate = new Label();
            textBoxProvincialMarginalTaxRate = new TextBox();
            labelEffectiveTaxRatePercentSign = new Label();
            labelFederalMarginalTaxRatePercentSign = new Label();
            labelTotalIncomeTax = new Label();
            textboxTotalIncomeTax = new TextBox();
            labelTotalIncomeTaxDollarSign = new Label();
            labelProvincialTax = new Label();
            textboxProvincialTax = new TextBox();
            labelProvincialTaxDollarSign = new Label();
            labelEffectiveTaxRate = new Label();
            labelTaxOwing = new Label();
            labelFederalMarginalTaxRate = new Label();
            labelTotalFederalTax = new Label();
            textboxEffectiveTaxRate = new TextBox();
            textboxTaxOwing = new TextBox();
            textboxFederalMarginalTaxRate = new TextBox();
            labelTaxOwingDollarSign = new Label();
            IncomeInformationBox = new GroupBox();
            labelTaxDeducted = new Label();
            labelEIPaid = new Label();
            labelCPPPaid = new Label();
            IncomeInformationBox.SuspendLayout();
            groupBox1.SuspendLayout();
            InputBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFederalTaxRates).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProvincialTaxRates).BeginInit();
            TaxRatesGroupBox.SuspendLayout();
            OutputGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // IncomeInformationBox
            // 
            IncomeInformationBox.Controls.Add(textboxTaxDeducted);
            IncomeInformationBox.Controls.Add(textboxEIPremiums);
            IncomeInformationBox.Controls.Add(textboxGrossIncome);
            IncomeInformationBox.Controls.Add(textboxCPP);
            IncomeInformationBox.Controls.Add(labelTaxDeductedDollarSign);
            IncomeInformationBox.Controls.Add(labelGrossIncomeDollarSign);
            IncomeInformationBox.Controls.Add(labelEIPremiumsDollarSign);
            IncomeInformationBox.Controls.Add(labelCPPContributionsDollarSign);
            IncomeInformationBox.Controls.Add(labelTaxDeducted);
            IncomeInformationBox.Controls.Add(labelEIPaid);
            IncomeInformationBox.Controls.Add(labelCPPPaid);
            IncomeInformationBox.Controls.Add(labelGrossIncome);
            IncomeInformationBox.Location = new Point(31, 143);
            IncomeInformationBox.Name = "IncomeInformationBox";
            IncomeInformationBox.Size = new Size(276, 222);
            IncomeInformationBox.TabIndex = 7;
            IncomeInformationBox.TabStop = false;
            // 
            // textboxTaxDeducted
            // 
            textboxTaxDeducted.Location = new Point(160, 169);
            textboxTaxDeducted.Name = "textboxTaxDeducted";
            textboxTaxDeducted.Size = new Size(100, 23);
            textboxTaxDeducted.TabIndex = 4;
            textboxTaxDeducted.TextChanged += textBoxTaxDeducted_TextChanged;
            textboxTaxDeducted.KeyPress += MoneyInput_KeyPress;
            textboxTaxDeducted.Leave += InputBox_Leave;
            // 
            // textboxEIPremiums
            // 
            textboxEIPremiums.Location = new Point(160, 106);
            textboxEIPremiums.Name = "textboxEIPremiums";
            textboxEIPremiums.Size = new Size(100, 23);
            textboxEIPremiums.TabIndex = 3;
            textboxEIPremiums.TextChanged += textBoxEIPaid_TextChanged;
            textboxEIPremiums.KeyPress += MoneyInput_KeyPress;
            textboxEIPremiums.Leave += InputBox_Leave;
            // 
            // textboxGrossIncome
            // 
            textboxGrossIncome.Location = new Point(160, 22);
            textboxGrossIncome.Name = "textboxGrossIncome";
            textboxGrossIncome.Size = new Size(100, 23);
            textboxGrossIncome.TabIndex = 1;
            textboxGrossIncome.TextChanged += textBoxGrossIncome_TextChanged;
            textboxGrossIncome.KeyPress += MoneyInput_KeyPress;
            textboxGrossIncome.Leave += InputBox_Leave;
            // 
            // textboxCPP
            // 
            textboxCPP.Location = new Point(160, 77);
            textboxCPP.Name = "textboxCPP";
            textboxCPP.Size = new Size(100, 23);
            textboxCPP.TabIndex = 2;
            textboxCPP.TextChanged += textBoxCPP_TextChanged;
            textboxCPP.KeyPress += MoneyInput_KeyPress;
            textboxCPP.Leave += InputBox_Leave;
            // 
            // labelTaxDeductedDollarSign
            // 
            labelTaxDeductedDollarSign.AutoSize = true;
            labelTaxDeductedDollarSign.Location = new Point(141, 172);
            labelTaxDeductedDollarSign.Name = "labelTaxDeductedDollarSign";
            labelTaxDeductedDollarSign.Size = new Size(13, 15);
            labelTaxDeductedDollarSign.TabIndex = 6;
            labelTaxDeductedDollarSign.Text = "$";
            // 
            // labelGrossIncomeDollarSign
            // 
            labelGrossIncomeDollarSign.AutoSize = true;
            labelGrossIncomeDollarSign.Location = new Point(141, 25);
            labelGrossIncomeDollarSign.Name = "labelGrossIncomeDollarSign";
            labelGrossIncomeDollarSign.Size = new Size(13, 15);
            labelGrossIncomeDollarSign.TabIndex = 6;
            labelGrossIncomeDollarSign.Text = "$";
            // 
            // labelEIPremiumsDollarSign
            // 
            labelEIPremiumsDollarSign.AutoSize = true;
            labelEIPremiumsDollarSign.Location = new Point(141, 109);
            labelEIPremiumsDollarSign.Name = "labelEIPremiumsDollarSign";
            labelEIPremiumsDollarSign.Size = new Size(13, 15);
            labelEIPremiumsDollarSign.TabIndex = 6;
            labelEIPremiumsDollarSign.Text = "$";
            // 
            // labelCPPContributionsDollarSign
            // 
            labelCPPContributionsDollarSign.AutoSize = true;
            labelCPPContributionsDollarSign.Location = new Point(141, 80);
            labelCPPContributionsDollarSign.Name = "labelCPPContributionsDollarSign";
            labelCPPContributionsDollarSign.Size = new Size(13, 15);
            labelCPPContributionsDollarSign.TabIndex = 6;
            labelCPPContributionsDollarSign.Text = "$";
            // 
            // labelTaxDeducted
            // 
            labelTaxDeducted.AutoSize = true;
            labelTaxDeducted.Location = new Point(17, 172);
            labelTaxDeducted.Name = "labelTaxDeducted";
            labelTaxDeducted.Size = new Size(78, 15);
            labelTaxDeducted.TabIndex = 5;
            labelTaxDeducted.Text = "Tax Deducted";
            // 
            // labelEIPaid
            // 
            labelEIPaid.AutoSize = true;
            labelEIPaid.Location = new Point(17, 109);
            labelEIPaid.Name = "labelEIPaid";
            labelEIPaid.Size = new Size(73, 15);
            labelEIPaid.TabIndex = 5;
            labelEIPaid.Text = "EI Premiums";
            // 
            // labelCPPPaid
            // 
            labelCPPPaid.AutoSize = true;
            labelCPPPaid.Location = new Point(17, 80);
            labelCPPPaid.Name = "labelCPPPaid";
            labelCPPPaid.Size = new Size(105, 15);
            labelCPPPaid.TabIndex = 5;
            labelCPPPaid.Text = "CPP Contributions";
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
            // textboxFederalTax
            // 
            textboxFederalTax.Location = new Point(162, 16);
            textboxFederalTax.Name = "textboxFederalTax";
            textboxFederalTax.ReadOnly = true;
            textboxFederalTax.Size = new Size(100, 23);
            textboxFederalTax.TabIndex = 6;
            // 
            // labelFederalTaxDollarSign
            // 
            labelFederalTaxDollarSign.AutoSize = true;
            labelFederalTaxDollarSign.Location = new Point(144, 21);
            labelFederalTaxDollarSign.Name = "labelFederalTaxDollarSign";
            labelFederalTaxDollarSign.Size = new Size(13, 15);
            labelFederalTaxDollarSign.TabIndex = 6;
            labelFederalTaxDollarSign.Text = "$";
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
            buttonCalculate.Location = new Point(178, 379);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(100, 23);
            buttonCalculate.TabIndex = 5;
            buttonCalculate.Text = "Calculate";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // InputBox
            // 
            InputBox.Controls.Add(buttonCalculate);
            InputBox.Location = new Point(13, 3);
            InputBox.Name = "InputBox";
            InputBox.Size = new Size(406, 415);
            InputBox.TabIndex = 9;
            InputBox.TabStop = false;
            // 
            // dataGridViewFederalTaxRates
            // 
            dataGridViewFederalTaxRates.AllowUserToAddRows = false;
            dataGridViewFederalTaxRates.AllowUserToDeleteRows = false;
            dataGridViewFederalTaxRates.AllowUserToResizeColumns = false;
            dataGridViewFederalTaxRates.AllowUserToResizeRows = false;
            dataGridViewFederalTaxRates.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFederalTaxRates.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewFederalTaxRates.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewFederalTaxRates.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFederalTaxRates.Location = new Point(18, 22);
            dataGridViewFederalTaxRates.Name = "dataGridViewFederalTaxRates";
            dataGridViewFederalTaxRates.ReadOnly = true;
            dataGridViewFederalTaxRates.RowHeadersVisible = false;
            dataGridViewFederalTaxRates.Size = new Size(277, 172);
            dataGridViewFederalTaxRates.TabIndex = 9;
            // 
            // dataGridViewProvincialTaxRates
            // 
            dataGridViewProvincialTaxRates.AllowUserToAddRows = false;
            dataGridViewProvincialTaxRates.AllowUserToDeleteRows = false;
            dataGridViewProvincialTaxRates.AllowUserToResizeColumns = false;
            dataGridViewProvincialTaxRates.AllowUserToResizeRows = false;
            dataGridViewProvincialTaxRates.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProvincialTaxRates.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewProvincialTaxRates.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewProvincialTaxRates.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProvincialTaxRates.Location = new Point(321, 22);
            dataGridViewProvincialTaxRates.Name = "dataGridViewProvincialTaxRates";
            dataGridViewProvincialTaxRates.ReadOnly = true;
            dataGridViewProvincialTaxRates.RowHeadersVisible = false;
            dataGridViewProvincialTaxRates.Size = new Size(277, 172);
            dataGridViewProvincialTaxRates.TabIndex = 10;
            // 
            // TaxRatesGroupBox
            // 
            TaxRatesGroupBox.Controls.Add(dataGridViewProvincialTaxRates);
            TaxRatesGroupBox.Controls.Add(dataGridViewFederalTaxRates);
            TaxRatesGroupBox.Location = new Point(449, 3);
            TaxRatesGroupBox.Name = "TaxRatesGroupBox";
            TaxRatesGroupBox.Size = new Size(611, 210);
            TaxRatesGroupBox.TabIndex = 11;
            TaxRatesGroupBox.TabStop = false;
            // 
            // OutputGroupBox
            // 
            OutputGroupBox.Controls.Add(labelProvincialMarginalTaxRatePercentSign);
            OutputGroupBox.Controls.Add(labelProvincialMarginalTaxRate);
            OutputGroupBox.Controls.Add(textBoxProvincialMarginalTaxRate);
            OutputGroupBox.Controls.Add(labelEffectiveTaxRatePercentSign);
            OutputGroupBox.Controls.Add(labelFederalMarginalTaxRatePercentSign);
            OutputGroupBox.Controls.Add(labelTotalIncomeTax);
            OutputGroupBox.Controls.Add(textboxTotalIncomeTax);
            OutputGroupBox.Controls.Add(labelTotalIncomeTaxDollarSign);
            OutputGroupBox.Controls.Add(labelProvincialTax);
            OutputGroupBox.Controls.Add(textboxProvincialTax);
            OutputGroupBox.Controls.Add(labelProvincialTaxDollarSign);
            OutputGroupBox.Controls.Add(labelEffectiveTaxRate);
            OutputGroupBox.Controls.Add(labelTaxOwing);
            OutputGroupBox.Controls.Add(labelFederalMarginalTaxRate);
            OutputGroupBox.Controls.Add(labelTotalFederalTax);
            OutputGroupBox.Controls.Add(textboxEffectiveTaxRate);
            OutputGroupBox.Controls.Add(textboxTaxOwing);
            OutputGroupBox.Controls.Add(textboxFederalMarginalTaxRate);
            OutputGroupBox.Controls.Add(labelTaxOwingDollarSign);
            OutputGroupBox.Controls.Add(textboxFederalTax);
            OutputGroupBox.Controls.Add(labelFederalTaxDollarSign);
            OutputGroupBox.Location = new Point(449, 236);
            OutputGroupBox.Name = "OutputGroupBox";
            OutputGroupBox.Size = new Size(611, 182);
            OutputGroupBox.TabIndex = 12;
            OutputGroupBox.TabStop = false;
            // 
            // labelProvincialMarginalTaxRatePercentSign
            // 
            labelProvincialMarginalTaxRatePercentSign.AutoSize = true;
            labelProvincialMarginalTaxRatePercentSign.Location = new Point(492, 61);
            labelProvincialMarginalTaxRatePercentSign.Name = "labelProvincialMarginalTaxRatePercentSign";
            labelProvincialMarginalTaxRatePercentSign.Size = new Size(17, 15);
            labelProvincialMarginalTaxRatePercentSign.TabIndex = 18;
            labelProvincialMarginalTaxRatePercentSign.Text = "%";
            // 
            // labelProvincialMarginalTaxRate
            // 
            labelProvincialMarginalTaxRate.AutoSize = true;
            labelProvincialMarginalTaxRate.Location = new Point(321, 61);
            labelProvincialMarginalTaxRate.Name = "labelProvincialMarginalTaxRate";
            labelProvincialMarginalTaxRate.Size = new Size(155, 15);
            labelProvincialMarginalTaxRate.TabIndex = 17;
            labelProvincialMarginalTaxRate.Text = "Provincial Marginal Tax Rate";
            // 
            // textBoxProvincialMarginalTaxRate
            // 
            textBoxProvincialMarginalTaxRate.Location = new Point(511, 56);
            textBoxProvincialMarginalTaxRate.Name = "textBoxProvincialMarginalTaxRate";
            textBoxProvincialMarginalTaxRate.ReadOnly = true;
            textBoxProvincialMarginalTaxRate.Size = new Size(74, 23);
            textBoxProvincialMarginalTaxRate.TabIndex = 11;
            // 
            // labelEffectiveTaxRatePercentSign
            // 
            labelEffectiveTaxRatePercentSign.AutoSize = true;
            labelEffectiveTaxRatePercentSign.Location = new Point(492, 111);
            labelEffectiveTaxRatePercentSign.Name = "labelEffectiveTaxRatePercentSign";
            labelEffectiveTaxRatePercentSign.Size = new Size(17, 15);
            labelEffectiveTaxRatePercentSign.TabIndex = 15;
            labelEffectiveTaxRatePercentSign.Text = "%";
            // 
            // labelFederalMarginalTaxRatePercentSign
            // 
            labelFederalMarginalTaxRatePercentSign.AutoSize = true;
            labelFederalMarginalTaxRatePercentSign.Location = new Point(492, 21);
            labelFederalMarginalTaxRatePercentSign.Name = "labelFederalMarginalTaxRatePercentSign";
            labelFederalMarginalTaxRatePercentSign.Size = new Size(17, 15);
            labelFederalMarginalTaxRatePercentSign.TabIndex = 14;
            labelFederalMarginalTaxRatePercentSign.Text = "%";
            // 
            // labelTotalIncomeTax
            // 
            labelTotalIncomeTax.AutoSize = true;
            labelTotalIncomeTax.Location = new Point(18, 111);
            labelTotalIncomeTax.Name = "labelTotalIncomeTax";
            labelTotalIncomeTax.Size = new Size(96, 15);
            labelTotalIncomeTax.TabIndex = 13;
            labelTotalIncomeTax.Text = "Total Income Tax";
            // 
            // textboxTotalIncomeTax
            // 
            textboxTotalIncomeTax.Location = new Point(162, 106);
            textboxTotalIncomeTax.Name = "textboxTotalIncomeTax";
            textboxTotalIncomeTax.ReadOnly = true;
            textboxTotalIncomeTax.Size = new Size(100, 23);
            textboxTotalIncomeTax.TabIndex = 8;
            // 
            // labelTotalIncomeTaxDollarSign
            // 
            labelTotalIncomeTaxDollarSign.AutoSize = true;
            labelTotalIncomeTaxDollarSign.Location = new Point(144, 111);
            labelTotalIncomeTaxDollarSign.Name = "labelTotalIncomeTaxDollarSign";
            labelTotalIncomeTaxDollarSign.Size = new Size(13, 15);
            labelTotalIncomeTaxDollarSign.TabIndex = 12;
            labelTotalIncomeTaxDollarSign.Text = "$";
            // 
            // labelProvincialTax
            // 
            labelProvincialTax.AutoSize = true;
            labelProvincialTax.Location = new Point(18, 61);
            labelProvincialTax.Name = "labelProvincialTax";
            labelProvincialTax.Size = new Size(79, 15);
            labelProvincialTax.TabIndex = 10;
            labelProvincialTax.Text = "Provincial Tax";
            // 
            // textboxProvincialTax
            // 
            textboxProvincialTax.Location = new Point(162, 56);
            textboxProvincialTax.Name = "textboxProvincialTax";
            textboxProvincialTax.ReadOnly = true;
            textboxProvincialTax.Size = new Size(100, 23);
            textboxProvincialTax.TabIndex = 7;
            // 
            // labelProvincialTaxDollarSign
            // 
            labelProvincialTaxDollarSign.AutoSize = true;
            labelProvincialTaxDollarSign.Location = new Point(144, 61);
            labelProvincialTaxDollarSign.Name = "labelProvincialTaxDollarSign";
            labelProvincialTaxDollarSign.Size = new Size(13, 15);
            labelProvincialTaxDollarSign.TabIndex = 9;
            labelProvincialTaxDollarSign.Text = "$";
            // 
            // labelEffectiveTaxRate
            // 
            labelEffectiveTaxRate.AutoSize = true;
            labelEffectiveTaxRate.Location = new Point(321, 111);
            labelEffectiveTaxRate.Name = "labelEffectiveTaxRate";
            labelEffectiveTaxRate.Size = new Size(98, 15);
            labelEffectiveTaxRate.TabIndex = 7;
            labelEffectiveTaxRate.Text = "Effective Tax Rate";
            // 
            // labelTaxOwing
            // 
            labelTaxOwing.AutoSize = true;
            labelTaxOwing.Location = new Point(18, 151);
            labelTaxOwing.Name = "labelTaxOwing";
            labelTaxOwing.Size = new Size(62, 15);
            labelTaxOwing.TabIndex = 7;
            labelTaxOwing.Text = "Tax Owing";
            // 
            // labelFederalMarginalTaxRate
            // 
            labelFederalMarginalTaxRate.AutoSize = true;
            labelFederalMarginalTaxRate.Location = new Point(321, 21);
            labelFederalMarginalTaxRate.Name = "labelFederalMarginalTaxRate";
            labelFederalMarginalTaxRate.Size = new Size(141, 15);
            labelFederalMarginalTaxRate.TabIndex = 7;
            labelFederalMarginalTaxRate.Text = "Federal Marginal Tax Rate";
            // 
            // labelTotalFederalTax
            // 
            labelTotalFederalTax.AutoSize = true;
            labelTotalFederalTax.Location = new Point(18, 21);
            labelTotalFederalTax.Name = "labelTotalFederalTax";
            labelTotalFederalTax.Size = new Size(65, 15);
            labelTotalFederalTax.TabIndex = 7;
            labelTotalFederalTax.Text = "Federal Tax";
            // 
            // textboxEffectiveTaxRate
            // 
            textboxEffectiveTaxRate.Location = new Point(511, 106);
            textboxEffectiveTaxRate.Name = "textboxEffectiveTaxRate";
            textboxEffectiveTaxRate.ReadOnly = true;
            textboxEffectiveTaxRate.Size = new Size(74, 23);
            textboxEffectiveTaxRate.TabIndex = 12;
            // 
            // textboxTaxOwing
            // 
            textboxTaxOwing.Location = new Point(162, 146);
            textboxTaxOwing.Name = "textboxTaxOwing";
            textboxTaxOwing.ReadOnly = true;
            textboxTaxOwing.Size = new Size(100, 23);
            textboxTaxOwing.TabIndex = 9;
            // 
            // textboxFederalMarginalTaxRate
            // 
            textboxFederalMarginalTaxRate.Location = new Point(511, 16);
            textboxFederalMarginalTaxRate.Name = "textboxFederalMarginalTaxRate";
            textboxFederalMarginalTaxRate.ReadOnly = true;
            textboxFederalMarginalTaxRate.Size = new Size(74, 23);
            textboxFederalMarginalTaxRate.TabIndex = 10;
            // 
            // labelTaxOwingDollarSign
            // 
            labelTaxOwingDollarSign.AutoSize = true;
            labelTaxOwingDollarSign.Location = new Point(144, 151);
            labelTaxOwingDollarSign.Name = "labelTaxOwingDollarSign";
            labelTaxOwingDollarSign.Size = new Size(13, 15);
            labelTaxOwingDollarSign.TabIndex = 6;
            labelTaxOwingDollarSign.Text = "$";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 451);
            Controls.Add(OutputGroupBox);
            Controls.Add(TaxRatesGroupBox);
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
            InputBox.ResumeLayout(false);
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
        private TextBox textboxFederalTax;
        private Label labelGrossIncome;
        private Label labelFederalTaxDollarSign;
        private GroupBox IncomeInformationBox;
        private TextBox textboxEIPremiums;
        private TextBox textboxCPP;
        private Label labelEIPremiumsDollarSign;
        private Label labelCPPContributionsDollarSign;
        private TextBox textboxTaxDeducted;
        private Label labelTaxDeductedDollarSign;
        private Button buttonCalculate;
        private GroupBox InputBox;
        private DataGridView dataGridViewFederalTaxRates;
        private DataGridView dataGridViewProvincialTaxRates;
        private GroupBox TaxRatesGroupBox;
        private GroupBox OutputGroupBox;
        private Label labelTaxOwing;
        private Label labelTotalFederalTax;
        private TextBox textboxTaxOwing;
        private Label labelTaxOwingDollarSign;
        private Label labelEffectiveTaxRate;
        private Label labelFederalMarginalTaxRate;
        private TextBox textboxEffectiveTaxRate;
        private TextBox textboxFederalMarginalTaxRate;
        private TextBox textboxGrossIncome;
        private Label labelGrossIncomeDollarSign;
        private Label labelTotalIncomeTax;
        private TextBox textboxTotalIncomeTax;
        private Label labelTotalIncomeTaxDollarSign;
        private Label labelProvincialTax;
        private TextBox textboxProvincialTax;
        private Label labelProvincialTaxDollarSign;
        private Label labelEffectiveTaxRatePercentSign;
        private Label labelFederalMarginalTaxRatePercentSign;
        private Label labelProvincialMarginalTaxRatePercentSign;
        private Label labelProvincialMarginalTaxRate;
        private TextBox textBoxProvincialMarginalTaxRate;
    }
}
