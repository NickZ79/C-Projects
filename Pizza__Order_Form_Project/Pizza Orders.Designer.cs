namespace Pizza__Order_Form_Project
{
    partial class frmPizzaOrders
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
            lblCustInfo = new GroupBox();
            lblOrderType = new GroupBox();
            lblPhoneCaption = new Label();
            txtPhoneNumber = new TextBox();
            rdoDelivery = new RadioButton();
            rdoPickUp = new RadioButton();
            lblStreetCaption = new Label();
            txtStreetAddress = new TextBox();
            lblLast = new Label();
            txtLastName = new TextBox();
            lblFirst = new Label();
            txtFirstName = new TextBox();
            lblCrust = new Label();
            lstCrustStyles = new ListBox();
            lblToppings = new GroupBox();
            rdoNoCheese = new RadioButton();
            rdoMozzarella = new RadioButton();
            chkGreenPeppers = new CheckBox();
            chkMushrooms = new CheckBox();
            chkOnions = new CheckBox();
            chkSausage = new CheckBox();
            chkHam = new CheckBox();
            chkPepperoni = new CheckBox();
            lblPizzaInfo = new GroupBox();
            lstPizzaSize = new ListBox();
            lblSize = new Label();
            txtPizzaOrders = new TextBox();
            tolButtons = new ToolStrip();
            tolbtnSubmit = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tolbtnCancel = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tolbtnExit = new ToolStripButton();
            lblErrorMessage = new ToolStripLabel();
            stsOrderSummary = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblPizzaCount = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            lblPickupCount = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            lblDeliveryCount = new ToolStripStatusLabel();
            toolStripStatusLabel6 = new ToolStripStatusLabel();
            lblTotalPizzaSalesWithTax = new ToolStripStatusLabel();
            lblCustInfo.SuspendLayout();
            lblOrderType.SuspendLayout();
            lblToppings.SuspendLayout();
            lblPizzaInfo.SuspendLayout();
            tolButtons.SuspendLayout();
            stsOrderSummary.SuspendLayout();
            SuspendLayout();
            // 
            // lblCustInfo
            // 
            lblCustInfo.Controls.Add(lblOrderType);
            lblCustInfo.Controls.Add(lblLast);
            lblCustInfo.Controls.Add(txtLastName);
            lblCustInfo.Controls.Add(lblFirst);
            lblCustInfo.Controls.Add(txtFirstName);
            lblCustInfo.Location = new Point(20, 28);
            lblCustInfo.Name = "lblCustInfo";
            lblCustInfo.Size = new Size(339, 290);
            lblCustInfo.TabIndex = 0;
            lblCustInfo.TabStop = false;
            lblCustInfo.Text = "Customer";
            // 
            // lblOrderType
            // 
            lblOrderType.Controls.Add(lblPhoneCaption);
            lblOrderType.Controls.Add(txtPhoneNumber);
            lblOrderType.Controls.Add(rdoDelivery);
            lblOrderType.Controls.Add(rdoPickUp);
            lblOrderType.Controls.Add(lblStreetCaption);
            lblOrderType.Controls.Add(txtStreetAddress);
            lblOrderType.Location = new Point(6, 112);
            lblOrderType.Name = "lblOrderType";
            lblOrderType.Size = new Size(327, 170);
            lblOrderType.TabIndex = 4;
            lblOrderType.TabStop = false;
            lblOrderType.Text = "Order Type";
            // 
            // lblPhoneCaption
            // 
            lblPhoneCaption.AutoSize = true;
            lblPhoneCaption.Location = new Point(0, 124);
            lblPhoneCaption.Name = "lblPhoneCaption";
            lblPhoneCaption.Size = new Size(82, 21);
            lblPhoneCaption.TabIndex = 4;
            lblPhoneCaption.Text = "&Phone no.:";
            lblPhoneCaption.Visible = false;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(87, 121);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(226, 29);
            txtPhoneNumber.TabIndex = 5;
            txtPhoneNumber.Visible = false;
            // 
            // rdoDelivery
            // 
            rdoDelivery.AutoSize = true;
            rdoDelivery.Location = new Point(214, 28);
            rdoDelivery.Name = "rdoDelivery";
            rdoDelivery.Size = new Size(85, 25);
            rdoDelivery.TabIndex = 1;
            rdoDelivery.Text = "&Delivery";
            rdoDelivery.UseVisualStyleBackColor = true;
            // 
            // rdoPickUp
            // 
            rdoPickUp.AutoSize = true;
            rdoPickUp.Location = new Point(117, 27);
            rdoPickUp.Name = "rdoPickUp";
            rdoPickUp.Size = new Size(80, 25);
            rdoPickUp.TabIndex = 0;
            rdoPickUp.Text = "Pick-&up";
            rdoPickUp.UseVisualStyleBackColor = true;
            // 
            // lblStreetCaption
            // 
            lblStreetCaption.AutoSize = true;
            lblStreetCaption.Location = new Point(6, 76);
            lblStreetCaption.Name = "lblStreetCaption";
            lblStreetCaption.Size = new Size(53, 21);
            lblStreetCaption.TabIndex = 2;
            lblStreetCaption.Text = "&Street:";
            lblStreetCaption.Visible = false;
            // 
            // txtStreetAddress
            // 
            txtStreetAddress.Location = new Point(87, 73);
            txtStreetAddress.Name = "txtStreetAddress";
            txtStreetAddress.Size = new Size(224, 29);
            txtStreetAddress.TabIndex = 3;
            txtStreetAddress.Visible = false;
            // 
            // lblLast
            // 
            lblLast.AutoSize = true;
            lblLast.Location = new Point(11, 71);
            lblLast.Name = "lblLast";
            lblLast.Size = new Size(84, 21);
            lblLast.TabIndex = 2;
            lblLast.Text = "&Last name:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(130, 62);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(191, 29);
            txtLastName.TabIndex = 3;
            // 
            // lblFirst
            // 
            lblFirst.AutoSize = true;
            lblFirst.Location = new Point(11, 31);
            lblFirst.Name = "lblFirst";
            lblFirst.Size = new Size(86, 21);
            lblFirst.TabIndex = 0;
            lblFirst.Text = "&First name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(130, 27);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(191, 29);
            txtFirstName.TabIndex = 1;
            // 
            // lblCrust
            // 
            lblCrust.AutoSize = true;
            lblCrust.Location = new Point(6, 24);
            lblCrust.Name = "lblCrust";
            lblCrust.Size = new Size(94, 21);
            lblCrust.TabIndex = 0;
            lblCrust.Text = "&Crust Styles:";
            // 
            // lstCrustStyles
            // 
            lstCrustStyles.FormattingEnabled = true;
            lstCrustStyles.ItemHeight = 21;
            lstCrustStyles.Location = new Point(106, 28);
            lstCrustStyles.Name = "lstCrustStyles";
            lstCrustStyles.Size = new Size(242, 109);
            lstCrustStyles.TabIndex = 1;
            // 
            // lblToppings
            // 
            lblToppings.Controls.Add(rdoNoCheese);
            lblToppings.Controls.Add(rdoMozzarella);
            lblToppings.Controls.Add(chkGreenPeppers);
            lblToppings.Controls.Add(chkMushrooms);
            lblToppings.Controls.Add(chkOnions);
            lblToppings.Controls.Add(chkSausage);
            lblToppings.Controls.Add(chkHam);
            lblToppings.Controls.Add(chkPepperoni);
            lblToppings.Location = new Point(725, 28);
            lblToppings.Name = "lblToppings";
            lblToppings.Size = new Size(217, 293);
            lblToppings.TabIndex = 2;
            lblToppings.TabStop = false;
            lblToppings.Text = "Toppings";
            // 
            // rdoNoCheese
            // 
            rdoNoCheese.AutoSize = true;
            rdoNoCheese.Location = new Point(19, 55);
            rdoNoCheese.Name = "rdoNoCheese";
            rdoNoCheese.Size = new Size(100, 25);
            rdoNoCheese.TabIndex = 1;
            rdoNoCheese.Text = "N&o cheese";
            rdoNoCheese.UseVisualStyleBackColor = true;
            // 
            // rdoMozzarella
            // 
            rdoMozzarella.AutoSize = true;
            rdoMozzarella.Location = new Point(19, 24);
            rdoMozzarella.Name = "rdoMozzarella";
            rdoMozzarella.Size = new Size(189, 25);
            rdoMozzarella.TabIndex = 0;
            rdoMozzarella.Text = "Mo&zzarella cheese (.50)";
            rdoMozzarella.UseVisualStyleBackColor = true;
            // 
            // chkGreenPeppers
            // 
            chkGreenPeppers.AutoSize = true;
            chkGreenPeppers.Location = new Point(19, 258);
            chkGreenPeppers.Name = "chkGreenPeppers";
            chkGreenPeppers.Size = new Size(165, 25);
            chkGreenPeppers.TabIndex = 7;
            chkGreenPeppers.Text = "&Green Peppers (.60)";
            chkGreenPeppers.UseVisualStyleBackColor = true;
            // 
            // chkMushrooms
            // 
            chkMushrooms.AutoSize = true;
            chkMushrooms.Location = new Point(19, 227);
            chkMushrooms.Name = "chkMushrooms";
            chkMushrooms.Size = new Size(148, 25);
            chkMushrooms.TabIndex = 6;
            chkMushrooms.Text = "&Mushrooms (.65)";
            chkMushrooms.UseVisualStyleBackColor = true;
            // 
            // chkOnions
            // 
            chkOnions.AutoSize = true;
            chkOnions.Location = new Point(19, 196);
            chkOnions.Name = "chkOnions";
            chkOnions.Size = new Size(114, 25);
            chkOnions.TabIndex = 5;
            chkOnions.Text = "&Onions (.65)";
            chkOnions.UseVisualStyleBackColor = true;
            // 
            // chkSausage
            // 
            chkSausage.AutoSize = true;
            chkSausage.Location = new Point(19, 163);
            chkSausage.Name = "chkSausage";
            chkSausage.Size = new Size(122, 25);
            chkSausage.TabIndex = 4;
            chkSausage.Text = "Sa&usage (.80)";
            chkSausage.UseVisualStyleBackColor = true;
            // 
            // chkHam
            // 
            chkHam.AutoSize = true;
            chkHam.Location = new Point(19, 128);
            chkHam.Name = "chkHam";
            chkHam.Size = new Size(97, 25);
            chkHam.TabIndex = 3;
            chkHam.Text = "&Ham (.70)";
            chkHam.UseVisualStyleBackColor = true;
            // 
            // chkPepperoni
            // 
            chkPepperoni.AutoSize = true;
            chkPepperoni.Location = new Point(19, 91);
            chkPepperoni.Name = "chkPepperoni";
            chkPepperoni.Size = new Size(134, 25);
            chkPepperoni.TabIndex = 2;
            chkPepperoni.Text = "Pepperon&i (.75)";
            chkPepperoni.UseVisualStyleBackColor = true;
            // 
            // lblPizzaInfo
            // 
            lblPizzaInfo.Controls.Add(lstPizzaSize);
            lblPizzaInfo.Controls.Add(lblSize);
            lblPizzaInfo.Controls.Add(lstCrustStyles);
            lblPizzaInfo.Controls.Add(lblCrust);
            lblPizzaInfo.Location = new Point(365, 28);
            lblPizzaInfo.Name = "lblPizzaInfo";
            lblPizzaInfo.Size = new Size(354, 293);
            lblPizzaInfo.TabIndex = 1;
            lblPizzaInfo.TabStop = false;
            lblPizzaInfo.Text = "Pizza Crust";
            // 
            // lstPizzaSize
            // 
            lstPizzaSize.FormattingEnabled = true;
            lstPizzaSize.ItemHeight = 21;
            lstPizzaSize.Location = new Point(106, 154);
            lstPizzaSize.Name = "lstPizzaSize";
            lstPizzaSize.Size = new Size(242, 109);
            lstPizzaSize.TabIndex = 3;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(6, 156);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(78, 21);
            lblSize.TabIndex = 2;
            lblSize.Text = "Pizza si&ze:";
            // 
            // txtPizzaOrders
            // 
            txtPizzaOrders.Location = new Point(20, 327);
            txtPizzaOrders.Multiline = true;
            txtPizzaOrders.Name = "txtPizzaOrders";
            txtPizzaOrders.ReadOnly = true;
            txtPizzaOrders.ScrollBars = ScrollBars.Both;
            txtPizzaOrders.Size = new Size(922, 387);
            txtPizzaOrders.TabIndex = 3;
            // 
            // tolButtons
            // 
            tolButtons.Font = new Font("Segoe UI", 12F);
            tolButtons.Items.AddRange(new ToolStripItem[] { tolbtnSubmit, toolStripSeparator1, tolbtnCancel, toolStripSeparator2, tolbtnExit, lblErrorMessage });
            tolButtons.Location = new Point(0, 0);
            tolButtons.Name = "tolButtons";
            tolButtons.Size = new Size(947, 28);
            tolButtons.TabIndex = 5;
            tolButtons.Text = "toolStrip1";
            tolButtons.ItemClicked += tolButtons_ItemClicked;
            // 
            // tolbtnSubmit
            // 
            tolbtnSubmit.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tolbtnSubmit.ImageTransparentColor = Color.Magenta;
            tolbtnSubmit.Name = "tolbtnSubmit";
            tolbtnSubmit.Size = new Size(109, 25);
            tolbtnSubmit.Text = "Submit Order";
            tolbtnSubmit.ToolTipText = "Submit Order";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 28);
            // 
            // tolbtnCancel
            // 
            tolbtnCancel.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tolbtnCancel.ImageTransparentColor = Color.Magenta;
            tolbtnCancel.Name = "tolbtnCancel";
            tolbtnCancel.Size = new Size(60, 25);
            tolbtnCancel.Text = "Cancel";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 28);
            // 
            // tolbtnExit
            // 
            tolbtnExit.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tolbtnExit.ImageTransparentColor = Color.Magenta;
            tolbtnExit.Name = "tolbtnExit";
            tolbtnExit.Size = new Size(38, 25);
            tolbtnExit.Text = "Exit";
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.ForeColor = Color.Red;
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(0, 25);
            // 
            // stsOrderSummary
            // 
            stsOrderSummary.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblPizzaCount, toolStripStatusLabel2, lblPickupCount, toolStripStatusLabel4, lblDeliveryCount, toolStripStatusLabel6, lblTotalPizzaSalesWithTax });
            stsOrderSummary.Location = new Point(0, 717);
            stsOrderSummary.Name = "stsOrderSummary";
            stsOrderSummary.Size = new Size(947, 22);
            stsOrderSummary.TabIndex = 4;
            stsOrderSummary.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(70, 17);
            toolStripStatusLabel1.Text = "Pizza count:";
            // 
            // lblPizzaCount
            // 
            lblPizzaCount.AutoSize = false;
            lblPizzaCount.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            lblPizzaCount.Name = "lblPizzaCount";
            lblPizzaCount.Size = new Size(50, 17);
            lblPizzaCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(114, 17);
            toolStripStatusLabel2.Text = "Total Pick-up Orders";
            // 
            // lblPickupCount
            // 
            lblPickupCount.AutoSize = false;
            lblPickupCount.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            lblPickupCount.Name = "lblPickupCount";
            lblPickupCount.Size = new Size(50, 17);
            lblPickupCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(115, 17);
            toolStripStatusLabel4.Text = "Total Delivery Orders";
            // 
            // lblDeliveryCount
            // 
            lblDeliveryCount.AutoSize = false;
            lblDeliveryCount.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            lblDeliveryCount.Name = "lblDeliveryCount";
            lblDeliveryCount.Size = new Size(50, 17);
            lblDeliveryCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel6
            // 
            toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            toolStripStatusLabel6.Size = new Size(138, 17);
            toolStripStatusLabel6.Text = "Total Pizza Sales with tax:";
            // 
            // lblTotalPizzaSalesWithTax
            // 
            lblTotalPizzaSalesWithTax.AutoSize = false;
            lblTotalPizzaSalesWithTax.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            lblTotalPizzaSalesWithTax.Name = "lblTotalPizzaSalesWithTax";
            lblTotalPizzaSalesWithTax.Size = new Size(50, 17);
            lblTotalPizzaSalesWithTax.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmPizzaOrders
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 739);
            ControlBox = false;
            Controls.Add(stsOrderSummary);
            Controls.Add(tolButtons);
            Controls.Add(txtPizzaOrders);
            Controls.Add(lblPizzaInfo);
            Controls.Add(lblToppings);
            Controls.Add(lblCustInfo);
            Font = new Font("Segoe UI", 12F);
            Name = "frmPizzaOrders";
            Text = "Pizza Orders-Big Z's Pizzeria";
            lblCustInfo.ResumeLayout(false);
            lblCustInfo.PerformLayout();
            lblOrderType.ResumeLayout(false);
            lblOrderType.PerformLayout();
            lblToppings.ResumeLayout(false);
            lblToppings.PerformLayout();
            lblPizzaInfo.ResumeLayout(false);
            lblPizzaInfo.PerformLayout();
            tolButtons.ResumeLayout(false);
            tolButtons.PerformLayout();
            stsOrderSummary.ResumeLayout(false);
            stsOrderSummary.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.GroupBox lblCustInfo;
        private System.Windows.Forms.Label lblCrust;
        private System.Windows.Forms.ListBox lstCrustStyles;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.GroupBox lblToppings;
        private System.Windows.Forms.GroupBox lblPizzaInfo;
        private System.Windows.Forms.TextBox txtPizzaOrders;
        private System.Windows.Forms.ToolStrip tolButtons;
        private System.Windows.Forms.ToolStripButton tolbtnSubmit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tolbtnCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tolbtnExit;
        private System.Windows.Forms.CheckBox chkOnions;
        private System.Windows.Forms.CheckBox chkSausage;
        private System.Windows.Forms.CheckBox chkHam;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.ListBox lstPizzaSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.StatusStrip stsOrderSummary;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblPizzaCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.GroupBox lblOrderType;
        private System.Windows.Forms.Label lblPhoneCaption;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.RadioButton rdoDelivery;
        private System.Windows.Forms.RadioButton rdoPickUp;
        private System.Windows.Forms.Label lblStreetCaption;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.RadioButton rdoNoCheese;
        private System.Windows.Forms.RadioButton rdoMozzarella;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.ToolStripStatusLabel lblPickupCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel lblDeliveryCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalPizzaSalesWithTax;
        private System.Windows.Forms.ToolStripLabel lblErrorMessage;
    }
}
