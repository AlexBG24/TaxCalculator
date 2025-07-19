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
        #region Select year and Province
        private void SelectTaxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxSelectTaxYear != null)
            {
                string Year = ComboBoxSelectTaxYear.SelectedItem.ToString();
            }
        }
        private void ComboBoxSelectProvince_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Gross Income Input Box
        private void GrossIncomeInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = sender as TextBox;

            // Allow control keys, numbers and period
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && textbox.Text.Contains("."))
            {
                e.Handled = true;
            }
            if (textbox.Text.Contains("."))
            {
                int index = textbox.Text.IndexOf('.');
                string afterDecimal = textbox.Text.Substring(index + 1);

                if (textbox.SelectionStart > index && afterDecimal.Length >= 2 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;   
                }
            }

        }

        private void GrossIncomeInput_TextChanged(object sender, EventArgs e)
        {
            string GrossIncome = TextBoxGrossIncome.Text;


        }
        #endregion


    }
}
