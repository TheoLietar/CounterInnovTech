using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace InnovTechExercice.Data
{
    public class TimerService
    {
        public Timer Timer { get; set; }
        public int Current { get; set; } = 30;
        public Action Handler { get; set; }

        public TimerService()
        {
            this.Timer = new Timer(this.OnTimedEvent, null, 0, 2000);
        }

        public void Decrement()
        {
            this.Current--;
        }

        private void OnTimedEvent(Object source)
        {
            if (this.Handler != null) this.Handler.Invoke();
        }
    }
}
