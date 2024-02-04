using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseApplication.src.Model.Object;
using WarehouseApplication.src.Model.Repo;

namespace WarehouseApplication.src.Controller
{
    public class ProductController
    {
        private ProductApiRepo productRepo;
        private ApiResponse<Products> response;

        public ProductController(Users _user)
        {
            this.productRepo = new ProductApiRepo(_user);
        }

        public async Task<ApiResponse<Products>> add(Products product)
        {
            this.response = await this.productRepo.add(product);

            if (this.response.status != 201)
            {
                MessageBox.Show("Failed To Add Product!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return this.response;
        }

        public async Task<ApiResponse<Products>> getAll()
        {
            this.response = await this.productRepo.getAll();

            if (this.response.status != 200)
            {
                MessageBox.Show("Failed To Load Data Products!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return this.response;
        }

        public async Task<ApiResponse<Products>> getById(string productId)
        {
            this.response = await this.productRepo.getById(productId);

            if (this.response.status != 200)
            {
                MessageBox.Show("Product ID Not Found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return this.response;
        }

        public async Task<ApiResponse<Products>> getByName(string productName)
        {
            this.response = await this.productRepo.getByName(productName);

            if (this.response.status != 200)
            {
                MessageBox.Show("Product Name Not Found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return this.response;
        }

        public async Task<ApiResponse<Products>> update(Products product, string id)
        {

            this.response = await this.productRepo.update(product, id);

            if (this.response.status != 200)
            {
                MessageBox.Show("Failed to Update Product!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            MessageBox.Show("Update Product Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return this.response;
        }

        public async Task<ApiResponse<Products>> delete(string productId)
        {
            this.response = await this.productRepo.delete(productId);

            if (this.response.status != 200)
            {
                MessageBox.Show("Failed to Delete Product!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            MessageBox.Show("Delete Product Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return this.response;
        }
    }
}
