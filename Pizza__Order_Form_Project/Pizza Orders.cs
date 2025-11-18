namespace Pizza__Order_Form_Project
{
    public partial class frmPizzaOrders : Form
    {
        private int totalOrders = 0;
        private int pickupOrders = 0;
        private int deliveryOrders = 0;
        private decimal totalSales = 0;
        private decimal taxRate = 0.06m;

        public frmPizzaOrders()
        {
            InitializeComponent();
            PopulatePizzaOptions();
            rdoDelivery.CheckedChanged += new EventHandler(OrderType_CheckedChanged);
            rdoPickUp.CheckedChanged += new EventHandler(OrderType_CheckedChanged);
        }

        private void PopulatePizzaOptions()
        {
            // Populate Pizza Size List
            lstPizzaSize.Items.Add("Small (9.00)");
            lstPizzaSize.Items.Add("Medium (15.00)");
            lstPizzaSize.Items.Add("Large (20.00)");
            lstPizzaSize.Items.Add("Party-Size (30.00)");

            // Populate Crust Styles List
            lstCrustStyles.Items.Add("Deep Dish (2.00)");
            lstCrustStyles.Items.Add("Hand-Tossed Round (1.50)");
            lstCrustStyles.Items.Add("Thin (1.35)");
            lstCrustStyles.Items.Add("NY Style (1.50)");
            lstCrustStyles.Items.Add("Seasoned Cauliflower (3.00)");
            lstCrustStyles.Items.Add("Gluten-Free (5.00)");
        }

        private void OrderType_CheckedChanged(object sender, EventArgs e)
        {
            bool isDelivery = rdoDelivery.Checked;
            lblStreetCaption.Visible = isDelivery;
            txtStreetAddress.Visible = isDelivery;
            lblPhoneCaption.Visible = isDelivery;
            txtPhoneNumber.Visible = isDelivery;
        }

        private void tolButtons_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "tolbtnSubmit":
                    Perform_Calculations();
                    break;
                case "tolbtnCancel":
                    Cancel_Order();
                    break;
                case "tolbtnExit":
                    Exit_Application();
                    break;
            }
        }

        private void Perform_Calculations()
        {
            decimal basePrice = 0;
            decimal crustPrice = 0;
            decimal toppingsPrice = 0;
            string orderSummary = "";

            string customerName = $"{txtFirstName.Text} {txtLastName.Text}";
            string orderType = rdoPickUp.Checked ? "Pick-up" : "Delivery";

            if (lstPizzaSize.SelectedItem != null)
            {
                switch (lstPizzaSize.SelectedItem.ToString())
                {
                    case "Small (9.00)": basePrice = 9.00m; break;
                    case "Medium (15.00)": basePrice = 15.00m; break;
                    case "Large (20.00)": basePrice = 20.00m; break;
                    case "Party-Size (30.00)": basePrice = 30.00m; break;
                }
            }

            if (lstCrustStyles.SelectedItem != null)
            {
                switch (lstCrustStyles.SelectedItem.ToString())
                {
                    case "Deep Dish (2.00)": crustPrice = 2.00m; break;
                    case "Hand-Tossed Round (1.50)": crustPrice = 1.50m; break;
                    case "Thin (1.35)": crustPrice = 1.35m; break;
                    case "NY Style (1.50)": crustPrice = 1.50m; break;
                    case "Seasoned Cauliflower (3.00)": crustPrice = 3.00m; break;
                    case "Gluten-Free (5.00)": crustPrice = 5.00m; break;
                }
            }

            if (chkPepperoni.Checked) toppingsPrice += 0.75m;
            if (chkHam.Checked) toppingsPrice += 0.70m;
            if (chkSausage.Checked) toppingsPrice += 0.80m;
            if (chkOnions.Checked) toppingsPrice += 0.65m;
            if (chkMushrooms.Checked) toppingsPrice += 0.65m;
            if (chkGreenPeppers.Checked) toppingsPrice += 0.60m;

            decimal totalPrice = basePrice + crustPrice + toppingsPrice;
            decimal totalPriceWithTax = totalPrice + (totalPrice * taxRate);

            orderSummary += $"{customerName} order: Crust {lstCrustStyles.SelectedItem}, Size: {lstPizzaSize.SelectedItem}\n";
            orderSummary += $"Order Type: {orderType}  Customer total: {totalPriceWithTax:C2}\n";
            orderSummary += "-------------------------------------------------------------------------------\n";

            txtPizzaOrders.Text = orderSummary;

            totalOrders++;
            totalSales += totalPriceWithTax;

            if (rdoPickUp.Checked) pickupOrders++;
            if (rdoDelivery.Checked) deliveryOrders++;

            UpdateOrderSummary();
        }

        private void UpdateOrderSummary()
        {
            lblPizzaCount.Text = totalOrders.ToString();
            lblPickupCount.Text = pickupOrders.ToString();
            lblDeliveryCount.Text = deliveryOrders.ToString();
            lblTotalPizzaSalesWithTax.Text = totalSales.ToString("C2");
        }

        private void Cancel_Order()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtStreetAddress.Clear();
            txtPhoneNumber.Clear();
            txtPizzaOrders.Clear();
            lstPizzaSize.ClearSelected();
            lstCrustStyles.ClearSelected();
            chkPepperoni.Checked = false;
            chkHam.Checked = false;
            chkSausage.Checked = false;
            chkOnions.Checked = false;
            chkMushrooms.Checked = false;
            chkGreenPeppers.Checked = false;
            rdoPickUp.Checked = false;
            rdoDelivery.Checked = false;
        }

        private void Exit_Application()
        {
            Application.Exit();
        }
    }
}
