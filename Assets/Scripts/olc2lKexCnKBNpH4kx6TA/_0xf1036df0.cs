using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The rooster. Owns where it stands (lane index plus a horizontal position in field
/// fractions) and every move it can make: a one-lane hop, a charged two-lane hop, a side
/// step, being carried by a raft, and the stumble and respawn after a hit.
/// Motion is DOTween on anchoredPosition only - no bodies, no gravity model, nothing that
/// a second system could fight over the same transform.
/// </summary>
public sealed class _0xf1036df0 : MonoBehaviour
{
    private float _0x68d08722 = 1f;
    [SerializeField]
    private Image _image;
    private int _0xe456ae83;
    public float _0x3187f274
    {
        get
        {
            return this._0x6d98fe31;
        }
    }

    private const float LongHopTime = 0.26f;
    /// <summary>A hit: stumble, drop back to the given safe lane, then blink for a while.</summary>
    public void _0xd1e8be2e(int _0xf7a01857)
    {
        if (this._rect == null)
        {
            return;
        }

        DOTween.Kill(this._rect);
        this._0x4d743812 = true;
        this._0xe456ae83 = Mathf.Clamp(_0xf7a01857, 0, this._0xd663a78f);
        this._0x6d98fe31 = _0x0bc07320.ColumnX(_0x0bc07320.Columns / 2);
        this._0x87efecc7 = GraceTime;
        Sequence _0x80e46974 = DOTween.Sequence().SetLink(this._rect.gameObject);
        _0x80e46974.Append(this._rect.DOScale(0.7f, this._0xb04faefc(StumbleTime * 0.4f)).SetEase(Ease.OutQuad));
        _0x80e46974.AppendCallback(() => this._0x643d37ca());
        _0x80e46974.Append(this._rect.DOScale(1f, this._0xb04faefc(StumbleTime * 0.6f)).SetEase(Ease.OutBack));
        _0x80e46974.OnComplete(() => this._0x6117fa61());
    }

    private int _0xd663a78f = 1;
    public void _0x88ce4377(Sprite _0xda209f6d, float _0xc402f5cb, float _0xa30e1ed8, int _0x6458cb5b, bool _0x9bfc388a)
    {
        this._0x591fac35 = _0xc402f5cb;
        this._0xd0c3e550 = _0xa30e1ed8;
        this._0xd663a78f = Mathf.Max(1, _0x6458cb5b);
        this._0x137856a2 = _0x9bfc388a;
        this._0x68d08722 = Mathf.Min(_0xa30e1ed8, _0xc402f5cb / _0x0bc07320.Columns) * 0.94f;
        this._0xe456ae83 = 0;
        this._0x6d98fe31 = _0x0bc07320.ColumnX(_0x0bc07320.Columns / 2);
        this._0x87efecc7 = 0f;
        this._0x4d743812 = false;
        if (this._image != null && _0xda209f6d != null)
        {
            this._image.sprite = _0xda209f6d;
        }

        if (this._rect != null)
        {
            this._rect.sizeDelta = new Vector2(this._0x68d08722, this._0x68d08722);
            this._rect.localScale = Vector3.one;
        }

        if (this._chargeMarker != null)
        {
            this._chargeMarker.sizeDelta = new Vector2(this._0x68d08722 * 1.15f, this._0x68d08722 * 0.4f);
            this._chargeMarker.gameObject.SetActive(false);
        }

        this._0x643d37ca();
    }

    private void _0x6117fa61()
    {
        this._0x4d743812 = false;
    }

    private float _0x87efecc7;
    public int _0xc9146478
    {
        get
        {
            return this._0xe456ae83;
        }
    }

    [SerializeField]
    private RectTransform _rect;
    private bool _0x4d743812;
    private float _0x6d98fe31;
    private void _0x643d37ca()
    {
        if (this._rect == null)
        {
            return;
        }

        this._rect.anchoredPosition = new Vector2(this._0x6d98fe31 * this._0x591fac35, (this._0xe456ae83 + 0.5f) * this._0xd0c3e550);
    }

    /// <summary>Raft carry. Applied straight to the position, never queued as a tween, so
    /// it cannot fight the hop that may be running at the same time.</summary>
    public void _0x053d715b(float _0x002bacb1)
    {
        if (this._0x4d743812 || Mathf.Abs(_0x002bacb1) < 0.000001f || this._rect == null)
        {
            return;
        }

        this._0x6d98fe31 = this._0x6d98fe31 + _0x002bacb1;
        this._rect.anchoredPosition = new Vector2(this._0x6d98fe31 * this._0x591fac35, this._rect.anchoredPosition.y);
    }

    private const float StumbleTime = 0.9f;
    private void OnDestroy()
    {
        if (this._rect != null)
        {
            DOTween.Kill(this._rect);
        }
    }

    private const float StepTime = 0.13f;
    private float _0xd0c3e550 = 1f;
    [SerializeField]
    private RectTransform _chargeMarker;
    private float _0x19bf175b;
    public bool _0x5df9f40e(int _0xe3054b65)
    {
        if (this._0x4d743812 || this._rect == null)
        {
            return false;
        }

        int _0x3bf82d06 = Mathf.Clamp(this._0xe456ae83 + Mathf.Max(1, _0xe3054b65), 0, this._0xd663a78f);
        if (_0x3bf82d06 == this._0xe456ae83)
        {
            return false;
        }

        this._0xe456ae83 = _0x3bf82d06;
        this._0x8f2d0a1b(false);
        this._0x4d743812 = true;
        float _0x6a9b5bbe = this._0xb04faefc(_0xe3054b65 >= 2 ? LongHopTime : HopTime);
        float _0x0e2b426a = (this._0xe456ae83 + 0.5f) * this._0xd0c3e550;
        this._rect.DOAnchorPosY(_0x0e2b426a, _0x6a9b5bbe).SetEase(Ease.OutQuad).OnComplete(() => this._0x887a2b8e()).SetLink(this._rect.gameObject);
        return true;
    }

    private bool _0x137856a2;
    private const float GraceTime = 1.5f;
    private float _0xb04faefc(float _0x5bcae4fa)
    {
        return this._0x137856a2 ? _0x5bcae4fa * 0.5f : _0x5bcae4fa;
    }

    private const float HopTime = 0.16f;
    /// <summary>The charged-hop marker two lanes ahead, so a held press reads in a still
    /// frame rather than only in motion (rule C.7).</summary>
    public void _0x8f2d0a1b(bool _0x5fbb3973)
    {
        if (this._chargeMarker != null)
        {
            this._chargeMarker.gameObject.SetActive(_0x5fbb3973 && !this._0x4d743812);
            if (_0x5fbb3973)
            {
                this._chargeMarker.anchoredPosition = new Vector2(0f, this._0xd0c3e550 * 2f);
            }
        }

        if (this._rect != null && !this._0x4d743812)
        {
            float _0xd2cb958f = _0x5fbb3973 ? 0.86f : 1f;
            this._rect.DOScaleY(_0xd2cb958f, this._0xb04faefc(0.16f)).SetLink(this._rect.gameObject);
        }
    }

    private void _0x887a2b8e()
    {
        if (this._rect == null)
        {
            this._0x4d743812 = false;
            return;
        }

        this._rect.localScale = new Vector3(1.12f, 0.9f, 1f);
        this._rect.DOScale(1f, this._0xb04faefc(LandTime)).SetEase(Ease.OutBack).OnComplete(() => this._0x6117fa61()).SetLink(this._rect.gameObject);
    }

    public int _0x391c9f54
    {
        get
        {
            float _0x5784ebf7 = 1f / _0x0bc07320.Columns;
            int _0x07469155 = Mathf.RoundToInt(this._0x6d98fe31 / _0x5784ebf7 + (_0x0bc07320.Columns - 1) * 0.5f);
            return Mathf.Clamp(_0x07469155, 0, _0x0bc07320.Columns - 1);
        }
    }

    public bool _0xfc1027d5
    {
        get
        {
            return this._0x6d98fe31 < -0.55f || this._0x6d98fe31 > 0.55f;
        }
    }

    public bool _0x157b06d1
    {
        get
        {
            return this._0x4d743812;
        }
    }

    private float _0x591fac35 = 1f;
    public bool _0x73cd4f1c(int _0x1ed125ab)
    {
        if (this._0x4d743812 || this._rect == null)
        {
            return false;
        }

        float _0xfd9400d4 = 1f / _0x0bc07320.Columns;
        float _0xb5dd3e70 = _0x0bc07320.ColumnX(_0x0bc07320.Columns - 1);
        float _0x0bebf102 = Mathf.Clamp(this._0x6d98fe31 + _0x1ed125ab * _0xfd9400d4, -_0xb5dd3e70, _0xb5dd3e70);
        if (Mathf.Abs(_0x0bebf102 - this._0x6d98fe31) < 0.0001f)
        {
            return false;
        }

        this._0x6d98fe31 = _0x0bebf102;
        this._0x4d743812 = true;
        this._rect.DOAnchorPosX(this._0x6d98fe31 * this._0x591fac35, this._0xb04faefc(StepTime)).SetEase(Ease.OutQuad).OnComplete(() => this._0x6117fa61()).SetLink(this._rect.gameObject);
        return true;
    }

    private const float LandTime = 0.1f;
    private void Update()
    {
        if (this._0x87efecc7 <= 0f)
        {
            if (this._image != null && this._image.color.a < 0.99f)
            {
                this._image.color = Color.white;
            }

            return;
        }

        this._0x87efecc7 = this._0x87efecc7 - Time.deltaTime;
        this._0x19bf175b = this._0x19bf175b + Time.deltaTime * 12f;
        if (this._image != null)
        {
            float _0xae7e560d = Mathf.Sin(this._0x19bf175b) > 0f ? 1f : 0.45f;
            this._image.color = new Color(1f, 1f, 1f, this._0x87efecc7 > 0f ? _0xae7e560d : 1f);
        }
    }

    public bool _0x101d1604
    {
        get
        {
            return this._0x87efecc7 > 0f;
        }
    }
}