using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tax_Calculator
{
    public partial class WarningForm : Form
    {
        public WarningForm()
        {
            InitializeComponent();
            this.Text = "Warning";
        }

        private void WarningForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonOkay_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
