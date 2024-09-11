using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1b
{
    public partial class FormInvoicetotal : Form
    {
        public FormInvoicetotal()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            this.textBoxTotal.Text = this.textBoxSubtotal.Text;
        }

        private void FormInvoicetotal_Load(object sender, EventArgs e)
        {

        }
    }
}
