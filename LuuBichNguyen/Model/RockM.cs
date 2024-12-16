using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuuBichNguyen.Model
{
    public class RockM
    {
        public int ID {  get; set; }
        public int Quanity { get; set; }

        public RockM(int id,int quanity = 1) 
        {
            ID = id;
            Quanity = quanity;
        }

        public override string ToString() => $"Số Lượng: {Quanity}";
    }
}
