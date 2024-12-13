using LuuBichNguyen.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuuBichNguyen.Views
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelPlayerName_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelPlayerName.Text = $"Chào mừng, {PlayerM.playerName}!";
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn bỏ qua hướng dẫn không?", "Xác nhận", 
                                                    MessageBoxButtons.YesNo, 
                                                    MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
            }
            else
            {
                //this.Close();
            }
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {

        }
    }
}
