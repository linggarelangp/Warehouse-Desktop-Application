using ComponentFactory.Krypton.Toolkit;
using System;
using WarehouseApplication.src.Controller;
using WarehouseApplication.src.Model.Object;

namespace WarehouseApplication.src.View
{
    public partial class FormAddTransaction : KryptonForm
    {
        public delegate void createEventHandler();
        public event createEventHandler onCreate;
        private Users user;
        private Products product;
        private TransactionController controller;
        private ApiResponse<Transaction> response;

        public FormAddTransaction()
        {
            InitializeComponent();

            this.controller = new TransactionController();
        }

        public FormAddTransaction(Users _user, Products _product) : this()
        {
            this.user = _user;
            this.product = _product;

            this.productCode.Text = this.product.productId;
            this.productName.Text = this.product.productName;
            this.productPrice.Text = this.product.productPrice;
            this.labelUnits.Text = "/ " + this.product.productUnit;
            this.amount.TextChanged += this.amount_TextChanged;
        }

        private void amount_TextChanged(object sender, System.EventArgs e)
        {
            if (int.TryParse(this.amount.Text, out int isAmount))
            {
                int pricePerUnit = Convert.ToInt32(this.product.productPrice);
                int calculateTotalPrice = isAmount * pricePerUnit;

                this.totalPrice.Text = calculateTotalPrice.ToString();
            }
            else
            {
                this.totalPrice.Text = string.Empty;
            }
        }

        private async void buttonAddTransaction_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction();
            transaction.userId = this.user.userId;
            transaction.productId = this.product.productId;
            transaction.price = this.product.productPrice;
            transaction.amount = this.amount.Text;
            transaction.totalPrice = this.totalPrice.Text;

            this.response = await this.controller.add(transaction);

            if (this.response.status == 201)
            {
                this.onCreate();
                this.Close();
            }
        }
    }
}
