using System;
using System.Windows.Forms;

namespace LuuBichNguyen.Service
{
    public class TimeCount
    {
        private int timeRemaining; 
        private System.Windows.Forms.Timer timer;       


        public event Action<int> TimeUpdated; 
        public event Action CountdownFinished; 

        public TimeCount(int initialTime)
        {
            timeRemaining = initialTime;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 giây
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (timeRemaining > 0)
            {
                timeRemaining--;
                TimeUpdated?.Invoke(timeRemaining); 
            }
            else
            {
                timer.Stop();
                CountdownFinished?.Invoke(); 
            }
        }

        public void Start(int time)
        {
            timeRemaining = time; 
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }
    }
}
