using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The village router. Exactly one of its OWN view objects is active at a time and the
/// switch is a SetActive on objects this prefab created - it never touches a template
/// placeholder and never looks anything up by name.
/// The Play slot belongs to the home view, so it is hidden with it; otherwise the template
/// button would keep taking taps behind the album or the map.
/// </summary>
public sealed class _0xb310c430 : MonoBehaviour
{
    [SerializeField]
    private _0x3cc73d02 _regions;
    public const int ViewRegions = 3;
    private void OnDestroy()
    {
        if (this._tabPlates == null)
        {
            return;
        }

        for (int _0x2441c431 = 0; _0x2441c431 < this._tabPlates.Length; _0x2441c431++)
        {
            if (this._tabPlates[_0x2441c431] != null)
            {
                DOTween.Kill(this._tabPlates[_0x2441c431].transform);
            }
        }
    }

    private void _0x4e84e39a(int _0xafcfdbd1)
    {
        if (_0xafcfdbd1 == ViewHome && this._home != null)
        {
            this._home._0xf744486d();
            return;
        }

        if (_0xafcfdbd1 == ViewMap && this._map != null)
        {
            this._map._0xe09c0c28();
            return;
        }

        if (_0xafcfdbd1 == ViewAlbum && this._album != null)
        {
            this._album._0x99bd46bb();
            return;
        }

        if (_0xafcfdbd1 == ViewRegions && this._regions != null)
        {
            this._regions._0x8d5e5898();
            return;
        }

        if (_0xafcfdbd1 != ViewMore)
        {
            return;
        }

        if (this._challenges != null)
        {
            this._challenges._0x7fbdc1f0();
        }

        if (this._settings != null)
        {
            this._settings._0xc38c30e5();
        }
    }

    private int _0xaef3ea79 = -1;
    public void _0x4d142c26()
    {
        if (this._0xb96ee28d)
        {
            return;
        }

        this._0xb96ee28d = true;
        if (this._tabButtons != null)
        {
            for (int _0xa4c92496 = 0; _0xa4c92496 < this._tabButtons.Length; _0xa4c92496++)
            {
                int _0x3a3ccb56 = _0xa4c92496;
                if (this._tabButtons[_0xa4c92496] != null)
                {
                    this._tabButtons[_0xa4c92496].onClick.AddListener(() => this.Show(_0x3a3ccb56));
                }
            }
        }

        this.Show(ViewHome);
    }

    [SerializeField]
    private Button[] _tabButtons;
    [SerializeField]
    private _0xbf3cac6e _settings;
    private void _0x456cb1e2(int _0x24c8291a)
    {
        if (this._tabPlates != null)
        {
            for (int _0x8b1d6e6c = 0; _0x8b1d6e6c < this._tabPlates.Length; _0x8b1d6e6c++)
            {
                if (this._tabPlates[_0x8b1d6e6c] == null)
                {
                    continue;
                }

                this._tabPlates[_0x8b1d6e6c].color = _0x8b1d6e6c == _0x24c8291a ? _0xa567d11e.Primary : _0xa567d11e.Surface;
                this._tabPlates[_0x8b1d6e6c].transform.DOScale(_0x8b1d6e6c == _0x24c8291a ? 1.04f : 1f, 0.16f).SetLink(this._tabPlates[_0x8b1d6e6c].gameObject);
            }
        }

        if (this._tabLabels == null)
        {
            return;
        }

        for (int _0xa65c1bc7 = 0; _0xa65c1bc7 < this._tabLabels.Length; _0xa65c1bc7++)
        {
            if (this._tabLabels[_0xa65c1bc7] != null)
            {
                this._tabLabels[_0xa65c1bc7].color = _0xa65c1bc7 == _0x24c8291a ? _0xa567d11e.Ink : _0xa567d11e.Caption;
            }
        }
    }

    [SerializeField]
    private _0x9f7f74f7 _map;
    [SerializeField]
    private Image[] _tabPlates;
    [SerializeField]
    private _0x4387ff13 _home;
    public const int ViewHome = 0;
    [SerializeField]
    private TMP_Text[] _tabLabels;
    [SerializeField]
    private GameObject[] _views;
    public const int ViewMore = 4;
    public const int ViewAlbum = 2;
    public const int ViewMap = 1;
    [SerializeField]
    private _0x95976f2c _album;
    private bool _0xb96ee28d;
    private void Start()
    {
        this._0x4d142c26();
    }

    public void Show(int _0x1343fa5a)
    {
        if (this._views == null || this._views.Length == 0)
        {
            return;
        }

        int _0x1e859196 = Mathf.Clamp(_0x1343fa5a, 0, this._views.Length - 1);
        if (_0x1e859196 == this._0xaef3ea79)
        {
            return;
        }

        this._0xaef3ea79 = _0x1e859196;
        for (int _0x0a433390 = 0; _0x0a433390 < this._views.Length; _0x0a433390++)
        {
            if (this._views[_0x0a433390] != null)
            {
                this._views[_0x0a433390].SetActive(_0x0a433390 == _0x1e859196);
            }
        }

        if (this._home != null)
        {
            this._home._0xa6499ff6(_0x1e859196 == ViewHome);
        }

        this._0x456cb1e2(_0x1e859196);
        this._0x4e84e39a(_0x1e859196);
    }

    [SerializeField]
    private _0x6488cc88 _challenges;
}