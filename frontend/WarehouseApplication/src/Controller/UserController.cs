using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseApplication.src.Model.Object;
using WarehouseApplication.src.Model.Repo;

namespace WarehouseApplication.src.Controller
{
    public class UserController
    {
        private UserApiRepo userRepo;
        private ApiResponse<Users> response;
        private Users user;

        public async Task<ApiResponse<Users>> login(Users _user)
        {
            this.user = _user;

            if (string.IsNullOrEmpty(this.user.username) || string.IsNullOrEmpty(this.user.password))
            {
                MessageBox.Show("Username Or Password Incorrect!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return new ApiResponse<Users>
                {
                    status = 400,
                    message = "Bad Request",
                    data = new List<Users>()
                };
            }

            this.userRepo = new UserApiRepo(this.user);
            this.response = await this.userRepo.login();

            if (this.response.status != 200)
            {
                MessageBox.Show("Username Or Password Not Found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return this.response;
        }
    }
}
