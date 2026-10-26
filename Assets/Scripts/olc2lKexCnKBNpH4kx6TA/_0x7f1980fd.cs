using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The splash. Branding is an ABSTRACT mark only - a coral road-sign lozenge with a cream
/// feather notch, no letters and no app name anywhere (HARD RULE 1).
/// A cocoa scrim that exists only here makes this frame read as a different screen from
/// the village behind it, and the template loading bar is themed to the palette: coral
/// fill over a dark track with real alpha, which the template leaves nearly invisible.
/// The bar is NOT resized - shrinking its root is what collapsed the fill area on
/// ANDROID-3578.
/// </summary>
public sealed class _0x7f1980fd : MonoBehaviour
{
    [SerializeField]
    private Image _glow;
    private void Start()
    {
        if (this._scrim != null)
        {
            this._scrim.color = _0xa567d11e.Fade(_0xa567d11e.Ink, 0.55f);
        }

        this._0x75b260e7();
        this._0xbfef14f3();
    }

    [SerializeField]
    private Image _scrim;
    private void _0x75b260e7()
    {
        if (_0x6fd584ac.Instance == null || _0x6fd584ac.Instance.AnimationSlider == null)
        {
            return;
        }

        Slider _0x292edd04 = _0x6fd584ac.Instance.AnimationSlider;
        Image _0x5e3f8642 = _0x292edd04.fillRect != null ? _0x292edd04.fillRect.GetComponent<Image>() : null;
        if (_0x5e3f8642 != null)
        {
            _0x5e3f8642.color = _0xa567d11e.Primary;
        }

        Image[] _0x25fe3b46 = _0x292edd04.GetComponentsInChildren<Image>(true);
        for (int _0x928cba4e = 0; _0x928cba4e < _0x25fe3b46.Length; _0x928cba4e++)
        {
            if (_0x25fe3b46[_0x928cba4e] == _0x5e3f8642)
            {
                continue;
            }

            _0x25fe3b46[_0x928cba4e].color = _0xa567d11e.Fade(_0xa567d11e.Ink, 0.45f);
        }
    }

    private void OnDestroy()
    {
        if (this._emblem != null)
        {
            DOTween.Kill(this._emblem);
        }

        if (this._glow != null)
        {
            DOTween.Kill(this._glow);
        }
    }

    private void _0xbfef14f3()
    {
        if (this._emblem != null)
        {
            this._emblem.localScale = Vector3.one * 0.86f;
            this._emblem.DOScale(1f, 0.7f).SetEase(Ease.OutBack).SetLink(this._emblem.gameObject);
            this._emblem.DOScale(1.03f, 2f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine).SetDelay(0.7f).SetLink(this._emblem.gameObject);
        }

        if (this._glow != null)
        {
            this._glow.color = _0xa567d11e.Fade(_0xa567d11e.Primary, 0.14f);
            this._glow.DOFade(0.32f, 1.3f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine).SetLink(this._glow.gameObject);
        }
    }

    [SerializeField]
    private RectTransform _emblem;
}