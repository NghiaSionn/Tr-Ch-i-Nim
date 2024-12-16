using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LuuBichNguyen.Service
{
    public class CoinFlip
    {
        private static Random random = new Random();


        public static string FlipCoin()
        {
            return random.Next(2) == 0 ? "Sấp" : "Ngửa";
        }
    }
}
