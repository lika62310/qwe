//namespace MetronomeDelegate
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");
//            Metronome metronome = new Metronome();
//            TickListener tickListener = new TickListener();
            
//            metronome.Tick TickTock += Metronome_Tick;
//            tickListener.Subscribe(metronome);

//            metronome.Start();

//            Console.ReadLine();

//        }

//        private static void Metronome_Tick()
//        { 
//            Console.WriteLine("Tik.");
//        }
//    }
//}
