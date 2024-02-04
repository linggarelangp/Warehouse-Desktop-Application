using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using WarehouseApplication.src.Controller;
using WarehouseApplication.src.Model.Object;

namespace WarehouseApplication.src.View
{
    public partial class FormProducts : KryptonForm
    {
        private Users user;
        private ProductController controller;
        private ApiResponse<Products> response;
        private List<Products> listProduct;

        public FormProducts(Users _user)
        {
            InitializeComponent();
            this.initListView();

            this.user = _user;
            this.controller = new ProductController(this.user);
            this.labelUserId.Text = this.user.userId;
            this.loadDataProducts();
        }

        private void initListView()
        {
            this.listViewProducts.View = System.Windows.Forms.View.Details;
            this.listViewProducts.FullRowSelect = true;
            this.listViewProducts.GridLines = true;

            this.listViewProducts.Columns.Add("No.", 30, HorizontalAlignment.Left);
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

        private void onCreateHandler(Products product)
        {
            int number = listViewProducts.Items.Count + 1;
            ListViewItem items = new ListViewItem(number.ToString());
            items.SubItems.Add(product.productId);
            items.SubItems.Add(product.productName);
            items.SubItems.Add(product.productStock + " " + product.productUnit);
            items.SubItems.Add(product.productPrice);
            this.listViewProducts.Items.Add(items);

            this.loadDataProducts();
        }

        private void onUpdateHandler(Products product)
        {
            int index = this.listViewProducts.SelectedIndices[0];

            ListViewItem rows = this.listViewProducts.Items[index];

            rows.SubItems[1].Text = product.productId;
            rows.SubItems[2].Text = product.productName;
            rows.SubItems[3].Text = product.productStock + " " + product.productUnit;
            rows.SubItems[4].Text = product.productPrice;
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

        private async void buttonAddProduct_Click(object sender, EventArgs e)
        {
            string productUnit = this.productUnits.SelectedItem as string;

            Products product = new Products();
            product.productId = this.productCode.Text;
            product.productName = this.productName.Text;
            product.productUnit = productUnit.ToLower();
            product.productStock = this.productStock.Text;
            product.productPrice = this.productPrice.Text;

            this.response = await this.controller.add(product);

            if (this.response.status == 201)
            {
                this.productCode.Text = "Product Code";
                this.productName.Text = "Product name";
                this.productPrice.Text = "Product Price";
                this.productStock.Text = "Quantity";
                this.productUnits.SelectedIndex = 0;

                this.onCreateHandler(product);
            }

        }

        private void comboBoxFilterSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxFilterSearch.SelectedIndex == 0)
            {
                this.comboBoxFilterSearch.SelectedIndex = 1;
            }
        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            string keyword = this.inputSearch.Text;

            if (this.comboBoxFilterSearch.SelectedIndex == 0)
            {
                MessageBox.Show("Error!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (this.listViewProducts.SelectedIndices.Count > 0)
            {
                Products product = this.listProduct[this.listViewProducts.SelectedIndices[0]];

                FormUpdateProduct formUpdate = new FormUpdateProduct(product, this.controller);
                formUpdate.onUpdate += this.onUpdateHandler;
                formUpdate.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Select Items First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void productUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.productUnits.SelectedIndex == 0)
            {
                this.productUnits.SelectedIndex = 1;
            }
        }

        private void productUnits2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.productUnits2.SelectedIndex == 0)
            {
                this.productUnits2.SelectedIndex = 1;
            }
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            if (this.listViewProducts.SelectedItems.Count > 0)
            {
                Products product = this.listProduct[listViewProducts.SelectedIndices[0]];

                DialogResult confirmation = MessageBox.Show($"Are You Sure Want to Delete Product With ID : {product.productId}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (confirmation == DialogResult.Yes)
                {
                    this.response = await this.controller.delete(product.productId);

                    if (this.response.status == 200)
                    {
                        this.loadDataProducts();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select Items First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Thread thread;
            this.Close();
            thread = new Thread(this.SetOpenForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void SetOpenForm() => Application.Run(new FormLogin());
    }
}

