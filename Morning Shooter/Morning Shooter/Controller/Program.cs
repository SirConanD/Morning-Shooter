using System;

namespace Morning_Shooter.Controller
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (ShooterGame game = new ShooterGame())
            {
                game.Run();
            }
        }
    }
#endif
}

