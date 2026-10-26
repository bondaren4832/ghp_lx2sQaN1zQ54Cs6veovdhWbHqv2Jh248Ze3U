using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0xdb393513 : MonoBehaviour
{
    private static void SafeAreaChanged()
    {
        _0xc5e01667 = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private static readonly List<_0xdb393513> _0x5315f546 = new();
    private Canvas _0x2c01897f;
    private RectTransform _0xa175596c;
    private static void OrientationChanged()
    {
        _0xc13b9f83 = Screen.orientation;
        _0xd79c778c.x = Screen.width;
        _0xd79c778c.y = Screen.height;
        _0xc5e01667 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x36b6bbb6.Invoke();
    }

    private static void ResolutionChanged()
    {
        _0xd79c778c.x = Screen.width;
        _0xd79c778c.y = Screen.height;
        _0xc5e01667 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x36b6bbb6.Invoke();
    }

    private static bool _0xdcbec9dc;
    private static void ApplySafeAreaToAll()
    {
        for (int _0x05d1bc3d = 0; _0x05d1bc3d < _0x5315f546.Count; _0x05d1bc3d++)
            _0x5315f546[_0x05d1bc3d]._0x5979947f();
    }

    private static Vector2 _0xd79c778c = Vector2.zero;
    private CanvasScaler _0x557b0661;
    private Vector2 _0x6e3410e5;
    private void _0x5979947f()
    {
        if (this._0xa175596c == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0x44c3cdd1 = Screen.safeArea;
        Vector2 _0x4d6fb12a = _0x44c3cdd1.position;
        Vector2 _0x51619f8e = _0x44c3cdd1.position + _0x44c3cdd1.size;
        _0x4d6fb12a.x /= screenWidth;
        _0x4d6fb12a.y /= screenHeight;
        _0x51619f8e.x /= screenWidth;
        _0x51619f8e.y /= screenHeight;
        this._0xa175596c.anchorMin = _0x4d6fb12a;
        this._0xa175596c.anchorMax = _0x51619f8e;
        this._0xa175596c.offsetMin = Vector2.zero;
        this._0xa175596c.offsetMax = Vector2.zero;
        if (this._0x557b0661 == null)
            return;
        Vector2 _0x8b559146 = _0x51619f8e - _0x4d6fb12a;
        float _0xfdfd2dc6 = 2f - _0x8b559146.x;
        float _0x733dd7f6 = 2f - _0x8b559146.y;
        this._0x557b0661.referenceResolution = this._0x6e3410e5 * new Vector2(_0xfdfd2dc6, _0x733dd7f6);
    }

    private void Update()
    {
        if (_0x5315f546.Count == 0 || _0x5315f546[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0xc13b9f83)
            OrientationChanged();
        if (Screen.safeArea != _0xc5e01667)
            SafeAreaChanged();
        if (Screen.width != _0xd79c778c.x || Screen.height != _0xd79c778c.y)
            ResolutionChanged();
    }

    private static UnityEvent _0x36b6bbb6 = new();
    private void Start()
    {
    }

    private void OnDestroy()
    {
        if (_0x5315f546 != null && _0x5315f546.Contains(this))
            _0x5315f546.Remove(this);
    }

    private RectTransform _0xd9222370;
    private static ScreenOrientation _0xc13b9f83 = ScreenOrientation.LandscapeLeft;
    private void Awake()
    {
        if (!_0x5315f546.Contains(this))
            _0x5315f546.Add(this);
        this._0x2c01897f = this.GetComponent<Canvas>();
        this._0x557b0661 = this.GetComponent<CanvasScaler>();
        if (this._0x557b0661 != null)
            this._0x6e3410e5 = this._0x557b0661.referenceResolution;
        this._0xd9222370 = this.GetComponent<RectTransform>();
        this._0xa175596c = this.transform.Find(_0xbb43f725._0xb784d0b1(new byte[8] { 227, 209, 214, 213, 241, 194, 213, 209 }, 176)) as RectTransform;
        if (!_0xdcbec9dc)
        {
            _0xc13b9f83 = Screen.orientation;
            _0xd79c778c.x = Screen.width;
            _0xd79c778c.y = Screen.height;
            _0xc5e01667 = Screen.safeArea;
            _0xdcbec9dc = true;
        }

        this._0x5979947f();
    }

    private static Rect _0xc5e01667 = Rect.zero;
}

internal static class _0xbb43f725
{
    internal static string _0xb784d0b1(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}