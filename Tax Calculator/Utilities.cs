using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax_Calculator
{   
    //Class to store general utility methods
    internal class Utilities
    {
        public static void ControlMoneyInputs(object sender, KeyPressEventArgs e)
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

        public static bool checkRequiredInputs(String Year, String Province, decimal GrossIncome, decimal CPPPaid, decimal EIPaid, decimal TaxPaid)
        {
            if (String.IsNullOrEmpty(Province) || String.IsNullOrEmpty(Year))
            {
                return false;
            }
            return !(GrossIncome < 0 || CPPPaid < 0|| EIPaid < 0 || TaxPaid < 0);
        }
    }
}
