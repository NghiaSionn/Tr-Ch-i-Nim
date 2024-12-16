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
        GameOver gameOver = new GameOver();
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

        public TakeRocksResult TakeRocksFromBag(int selectedBagIndex)
        {
            if (selectedBagIndex < 0 || selectedBagIndex >= bagRockList.Count)
            {
                return new TakeRocksResult
                {
                    TakenRocks = 0,
                    RemainingRocks = 0,
                    Message = "Không tìm thấy túi đá."
                };
            }

            var bag = bagRockList[selectedBagIndex];

            if (bag.GetQuantity() <= 0)
            {
                return new TakeRocksResult
                {
                    TakenRocks = 0,
                    RemainingRocks = 0,
                    Message = "Không còn sỏi trong túi này."
                };
            }

            int rocksToTake = random.Next(1, bag.GetQuantity() + 1);
            int newQuantity = bag.GetQuantity() - rocksToTake;
            bag.SetQuantity(newQuantity);

            return new TakeRocksResult
            {
                TakenRocks = rocksToTake,
                RemainingRocks = newQuantity,
                Message = $"AI đã lấy {rocksToTake} viên sỏi từ túi {selectedBagIndex + 1}. Số lượng còn lại: {newQuantity}."
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
            gameOver.Show();
            
        }
        public void SwitchTurn()
        {
            IsPlayer1Turn = !IsPlayer1Turn;
        }

        public void AITurn(int selectedBagIndex, Form parentForm)
        {
            // Lấy đá từ túi được người chơi chọn
            var result = TakeRocksFromBag(selectedBagIndex);

            if (result.TakenRocks > 0)
            {
                MessageBox.Show($"AI đã lấy {result.TakenRocks} viên sỏi từ túi {selectedBagIndex + 1}. Số lượng còn lại trong túi: {result.RemainingRocks}.");

                // Kiểm tra kết thúc trò chơi
                if (CheckGameOver())
                {
                    MessageBox.Show("Trò chơi kết thúc! AI thắng!");
                    parentForm.Close();
                    return;
                }

                // Chuyển lượt sang người chơi
                SwitchTurn();
            }
            else
            {
                MessageBox.Show("Túi đã hết sỏi nhỏ để lấy!");
            }
        }



    }
}
