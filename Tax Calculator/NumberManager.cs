using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax_Calculator
{
    internal class NumberManager
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

            //decimal.TryParse(textbox.Text, out decimal value);

            //textbox.Text = value.ToString("#,###.00");

        }

        public static string OutputAsDollarValue(decimal Number)
        {
            return Math.Round(Number, 2, MidpointRounding.ToPositiveInfinity).ToString("#,##0.00"); 
        }

        public static string OutputAsPercentage(decimal Number)
        {
            return Math.Round(100 * Number, 2, MidpointRounding.ToPositiveInfinity).ToString("0.00");
        }
    }
}
