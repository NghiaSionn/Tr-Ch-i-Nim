using LuuBichNguyen.Model;
using LuuBichNguyen.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuuBichNguyen.Service
{
    public class GameManager
    {
        private List<BagRock> bagRockList;
        private Random random = new Random();
        public bool IsPlayer1Turn { get; private set; } = true;


        public GameManager(List<BagRock> bags)
        {
            bagRockList = bags;
        }

        public class TakeRocksResult
        {
            public int TakenRocks { get; set; }
            public int RemainingRocks { get; set; }
            public string Message { get; set; }
        }

        public TakeRocksResult TakeRocksFromBag(BagRock bag)
        {
            if (bag.GetQuantity() <= 0)
            {
                return new TakeRocksResult
                {
                    TakenRocks = 0,
                    RemainingRocks = 0,
                    Message = "Không còn sỏi trong túi này."
                };
            }

            // Random số lượng sỏi được lấy (từ 1 đến số lượng hiện có)
            int rocksToTake = random.Next(1, bag.GetQuantity() + 1);

            // Cập nhật số lượng còn lại
            int newQuantity = bag.GetQuantity() - rocksToTake;
            bag.SetQuantity(newQuantity);

            return new TakeRocksResult
            {
                TakenRocks = rocksToTake,
                RemainingRocks = newQuantity,
                Message = $"Đã lấy {rocksToTake} viên sỏi. Số lượng còn lại: {newQuantity}."
            };
        }


        public void RemoveRocksFromBag(BagRock bag, Control.ControlCollection controls)
        {
            // Lấy danh sách các PictureBox đại diện cho túi đá hiện tại
            var rocksToRemove = controls.OfType<PictureBox>()
                .Where(p => p.Tag != null && (int)p.Tag == bag.GetQuantity());

            // Xóa các PictureBox tương ứng khỏi giao diện
            foreach (var rock in rocksToRemove)
            {
                controls.Remove(rock);
                rock.Dispose();
            }
        }


        public bool CheckGameOver()
        {
            return bagRockList.All(bag => bag.GetQuantity() == 0);
        }
        public void SwitchTurn()
        {
            IsPlayer1Turn = !IsPlayer1Turn;
        }

        public void AiTakeTurn(Form parentForm)
        {
            Task.Run(async () =>
            {
                
                int delayTime = random.Next(1000, 10000);  
                await Task.Delay(delayTime);

                var availableBags = bagRockList.Where(bag => bag.GetQuantity() > 0).ToList();

                if (availableBags.Count == 0)
                {
                    MessageBox.Show("Không còn túi sỏi!");
                    return;
                }

                var randomBag = availableBags[random.Next(availableBags.Count)];

                parentForm.Invoke(new Action(() =>
                {
                    MessageBox.Show($"AI đã chọn túi với {randomBag.GetQuantity()} viên sỏi.");
                    var result = TakeRocksFromBag(randomBag);

                    if (result.TakenRocks > 0)
                    {
                        MessageBox.Show($"AI đã lấy {result.TakenRocks} viên sỏi.");

                        if (CheckGameOver())
                        {
                            MessageBox.Show("Trò chơi kết thúc! AI thắng!");
                            parentForm.Close();
                            return;
                        }

                        SwitchTurn();
                        ((GameNim)parentForm).UpdatePlayerTurnLabel();
                    }
                }));
            });
        }

    }
}
