using ComponentFactory.Krypton.Toolkit;
using System.Threading;
using System.Windows.Forms;
using WarehouseApplication.src.Model.Object;

namespace WarehouseApplication.src.View
{
    public partial class FormMain : KryptonForm
    {
        private Users user;

        public FormMain(Users _user)
        {
            InitializeComponent();

            this.user = _user;
        }

        private void productMenu_Click(object sender, System.EventArgs e)
        {
            FormUserProducts formUserProducts = new FormUserProducts(this.user);
            formUserProducts.ShowDialog();
        }

        private void addTransactionMenu_Click(object sender, System.EventArgs e)
        {
            FormTransaction formTransaction = new FormTransaction(this.user);
            formTransaction.ShowDialog();
        }

        private void myTransactionMenu_Click(object sender, System.EventArgs e)
        {
            FormMyTransaction formMyTransaction = new FormMyTransaction(this.user);
            formMyTransaction.ShowDialog();
        }

        private void logoutMenu_Click(object sender, System.EventArgs e)
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
