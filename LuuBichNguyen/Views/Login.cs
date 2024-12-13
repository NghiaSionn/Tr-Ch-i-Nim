using LuuBichNguyen.Model;
using LuuBichNguyen.Views;

namespace LuuBichNguyen
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxLogin.Text))
            {
                PlayerM.playerName = textBoxLogin.Text;
                labelWaring.Visible = false;

                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                labelWaring.Text = "Vui lòng nhập tên trước khi tiếp tục.";
                labelWaring.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            labelWaring.Visible = false;
        }
    }
}
