using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Three result stars that pop in one after another. Earned stars take the coral accent,
/// the rest the muted surface edge, so the score reads in a still frame.
/// </summary>
public sealed class _0x87d47a0b : MonoBehaviour
{
    [SerializeField]
    private Image[] _stars;
    public void _0xb39bbae0(int _0xf5d50e25, bool _0x3fd22da8)
    {
        if (this._stars == null)
        {
            return;
        }

        for (int _0xf5f66a98 = 0; _0xf5f66a98 < this._stars.Length; _0xf5f66a98++)
        {
            Image _0xc6b2a3bb = this._stars[_0xf5f66a98];
            if (_0xc6b2a3bb == null)
            {
                continue;
            }

            bool _0xc6a5f4e4 = _0xf5f66a98 < _0xf5d50e25;
            _0xc6b2a3bb.color = _0xc6a5f4e4 ? _0xa567d11e.Primary : _0xa567d11e.Fade(_0xa567d11e.Edge, 0.8f);
            _0xc6b2a3bb.transform.localScale = _0xc6a5f4e4 ? Vector3.one * 0.4f : Vector3.one;
            if (!_0xc6a5f4e4)
            {
                continue;
            }

            float _0xd3b16836 = _0x3fd22da8 ? _0xf5f66a98 * 0.045f : _0xf5f66a98 * 0.09f;
            _0xc6b2a3bb.transform.DOScale(1f, _0x3fd22da8 ? 0.12f : 0.24f).SetEase(Ease.OutBack).SetDelay(_0xd3b16836).SetLink(_0xc6b2a3bb.gameObject);
        }
    }

    private void OnDestroy()
    {
        if (this._stars == null)
        {
            return;
        }

        for (int _0x2b5f414f = 0; _0x2b5f414f < this._stars.Length; _0x2b5f414f++)
        {
            if (this._stars[_0x2b5f414f] != null)
            {
                DOTween.Kill(this._stars[_0x2b5f414f].transform);
            }
        }
    }
}