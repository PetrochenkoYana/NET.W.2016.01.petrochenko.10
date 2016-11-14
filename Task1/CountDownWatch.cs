using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    public class CountDownWatch
    {
        private int time;

        public CountDownWatch(int time)
        {
            this.time = time;
        }

        public void CountDown()
        {
            Thread.Sleep(time);
            TimeIsOver?.Invoke(this,new CountDownEventArgs("Time is over"));
        }

        public event EventHandler<CountDownEventArgs> TimeIsOver;
    }
}
