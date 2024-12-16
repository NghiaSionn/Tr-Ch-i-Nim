using LuuBichNguyen.Model;
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
    public partial class Rock : Form
    {
        SFXButton sfxButton = new SFXButton();

        private BagRock bagRock;
        public Rock()
        {
            InitializeComponent();
            labelWaring.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxInt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rock_Load(object sender, EventArgs e)
        {

        }

        private void labelWaring_Click(object sender, EventArgs e)
        {
            labelWaring.Visible = false;
        }

        private void btnAcepct_Click(object sender, EventArgs e)
        {
            sfxButton.ButtonPressed();

            if (int.TryParse(textBoxInt.Text, out int numBags) && numBags > 0 && numBags <= 10)
            {
                labelWaring.Visible = false;


                List<BagRock> bagRockList = new List<BagRock>();
                for (int i = 0; i < numBags; i++)
                {
                    bagRockList.Add(new BagRock(10));
                }


                GameNim formGame = new GameNim(bagRockList);

                formGame.Show();
                this.Hide();
            }
            else
            {
                labelWaring.Text = "Số lượng nhập không chính xác!";
                labelWaring.Visible = true;
            }
        }

        private void btnAcepct_Hover(object sender, EventArgs e)
        {
            sfxButton.ButtonSelected();
            btnAcepct.Image = Properties.Resources.Add_Pressed;
        }

        private void btnAcepct_Leave(object sender, EventArgs e)
        {
            btnAcepct.Image = Properties.Resources.Add_Unpressed;
        }
    }
}
