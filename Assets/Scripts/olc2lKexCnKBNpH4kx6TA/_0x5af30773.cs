using System;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The card every popup of this game wears: badge, three lines of wording, an optional
/// star row and two action buttons plus a close cross. The cross carries a real sprite
/// assigned through a serialized field - an Image with no sprite ships as a solid white
/// square, which is exactly the defect rule B.1 and C.3 are about.
/// Every button gets its OWN caption; the cross gets none (rule C.17).
/// </summary>
public sealed class _0x5af30773 : MonoBehaviour
{
    public void _0x4bd1ca36(Sprite _0x457cdec9, Color _0xed453cb2)
    {
        if (this._badge == null)
        {
            return;
        }

        this._badge.gameObject.SetActive(_0x457cdec9 != null);
        this._badge.sprite = _0x457cdec9;
        this._badge.color = _0xed453cb2;
    }

    public void _0x172d9c65()
    {
        if (this._0xb378bb9f)
        {
            return;
        }

        this._0xb378bb9f = true;
        if (this._closeIcon != null && this._closeSprite != null)
        {
            this._closeIcon.sprite = this._closeSprite;
            this._closeIcon.color = _0xa567d11e.Ink;
        }

        if (this._leftButton != null)
        {
            this._leftButton.onClick.AddListener(() => this._0x9b0a81a8());
        }

        if (this._rightButton != null)
        {
            this._rightButton.onClick.AddListener(() => this._0xd05d50da());
        }

        if (this._closeButton != null)
        {
            this._closeButton.onClick.AddListener(() => this._0xe35de1c4());
        }
    }

    private void _0xd05d50da()
    {
        if (this._0xd5f25778 != null)
        {
            this._0xd5f25778();
        }
    }

    [SerializeField]
    private TMP_Text _main;
    public void _0xf539f8b2(int _0x559fdcc3, bool _0x36985846)
    {
        if (this._starHost != null)
        {
            this._starHost.SetActive(_0x559fdcc3 >= 0);
        }

        if (_0x559fdcc3 >= 0 && this._starRow != null)
        {
            this._starRow._0xb39bbae0(_0x559fdcc3, _0x36985846);
        }
    }

    private bool _0xb378bb9f;
    public void _0x0edf0b10(Action _0x9db141e6)
    {
        this._0x22c688cc = _0x9db141e6;
    }

    [SerializeField]
    private Button _leftButton;
    [SerializeField]
    private GameObject _starHost;
    public void _0xb043f903(string _0x6e33024d, string _0x3e3342a9, string _0xaf321e17)
    {
        if (this._header != null)
        {
            this._header.text = _0x6e33024d;
        }

        if (this._main != null)
        {
            this._main.text = _0x3e3342a9;
        }

        if (this._extra != null)
        {
            this._extra.text = _0xaf321e17;
        }
    }

    public void _0xe4fe36d1(string _0x95c11405, Action _0x4f12d64a)
    {
        this._0xaf636c8e = _0x4f12d64a;
        if (this._leftLabel != null)
        {
            this._leftLabel.text = _0x95c11405;
        }

        if (this._leftButton != null)
        {
            this._leftButton.gameObject.SetActive(!string.IsNullOrEmpty(_0x95c11405));
        }
    }

    [SerializeField]
    private Button _rightButton;
    [SerializeField]
    private Sprite _closeSprite;
    private Action _0x22c688cc;
    public void _0xbbb6ec70(string _0xa6653789, Action _0x11f3a4c9)
    {
        this._0xd5f25778 = _0x11f3a4c9;
        if (this._rightLabel != null)
        {
            this._rightLabel.text = _0xa6653789;
        }

        if (this._rightButton != null)
        {
            this._rightButton.gameObject.SetActive(!string.IsNullOrEmpty(_0xa6653789));
        }
    }

    [SerializeField]
    private TMP_Text _leftLabel;
    [SerializeField]
    private TMP_Text _extra;
    [SerializeField]
    private TMP_Text _header;
    [SerializeField]
    private TMP_Text _rightLabel;
    private void _0xe35de1c4()
    {
        if (this._0x22c688cc != null)
        {
            this._0x22c688cc();
            return;
        }

        if (_0x498f87d1.Instance != null)
        {
            _0x498f87d1.Instance._0x6c5bed12();
        }
    }

    [SerializeField]
    private Image _closeIcon;
    private Action _0xaf636c8e;
    [SerializeField]
    private RectTransform _card;
    [SerializeField]
    private _0x87d47a0b _starRow;
    private void _0x9b0a81a8()
    {
        if (this._0xaf636c8e != null)
        {
            this._0xaf636c8e();
        }
    }

    private void OnDestroy()
    {
        if (this._card != null)
        {
            DOTween.Kill(this._card);
        }
    }

    public void _0x751475c6(bool _0x02b60ba1)
    {
        if (this._card == null)
        {
            return;
        }

        this._card.localScale = Vector3.one * 0.9f;
        this._card.DOScale(1f, _0x02b60ba1 ? 0.12f : 0.26f).SetEase(Ease.OutBack).SetLink(this._card.gameObject);
    }

    [SerializeField]
    private Image _badge;
    [SerializeField]
    private Button _closeButton;
    private Action _0xd5f25778;
    private void Start()
    {
        this._0x172d9c65();
    }
}