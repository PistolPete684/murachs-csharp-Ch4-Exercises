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
            decimal subtotal = Decimal.Parse(txtEnterSubtotal.Text);
            decimal discountPct = .25m;
            decimal discountAmt = Math.Round(subtotal * discountPct, 2);
            decimal invoiceTotal = Math.Round(subtotal - discountAmt);

            txtSubtotal.Text = subtotal.ToString("c");
            txtDiscountPct.Text = discountPct.ToString("p1");
            txtDiscountAmt.Text = discountAmt.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");

            numberOfInvoices++;
            totalInvoices += invoiceTotal;
            //totalInvoices = totalInvoices + invoiceTotal;
            avgOfInvoices = totalInvoices / numberOfInvoices;

            txtNumberOfInvoices.Text = numberOfInvoices.ToString();
            txtTotalOfInvoices.Text = totalInvoices.ToString("c");
            txtAverageOfInvoices.Text = avgOfInvoices.ToString("c");

            txtEnterSubtotal.Text = "";
            txtEnterSubtotal.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSubtotal.Text = "";
            txtDiscountPct.Text = "";
            txtDiscountAmt.Text = "";
            txtTotal.Text = "";
            txtNumberOfInvoices.Text = "";
            txtTotalOfInvoices.Text = "";
            txtAverageOfInvoices.Text = "";

            txtEnterSubtotal.Focus();

        }
    }
}