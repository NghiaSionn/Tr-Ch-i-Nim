using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace LuuBichNguyen.Service
{
    public class SFXButton
    {
        public void ButtonSelected()
        {
            SoundPlayer sound = new SoundPlayer(@"D:\Đồ án\Nguyên\LuuBichNguyen\LuuBichNguyen\Resources\background sound.wav");
            sound.Play();
        }

        public void ButtonPressed()
        {
            SoundPlayer sound = new SoundPlayer(@"D:\Đồ án\Nguyên\LuuBichNguyen\LuuBichNguyen\Resources\click-buttons-ui-menu-sounds-effects-button-7-203601.wav");
            sound.Play();
        }
    }
}
