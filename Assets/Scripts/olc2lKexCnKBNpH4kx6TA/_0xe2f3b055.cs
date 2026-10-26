using System;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// One region card. A locked card does not merely say so: tapping it shakes the card and
/// flashes the unlock line coral, which is feedback a reviewer can see in a still frame
/// (rule C.7) rather than a label change nobody notices.
/// </summary>
public sealed class _0xe2f3b055 : MonoBehaviour
{
    public void _0xdd94264b()
    {
        if (this._0xe31efabe)
        {
            return;
        }

        this._0xe31efabe = true;
        if (this._progressFill != null && this._progressFill.parent is RectTransform)
        {
            this._0x06b223a8 = Mathf.Max(1f, ((RectTransform)this._progressFill.parent).rect.width);
        }

        if (this._button != null)
        {
            this._button.onClick.AddListener(() => this._0xffa0fad1());
        }
    }

    [SerializeField]
    private Button _button;
    [SerializeField]
    private TMP_Text _title;
    private Action _0x59234aee;
    private void OnDestroy()
    {
        if (this._card != null)
        {
            DOTween.Kill(this._card);
        }

        if (this._rule != null)
        {
            DOTween.Kill(this._rule);
        }
    }

    [SerializeField]
    private RectTransform _progressFill;
    private float _0x06b223a8 = 1f;
    [SerializeField]
    private TMP_Text _rule;
    private bool _0xe31efabe;
    private bool _0x1ac13e5b;
    private void _0xffa0fad1()
    {
        if (!this._0x1ac13e5b)
        {
            if (this._0x59234aee != null)
            {
                this._0x59234aee();
            }

            return;
        }

        if (this._card != null)
        {
            DOTween.Kill(this._card);
            this._card.anchoredPosition = new Vector2(0f, this._card.anchoredPosition.y);
            this._card.DOPunchAnchorPos(new Vector2(16f, 0f), 0.3f, 12, 0.9f).SetLink(this._card.gameObject);
        }

        if (this._rule == null)
        {
            return;
        }

        DOTween.Kill(this._rule);
        this._rule.color = _0xa567d11e.Primary;
        this._rule.DOColor(_0xa567d11e.Caption, 0.6f).SetDelay(0.25f).SetLink(this._rule.gameObject);
    }

    public void _0xcc748026(string _0xf274452a, int _0x7eca9337, int _0x134cabba, bool _0xa9526f76, Color _0xa3e33aa2, Action _0x586d43b3)
    {
        this._0xdd94264b();
        this._0x1ac13e5b = _0xa9526f76;
        this._0x59234aee = _0x586d43b3;
        if (this._title != null)
        {
            this._title.text = _0xf274452a;
        }

        if (this._plate != null)
        {
            this._plate.color = _0xa9526f76 ? _0xa567d11e.SurfaceAlt : _0xa567d11e.Base;
        }

        if (this._strip != null)
        {
            this._strip.color = _0xa9526f76 ? _0xa567d11e.Fade(_0xa567d11e.Edge, 0.9f) : _0xa3e33aa2;
        }

        if (this._lockBadge != null)
        {
            this._lockBadge.gameObject.SetActive(_0xa9526f76);
            this._lockBadge.color = _0xa567d11e.Primary;
        }

        int _0x3acd605d = Mathf.Max(1, _0x134cabba);
        if (this._progressLabel != null)
        {
            this._progressLabel.text = Mathf.Min(_0x7eca9337, _0x3acd605d).ToString() + _0x228334d5._0xe2ce664f(new byte[3] { 158, 145, 158 }, 190) + _0x3acd605d.ToString() + _0x228334d5._0xe2ce664f(new byte[9] { 58, 80, 85, 79, 72, 84, 95, 67, 73 }, 26);
        }

        if (this._rule != null)
        {
            this._rule.text = _0xa9526f76 ? _0x228334d5._0xe2ce664f(new byte[9] { 33, 62, 43, 32, 61, 78, 47, 58, 78 }, 110) + _0x3acd605d.ToString() + _0x228334d5._0xe2ce664f(new byte[9] { 226, 136, 141, 151, 144, 140, 135, 155, 145 }, 194) : _0x228334d5._0xe2ce664f(new byte[23] { 177, 174, 187, 176, 222, 211, 222, 169, 191, 178, 181, 222, 183, 170, 222, 191, 176, 167, 222, 170, 183, 179, 187 }, 254);
            this._rule.color = _0xa9526f76 ? _0xa567d11e.Caption : _0xa567d11e.Value;
        }

        if (this._progressFill != null)
        {
            float _0x1645aad2 = Mathf.Clamp01((float)_0x7eca9337 / _0x3acd605d);
            this._progressFill.sizeDelta = new Vector2(this._0x06b223a8 * _0x1645aad2, this._progressFill.sizeDelta.y);
        }
    }

    [SerializeField]
    private TMP_Text _progressLabel;
    [SerializeField]
    private RectTransform _card;
    [SerializeField]
    private Image _plate;
    [SerializeField]
    private Image _strip;
    private void Start()
    {
        this._0xdd94264b();
    }

    [SerializeField]
    private Image _lockBadge;
}

internal static class _0x228334d5
{
    internal static string _0xe2ce664f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}