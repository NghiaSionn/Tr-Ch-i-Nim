using LuuBichNguyen.Model;
using LuuBichNguyen.Service;
using LuuBichNguyen.Views;
using System.Media;

namespace LuuBichNguyen
{
    public partial class Login : Form
    {
        SFXButton sfxButton = new SFXButton();
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            labelWaring.Visible = false;
        }


        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            sfxButton.ButtonSelected();           
            btnLogin.Image = Properties.Resources.Add_Pressed;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.Image = Properties.Resources.Add_Unpressed;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            sfxButton.ButtonPressed();
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

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            if (textBoxLogin.Text.Length > 10)
            {

                textBoxLogin.Text = textBoxLogin.Text.Substring(0, 10);
                textBoxLogin.SelectionStart = textBoxLogin.Text.Length;
            }

            if (textBoxLogin.Text.Length == 10)
            {
                labelWaring.Text = "Bạn đã đạt giới hạn tối đa (10 ký tự).";
                labelWaring.Visible = true;
            }
            else
            {
                labelWaring.Visible = false;
            }
        }
    }
}
