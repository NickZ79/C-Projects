using System;
using System.Windows.Forms;

namespace Bakery_Shop_Project
{
    public partial class frmBakeryOrder : Form
    {
        // Named constants
        private const decimal MichiganSalesTaxRate = 0.06m;
        private const decimal BreadPrice = 3.50m;
        private const decimal PastryPrice = 2.00m;
        private const decimal CakePrice = 10.00m;

        public frmBakeryOrder()
        {
            InitializeComponent();
        }

        private void frmBakeryOrder_Load(object sender, EventArgs e)
        {
            // Default order date
            txtDate.Text = DateTime.Today.ToShortDateString();

            // Show prices in the items group
            lblBreadPrice.Text = BreadPrice.ToString("C");
            lblPastryPrice.Text = PastryPrice.ToString("C");
            lblCakePrice.Text   = CakePrice.ToString("C");
        }

        private void bttnCalc_Click(object sender, EventArgs e)
        {
            // Parse quantities (treat blank/invalid as 0)
            if (!decimal.TryParse(txtqtybread.Text.Trim(), out decimal qtyBread))
                qtyBread = 0m;
            if (!decimal.TryParse(txtqtypastry.Text.Trim(), out decimal qtyPastry))
                qtyPastry = 0m;
            if (!decimal.TryParse(txtqtycake.Text.Trim(), out decimal qtyCake))
                qtyCake = 0m;

            // Optional discount rate (%)
            decimal discountRate = 0m;
            if (!string.IsNullOrWhiteSpace(txtRate.Text))
            {
                if (!decimal.TryParse(txtRate.Text.Trim(), out discountRate))
                {
                    MessageBox.Show("Please enter a valid discount rate (e.g. 5 for 5%).",
                        "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRate.Focus();
                    return;
                }
            }

            // Subtotal
            decimal subtotal = (qtyBread * BreadPrice) +
                               (qtyPastry * PastryPrice) +
                               (qtyCake * CakePrice);

            // Discount amount
            decimal discountAmount = subtotal * (discountRate / 100m);
            if (discountAmount > subtotal) discountAmount = subtotal; // safety

            // Tax on (subtotal - discount)
            decimal taxableAmount = subtotal - discountAmount;
            if (taxableAmount < 0) taxableAmount = 0;
            decimal taxAmount = taxableAmount * MichiganSalesTaxRate;

            // Final total
            decimal finalTotal = taxableAmount + taxAmount;

            // Display results
            lblSubValue.Text       = subtotal.ToString("C");
            lblDiscountValue.Text  = discountAmount.ToString("C");
            lblTaxValue.Text       = taxAmount.ToString("C");
            lblTotalValue.Text     = finalTotal.ToString("C");
        }

        private void bttnClear_Click(object sender, EventArgs e)
        {
            // Clear header fields
            txtCust.Clear();
            txtCash.Clear();
            txtDate.Text = DateTime.Today.ToShortDateString();
            txtRate.Clear();

            // Clear quantities
            txtqtybread.Clear();
            txtqtypastry.Clear();
            txtqtycake.Clear();

            // Clear totals
            lblSubValue.Text      = string.Empty;
            lblDiscountValue.Text = string.Empty;
            lblTaxValue.Text      = string.Empty;
            lblTotalValue.Text    = string.Empty;

            txtCust.Focus();
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
