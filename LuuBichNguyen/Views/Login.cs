using LuuBichNguyen.Model;
using LuuBichNguyen.Service;
using LuuBichNguyen.Views;
using System.Media;

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
            SoundPlayer sound = new SoundPlayer(@"D:\Đồ án\Nguyên\LuuBichNguyen\LuuBichNguyen\Resources\background sound.wav");
            sound.Play();

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
