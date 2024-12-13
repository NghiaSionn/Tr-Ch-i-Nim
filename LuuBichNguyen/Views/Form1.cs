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
            wplayer.URL = (@"D:\Đồ án\Nguyên\LuuBichNguyen\LuuBichNguyen\Resources\Track_#1.wav");
            wplayer.controls.play();

            axWindowsMediaPlayer1.Hide();
        }

        public static WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        private void labelPlayerName_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelPlayerName.Text = $"Chào mừng, {PlayerM.playerName}!";
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\Đồ án\Nguyên\LuuBichNguyen\LuuBichNguyen\Resources\background sound.wav");
            sound.Play();

            DialogResult result = MessageBox.Show("Bạn có muốn bỏ qua hướng dẫn không?", "Xác nhận", 
                                                    MessageBoxButtons.YesNo, 
                                                    MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                GameNim gameNim = new GameNim();
                gameNim.Show();
                this.Hide();
            }
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\Đồ án\Nguyên\LuuBichNguyen\LuuBichNguyen\Resources\background sound.wav");
            sound.Play();

            Setting setting = new Setting();
            setting.ShowDialog();
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\Đồ án\Nguyên\LuuBichNguyen\LuuBichNguyen\Resources\background sound.wav");
            sound.Play();

            DialogResult result = MessageBox.Show("Bạn có muốn thoát game không ?", "Xác nhận",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
            
        }
    }
}
