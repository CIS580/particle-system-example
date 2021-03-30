using System;

namespace ParticleSystemExample
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new ParticleSystemExampleGame())
                game.Run();
        }
    }
}
