using ComponentFactory.Krypton.Toolkit;
using System.Collections.Generic;
using System.Windows.Forms;
using WarehouseApplication.src.Controller;
using WarehouseApplication.src.Model.Object;

namespace WarehouseApplication.src.View
{
    public partial class FormUserProducts : KryptonForm
    {
        private Users user;
        private ProductController controller;
        private ApiResponse<Products> response;
        private List<Products> listProduct;

        public FormUserProducts(Users _user)
        {
            InitializeComponent();

            this.user = _user;
            this.controller = new ProductController(this.user);
            this.labelUserId.Text = this.user.userId;
            this.initListView();
            this.loadDataProducts();
        }

        private void initListView()
        {
            this.listViewProducts.View = System.Windows.Forms.View.Details;
            this.listViewProducts.FullRowSelect = true;
            this.listViewProducts.GridLines = true;

            this.listViewProducts.Columns.Add("No.", 35, HorizontalAlignment.Left);
            this.listViewProducts.Columns.Add("Product ID", 110, HorizontalAlignment.Center);
            this.listViewProducts.Columns.Add("Product Name", 220, HorizontalAlignment.Center);
            this.listViewProducts.Columns.Add("Stock", 80, HorizontalAlignment.Center);
            this.listViewProducts.Columns.Add("Price", 100, HorizontalAlignment.Center);
        }

        private async void loadDataProducts()
        {
            this.listViewProducts.Items.Clear();

            this.response = await this.controller.getAll();
            this.listProduct = this.response.data;

            foreach (Products product in this.listProduct)
            {
                int number = listViewProducts.Items.Count + 1;
                ListViewItem items = new ListViewItem(number.ToString());
                items.SubItems.Add(product.productId);
                items.SubItems.Add(product.productName);
                items.SubItems.Add(product.productStock + " " + product.productUnit);
                items.SubItems.Add(product.productPrice);
                items.SubItems.Add(product.id);
                this.listViewProducts.Items.Add(items);
            }
        }

        private void onSearchHandler(List<Products> list)
        {
            this.listViewProducts.Items.Clear();

            foreach (Products product in list)
            {
                int number = listViewProducts.Items.Count + 1;
                ListViewItem items = new ListViewItem(number.ToString());
                items.SubItems.Add(product.productId);
                items.SubItems.Add(product.productName);
                items.SubItems.Add(product.productStock + " " + product.productUnit);
                items.SubItems.Add(product.productPrice);
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
                this.loadDataProducts();
            }
            else if (this.comboBoxFilterSearch.SelectedIndex == 2)
            {
                this.response = await this.controller.getById(keyword);

                if (this.response.status == 200)
                {
                    this.inputSearch.Text = "Seacrh...";
                    this.listProduct = this.response.data;
                    this.onSearchHandler(this.listProduct);
                }
            }
            else if (this.comboBoxFilterSearch.SelectedIndex == 3)
            {
                this.response = await this.controller.getByName(keyword);

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
