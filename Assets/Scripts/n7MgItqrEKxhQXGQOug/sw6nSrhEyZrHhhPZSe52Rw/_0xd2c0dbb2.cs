using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0xd2c0dbb2 : MonoBehaviour
{
    private void Update()
    {
        if (_0x4efcae33[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x64e0db31)
            OrientationChanged();
        if (Screen.safeArea != _0xa2b58efb)
            SafeAreaChanged();
        if (Screen.width != _0xc8df87c5.x || Screen.height != _0xc8df87c5.y)
            ResolutionChanged();
    }

    private static Rect _0xa2b58efb = Rect.zero;
    private static UnityEvent _0xd0d2012d = new();
    private Canvas _0xdb83e963;
    private RectTransform _0x66f2ccff;
    private void _0xbfad0111()
    {
        if (this._0x66f2ccff == null)
            return;
        Rect _0x0502257e = Screen.safeArea;
        Vector2 _0x3dc045d8 = _0x0502257e.position;
        Vector2 _0xec81d911 = _0x0502257e.position + _0x0502257e.size;
        _0x3dc045d8.x /= this._0xdb83e963.pixelRect.width;
        _0x3dc045d8.y /= this._0xdb83e963.pixelRect.height;
        _0xec81d911.x /= this._0xdb83e963.pixelRect.width;
        _0xec81d911.y /= this._0xdb83e963.pixelRect.height;
        this._0x66f2ccff.anchorMin = _0x3dc045d8;
        this._0x66f2ccff.anchorMax = _0xec81d911;
    }

    private static Vector2 _0xc8df87c5 = Vector2.zero;
    private void Awake()
    {
        if (!_0x4efcae33.Contains(this))
            _0x4efcae33.Add(this);
        this._0xdb83e963 = this.GetComponent<Canvas>();
        this._0xb1f09cde = this.GetComponent<RectTransform>();
        this._0x66f2ccff = this.transform.Find(_0x64aefd39._0x7eb3c044(new byte[8] { 233, 219, 220, 223, 251, 200, 223, 219 }, 186)) as RectTransform;
        if (!_0xcfe44ab7)
        {
            _0x64e0db31 = Screen.orientation;
            _0xc8df87c5.x = Screen.width;
            _0xc8df87c5.y = Screen.height;
            _0xa2b58efb = Screen.safeArea;
            _0xcfe44ab7 = true;
        }

        this._0xbfad0111();
    }

    private static void OrientationChanged()
    {
        _0x64e0db31 = Screen.orientation;
        _0xc8df87c5.x = Screen.width;
        _0xc8df87c5.y = Screen.height;
        _0xd0d2012d.Invoke();
    }

    private void OnDestroy()
    {
        if (_0x4efcae33 != null && _0x4efcae33.Contains(this))
            _0x4efcae33.Remove(this);
    }

    private static bool _0xcfe44ab7;
    private static void ResolutionChanged()
    {
        _0xc8df87c5.x = Screen.width;
        _0xc8df87c5.y = Screen.height;
        _0xd0d2012d.Invoke();
    }

    private static readonly List<_0xd2c0dbb2> _0x4efcae33 = new();
    private static void SafeAreaChanged()
    {
        _0xa2b58efb = Screen.safeArea;
        for (int _0x53683a41 = 0; _0x53683a41 < _0x4efcae33.Count; _0x53683a41++)
            _0x4efcae33[_0x53683a41]._0xbfad0111();
    }

    private RectTransform _0xb1f09cde;
    private static ScreenOrientation _0x64e0db31 = ScreenOrientation.LandscapeLeft;
}

internal static class _0x64aefd39
{
    internal static string _0x7eb3c044(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}