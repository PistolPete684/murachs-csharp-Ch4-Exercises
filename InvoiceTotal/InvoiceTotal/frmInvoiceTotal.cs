namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Changed Convert.ToDecimal() -> Decimal.Parse()
            decimal subtotal = Decimal.Parse(txtSubtotal.Text);
            //decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal discountPct = .25m;
            decimal discountAmt = Decimal.Round(subtotal * discountPct);
            decimal invoiceTotal = Decimal.Round(subtotal - discountAmt);

            txtDiscountPct.Text = discountPct.ToString("p1");
            txtDiscountAmt.Text = discountAmt.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");

            txtSubtotal.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}