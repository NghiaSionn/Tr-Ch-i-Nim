using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuuBichNguyen.Model
{
    public class BagRock
    {
        public int Quantity { get; private set; }

        public BagRock(int numRocks)
        {
            var random = new System.Random();

            numRocks = System.Math.Min(numRocks, 20);

            Quantity = random.Next(1, numRocks + 1);
        }


        public void SetQuantity(int newQuantity)
        {
            Quantity = newQuantity;
            

        }

        public int GetQuantity() => Quantity;
    }
}
