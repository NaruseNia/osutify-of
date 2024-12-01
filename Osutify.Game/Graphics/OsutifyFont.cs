using osu.Framework.Graphics.Sprites;

namespace Osutify.Game.Graphics;

public static class OsutifyFont
{
    public const float DEFAULT_FONT_SIZE = 16.0f;

    public static FontUsage Default => GetFont();
    public static FontUsage Torus => GetFont(Typeface.Torus, weight: FontWeight.Regular);
    public static FontUsage TorusM => GetFont();

    public static FontUsage GetFont(Typeface typeface = Typeface.TorusM, float size = DEFAULT_FONT_SIZE, FontWeight weight = FontWeight.Regular, bool italics = false, bool fixedWidth = false)
    {
        return new FontUsage(GetFontFamilyName(typeface), size, weight.ToString(), italics, fixedWidth);
    }

    public static string GetWeightName(string family, FontWeight weight)
    {
        return weight.ToString();
    }

    public static string GetFontFamilyName(Typeface typeface)
    {
        return typeface switch
        {
            Typeface.Torus => @"Torus",
            Typeface.TorusM => @"TorusM",
            _ => null
        };
    }
}

public enum FontWeight
{
    Light = 300,
    Regular = 400,
    SemiBold = 600
}

public enum Typeface
{
    Torus,
    TorusM
}
