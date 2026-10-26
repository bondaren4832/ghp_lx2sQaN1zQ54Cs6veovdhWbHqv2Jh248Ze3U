using UnityEngine;

/// <summary>
/// The WARM_EARTHY preset with the two accent overrides the brief asks for
/// (primary -> sunset coral, secondary -> highway teal). Every colour used anywhere in
/// this game comes from here, so nothing is picked by eye twice.
/// The shared TMP material carries a CREAM outline, so every text colour below is DARK
/// and every one of them is above 8:1 against that outline (rule C.14).
/// </summary>
public static class _0xa567d11e
{
    public static readonly Color SurfaceAlt = new Color(0.9098039f, 0.8666667f, 0.76862746f, 1f);
    public static readonly Color PrimaryLo = new Color(0.7764706f, 0.2901961f, 0.13333334f, 1f);
    public static readonly Color Primary = new Color(0.9490196f, 0.4117647f, 0.23529412f, 1f);
    public static readonly Color Base = new Color(0.98039216f, 0.9607843f, 0.9254902f, 1f);
    public static Color Fade(Color _0xc0990d31, float _0x54c3805f)
    {
        return new Color(_0xc0990d31.r, _0xc0990d31.g, _0xc0990d31.b, _0x54c3805f);
    }

    public static readonly Color Asphalt = new Color(0.2901961f, 0.2509804f, 0.22352941f, 1f);
    public static readonly Color Value = new Color(0.078431375f, 0.3137255f, 0.28627452f, 1f);
    public static readonly Color Wheat = new Color(0.8901961f, 0.7764706f, 0.41960785f, 1f);
    public static readonly Color Grass = new Color(0.49803922f, 0.6431373f, 0.41960785f, 1f);
    public static readonly Color Cream = new Color(1f, 0.95686275f, 0.9019608f, 1f);
    public static readonly Color Surface = new Color(0.9490196f, 0.91764706f, 0.84705883f, 1f);
    public static readonly Color Shadow = new Color(0.5411765f, 0.3529412f, 0.23529412f, 1f);
    /// <summary>Text colours. All dark: the single font material outlines in cream.</summary>
    public static readonly Color Ink = new Color(0.16862746f, 0.101960786f, 0.078431375f, 1f);
    public static readonly Color Teal = new Color(0.18039216f, 0.6156863f, 0.56078434f, 1f);
    public static readonly Color Edge = new Color(0.84705883f, 0.7882353f, 0.65882355f, 1f);
    public static readonly Color PrimaryHi = new Color(1f, 0.5411765f, 0.35686275f, 1f);
    public static readonly Color Caption = new Color(0.3529412f, 0.25490198f, 0.2f, 1f);
}