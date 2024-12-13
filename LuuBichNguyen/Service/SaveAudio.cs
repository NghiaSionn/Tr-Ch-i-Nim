using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuuBichNguyen.Service
{
    public class SaveAudio : System.Configuration.ApplicationSettingsBase
    {
        [UserScopedSetting]
        [DefaultSettingValue("100")]
        public int TrackBarVolume
        {
            get { return ((int)(this["TrackBarVolume"])); }
            set { this["TrackBarVolume"] = value; }
        }
    }
}
