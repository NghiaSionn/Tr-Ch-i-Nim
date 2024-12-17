using LuuBichNguyen.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuuBichNguyen.Views
{
    public partial class Setting : Form
    {

       


        SFXButton sfxButton = new SFXButton();
        public Setting()
        {
            InitializeComponent();
        }

        private SaveAudio saveAudio = new SaveAudio();

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Form1.wplayer.controls.play();
            Form1.wplayer.settings.volume = trackBar1.Value;

            saveAudio.TrackBarVolume = trackBar1.Value;
            saveAudio.Save();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Setting_Load(object sender, EventArgs e)
        {
            trackBar1.Value = saveAudio.TrackBarVolume;

            if (Form1.wplayer != null)
            {
                Form1.wplayer.settings.volume = saveAudio.TrackBarVolume;
                Form1.wplayer.controls.play();
            }

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            sfxButton.ButtonPressed();
            
            this.Close();

        }

        private void btnPause_Hover(object sender, EventArgs e)
        {
            sfxButton.ButtonSelected();

            btnPause.Image = Properties.Resources.Menu_Buttons_sprite__Colored_;
        }

        private void btnPause_Leave(object sender, EventArgs e)
        {
            btnPause.Image = Properties.Resources.Menu_Buttons_sprite__BnW_;
        }
    }
}
