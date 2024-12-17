using LuuBichNguyen.Model;
using LuuBichNguyen.Service;
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
        SFXButton sfxButton = new SFXButton();
        public Form1()
        {
            InitializeComponent();
            saveAudio = new SaveAudio();

            wplayer.URL = @"D:\Đồ án\Nguyên\LuuBichNguyen\LuuBichNguyen\Resources\Track_#1.wav";
            wplayer.settings.volume = saveAudio.TrackBarVolume;
            wplayer.controls.play();
            axWindowsMediaPlayer1.Hide();
        }

        public static WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        private SaveAudio saveAudio;

        private void labelPlayerName_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelPlayerName.Text = $"Chào mừng, {PlayerM.playerName}!";

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }



        private void btnStart_Click(object sender, EventArgs e)
        {
            sfxButton.ButtonPressed();

            DialogResult result = MessageBox.Show("Bạn có muốn bắt đầu?", "Xác nhận",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Rock rock = new Rock();
                rock.Show();
                this.Hide();
            }
        }

        private void btnStart_Hover(object sender, EventArgs e)
        {
            sfxButton.ButtonSelected();
            btnStart.Image = Properties.Resources.start_hover;
        }

        private void btnStart_Leave(object sender, EventArgs e)
        {
            btnStart.Image = Properties.Resources.start_normal;
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            sfxButton.ButtonPressed();

            Setting setting = new Setting();
            setting.ShowDialog();


        }

        private void btnOption_Hover(object sender, EventArgs e)
        {
            sfxButton.ButtonSelected();
            btnOption.Image = Properties.Resources.option_hover;
        }

        private void btnOption_Leave(object sender, EventArgs e)
        {
            btnOption.Image = Properties.Resources.option_normal;
        }

        private void btnExit_Hover(object sender, EventArgs e)
        {
            sfxButton.ButtonSelected();
            btnExit.Image = Properties.Resources.exit_hover;
        }

        private void btnExit_Leave(object sender, EventArgs e)
        {
            btnExit.Image = Properties.Resources.exit_normal;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            sfxButton.ButtonPressed();

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
