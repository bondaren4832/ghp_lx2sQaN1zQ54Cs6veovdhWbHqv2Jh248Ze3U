using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

/// <summary>
/// Reads taps through the new Input System only. The template InputController declares
/// both its Instance field and every touch helper as private, so they cannot be called
/// from here; EnhancedTouch is the same API those helpers use, and gating on
/// BasicController.IsGameRunning reproduces exactly what their guard did - which is also
/// what makes a raised popup really stop play.
///
/// Zones (fractions of screen width, only below the HUD):
///   left   0.00 - 0.28   step one column left
///   centre 0.28 - 0.72   short press hops one lane, a held press hops two
///   right  0.72 - 1.00   step one column right
/// </summary>
public sealed class _0xb24cef90 : MonoBehaviour
{
    [SerializeField]
    private _0x51e8ccc0 _director;
    private void OnEnable()
    {
        EnhancedTouchSupport.Enable();
    }

    private bool _0x8f2350b7(float _0xfd678211)
    {
        return _0xfd678211 >= LeftEdge && _0xfd678211 <= RightEdge;
    }

    private float _0x376ee5bc;
    private const float HoldSeconds = 0.3f;
    private void Update()
    {
        if (this._director == null)
        {
            return;
        }

        if (_0x2755d8a9.Instance == null || !_0x2755d8a9.Instance._0xde008afc)
        {
            this._0xc122ebff();
            return;
        }

        foreach (Touch _0x0a78e60e in Touch.activeTouches)
        {
            Vector2 _0xe294bf4f = _0x0a78e60e.screenPosition;
            float _0x4332f253 = Screen.width > 0 ? _0xe294bf4f.x / Screen.width : 0.5f;
            float _0xb0786607 = Screen.height > 0 ? _0xe294bf4f.y / Screen.height : 0.5f;
            if (_0x0a78e60e.phase == TouchPhase.Began)
            {
                if (_0xb0786607 > HudCeiling)
                {
                    continue;
                }

                this._0xa5fda970 = true;
                this._0xaf3b1da0 = _0x0a78e60e.touchId;
                this._0xf50a724d = Time.unscaledTime;
                this._0x376ee5bc = _0x4332f253;
                this._0x53298947 = false;
                continue;
            }

            if (!this._0xa5fda970 || _0x0a78e60e.touchId != this._0xaf3b1da0)
            {
                continue;
            }

            if (_0x0a78e60e.phase == TouchPhase.Canceled)
            {
                this._0xc122ebff();
                continue;
            }

            if (_0x0a78e60e.phase == TouchPhase.Ended)
            {
                float _0xedd7798d = Time.unscaledTime - this._0xf50a724d;
                this._0xa5fda970 = false;
                this._0xc122ebff();
                this._director._0x7a2c44ad(this._0xcc07a614(this._0x376ee5bc, _0xedd7798d));
                continue;
            }

            bool _0x76fe37e6 = this._0x8f2350b7(this._0x376ee5bc) && Time.unscaledTime - this._0xf50a724d >= HoldSeconds;
            if (_0x76fe37e6 && !this._0x53298947)
            {
                this._0x53298947 = true;
                this._director._0xa4cc2ac1(true);
            }
        }
    }

    private const float HudCeiling = 0.82f;
    private const float RightEdge = 0.72f;
    private bool _0x53298947;
    private bool _0xa5fda970;
    private int _0xaf3b1da0;
    private int _0xcc07a614(float _0x5f42c29e, float _0xca91e6b7)
    {
        if (_0x5f42c29e < LeftEdge)
        {
            return -1;
        }

        if (_0x5f42c29e > RightEdge)
        {
            return 1;
        }

        return _0xca91e6b7 >= HoldSeconds ? 2 : 0;
    }

    private void _0xc122ebff()
    {
        if (!this._0x53298947)
        {
            return;
        }

        this._0x53298947 = false;
        if (this._director != null)
        {
            this._director._0xa4cc2ac1(false);
        }
    }

    private float _0xf50a724d;
    private const float LeftEdge = 0.28f;
}