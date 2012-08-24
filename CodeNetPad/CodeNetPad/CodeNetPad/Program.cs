using System;

namespace CodeNetPad
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (CodeNetPad game = new CodeNetPad())
            {
                game.Run();
            }
        }
    }
#endif
}

