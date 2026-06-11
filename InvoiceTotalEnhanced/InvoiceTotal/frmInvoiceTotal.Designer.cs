namespace InvoiceTotal
{
    partial class frmInvoiceTotal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtSubtotal = new TextBox();
            label2 = new Label();
            txtDiscountPct = new TextBox();
            label3 = new Label();
            txtDiscountAmt = new TextBox();
            label4 = new Label();
            txtTotal = new TextBox();
            btnCalculate = new Button();
            btnExit = new Button();
            lblNumberOfInvoices = new Label();
            lblTotalOfInvoices = new Label();
            lblAverageOfInvoices = new Label();
            txtNumberOfInvoices = new TextBox();
            txtTotalOfInvoices = new TextBox();
            txtAverageOfInvoices = new TextBox();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 24);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "&Subtotal:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(150, 20);
            txtSubtotal.Margin = new Padding(3, 4, 3, 4);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(114, 27);
            txtSubtotal.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 63);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 2;
            label2.Text = "Discount Percent:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDiscountPct
            // 
            txtDiscountPct.Location = new Point(150, 59);
            txtDiscountPct.Margin = new Padding(3, 4, 3, 4);
            txtDiscountPct.Name = "txtDiscountPct";
            txtDiscountPct.ReadOnly = true;
            txtDiscountPct.Size = new Size(114, 27);
            txtDiscountPct.TabIndex = 3;
            txtDiscountPct.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 101);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 4;
            label3.Text = "Discount Amount:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDiscountAmt
            // 
            txtDiscountAmt.Location = new Point(150, 97);
            txtDiscountAmt.Margin = new Padding(3, 4, 3, 4);
            txtDiscountAmt.Name = "txtDiscountAmt";
            txtDiscountAmt.ReadOnly = true;
            txtDiscountAmt.Size = new Size(114, 27);
            txtDiscountAmt.TabIndex = 5;
            txtDiscountAmt.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 140);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 6;
            label4.Text = "Total:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(150, 136);
            txtTotal.Margin = new Padding(3, 4, 3, 4);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(114, 27);
            txtTotal.TabIndex = 7;
            txtTotal.TabStop = false;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(233, 196);
            btnCalculate.Margin = new Padding(3, 4, 3, 4);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(86, 31);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(496, 197);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(86, 31);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblNumberOfInvoices
            // 
            lblNumberOfInvoices.AutoSize = true;
            lblNumberOfInvoices.Location = new Point(406, 43);
            lblNumberOfInvoices.Name = "lblNumberOfInvoices";
            lblNumberOfInvoices.Size = new Size(141, 20);
            lblNumberOfInvoices.TabIndex = 8;
            lblNumberOfInvoices.Text = "Number of invoices:";
            // 
            // lblTotalOfInvoices
            // 
            lblTotalOfInvoices.AutoSize = true;
            lblTotalOfInvoices.Location = new Point(406, 86);
            lblTotalOfInvoices.Name = "lblTotalOfInvoices";
            lblTotalOfInvoices.Size = new Size(120, 20);
            lblTotalOfInvoices.TabIndex = 9;
            lblTotalOfInvoices.Text = "Total of invoices:";
            // 
            // lblAverageOfInvoices
            // 
            lblAverageOfInvoices.AutoSize = true;
            lblAverageOfInvoices.Location = new Point(406, 133);
            lblAverageOfInvoices.Name = "lblAverageOfInvoices";
            lblAverageOfInvoices.Size = new Size(134, 20);
            lblAverageOfInvoices.TabIndex = 10;
            lblAverageOfInvoices.Text = "Averge of invoices:";
            // 
            // txtNumberOfInvoices
            // 
            txtNumberOfInvoices.Location = new Point(580, 36);
            txtNumberOfInvoices.Name = "txtNumberOfInvoices";
            txtNumberOfInvoices.ReadOnly = true;
            txtNumberOfInvoices.Size = new Size(125, 27);
            txtNumberOfInvoices.TabIndex = 11;
            // 
            // txtTotalOfInvoices
            // 
            txtTotalOfInvoices.Location = new Point(580, 86);
            txtTotalOfInvoices.Name = "txtTotalOfInvoices";
            txtTotalOfInvoices.ReadOnly = true;
            txtTotalOfInvoices.Size = new Size(125, 27);
            txtTotalOfInvoices.TabIndex = 12;
            // 
            // txtAverageOfInvoices
            // 
            txtAverageOfInvoices.Location = new Point(580, 133);
            txtAverageOfInvoices.Name = "txtAverageOfInvoices";
            txtAverageOfInvoices.ReadOnly = true;
            txtAverageOfInvoices.Size = new Size(125, 27);
            txtAverageOfInvoices.TabIndex = 13;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(355, 198);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // frmInvoiceTotal
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(750, 241);
            Controls.Add(btnClear);
            Controls.Add(txtAverageOfInvoices);
            Controls.Add(txtTotalOfInvoices);
            Controls.Add(txtNumberOfInvoices);
            Controls.Add(lblAverageOfInvoices);
            Controls.Add(lblTotalOfInvoices);
            Controls.Add(lblNumberOfInvoices);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(txtTotal);
            Controls.Add(label4);
            Controls.Add(txtDiscountAmt);
            Controls.Add(label3);
            Controls.Add(txtDiscountPct);
            Controls.Add(label2);
            Controls.Add(txtSubtotal);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmInvoiceTotal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invoice Total";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtSubtotal;
        private Label label2;
        private TextBox txtDiscountPct;
        private Label label3;
        private TextBox txtDiscountAmt;
        private Label label4;
        private TextBox txtTotal;
        private Button btnCalculate;
        private Button btnExit;
        private Label lblNumberOfInvoices;
        private Label lblTotalOfInvoices;
        private Label lblAverageOfInvoices;
        private TextBox txtNumberOfInvoices;
        private TextBox txtTotalOfInvoices;
        private TextBox txtAverageOfInvoices;
        private Button btnClear;
    }
}