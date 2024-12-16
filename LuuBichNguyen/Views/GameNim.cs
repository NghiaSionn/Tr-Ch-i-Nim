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
    public partial class GameNim : Form
    {
        private TimeCount timeCount;
        private bool isPlayer1Turn = true;
        private List<BagRock> bagRockList;
        private PictureBox selectedBagPictureBox = null;
        private List<PictureBox> rockPictureBoxes = new List<PictureBox>();
        private GameManager gameManager;


        public GameNim(List<BagRock> bags)
        {
            InitializeComponent();

            timeCount = new TimeCount(30);
            timeCount.TimeUpdated += OnTimeUpdated;
            timeCount.CountdownFinished += OnCountdownFinished;

            gameManager = new GameManager(bags);
            bagRockList = bags;

            DisplayBagContents();

            labelTime.Text = "Chọn túi để bắt đầu";
            labelMess.Visible = false;

        }

        private void labelPlayer1_Click(object sender, EventArgs e)
        {

        }

        private void GameNim_Load(object sender, EventArgs e)
        {
            labelPlayer1.Text = $"{PlayerM.playerName}";
            labelPlayer2.Text = "Người Máy";

        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void OnTimeUpdated(int timeRemaining)
        {

            labelTime.Text = $"{timeRemaining}s";
        }

        private void OnCountdownFinished()
        {
            gameManager.SwitchTurn();  

            UpdatePlayerTurnLabel();

            if (!gameManager.IsPlayer1Turn)
            {
                
                gameManager.AiTakeTurn(this);

                StartCountdown();  
            }
            else
            {
                StartCountdown(); 
            }
        }



        private void StartCountdown()
        {
            timeCount.Start(30);
        }

        private void StopCountdown()
        {
            timeCount.Stop();
        }

        private void labelMess_Click(object sender, EventArgs e)
        {

        }

        private void DisplayBagContents()
        {
            int padding = 15;
            int bagWidth = 50;

            int numBags = bagRockList.Count;
            int totalWidth = numBags * (bagWidth + padding) - padding;

            int startX = (this.ClientSize.Width - totalWidth) / 2;
            int y = 100;
            int x = startX;

            foreach (var bag in bagRockList)
            {
                PictureBox bagPictureBox = new PictureBox();
                bagPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                bagPictureBox.Width = bagWidth;
                bagPictureBox.Height = 50;
                bagPictureBox.Image = Image.FromFile(@"D:\Đồ án\Nguyên\LuuBichNguyen\LuuBichNguyen\Resources\business-bag.png");
                bagPictureBox.Location = new Point(x, y);

                bagPictureBox.Tag = bag.GetQuantity();

                bagPictureBox.Click += pictureBox_Click;

                this.Controls.Add(bagPictureBox);

                x += bagWidth + padding;
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (selectedBagPictureBox != null)
            {
                MessageBox.Show("Bạn đã chọn một túi. Vui lòng lấy đá hoặc chọn túi khác.");
                return;
            }

            selectedBagPictureBox = sender as PictureBox;
            if (selectedBagPictureBox != null)
            {
                int numRocks = (int)selectedBagPictureBox.Tag;
                MessageBox.Show($"Số lượng sỏi trong túi này: {numRocks}");

                UpdateBagVisibility(false); // Ẩn các túi khác
                selectedBagPictureBox.Visible = true;

                DisplayRocksInSelectedBag();
                ChoseCoins();
                StartCountdown();
            }
        }

        private void UpdateBagVisibility(bool isVisible)
        {
            foreach (Control control in this.Controls.OfType<PictureBox>())
            {
                control.Visible = isVisible;
            }
        }


        private void DisplayRocksInSelectedBag()
        {
            // Xoá các sỏi cũ
            foreach (var rock in rockPictureBoxes)
            {
                this.Controls.Remove(rock);
            }
            rockPictureBoxes.Clear();

            if (selectedBagPictureBox == null) return;

            int numRocks = (int)selectedBagPictureBox.Tag;

            int yPosition = 160;
            int padding = 15;

            for (int i = 0; i < numRocks; i++)
            {
                PictureBox rockPictureBox = new PictureBox();
                rockPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                rockPictureBox.Width = 30;
                rockPictureBox.Height = 30;
                rockPictureBox.Image = Image.FromFile(@"D:\Đồ án\Nguyên\LuuBichNguyen\LuuBichNguyen\Resources\rocks-export.png");

                int xPosition = 50 + i * (30 + padding);

                rockPictureBox.Location = new Point(xPosition, yPosition);

                this.Controls.Add(rockPictureBox);
                rockPictureBoxes.Add(rockPictureBox);
            }
        }


        public void ChoseCoins()
        {
            if (!isPlayer1Turn)
            {
                MessageBox.Show("Không đến lượt bạn.");
                return;
            }

            DialogResult result = MessageBox.Show("Chọn mặt đồng xu: Sấp?", "Chọn mặt đồng xu", MessageBoxButtons.YesNo);

            string playerChoice = result == DialogResult.Yes ? "Sấp" : "Ngửa";
            string coinResult = CoinFlip.FlipCoin();

            if (coinResult == playerChoice)
            {
                labelMess.Visible = true;
                MessageBox.Show($"Kết quả tung đồng xu là {coinResult}. {PlayerM.playerName} được đi tiếp!");
                // Không chuyển lượt vì người chơi đã thắng
                StartCountdown();
            }
            else
            {
                labelMess.Visible = true;
                MessageBox.Show($"Kết quả tung đồng xu là {coinResult}. Lượt đối thủ.");
                gameManager.SwitchTurn();
                UpdatePlayerTurnLabel();

                StartCountdown();
            }
        }



        public void UpdatePlayerTurnLabel()
        {
            labelMess.Visible = true;
            labelMess.Text = gameManager.IsPlayer1Turn ? $"Lượt {PlayerM.playerName}" : "Lượt đối thủ";

            buttonTake.Visible = gameManager.IsPlayer1Turn;
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void buttonTake_Click(object sender, EventArgs e)
        {
            if (selectedBagPictureBox == null)
            {
                MessageBox.Show("Vui lòng chọn túi trước khi lấy đá.");
                return;
            }

            int numRocks = (int)selectedBagPictureBox.Tag;
            BagRock selectedBag = bagRockList.FirstOrDefault(bag => bag.GetQuantity() == numRocks);

            if (selectedBag == null)
            {
                MessageBox.Show("Không tìm thấy túi này.");
                return;
            }

            var result = gameManager.TakeRocksFromBag(selectedBag);

            MessageBox.Show(result.Message);

            selectedBagPictureBox.Tag = result.RemainingRocks;

            // Xoá các PictureBox sỏi đã được lấy khỏi giao diện
            int rocksToRemove = numRocks - result.RemainingRocks;
            for (int i = 0; i < rocksToRemove; i++)
            {
                if (rockPictureBoxes.Count > i)
                {
                    PictureBox rockToRemove = rockPictureBoxes[i];
                    this.Controls.Remove(rockToRemove);
                }
            }

            rockPictureBoxes.RemoveRange(0, rocksToRemove);

            if (gameManager.CheckGameOver())
            {
                MessageBox.Show("Trò chơi đã kết thúc!");
                Close();
            }
            else
            {
                gameManager.SwitchTurn();
                UpdatePlayerTurnLabel();
            }
        }

    }
}
