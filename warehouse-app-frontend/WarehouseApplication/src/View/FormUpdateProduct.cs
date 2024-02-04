using ComponentFactory.Krypton.Toolkit;
using WarehouseApplication.src.Controller;
using WarehouseApplication.src.Model.Object;

namespace WarehouseApplication.src.View
{
    public partial class FormUpdateProduct : KryptonForm
    {
        public delegate void eventHandlerUpdate(Products product);
        public event eventHandlerUpdate onUpdate;
        private ProductController controller;
        private ApiResponse<Products> response;
        private Products product;

        public FormUpdateProduct()
        {
            InitializeComponent();
        }

        public FormUpdateProduct(Products _product, ProductController _controller) : this()
        {
            this.controller = _controller;
            this.product = _product;

            this.productCode.Text = this.product.productId;
            this.productName.Text = this.product.productName;
            this.productStock.Text = this.product.productStock;
            this.productUnits.SelectedIndex = this.handleProductUnits(this.product.productUnit);
            this.productPrice.Text = this.product.productPrice;
        }

        private int handleProductUnits(string unit)
        {
            if (unit == "kg") return 1;
            if (unit == "pcs") return 2;
            return 3;
        }

        private async void buttonUpdate_Click(object sender, System.EventArgs e)
        {
            string productUnit = this.productUnits.SelectedItem as string;

            Products updateProduct = new Products();
            updateProduct.productId = this.productCode.Text;
            updateProduct.productName = this.productName.Text;
            updateProduct.productStock = this.productStock.Text;
            updateProduct.productUnit = productUnit.ToLower();
            updateProduct.productPrice = this.productPrice.Text;

            this.response = await this.controller.update(updateProduct, this.product.id);

            if (this.response.status == 200)
            {
                this.onUpdate(updateProduct);
                this.Close();
            }

            //Console.WriteLine($"Data Update : {updateProduct.id}");
            //Console.WriteLine($"Data Update : {updateProduct.productId}");
            //Console.WriteLine($"Data Update : {updateProduct.productName}");
            //Console.WriteLine($"Data Update : {updateProduct.productStock}");
            //Console.WriteLine($"Data Update : {updateProduct.productUnit}");
            //Console.WriteLine($"Data Update : {updateProduct.productPrice}");
        }

        private void productUnits_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.productUnits.SelectedIndex == 0)
            {
                this.productUnits.SelectedIndex = 1;
            }
        }

        private void buttonClose_Click(object sender, System.EventArgs e) => this.Close();
    }
}