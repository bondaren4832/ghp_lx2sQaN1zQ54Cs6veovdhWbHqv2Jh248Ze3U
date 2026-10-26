using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0xa3b4dff5 : MonoBehaviour
{
    private bool _0x6a097144(Touch? _0x24b02da4)
    {
        if (!_0x24b02da4.HasValue)
            return false;
        Vector3 _0xd7576974 = Camera.main.ScreenToWorldPoint(_0x24b02da4.Value.screenPosition);
        Vector3 _0xff352fe9 = _0xd7576974;
        _0xff352fe9.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0xff352fe9))
            return true;
        _0x24b02da4 = null;
        return false;
    }

    private Touch? _0x7fa55c7f(Bounds _0x2461dcb2)
    {
        if (!_0x2755d8a9.Instance._0xde008afc)
            return null;
        foreach (Touch _0x5be9e518 in Touch.activeTouches)
            if (_0x5be9e518.ended)
            {
                Vector3 _0xbbf0c725 = Camera.main.ScreenToWorldPoint(_0x5be9e518.screenPosition);
                Vector3 _0x934c8325 = new(_0xbbf0c725.x, _0xbbf0c725.y, _0x2461dcb2.center.z);
                if (_0x2461dcb2.Contains(_0x934c8325) && this._0x6a097144(_0x5be9e518))
                    return _0x5be9e518;
            }

        return null;
    }

    private Touch? _0x49781e41(Bounds _0x36cc2f1b)
    {
        if (!_0x2755d8a9.Instance._0xde008afc)
            return null;
        foreach (Touch _0x8b3360c5 in Touch.activeTouches)
            if (!_0x8b3360c5.ended)
            {
                Vector3 _0xbb15284c = Camera.main.ScreenToWorldPoint(_0x8b3360c5.screenPosition);
                Vector3 _0x21fe8208 = new(_0xbb15284c.x, _0xbb15284c.y, _0x36cc2f1b.center.z);
                if (_0x36cc2f1b.Contains(_0x21fe8208) && this._0x6a097144(_0x8b3360c5))
                    return _0x8b3360c5;
            }

        return null;
    }

    private Touch? _0x3fe78456()
    {
        if (!_0x2755d8a9.Instance._0xde008afc)
            return null;
        foreach (Touch _0xe9fc17b8 in Touch.activeTouches)
            if (_0xe9fc17b8.ended)
                if (this._0x6a097144(_0xe9fc17b8))
                    return _0xe9fc17b8;
        return null;
    }

    private Touch? _0x1ca217b6()
    {
        if (!_0x2755d8a9.Instance._0xde008afc)
            return null;
        foreach (Touch _0xb90c5a1f in Touch.activeTouches)
            if (!_0xb90c5a1f.ended)
                if (this._0x6a097144(_0xb90c5a1f))
                    return _0xb90c5a1f;
        return null;
    }

    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0xd0076b20 = this.gameObject.GetComponent<_0xa3b4dff5>();
    }

    private static _0xa3b4dff5 _0xd0076b20;
    private void _0x3b055ac2(Touch? _0x8ce55e37)
    {
        if (!_0x2755d8a9.Instance._0xde008afc)
        {
            _0x8ce55e37 = null;
            return;
        }

        int _0xd7be685a = _0x8ce55e37.Value.touchId;
        _0x8ce55e37 = Touch.activeTouches.FirstOrDefault(_0xca27d89d => _0xca27d89d.touchId == _0xd7be685a);
        if (!this._0x6a097144(_0x8ce55e37.Value))
            _0x8ce55e37 = null;
    }

    public BoxCollider2D CameraTouchBounds;
    private bool _0x177f5fe3(Touch? _0xb2e6988d, Bounds _0x7c605984, TouchPhase _0xca4aade0)
    {
        if (!_0x2755d8a9.Instance._0xde008afc)
        {
            _0xb2e6988d = null;
            return false;
        }

        if (_0xb2e6988d != null)
            if (_0xb2e6988d.Value.phase == _0xca4aade0)
            {
                Vector3 _0x55c92696 = Camera.main.ScreenToWorldPoint(_0xb2e6988d.Value.screenPosition);
                Vector3 _0x784a57e3 = new(_0x55c92696.x, _0x55c92696.y, _0x7c605984.center.z);
                if (_0x7c605984.Contains(_0x784a57e3) && this._0x6a097144(_0xb2e6988d.Value))
                    return true;
            }

        return false;
    }

    private Touch? _0x7f1e5343(Bounds _0x1a0a12b9, TouchPhase _0xc5b9b267)
    {
        if (!_0x2755d8a9.Instance._0xde008afc)
            return null;
        foreach (Touch _0x0dd118dd in Touch.activeTouches)
            if (_0x0dd118dd.phase == _0xc5b9b267)
            {
                Vector3 _0x71d02d49 = Camera.main.ScreenToWorldPoint(_0x0dd118dd.screenPosition);
                Vector3 _0x44f8d5f5 = new(_0x71d02d49.x, _0x71d02d49.y, _0x1a0a12b9.center.z);
                if (_0x1a0a12b9.Contains(_0x44f8d5f5) && this._0x6a097144(_0x0dd118dd))
                    return _0x0dd118dd;
            }

        return null;
    }
}