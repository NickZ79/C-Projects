using System.Drawing;
using System.Windows.Forms;

namespace Bakery_Shop_Project
{
    partial class frmBakeryOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblCust = new System.Windows.Forms.Label();
            this.txtCust = new System.Windows.Forms.TextBox();
            this.lblCash = new System.Windows.Forms.Label();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblRateHint = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCakePrice = new System.Windows.Forms.Label();
            this.lblPastryPrice = new System.Windows.Forms.Label();
            this.lblBreadPrice = new System.Windows.Forms.Label();
            this.lblPriceHeader = new System.Windows.Forms.Label();
            this.lblQtyHeader = new System.Windows.Forms.Label();
            this.lblCake = new System.Windows.Forms.Label();
            this.txtqtycake = new System.Windows.Forms.TextBox();
            this.lblPastry = new System.Windows.Forms.Label();
            this.txtqtypastry = new System.Windows.Forms.TextBox();
            this.lblBread = new System.Windows.Forms.Label();
            this.txtqtybread = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTaxValue = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblDiscountValue = new System.Windows.Forms.Label();
            this.lblDisc = new System.Windows.Forms.Label();
            this.lblSubValue = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttnExit = new System.Windows.Forms.Button();
            this.bttnClear = new System.Windows.Forms.Button();
            this.bttnCalc = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCust
            // 
            this.lblCust.AutoSize = true;
            this.lblCust.Location = new System.Drawing.Point(15, 20);
            this.lblCust.Name = "lblCust";
            this.lblCust.Size = new System.Drawing.Size(102, 17);
            this.lblCust.TabIndex = 0;
            this.lblCust.Text = "Customer name:";
            // 
            // txtCust
            // 
            this.txtCust.Location = new System.Drawing.Point(150, 17);
            this.txtCust.Name = "txtCust";
            this.txtCust.Size = new System.Drawing.Size(430, 25);
            this.txtCust.TabIndex = 1;
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Location = new System.Drawing.Point(15, 55);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(93, 17);
            this.lblCash.TabIndex = 2;
            this.lblCash.Text = "Cashier name:";
            // 
            // txtCash
            // 
            this.txtCash.Location = new System.Drawing.Point(150, 52);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(430, 25);
            this.txtCash.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(15, 90);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(71, 17);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Order date:";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(150, 87);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 25);
            this.txtDate.TabIndex = 5;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(270, 90);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(106, 17);
            this.lblRate.TabIndex = 6;
            this.lblRate.Text = "Discount rate (%):";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(400, 87);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(60, 25);
            this.txtRate.TabIndex = 7;
            // 
            // lblRateHint
            // 
            this.lblRateHint.AutoSize = true;
            this.lblRateHint.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblRateHint.Location = new System.Drawing.Point(270, 115);
            this.lblRateHint.Name = "lblRateHint";
            this.lblRateHint.Size = new System.Drawing.Size(136, 15);
            this.lblRateHint.TabIndex = 8;
            this.lblRateHint.Text = "(e.g. 5% entered as 5)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCakePrice);
            this.groupBox2.Controls.Add(this.lblPastryPrice);
            this.groupBox2.Controls.Add(this.lblBreadPrice);
            this.groupBox2.Controls.Add(this.lblPriceHeader);
            this.groupBox2.Controls.Add(this.lblQtyHeader);
            this.groupBox2.Controls.Add(this.lblCake);
            this.groupBox2.Controls.Add(this.txtqtycake);
            this.groupBox2.Controls.Add(this.lblPastry);
            this.groupBox2.Controls.Add(this.txtqtypastry);
            this.groupBox2.Controls.Add(this.lblBread);
            this.groupBox2.Controls.Add(this.txtqtybread);
            this.groupBox2.Location = new System.Drawing.Point(15, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(565, 155);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Items";
            // 
            // lblCakePrice
            // 
            this.lblCakePrice.AutoSize = true;
            this.lblCakePrice.Location = new System.Drawing.Point(340, 115);
            this.lblCakePrice.Name = "lblCakePrice";
            this.lblCakePrice.Size = new System.Drawing.Size(41, 17);
            this.lblCakePrice.TabIndex = 10;
            this.lblCakePrice.Text = "$0.00";
            // 
            // lblPastryPrice
            // 
            this.lblPastryPrice.AutoSize = true;
            this.lblPastryPrice.Location = new System.Drawing.Point(340, 85);
            this.lblPastryPrice.Name = "lblPastryPrice";
            this.lblPastryPrice.Size = new System.Drawing.Size(41, 17);
            this.lblPastryPrice.TabIndex = 9;
            this.lblPastryPrice.Text = "$0.00";
            // 
            // lblBreadPrice
            // 
            this.lblBreadPrice.AutoSize = true;
            this.lblBreadPrice.Location = new System.Drawing.Point(340, 55);
            this.lblBreadPrice.Name = "lblBreadPrice";
            this.lblBreadPrice.Size = new System.Drawing.Size(41, 17);
            this.lblBreadPrice.TabIndex = 8;
            this.lblBreadPrice.Text = "$0.00";
            // 
            // lblPriceHeader
            // 
            this.lblPriceHeader.AutoSize = true;
            this.lblPriceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.lblPriceHeader.Location = new System.Drawing.Point(340, 25);
            this.lblPriceHeader.Name = "lblPriceHeader";
            this.lblPriceHeader.Size = new System.Drawing.Size(35, 15);
            this.lblPriceHeader.TabIndex = 7;
            this.lblPriceHeader.Text = "Price";
            // 
            // lblQtyHeader
            // 
            this.lblQtyHeader.AutoSize = true;
            this.lblQtyHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.lblQtyHeader.Location = new System.Drawing.Point(220, 25);
            this.lblQtyHeader.Name = "lblQtyHeader";
            this.lblQtyHeader.Size = new System.Drawing.Size(51, 15);
            this.lblQtyHeader.TabIndex = 6;
            this.lblQtyHeader.Text = "Quantity";
            // 
            // lblCake
            // 
            this.lblCake.AutoSize = true;
            this.lblCake.Location = new System.Drawing.Point(40, 115);
            this.lblCake.Name = "lblCake";
            this.lblCake.Size = new System.Drawing.Size(40, 17);
            this.lblCake.TabIndex = 4;
            this.lblCake.Text = "Cake:";
            // 
            // txtqtycake
            // 
            this.txtqtycake.Location = new System.Drawing.Point(220, 112);
            this.txtqtycake.Name = "txtqtycake";
            this.txtqtycake.Size = new System.Drawing.Size(70, 25);
            this.txtqtycake.TabIndex = 5;
            // 
            // lblPastry
            // 
            this.lblPastry.AutoSize = true;
            this.lblPastry.Location = new System.Drawing.Point(40, 85);
            this.lblPastry.Name = "lblPastry";
            this.lblPastry.Size = new System.Drawing.Size(48, 17);
            this.lblPastry.TabIndex = 2;
            this.lblPastry.Text = "Pastry:";
            // 
            // txtqtypastry
            // 
            this.txtqtypastry.Location = new System.Drawing.Point(220, 82);
            this.txtqtypastry.Name = "txtqtypastry";
            this.txtqtypastry.Size = new System.Drawing.Size(70, 25);
            this.txtqtypastry.TabIndex = 3;
            // 
            // lblBread
            // 
            this.lblBread.AutoSize = true;
            this.lblBread.Location = new System.Drawing.Point(40, 55);
            this.lblBread.Name = "lblBread";
            this.lblBread.Size = new System.Drawing.Size(44, 17);
            this.lblBread.TabIndex = 0;
            this.lblBread.Text = "Bread:";
            // 
            // txtqtybread
            // 
            this.txtqtybread.Location = new System.Drawing.Point(220, 52);
            this.txtqtybread.Name = "txtqtybread";
            this.txtqtybread.Size = new System.Drawing.Size(70, 25);
            this.txtqtybread.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTotalValue);
            this.groupBox3.Controls.Add(this.lblTotal);
            this.groupBox3.Controls.Add(this.lblTaxValue);
            this.groupBox3.Controls.Add(this.lblTax);
            this.groupBox3.Controls.Add(this.lblDiscountValue);
            this.groupBox3.Controls.Add(this.lblDisc);
            this.groupBox3.Controls.Add(this.lblSubValue);
            this.groupBox3.Controls.Add(this.lblSub);
            this.groupBox3.Location = new System.Drawing.Point(15, 305);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(565, 150);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order Totals";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalValue.Location = new System.Drawing.Point(220, 115);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(150, 25);
            this.lblTotalValue.TabIndex = 7;
            this.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(40, 118);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(77, 17);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Order total:";
            // 
            // lblTaxValue
            // 
            this.lblTaxValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTaxValue.Location = new System.Drawing.Point(220, 85);
            this.lblTaxValue.Name = "lblTaxValue";
            this.lblTaxValue.Size = new System.Drawing.Size(150, 25);
            this.lblTaxValue.TabIndex = 5;
            this.lblTaxValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(40, 88);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(63, 17);
            this.lblTax.TabIndex = 4;
            this.lblTax.Text = "Sales tax:";
            // 
            // lblDiscountValue
            // 
            this.lblDiscountValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDiscountValue.Location = new System.Drawing.Point(220, 55);
            this.lblDiscountValue.Name = "lblDiscountValue";
            this.lblDiscountValue.Size = new System.Drawing.Size(150, 25);
            this.lblDiscountValue.TabIndex = 3;
            this.lblDiscountValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDisc
            // 
            this.lblDisc.AutoSize = true;
            this.lblDisc.Location = new System.Drawing.Point(40, 58);
            this.lblDisc.Name = "lblDisc";
            this.lblDisc.Size = new System.Drawing.Size(61, 17);
            this.lblDisc.TabIndex = 2;
            this.lblDisc.Text = "Discount:";
            // 
            // lblSubValue
            // 
            this.lblSubValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubValue.Location = new System.Drawing.Point(220, 25);
            this.lblSubValue.Name = "lblSubValue";
            this.lblSubValue.Size = new System.Drawing.Size(150, 25);
            this.lblSubValue.TabIndex = 1;
            this.lblSubValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Location = new System.Drawing.Point(40, 28);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(60, 17);
            this.lblSub.TabIndex = 0;
            this.lblSub.Text = "Subtotal:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttnExit);
            this.groupBox1.Controls.Add(this.bttnClear);
            this.groupBox1.Controls.Add(this.bttnCalc);
            this.groupBox1.Location = new System.Drawing.Point(15, 465);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 60);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Commands";
            // 
            // bttnExit
            // 
            this.bttnExit.Location = new System.Drawing.Point(400, 22);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(120, 27);
            this.bttnExit.TabIndex = 2;
            this.bttnExit.Text = "Exit";
            this.bttnExit.UseVisualStyleBackColor = true;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // bttnClear
            // 
            this.bttnClear.Location = new System.Drawing.Point(220, 22);
            this.bttnClear.Name = "bttnClear";
            this.bttnClear.Size = new System.Drawing.Size(120, 27);
            this.bttnClear.TabIndex = 1;
            this.bttnClear.Text = "Clear";
            this.bttnClear.UseVisualStyleBackColor = true;
            this.bttnClear.Click += new System.EventHandler(this.bttnClear_Click);
            // 
            // bttnCalc
            // 
            this.bttnCalc.Location = new System.Drawing.Point(40, 22);
            this.bttnCalc.Name = "bttnCalc";
            this.bttnCalc.Size = new System.Drawing.Size(120, 27);
            this.bttnCalc.TabIndex = 0;
            this.bttnCalc.Text = "Calculate";
            this.bttnCalc.UseVisualStyleBackColor = true;
            this.bttnCalc.Click += new System.EventHandler(this.bttnCalc_Click);
            // 
            // frmBakeryOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 540);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblRateHint);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.txtCust);
            this.Controls.Add(this.lblCust);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "frmBakeryOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bakery Order";
            this.Load += new System.EventHandler(this.frmBakeryOrder_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label lblCust;
        private TextBox txtCust;
        private Label lblCash;
        private TextBox txtCash;
        private Label lblDate;
        private TextBox txtDate;
        private Label lblRate;
        private TextBox txtRate;
        private Label lblRateHint;
        private GroupBox groupBox2;
        private Label lblCakePrice;
        private Label lblPastryPrice;
        private Label lblBreadPrice;
        private Label lblPriceHeader;
        private Label lblQtyHeader;
        private Label lblCake;
        private TextBox txtqtycake;
        private Label lblPastry;
        private TextBox txtqtypastry;
        private Label lblBread;
        private TextBox txtqtybread;
        private GroupBox groupBox3;
        private Label lblTotalValue;
        private Label lblTotal;
        private Label lblTaxValue;
        private Label lblTax;
        private Label lblDiscountValue;
        private Label lblDisc;
        private Label lblSubValue;
        private Label lblSub;
        private GroupBox groupBox1;
        private Button bttnExit;
        private Button bttnClear;
        private Button bttnCalc;
    }
}
