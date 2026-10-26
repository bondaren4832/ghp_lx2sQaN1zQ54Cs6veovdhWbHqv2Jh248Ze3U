using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Settings. There is NO sound row, no music row and no volume slider: this build ships
/// without audio, so such a control could never confirm its own action (rules C.20, C.7).
/// Every row here does something the player can see or feel:
///   VIBRATION      - a short buzz on a rescue and on a hit;
///   REDUCE MOTION  - stops the decorative loops and halves every tween;
///   RESET PROGRESS - its own confirm sheet, not a borrowed gameplay popup;
///   VERSION        - the real Application.version.
/// Each toggle confirms itself: the knob slides, the track moves from edge to teal and the
/// caption darkens from the caption colour to ink.
/// </summary>
public sealed class _0xbf3cac6e : MonoBehaviour
{
    [SerializeField]
    private _0xa198a498 _store;
    private void _0xfab3872b(Image _0x61d385b4, RectTransform _0x8c7338de, TMP_Text _0x834a15b7, TMP_Text _0x8d7abcfd, bool _0xa7fcc360, bool _0x0ebaf860)
    {
        if (_0x61d385b4 != null)
        {
            Color _0x584de13a = _0xa7fcc360 ? _0xa567d11e.Teal : _0xa567d11e.Edge;
            if (_0x0ebaf860)
            {
                _0x61d385b4.color = _0x584de13a;
            }
            else
            {
                _0x61d385b4.DOColor(_0x584de13a, 0.11f).SetLink(_0x61d385b4.gameObject);
            }
        }

        if (_0x8c7338de != null)
        {
            float _0xf0538a36 = _0xa7fcc360 ? this._0x69c94b74 : -this._0x69c94b74;
            if (_0x0ebaf860)
            {
                _0x8c7338de.anchoredPosition = new Vector2(_0xf0538a36, _0x8c7338de.anchoredPosition.y);
            }
            else
            {
                _0x8c7338de.DOAnchorPosX(_0xf0538a36, 0.11f).SetEase(Ease.OutQuad).SetLink(_0x8c7338de.gameObject);
            }
        }

        if (_0x834a15b7 != null)
        {
            _0x834a15b7.color = _0xa7fcc360 ? _0xa567d11e.Ink : _0xa567d11e.Caption;
        }

        if (_0x8d7abcfd != null)
        {
            _0x8d7abcfd.text = _0xa7fcc360 ? _0x82e82fcf._0xa3a9d783(new byte[2] { 134, 135 }, 201) : _0x82e82fcf._0xa3a9d783(new byte[3] { 31, 22, 22 }, 80);
            _0x8d7abcfd.color = _0xa7fcc360 ? _0xa567d11e.Value : _0xa567d11e.Caption;
        }
    }

    [SerializeField]
    private Button _confirmYes;
    [SerializeField]
    private RectTransform _motionKnob;
    private void _0xed768e20()
    {
        if (this._confirmGate != null)
        {
            this._confirmGate._0xd34829df(false);
        }
    }

    private bool _0x430dd494;
    [SerializeField]
    private _0x4387ff13 _home;
    [SerializeField]
    private RectTransform _vibrationKnob;
    [SerializeField]
    private Button _resetButton;
    private void _0x7e3e4a29()
    {
        if (this._store == null)
        {
            return;
        }

        this._store._0x42811e0a = !this._store._0x42811e0a;
        this._0xfab3872b(this._motionTrack, this._motionKnob, this._motionCaption, this._motionState, this._store._0x42811e0a, false);
        if (this._home != null)
        {
            this._home._0xf744486d();
        }
    }

    [SerializeField]
    private TMP_Text _vibrationCaption;
    [SerializeField]
    private _0xf7a0106b _confirmGate;
    private void _0x4fc6fa73()
    {
        if (this._store != null)
        {
            this._store._0x6bb4f53e();
        }

        this._0xed768e20();
        this._0xc38c30e5();
        if (this._home != null)
        {
            this._home._0xf744486d();
        }
    }

    private void Start()
    {
        this._0xc38c30e5();
    }

    [SerializeField]
    private TMP_Text _motionCaption;
    private float _0x69c94b74 = 60f;
    [SerializeField]
    private Image _vibrationTrack;
    [SerializeField]
    private TMP_Text _versionLabel;
    [SerializeField]
    private Image _motionTrack;
    private void OnDestroy()
    {
        if (this._vibrationTrack != null)
        {
            DOTween.Kill(this._vibrationTrack);
        }

        if (this._motionTrack != null)
        {
            DOTween.Kill(this._motionTrack);
        }

        if (this._vibrationKnob != null)
        {
            DOTween.Kill(this._vibrationKnob);
        }

        if (this._motionKnob != null)
        {
            DOTween.Kill(this._motionKnob);
        }
    }

    private void _0x20dc2ab2()
    {
        if (this._confirmGate != null)
        {
            this._confirmGate._0xd34829df(true);
        }
    }

    public void _0xc38c30e5()
    {
        this._0xc28aee1f();
        if (this._store == null)
        {
            return;
        }

        this._0xfab3872b(this._vibrationTrack, this._vibrationKnob, this._vibrationCaption, this._vibrationState, this._store._0x0108f2ce, true);
        this._0xfab3872b(this._motionTrack, this._motionKnob, this._motionCaption, this._motionState, this._store._0x42811e0a, true);
    }

    private void _0x73252baf()
    {
        if (this._store == null)
        {
            return;
        }

        this._store._0x0108f2ce = !this._store._0x0108f2ce;
        this._0xfab3872b(this._vibrationTrack, this._vibrationKnob, this._vibrationCaption, this._vibrationState, this._store._0x0108f2ce, false);
        if (this._store._0x0108f2ce)
        {
            Handheld.Vibrate();
        }
    }

    [SerializeField]
    private Button _vibrationButton;
    [SerializeField]
    private TMP_Text _motionState;
    [SerializeField]
    private TMP_Text _vibrationState;
    [SerializeField]
    private Button _motionButton;
    private void _0xc28aee1f()
    {
        if (this._0x430dd494)
        {
            return;
        }

        this._0x430dd494 = true;
        if (this._store != null)
        {
            this._store._0xe422ae80();
        }

        if (this._vibrationTrack != null && this._vibrationKnob != null)
        {
            this._0x69c94b74 = Mathf.Max(20f, this._vibrationTrack.rectTransform.rect.width * 0.5f - this._vibrationKnob.rect.width * 0.5f - 8f);
        }

        if (this._vibrationButton != null)
        {
            this._vibrationButton.onClick.AddListener(() => this._0x73252baf());
        }

        if (this._motionButton != null)
        {
            this._motionButton.onClick.AddListener(() => this._0x7e3e4a29());
        }

        if (this._resetButton != null)
        {
            this._resetButton.onClick.AddListener(() => this._0x20dc2ab2());
        }

        if (this._confirmYes != null)
        {
            this._confirmYes.onClick.AddListener(() => this._0x4fc6fa73());
        }

        if (this._confirmNo != null)
        {
            this._confirmNo.onClick.AddListener(() => this._0xed768e20());
        }

        if (this._confirmGate != null)
        {
            this._confirmGate._0xd34829df(false);
        }

        if (this._versionLabel != null)
        {
            this._versionLabel.text = Application.version;
        }
    }

    [SerializeField]
    private Button _confirmNo;
}

internal static class _0x82e82fcf
{
    internal static string _0xa3a9d783(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}