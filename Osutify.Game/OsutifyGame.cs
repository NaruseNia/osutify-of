using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.IO.Stores;
using osu.Framework.Screens;
using Osutify.Resources;

namespace Osutify.Game;

public partial class OsutifyGame : OsutifyGameBase
{
    private ScreenStack screenStack;

    [BackgroundDependencyLoader]
    private void load()
    {
        Resources.AddStore(new DllResourceStore(OsutifyResources.ResourceAssembly));
        {
            initializeFonts();
        }

        Child = screenStack = new ScreenStack { RelativeSizeAxes = Axes.Both };
    }

    private void initializeFonts()
    {
        AddFont(Resources, @"Fonts/Torus/Torus-Light");
        AddFont(Resources, @"Fonts/Torus/Torus-Regular");
        AddFont(Resources, @"Fonts/Torus/Torus-SemiBold");
        AddFont(Resources, @"Fonts/Torus/Torus-Bold");

        AddFont(Resources, @"Fonts/MPLUSRounded/MPLUSRounded-Regular");
        AddFont(Resources, @"Fonts/MPLUSRounded/MPLUSRounded-Semibold");
    }

    protected override void LoadComplete()
    {
        base.LoadComplete();

        screenStack.Push(new MainScreen());
    }
}
