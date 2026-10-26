using System;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// One mission node on the journey map. The badge gutter and the text column keep two
/// non-overlapping x bands (rule C.25): the badge is centred at x 96 with a width of 120,
/// and the text column starts at x 232, so the glyphs can never slide under the badge.
/// </summary>
public sealed class _0x84bd5ab1 : MonoBehaviour
{
    private bool _0x5f85a594;
    [SerializeField]
    private Image _plate;
    [SerializeField]
    private Button _button;
    private void Start()
    {
        this._0x1feda66f();
    }

    private Action _0xad90e7b6;
    private const int StateCurrent = 1;
    [SerializeField]
    private TMP_Text _state;
    [SerializeField]
    private TMP_Text _title;
    [SerializeField]
    private TMP_Text _badgeLabel;
    [SerializeField]
    private TMP_Text _goal;
    [SerializeField]
    private RectTransform _card;
    [SerializeField]
    private _0x87d47a0b _stars;
    private const int StateLocked = 2;
    private void _0xa07f7739()
    {
        if (this._0xad90e7b6 != null)
        {
            this._0xad90e7b6();
        }
    }

    private const int StateCleared = 0;
    [SerializeField]
    private Image _badgePlate;
    public void _0x1feda66f()
    {
        if (this._0x5f85a594)
        {
            return;
        }

        this._0x5f85a594 = true;
        if (this._button != null)
        {
            this._button.onClick.AddListener(() => this._0xa07f7739());
        }
    }

    public void _0xc1e1a189(int _0x1d360559, string _0x316214da, string _0xd5787a16, int _0x7ff41c10, int _0x5c710da6, bool _0x3d439d71, Action _0xceed49b1)
    {
        this._0x1feda66f();
        this._0xad90e7b6 = _0xceed49b1;
        if (this._badgeLabel != null)
        {
            this._badgeLabel.text = _0x1d360559.ToString();
        }

        if (this._title != null)
        {
            this._title.text = _0x316214da;
        }

        if (this._goal != null)
        {
            this._goal.text = _0xd5787a16;
        }

        if (this._stars != null)
        {
            this._stars._0xb39bbae0(_0x7ff41c10, _0x3d439d71);
        }

        bool _0x779bfa21 = _0x5c710da6 == StateLocked;
        if (this._plate != null)
        {
            this._plate.color = _0x779bfa21 ? _0xa567d11e.SurfaceAlt : _0xa567d11e.Base;
        }

        if (this._badgePlate != null)
        {
            this._badgePlate.color = _0x5c710da6 == StateCleared ? _0xa567d11e.Teal : (_0x779bfa21 ? _0xa567d11e.Edge : _0xa567d11e.Primary);
        }

        if (this._state != null)
        {
            this._state.text = _0x5c710da6 == StateCleared ? _0x509a97e5._0x2fb37d2a(new byte[7] { 206, 193, 200, 204, 223, 200, 201 }, 141) : (_0x779bfa21 ? _0x509a97e5._0x2fb37d2a(new byte[6] { 54, 53, 57, 49, 63, 62 }, 122) : _0x509a97e5._0x2fb37d2a(new byte[5] { 178, 181, 160, 179, 181 }, 225));
            this._state.color = _0x779bfa21 ? _0xa567d11e.Caption : _0xa567d11e.Value;
        }

        if (this._button != null)
        {
            this._button.interactable = !_0x779bfa21;
        }

        if (this._card == null)
        {
            return;
        }

        DOTween.Kill(this._card);
        this._card.localScale = Vector3.one;
        if (_0x5c710da6 == StateCurrent && !_0x3d439d71)
        {
            this._card.DOScale(1.02f, 1.1f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine).SetLink(this._card.gameObject);
        }
    }

    private void OnDestroy()
    {
        if (this._card != null)
        {
            DOTween.Kill(this._card);
        }
    }
}

internal static class _0x509a97e5
{
    internal static string _0x2fb37d2a(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}