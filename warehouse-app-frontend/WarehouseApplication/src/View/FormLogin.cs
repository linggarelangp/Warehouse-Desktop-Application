using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using WarehouseApplication.src.Controller;
using WarehouseApplication.src.Model.Object;

namespace WarehouseApplication.src.View
{
    public partial class FormLogin : KryptonForm
    {
        private UserController controller;
        private Users user;
        private ApiResponse<Users> response;
        private List<Users> listUser;

        public FormLogin()
        {
            this.controller = new UserController();
            this.user = new Users();

            InitializeComponent();

            this.password.UseSystemPasswordChar = true;
        }

        private async void buttonLogin_Click(object sender, System.EventArgs e)
        {
            this.user.username = this.username.Text;
            this.user.password = this.password.Text;

            this.response = await this.controller.login(this.user);

            if (this.response.status == 200)
            {
                Thread thread;
                this.Close();
                thread = new Thread(this.setOpenForm);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }

        }

        private void setOpenForm()
        {
            this.listUser = this.response.data as List<Users>;
            Users data = new Users();

            foreach (Users items in this.listUser)
            {
                data.id = items.id;
                data.userId = items.userId;
                data.roleId = items.roleId;
                data.firstname = items.firstname;
                data.lastname = items.lastname;
                data.fullname = items.fullname;
                data.token = items.token;
                data.refreshToken = items.refreshToken;
                data.active = items.active;
            }

            if (Convert.ToInt32(data.roleId) == 1 && data.active == true)
            {
                Application.Run(new FormProducts(data));
            }
            else
            {
                Application.Run(new FormMain(data));
            }
        }
    }
}
