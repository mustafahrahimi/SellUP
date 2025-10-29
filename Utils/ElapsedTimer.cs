using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellUp.Utils
{
    public class ElapsedTimer
    {
        private System.Windows.Forms.Timer timer;
        private int seconds;

        public event EventHandler<int> SecondsElapsed;

        public ElapsedTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += (s, e) =>
            {
                seconds++;
                SecondsElapsed?.Invoke(this, seconds);
            };
        }
        public void Start() => timer.Start();
        public void Stop() => timer.Stop();
    }
}
