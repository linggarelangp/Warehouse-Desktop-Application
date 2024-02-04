using ComponentFactory.Krypton.Toolkit;
using System.Collections.Generic;
using System.Windows.Forms;
using WarehouseApplication.src.Controller;
using WarehouseApplication.src.Model.Object;

namespace WarehouseApplication.src.View
{
    public partial class FormMyTransaction : KryptonForm
    {
        Users user;
        private TransactionController controller;
        private ApiResponse<Transaction> response;
        private List<Transaction> listProduct;

        public FormMyTransaction(Users _user)
        {
            InitializeComponent();

            this.user = _user;
            this.controller = new TransactionController();
            this.labelUserId.Text = this.user.userId;

            this.initListView();
            this.loadDataTransactions(this.user.userId as string);
        }

        private void initListView()
        {
            this.listViewProducts.View = System.Windows.Forms.View.Details;
            this.listViewProducts.FullRowSelect = true;
            this.listViewProducts.GridLines = true;

            this.listViewProducts.Columns.Add("No.", 35, HorizontalAlignment.Left);
            this.listViewProducts.Columns.Add("Transaction ID", 110, HorizontalAlignment.Center);
            this.listViewProducts.Columns.Add("Name", 150, HorizontalAlignment.Center);
            this.listViewProducts.Columns.Add("Product Name", 130, HorizontalAlignment.Center);
            this.listViewProducts.Columns.Add("Price", 80, HorizontalAlignment.Center);
            this.listViewProducts.Columns.Add("Amount", 100, HorizontalAlignment.Center);
            this.listViewProducts.Columns.Add("Total Price", 100, HorizontalAlignment.Center);
            this.listViewProducts.Columns.Add("Status", 100, HorizontalAlignment.Center);
        }

        private async void loadDataTransactions(string userId)
        {
            this.listViewProducts.Items.Clear();

            this.response = await this.controller.getAll(userId);
            this.listProduct = this.response.data;


            foreach (Transaction transaction in this.listProduct)
            {
                int number = listViewProducts.Items.Count + 1;
                ListViewItem items = new ListViewItem(number.ToString());
                items.SubItems.Add(transaction.id);
                items.SubItems.Add(transaction.username);
                items.SubItems.Add(transaction.productName);
                items.SubItems.Add("Rp. " + transaction.price);
                items.SubItems.Add(transaction.amount + " " + transaction.unit);
                items.SubItems.Add("Rp. " + transaction.totalPrice);
                items.SubItems.Add(transaction.status);
                this.listViewProducts.Items.Add(items);
            }
        }

        private void onSearchHandler(List<Transaction> list)
        {
            this.listViewProducts.Items.Clear();

            foreach (Transaction transaction in list)
            {
                int number = listViewProducts.Items.Count + 1;
                ListViewItem items = new ListViewItem(number.ToString());
                items.SubItems.Add(transaction.id);
                items.SubItems.Add(transaction.username);
                items.SubItems.Add(transaction.productName);
                items.SubItems.Add("Rp. " + transaction.price);
                items.SubItems.Add(transaction.amount + " " + transaction.unit);
                items.SubItems.Add("Rp. " + transaction.totalPrice);
                items.SubItems.Add(transaction.status);
                this.listViewProducts.Items.Add(items);
            }
        }

        private async void buttonSearch_Click(object sender, System.EventArgs e)
        {
            string keyword = this.inputSearch.Text;

            if (this.comboBoxFilterSearch.SelectedIndex == 0)
            {
                MessageBox.Show("Cannot do a Search!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (this.comboBoxFilterSearch.SelectedIndex == 1)
            {
                this.loadDataTransactions(this.user.userId);
            }
            else if (this.comboBoxFilterSearch.SelectedIndex == 2)
            {
                this.response = await this.controller.getById(keyword, this.user.userId);

                if (this.response.status == 200)
                {
                    this.inputSearch.Text = "Seacrh...";
                    this.listProduct = this.response.data;
                    this.onSearchHandler(this.listProduct);
                }
            }
            else if (this.comboBoxFilterSearch.SelectedIndex == 3)
            {
                this.response = await this.controller.getByProductname(this.user.userId, keyword);

                if (this.response.status == 200)
                {
                    this.inputSearch.Text = "Seacrh...";
                    this.listProduct = this.response.data;
                    this.onSearchHandler(this.listProduct);
                }
            }
        }


        private void comboBoxFilterSearch_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.comboBoxFilterSearch.SelectedIndex == 0)
            {
                this.comboBoxFilterSearch.SelectedIndex = 1;
            }
        }
    }
}
