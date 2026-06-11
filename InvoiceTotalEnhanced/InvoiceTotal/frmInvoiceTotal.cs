namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        int numberOfInvoices = 0;
        decimal totalInvoices = 0;
        decimal avgOfInvoices = 0;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal subtotal = Decimal.Parse(txtSubtotal.Text);
            decimal discountPct = .25m;
            decimal discountAmt = Math.Round(subtotal * discountPct, 2);
            decimal invoiceTotal = Math.Round(subtotal - discountAmt);

            txtDiscountPct.Text = discountPct.ToString("p1");
            txtDiscountAmt.Text = discountAmt.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");

            numberOfInvoices++;
            totalInvoices = totalInvoices + invoiceTotal;
            avgOfInvoices = totalInvoices / numberOfInvoices;

            txtNumberOfInvoices.Text = numberOfInvoices.ToString();
            txtTotalOfInvoices.Text = totalInvoices.ToString("c");
            txtAverageOfInvoices.Text = avgOfInvoices.ToString("c");

            txtSubtotal.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}