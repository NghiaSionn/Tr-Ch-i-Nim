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
    public partial class GameOver : Form
    {
        SFXButton sfxButton = new SFXButton();
        Form1 form1 = new Form1();
        Rock rock = new Rock();
        private SaveAudio saveAudio;
        private GameNim gameNim;

        public static WMPLib.WindowsMediaPlayer wplayer2 = new WMPLib.WindowsMediaPlayer();
        public GameOver()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.Hide();

           
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            sfxButton.ButtonPressed();


            DialogResult result = MessageBox.Show("Bạn có muốn về Menu ?", "Xác nhận",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                form1.Show();
                this.Hide();
            }



        }

        public void AudioOver()
        {
            saveAudio = new SaveAudio();
            wplayer2.URL = @"D:\Đồ án\Nguyên\LuuBichNguyen\LuuBichNguyen\Resources\game-over-39-199830.wav";
            wplayer2.settings.volume = saveAudio.TrackBarVolume;
            wplayer2.controls.play();
        }

        private void btnHome_Hover(object sender, EventArgs e)
        {
            sfxButton.ButtonSelected();
            btnHome.Image = Properties.Resources.home_hover;

        }
        private void btnHome_Leave(object sender, EventArgs e)
        {
            btnHome.Image = Properties.Resources.Menu_Buttons_sprite__BnW____Copy;
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            sfxButton.ButtonPressed();

            DialogResult result = MessageBox.Show("Bạn có muốn chơi lại không?", "Xác nhận",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                rock.Show();
                this.Hide();
            }
        }

        private void btnOption_Hover(object sender, EventArgs e)
        {
            sfxButton.ButtonSelected();
            btnOption.Image = Properties.Resources.restart_hover;
        }

        private void btnOption_Leave(object sender, EventArgs e)
        {
            btnOption.Image = Properties.Resources.restart_normal;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            sfxButton.ButtonPressed();

            DialogResult result = MessageBox.Show("Bạn có muốn thoát không ?", "Xác nhận",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void btnExit_Hover(object sender, EventArgs e)
        {
            sfxButton.ButtonSelected();
            btnExit.Image = Properties.Resources.quit_hover;
        }

        private void btnExit_Leave(object sender, EventArgs e)
        {
            btnExit.Image = Properties.Resources.quit_normal;
        }

        private void GameOver_Load(object sender, EventArgs e)
        {
            //gameNim.StopCountdown();
        }

        private void labelMess_Click(object sender, EventArgs e)
        {

        }

       
    }
}
