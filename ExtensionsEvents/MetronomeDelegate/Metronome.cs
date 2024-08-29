//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MetronomeDelegate
//{
//    public class Metronome
//    {
//        public delegate void Tick();

//        public void Start()
//        {
//            for (int i = 0; i < 5;  i++) 
//            {
//                Thread.Sleep(3000);
//                Tick TickTock += Metronome_Tick;
//                //OnTick();
//            }
//        }

//        //protected virtual void OnTick() 
//        //{
//        //    Tick?.Invoke(this, EventArgs.Empty);
//        //}
//    }
//}
