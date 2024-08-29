namespace Metronome1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Metronome metronome = new Metronome();
            TickListener tickListener = new TickListener();
            metronome.Tick += Metronome_Tick;
            tickListener.Subscribe(metronome);

            metronome.Start();

            Console.ReadLine();

        }

        private static void Metronome_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Tik.");
        }
    }
}
