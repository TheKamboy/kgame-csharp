using Mindmagma.Curses;
using System;

namespace kgame_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var Screen = NCurses.InitScreen();
            NCurses.NoDelay(Screen, true);
            NCurses.NoEcho();
        }
    }
}
