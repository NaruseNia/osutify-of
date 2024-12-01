using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Screens;
using Osutify.Game.Graphics;
using osuTK.Graphics;

namespace Osutify.Game;

public partial class MainScreen : Screen
{
    [BackgroundDependencyLoader]
    private void load()
    {
        InternalChildren = new Drawable[]
        {
            new Box
            {
                Colour = Color4.Violet,
                RelativeSizeAxes = Axes.Both
            },
            new SpriteText
            {
                Y = 20,
                Text = "Main Screenだよ",
                Anchor = Anchor.TopCentre,
                Origin = Anchor.TopCentre,
                Font = OsutifyFont.Default.With(size: 40)
            },
            new SpinningBox
            {
                Anchor = Anchor.Centre
            }
        };
    }
}
