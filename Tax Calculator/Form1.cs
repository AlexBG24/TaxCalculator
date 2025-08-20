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
            Utilities.ControlMoneyInputs(sender, e);
        }

        private void textBoxGrossIncome_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxGrossIncome.Text))
            {
                this.GrossIncome = decimal.Parse(textBoxGrossIncome.Text);
            }
        }
        private void textBoxCPP_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxCPP.Text))
            {
                this.CPPPaid = decimal.Parse(textBoxCPP.Text);
            }
        }
        private void textBoxEIPaid_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxEIPaid.Text))
            {
                this.EIPaid = decimal.Parse(textBoxEIPaid.Text);
            }
        }
        private void textBoxTaxDeducted_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxTaxDeducted.Text))
            {
                this.TaxDeducted = decimal.Parse(textBoxTaxDeducted.Text);
            }
        }
        #endregion

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            TaxPayer tp;

            if (Utilities.checkRequiredInputs(Year, Province, GrossIncome, CPPPaid, EIPaid, TaxDeducted))
            {
                tp = new TaxPayer(Year, Province, GrossIncome, CPPPaid, EIPaid, TaxDeducted);

                tp.CalculateTax();

                textboxIncomeTax.Text = tp.IncomeTax.ToString();
                textboxTaxOwed.Text = tp.TaxesOwed.ToString();
                textboxMarginalTaxRate.Text = tp.MarginalTaxRate.ToString();
                textBoxEffectiveTaxRate.Text = tp.EffectiveTaxRate.ToString();

            }
            else
            {
                WarningForm warningForm = new WarningForm();
                warningForm.ShowDialog();
            }

            


        }

    }
}
