using osu.Framework.Platform;
using osu.Framework;
using Osutify.Game;

namespace Osutify.Desktop
{
    public static class Program
    {
        public static void Main()
        {
            using GameHost host = Host.GetSuitableDesktopHost(@"Osutify");
            using osu.Framework.Game game = new OsutifyGame();
            host.Run(game);
        }
    }
}
