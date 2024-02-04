using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseApplication.src.Model.Object;
using WarehouseApplication.src.Model.Repo;

namespace WarehouseApplication.src.Controller
{
    public class TransactionController
    {
        private TransactionApiRepo transactionRepo;
        private ApiResponse<Transaction> response;

        public TransactionController()
        {
            this.transactionRepo = new TransactionApiRepo();
        }

        public async Task<ApiResponse<Transaction>> add(Transaction transaction)
        {
            this.response = await this.transactionRepo.add(transaction);

            if (this.response.status != 201)
            {
                MessageBox.Show("Failed To Add Product!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            MessageBox.Show("Success to Add Transaction!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return this.response;
        }

        public async Task<ApiResponse<Transaction>> getAll(string userId)
        {
            this.response = await this.transactionRepo.getAll(userId);

            if (this.response.status != 200)
            {
                MessageBox.Show("Failed To Load Data Products!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return this.response;
        }
        public async Task<ApiResponse<Transaction>> getById(string id, string userId)
        {
            this.response = await this.transactionRepo.getById(id, userId);

            if (this.response.status != 200)
            {
                MessageBox.Show("Failed To Load Data Products!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return this.response;
        }

        public async Task<ApiResponse<Transaction>> getByProductname(string userId, string productName)
        {
            this.response = await this.transactionRepo.getByProductname(userId, productName);

            if (this.response.status != 200)
            {
                MessageBox.Show("Failed To Load Data Products!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return this.response;
        }
    }
}
