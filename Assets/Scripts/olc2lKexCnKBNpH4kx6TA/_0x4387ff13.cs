using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The village: where the player is in the journey, three stat chips, the current mission
/// card and the Play slot.
///
/// Rule G.3 is handled here as well as in the scene file. The template ships the slot
/// stretched across the whole panel with a zero size delta; its anchors are collapsed to a
/// point and the size set in reference pixels, then OUR face is parented into the slot so
/// the visible button and the tap rect are the same rectangle. The template slot renders
/// nothing of its own (its decorative layers are stencil-gated off in the EMPTY variant),
/// which is why the face has to be our object rather than a sprite handed to its Images.
/// </summary>
public sealed class _0x4387ff13 : MonoBehaviour
{
    [SerializeField]
    private RectTransform _playFace;
    [SerializeField]
    private _0x87d47a0b _missionStars;
    [SerializeField]
    private TMP_Text _missionName;
    [SerializeField]
    private _0x3b0bd600 _catalog;
    private void Start()
    {
        this._0x1505c730();
    }

    private const float PlayHeight = 170f;
    [SerializeField]
    private _0xa198a498 _store;
    [SerializeField]
    private TMP_Text[] _statValues;
    public void _0xf744486d()
    {
        if (this._store == null || this._catalog == null)
        {
            return;
        }

        int _0xb4140286 = Mathf.Clamp(this._store._0xaebebbcb, 0, _0x3b0bd600.RegionCount - 1);
        int _0xa4a7c045 = Mathf.Clamp(this._store._0x0a476385, 0, _0x3b0bd600.MissionsPerRegion - 1);
        if (this._regionBadge != null)
        {
            this._regionBadge.text = (_0xb4140286 + 1).ToString();
        }

        if (this._regionLabel != null)
        {
            this._regionLabel.text = _0x93e4e5fd._0xf0efa7cb(new byte[7] { 222, 201, 203, 197, 195, 194, 172 }, 140) + (_0xb4140286 + 1).ToString();
        }

        if (this._regionSub != null)
        {
            this._regionSub.text = this._catalog._0x7c95c2a4(_0xb4140286);
        }

        if (this._statValues != null && this._statValues.Length >= 3)
        {
            if (this._statValues[1] != null)
            {
                this._statValues[1].text = this._store._0x3aab6a43.ToString();
            }

            if (this._statValues[2] != null)
            {
                this._statValues[2].text = this._store._0x73e111de.ToString();
            }
        }

        if (this._featherCounter != null)
        {
            this._featherCounter._0xb91b66da();
        }

        int _0xc1f118a1 = this._catalog._0x05a42898(_0xb4140286, _0xa4a7c045);
        int _0xf6fac5eb = this._catalog._0x1e553a3b(_0xb4140286, _0xa4a7c045);
        if (this._missionName != null)
        {
            this._missionName.text = this._catalog._0x4d9d35e2(_0xa4a7c045);
        }

        if (this._missionGoal != null)
        {
            this._missionGoal.text = _0xc1f118a1.ToString() + _0x93e4e5fd._0xf0efa7cb(new byte[9] { 20, 120, 117, 122, 113, 103, 20, 25, 20 }, 52) + _0xf6fac5eb.ToString() + _0x93e4e5fd._0xf0efa7cb(new byte[7] { 249, 154, 145, 144, 154, 146, 138 }, 217);
        }

        if (this._missionStars != null)
        {
            this._missionStars._0xb39bbae0(this._store._0x4f35c54e(_0xb4140286, _0xa4a7c045), this._store._0x42811e0a);
        }

        if (this._objectiveLabel != null)
        {
            this._objectiveLabel.text = _0x93e4e5fd._0xf0efa7cb(new byte[6] { 251, 234, 247, 235, 235, 152 }, 184) + _0xc1f118a1.ToString() + _0x93e4e5fd._0xf0efa7cb(new byte[16] { 201, 165, 168, 167, 172, 186, 201, 196, 201, 187, 172, 186, 170, 188, 172, 201 }, 233) + _0xf6fac5eb.ToString() + _0x93e4e5fd._0xf0efa7cb(new byte[7] { 255, 156, 151, 150, 156, 148, 140 }, 223);
        }
    }

