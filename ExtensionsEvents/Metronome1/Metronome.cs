using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metronome1
{
    public class Metronome
    {
        public event EventHandler Tick;

        public void Start()
        {
            for (int i = 0; i < 5;  i++) 
            {
                Thread.Sleep(3000);
                OnTick();
            }
        }

        protected virtual void OnTick() 
        {
            Tick?.Invoke(this, EventArgs.Empty);
        }
    }
}
