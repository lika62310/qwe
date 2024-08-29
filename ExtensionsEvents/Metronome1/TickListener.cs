using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metronome1
{
    public class TickListener
    {
        public void Subscribe(Metronome metronome)
        {
            metronome.Tick += Heard;
        }

        public void Heard(object sender, EventArgs e)
        {
            Console.WriteLine("Heard you!");
        }
    }
}
