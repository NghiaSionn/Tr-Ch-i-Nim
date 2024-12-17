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
        public List<BagRock> bagRockList;
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

        public TakeRocksResult TakeRocksFromBag(int selectedBagIndex, bool isAI, GameNim gameNim)
        {
            if (selectedBagIndex < 0 || selectedBagIndex >= bagRockList.Count)
            {
                return new TakeRocksResult
                {
                    TakenRocks = 0,
                    RemainingRocks = 0,
                    Message = "Không tìm thấy túi."
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

            string actor = isAI ? "Người Máy" : "Người chơi";

            var result = new TakeRocksResult
            {
                TakenRocks = rocksToTake,
                RemainingRocks = newQuantity,
                Message = $"{actor} đã lấy {rocksToTake} viên sỏi từ túi {selectedBagIndex + 1}. Số lượng còn lại: {newQuantity}."
            };

            gameNim.StopCountdown();
           
            if(MessageBox.Show(result.Message) == DialogResult.OK) gameNim.StartCountdown();


            if (newQuantity == 0)
            {
                gameNim.StopCountdown();
                MessageBox.Show($"{actor} đã lấy hết sỏi từ túi {selectedBagIndex + 1}.");
                gameOver.labelMess.Text = ($"{actor} ĐÃ GIÀNH CHIẾN THẮNG");
                Form1.wplayer.controls.stop();
                gameOver.AudioOver();
                gameOver.Show();
                gameNim.Close();
                
            }

            return result;
        }

        public void SwitchTurn(GameNim gameNim)
        {
            IsPlayer1Turn = !IsPlayer1Turn;
   

            gameNim.UpdatePlayerTurnLabel();
            gameNim.StartCountdown();           
        }


        public void AITurn(int selectedBagIndex, GameNim gameNim)
        {
            if (!IsPlayer1Turn)
            {
                if (selectedBagIndex >= 0 && selectedBagIndex < bagRockList.Count)
                {
                    if (bagRockList[selectedBagIndex].GetQuantity() > 0)
                    {
                        var takeRocksResult = TakeRocksFromBag(selectedBagIndex, true, gameNim);
                        SwitchTurn(gameNim);

                        if (takeRocksResult.TakenRocks > 0)
                        {
                            // Corrected call: Only pass the number of rocks to remove
                            gameNim.RemoveRocksFromUI(takeRocksResult.TakenRocks);
                            gameNim.UpdateBagQuantityForSelectedBag(selectedBagIndex, takeRocksResult.RemainingRocks);
                        }
                        else
                        {
                            gameOver.Show();
                            gameNim.Dispose();
                        }
                    }
                    else
                    {     
                        gameOver.Show();
                        gameNim.Dispose();
                    }
                }
            }
        }
    }
}
