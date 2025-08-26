using System.CodeDom;

namespace Tax_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Tax Calculator";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region Data
        String Province = "";
        String Year = "";
        decimal GrossIncome = -1m;
        decimal CPPPaid = -1m;
        decimal EIPaid = -1m;
        decimal TaxDeducted = -1m;

        #endregion
        #region Select year and Province
        private void SelectTaxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxSelectTaxYear != null)
            {
                this.Year = ComboBoxSelectTaxYear.SelectedItem.ToString();
            }
        }
        private void ComboBoxSelectProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxSelectProvince != null)
            {
                this.Province = ComboBoxSelectProvince.SelectedItem.ToString();
            }
        }
        #endregion

        #region Gross Income Input Box
        private void MoneyInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberManager.ControlMoneyInputs(sender, e);
        }

        private void textBoxGrossIncome_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textboxGrossIncome.Text))
            {
                this.GrossIncome = decimal.Parse(textboxGrossIncome.Text);
            }
        }
        private void textBoxCPP_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textboxCPP.Text))
            {
                this.CPPPaid = decimal.Parse(textboxCPP.Text);
            }
        }
        private void textBoxEIPaid_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textboxEIPremiums.Text))
            {
                this.EIPaid = decimal.Parse(textboxEIPremiums.Text);
            }
        }
        private void textBoxTaxDeducted_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textboxTaxDeducted.Text))
            {
                this.TaxDeducted = decimal.Parse(textboxTaxDeducted.Text);
            }
        }
        #endregion

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            TaxPayer taxPayer;

            if (!(String.IsNullOrEmpty(Province) || String.IsNullOrEmpty(Year) || textboxGrossIncome.Text == "" || textboxCPP.Text == "" || textboxEIPremiums.Text == "" || textboxTaxDeducted.Text == ""))
            {
                taxPayer = new TaxPayer(Year, Province, GrossIncome, CPPPaid, EIPaid, TaxDeducted);

                taxPayer.CalculateTax();

                textboxFederalTax.Text = NumberManager.OutputAsDollarValue(taxPayer.FederalIncomeTax);
                textboxProvincialTax.Text = NumberManager.OutputAsDollarValue(taxPayer.ProvincialIncomeTax);
                textboxTotalIncomeTax.Text = NumberManager.OutputAsDollarValue(taxPayer.TotalIncomeTax);
                textboxTaxOwing.Text = NumberManager.OutputAsDollarValue(taxPayer.TaxesOwed);
                textboxFederalMarginalTaxRate.Text = NumberManager.OutputAsPercentage(taxPayer.FederalMarginalTaxRate);
                textBoxProvincialMarginalTaxRate.Text = NumberManager.OutputAsPercentage(taxPayer.ProvincialMarginalTaxRate);
                textboxEffectiveTaxRate.Text = NumberManager.OutputAsPercentage(taxPayer.EffectiveTaxRate);

            }
            else
            {
                WarningForm warningForm = new WarningForm();
                warningForm.ShowDialog();
            }
        }
    }
}