    [SerializeField]
    private TMP_Text _objectiveLabel;
    private RectTransform _0xee8e93f3;
    private const float PlayWidth = 780f;
    private void _0x9910a8e6()
    {
        _0x63cbf436 _0x4f2b3603 = null;
        if (_0xc9856497.Instance != null && _0xc9856497.Instance.Panels != null && _0xe84084b3._0x35f75e78.DEFAULT < _0xc9856497.Instance.Panels.Count)
        {
            _0x544a2399 _0xa1e43487 = _0xc9856497.Instance.Panels[_0xe84084b3._0x35f75e78.DEFAULT];
            if (_0xa1e43487 != null && _0xa1e43487.Content != null)
            {
                _0x4f2b3603 = _0xa1e43487.Content.GetComponentInChildren<_0x63cbf436>(true);
            }
        }

        if (_0x4f2b3603 == null || _0x4f2b3603.Button == null)
        {
            return;
        }

        this._0xee8e93f3 = _0x4f2b3603.Button.transform as RectTransform;
        if (this._0xee8e93f3 == null)
        {
            return;
        }

        this._0xee8e93f3.anchorMin = new Vector2(0.5f, PlayAnchorY);
        this._0xee8e93f3.anchorMax = new Vector2(0.5f, PlayAnchorY);
        this._0xee8e93f3.pivot = new Vector2(0.5f, 0.5f);
        this._0xee8e93f3.anchoredPosition = Vector2.zero;
        this._0xee8e93f3.sizeDelta = new Vector2(PlayWidth, PlayHeight);
        if (this._playFace == null)
        {
            return;
        }

        this._playFace.SetParent(this._0xee8e93f3, false);
        this._playFace.anchorMin = Vector2.zero;
        this._playFace.anchorMax = Vector2.one;
        this._playFace.offsetMin = Vector2.zero;
        this._playFace.offsetMax = Vector2.zero;
        this._playFace.SetAsLastSibling();
        bool _0x8f1577f7 = this._store != null && this._store._0x42811e0a;
        if (!_0x8f1577f7)
        {
            this._playFace.DOScale(1.03f, 1.5f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine).SetLink(this._playFace.gameObject);
        }
    }

    [SerializeField]
    private TMP_Text _regionSub;
    [SerializeField]
    private TMP_Text _regionBadge;
    /// <summary>The slot lives next to this view, not inside it, so the router asks for it
    /// to be hidden whenever another page is on screen.</summary>
    public void _0xa6499ff6(bool _0xfbe97095)
    {
        // The router may reach this before this view has had its own Start, and Start
        // order is undefined - so the slot is resolved on demand rather than waited for
        // (rule C.59).
        this._0x1505c730();
        if (this._0xee8e93f3 != null)
        {
            this._0xee8e93f3.gameObject.SetActive(_0xfbe97095);
        }
    }

    [SerializeField]
    private _0xed270438 _featherCounter;
    [SerializeField]
    private TMP_Text _regionLabel;
    private bool _0xcb10bda7;
    [SerializeField]
    private TMP_Text _missionGoal;
    private void OnDestroy()
    {
        if (this._playFace != null)
        {
            DOTween.Kill(this._playFace);
        }
    }

    public void _0x1505c730()
    {
        if (this._0xcb10bda7)
        {
            return;
        }

        this._0xcb10bda7 = true;
        if (this._store != null)
        {
            this._store._0xe422ae80();
        }

        this._0x9910a8e6();
        this._0xf744486d();
    }

    private const float PlayAnchorY = 0.2827f;
}

internal static class _0x93e4e5fd
{
    internal static string _0xf0efa7cb(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}