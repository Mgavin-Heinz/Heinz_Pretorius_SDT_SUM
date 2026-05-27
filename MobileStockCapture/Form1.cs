namespace MobileStockCapture
{
    public partial class Form1 : Form
    {
        List<MobileStock> stockList = new List<MobileStock>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCode.Text) || string.IsNullOrWhiteSpace(txtMake.Text) || string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!int.TryParse(txtCode.Text, out int code))
            {
                MessageBox.Show("Code must be a number");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Quantity must be a valid number and more than zero.");
                return;
            }



            MobileStock newStock = new MobileStock(int.Parse(txtCode.Text), txtMake.Text, quantity);
            stockList.Add(newStock);
            tblMobilePhones.Items.Add(newStock);
            lblOutput.Text = $"Added: {newStock}";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCode.Text))
            {
                MessageBox.Show("Please enter a code to delete.");
                return;
            }

            foreach (MobileStock item in tblMobilePhones.Items)
            {

                if (!item.Code.ToString().Equals(txtCode.Text))
                {
                    
                    lblOutput.Text = "Record not found.";
                    return;
                }

                if (txtCode.Text == item.Code.ToString())
                {
                    stockList.Remove(item);
                    tblMobilePhones.Items.Remove(item);
                    lblOutput.Text = $"Record Deleted: {item}";
                    break;
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            foreach (MobileStock item in tblMobilePhones.Items)
            {
                if (txtCode.Text == item.Code.ToString())
                {
                    lblOutput.Text = $"Record Found: {item}";
                    return;
                }
            }
            lblOutput.Text = "Record not found.";
        }
    }
}
