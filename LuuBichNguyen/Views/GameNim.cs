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
        public List<PictureBox> rockPictureBoxes = new List<PictureBox>();
        private GameManager gameManager;
        private Random random = new Random();
        Setting setting = new Setting();

        SFXButton sfxButton = new SFXButton();

        private int selectedBagIndex = -1;


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
            labelMess.Visible = true;
            if (gameManager.IsPlayer1Turn)
            {
                MessageBox.Show($"{PlayerM.playerName} hết thời gian! Chuyển lượt cho đối thủ.");
            }
            else
            {
                MessageBox.Show("AI hết thời gian! Lượt của người chơi.");
            }

            gameManager.SwitchTurn(this);
        }

        public void UpdatePlayerTurnLabel()
        {
            labelMess.Visible = true;
            labelMess.Text = gameManager.IsPlayer1Turn ? $"Lượt {PlayerM.playerName}" : "Lượt đối thủ";
            buttonTake.Visible = gameManager.IsPlayer1Turn;
            labelTime.Text = "30s";
        }






        public void StartCountdown()
        {
            timeCount.Start(30);
            labelTime.Text = "30s";
        }


        public void StopCountdown()
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
                selectedBagIndex = bagRockList.IndexOf(bagRockList.FirstOrDefault(bag => bag.GetQuantity() == (int)selectedBagPictureBox.Tag));

                int numRocks = (int)selectedBagPictureBox.Tag;
                MessageBox.Show($"Số lượng sỏi trong túi này: {numRocks}");

                UpdateBagVisibility(false);
                selectedBagPictureBox.Visible = true;

                DisplayRocksInSelectedBag();
                ChoseCoins();
            }
        }


        private void UpdateBagVisibility(bool isVisible)
        {
            foreach (Control control in this.Controls.OfType<PictureBox>())
            {
                if (control != selectedBagPictureBox)
                {
                    control.Visible = isVisible;
                }
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
            DialogResult result = MessageBox.Show("Chọn mặt đồng xu: Sấp?", "Chọn mặt đồng xu", MessageBoxButtons.YesNo);

            string playerChoice = result == DialogResult.Yes ? "Sấp" : "Ngửa";
            string coinResult = CoinFlip.FlipCoin();

            if (coinResult == playerChoice)
            {
                labelMess.Visible = true;
                MessageBox.Show($"Kết quả tung đồng xu là {coinResult}. {PlayerM.playerName} được đi tiếp!");

                StartCountdown();
            }
            else
            {
                MessageBox.Show($"Kết quả tung đồng xu là {coinResult}. Lượt đối thủ.");

                UpdatePlayerTurnLabel();
                gameManager.SwitchTurn(this);

                if (!gameManager.IsPlayer1Turn)
                {
                    // AI chờ ngẫu nhiên từ 2-10 giây trước khi lấy đá
                    Task.Delay(random.Next(2000, 10000)).ContinueWith(_ =>
                    {
                        this.Invoke(new Action(() =>
                        {
                            gameManager.AITurn(selectedBagIndex, this);
                            StartCountdown();
                        }));
                    });
                }
            }
        }



        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void buttonTake_Click(object sender, EventArgs e)
        {
            if (!gameManager.IsPlayer1Turn)
            {
                MessageBox.Show("Không thể lấy sỏi vì đang là lượt của AI.");
                return;
            }

            if (selectedBagIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn túi trước khi lấy đá.");
                return;
            }

            var takeRocksResult = gameManager.TakeRocksFromBag(selectedBagIndex, false, this);

            if (takeRocksResult.TakenRocks > 0)
            {

                UpdateBagQuantityForSelectedBag(selectedBagIndex, takeRocksResult.RemainingRocks);

                RemoveRocksFromUI(takeRocksResult.TakenRocks);

                gameManager.SwitchTurn(this);
                UpdatePlayerTurnLabel();

                if (!gameManager.IsPlayer1Turn)
                {
                    gameManager.AITurn(selectedBagIndex, this);


                }
            }
            else
            {

                MessageBox.Show(takeRocksResult.Message);
            }
        }



        public void UpdateBagQuantityForSelectedBag(int selectedBagIndex, int remainingRocks)
        {

            var selectedBagPictureBox = this.Controls.OfType<PictureBox>()
                .FirstOrDefault(pb => pb.Tag != null && (int)pb.Tag == bagRockList[selectedBagIndex].GetQuantity());

            if (selectedBagPictureBox != null)
            {
                selectedBagPictureBox.Tag = remainingRocks;
            }
        }

        public void RemoveRocksFromUI(int numRocksToRemove)
        {
            for (int i = 0; i < numRocksToRemove && rockPictureBoxes.Count > 0; i++)
            {
                var rockToRemove = rockPictureBoxes.FirstOrDefault();
                if (rockToRemove != null)
                {
                    rockPictureBoxes.Remove(rockToRemove);
                    this.Controls.Remove(rockToRemove);
                    rockToRemove.Dispose();
                }
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            sfxButton.ButtonPressed();
  
            setting.ShowDialog();
                               
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
