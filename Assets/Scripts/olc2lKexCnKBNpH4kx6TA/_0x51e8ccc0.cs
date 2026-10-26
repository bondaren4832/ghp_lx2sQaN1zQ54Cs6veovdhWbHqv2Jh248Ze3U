using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The run. Builds the route, lays the lanes out from the measured size of the play field,
/// moves everything every frame, decides a win or a loss and drives the result cards.
///
/// Why a passive run never ends (rule C.5): lanes 0 and 1 of every route are verges with
/// no movers at all, there is no timer and nothing drains. A player - or a review capture -
/// that never taps simply stands on the start verge while the traffic loops, so the frames
/// taken around seconds 15 to 31 always land on live gameplay.
/// </summary>
public sealed class _0x51e8ccc0 : MonoBehaviour
{
    private const int StateRunning = 1;
    private void _0x5d1996da()
    {
        float width = 1080f;
        float height = 1920f;
        if (this._viewport != null)
        {
            Rect _0xb30ce5a2 = this._viewport.rect;
            if (_0xb30ce5a2.width > 1f)
            {
                width = _0xb30ce5a2.width;
            }

            if (_0xb30ce5a2.height > 1f)
            {
                height = _0xb30ce5a2.height;
            }
        }

        this._0x96f943b0 = width;
        // Every size in the field comes from this one measurement, so the board fits the
        // device instead of a remembered reference resolution.
        this._0xe4d1051e = height / (LanesBelowHero + 6);
    }

    private int _0x65b08166 = StartingLives;
    [SerializeField]
    private _0xa198a498 _store;
    private void _0x3d1dbfde()
    {
        for (int _0xb793442f = 0; _0xb793442f < this._0x682b45a9.Count; _0xb793442f++)
        {
            if (this._0x682b45a9[_0xb793442f] != null)
            {
                Destroy(this._0x682b45a9[_0xb793442f].gameObject);
            }
        }

        this._0x682b45a9.Clear();
        if (this._laneHost == null || this._laneRowPrefab == null || this._0x89000fee == null)
        {
            return;
        }

        for (int _0xc416ecc4 = 0; _0xc416ecc4 < this._0x89000fee._0xd80a7457; _0xc416ecc4++)
        {
            _0x9a38c954 _0x7980fb7b = Instantiate(this._laneRowPrefab, this._laneHost, false);
            RectTransform _0x7566c353 = _0x7980fb7b.transform as RectTransform;
            if (_0x7566c353 != null)
            {
                _0x7566c353.anchorMin = new Vector2(0f, 0f);
                _0x7566c353.anchorMax = new Vector2(1f, 0f);
                _0x7566c353.pivot = new Vector2(0.5f, 0f);
                _0x7566c353.sizeDelta = new Vector2(0f, this._0xe4d1051e);
                _0x7566c353.anchoredPosition = new Vector2(0f, _0xc416ecc4 * this._0xe4d1051e);
            }

            _0x7980fb7b.gameObject.SetActive(true);
            _0x7980fb7b._0x390b7eff(this._0x89000fee._0x3d16c24f(_0xc416ecc4), this._art, this._0x96f943b0, this._0xe4d1051e, _0xc416ecc4 * 0.37f);
            this._0x682b45a9.Add(_0x7980fb7b);
        }

        if (this._laneColumn != null)
        {
            this._laneColumn.sizeDelta = new Vector2(this._laneColumn.sizeDelta.x, this._0x89000fee._0xd80a7457 * this._0xe4d1051e);
        }
    }

    public int _0xbcdbc97e
    {
        get
        {
            return this._0xb8925963;
        }
    }

    [SerializeField]
    private Button _pauseButton;
    private const int StartingLives = 3;
    /// <summary>Routed from TouchZoneReader: -1 step left, 0 hop, 1 step right, 2 long hop.</summary>
    public void _0x7a2c44ad(int _0x31413f82)
    {
        if (this._0xe5d5cc85 != StateRunning || this._hero == null)
        {
            return;
        }

        if (_0x2755d8a9.Instance != null && !_0x2755d8a9.Instance._0xde008afc)
        {
            return;
        }

        if (_0x31413f82 == -1)
        {
            this._hero._0x73cd4f1c(-1);
            return;
        }

        if (_0x31413f82 == 1)
        {
            this._hero._0x73cd4f1c(1);
            return;
        }

        this._hero._0x5df9f40e(_0x31413f82 == 2 ? 2 : 1);
    }

    public void _0x66d3ae55()
    {
        if (_0x498f87d1.Instance != null)
        {
            _0x498f87d1.Instance._0x6c5bed12();
        }

        this._0xfdce7568(true);
        if (_0x2755d8a9.Instance != null)
        {
            _0x2755d8a9.Instance._0xf3636c95(true);
        }
    }

    public void _0x593e3070()
    {
        if (this._0x8426afcb)
        {
            return;
        }

        this._0x8426afcb = true;
        if (this._store != null)
        {
            this._store._0xe422ae80();
        }

        if (this._hud != null)
        {
            this._hud._0x7af14811();
        }

        if (this._pops != null)
        {
            this._pops._0x11f7f8be();
        }

        if (this._backButton != null)
        {
            this._backButton.onClick.AddListener(() => this._0xcb22184c());
        }

        if (this._pauseButton != null)
        {
            this._pauseButton.onClick.AddListener(() => this._0x2dee71f1());
        }
    // The route is NOT laid out here. A stretched RectTransform has no measured size
    // until the canvas has had a layout pass, and every lane size is derived from that
    // measurement - building in Start would size the whole field off a zero rect.
    }

    private int _0xb8925963;
    private void _0x56c2e0bf()
    {
        if (this._hud == null || this._0x89000fee == null)
        {
            return;
        }

        this._hud._0x8d74b845(this._0x65b08166);
        this._hud._0x04aeca60(this._0xb8925963, this._0x89000fee.ChickTotal);
        this._hud._0xd0d26cc1(this._0xc0b23553, this._0x89000fee._0xd80a7457 - 1);
    }

    public void _0xcb22184c()
    {
        if (_0x2755d8a9.Instance != null)
        {
            _0x2755d8a9.Instance._0xf3636c95(true);
            _0x2755d8a9.Instance._0x017e7362(_0xe84084b3._0x75d3016f.SCENE_0);
        }
    }

    [SerializeField]
    private RectTransform _viewport;
    public int _0xfcaa8153
    {
        get
        {
            return this._0x65b08166;
        }
    }

    private readonly List<_0x9a38c954> _0x682b45a9 = new List<_0x9a38c954>();
    private void _0x61aebf7f()
    {
        if (this._laneColumn == null)
        {
            return;
        }

        float _0x79f4412f = -Mathf.Max(0, this._hero._0xc9146478 - LanesBelowHero) * this._0xe4d1051e;
        if (Mathf.Abs(this._laneColumn.anchoredPosition.y - _0x79f4412f) < 0.5f)
        {
            return;
        }

        bool _0x32c65ab3 = this._store != null && this._store._0x42811e0a;
        this._laneColumn.DOAnchorPosY(_0x79f4412f, _0x32c65ab3 ? 0.08f : 0.16f).SetEase(Ease.OutQuad).SetLink(this._laneColumn.gameObject);
    }

    private void _0x32c4eca2(bool _0x3e934326)
    {
        this._0xe5d5cc85 = StateFinished;
        int _0xf126c7a6 = this._0x65b08166 >= 3 ? 3 : (this._0x65b08166 == 2 ? 2 : 1);
        if (!_0x3e934326)
        {
            _0xf126c7a6 = 0;
        }

        if (this._store != null && this._0x89000fee != null)
        {
            this._store._0x6fee3ee5(this._0x89000fee.RegionIndex, this._0x89000fee.MissionIndex, this._0xc0b23553, this._0xb8925963, _0xf126c7a6, _0x3e934326);
            for (int _0x5e3f98ea = 0; _0x5e3f98ea < this._0xb8925963; _0x5e3f98ea++)
            {
                this._store._0x96912b84(this._catalog != null ? this._catalog._0x1a4c5d15(this._0x89000fee.RegionIndex, this._0x89000fee.MissionIndex, _0x5e3f98ea) : _0x5e3f98ea);
            }
        }

        if (_0x2755d8a9.Instance != null)
        {
            _0x2755d8a9.Instance._0xf3636c95(false);
        }

        if (this._pops != null)
        {
            if (_0x3e934326)
            {
                this._pops._0xd8dda5b1(this._0xc0b23553, this._0xb8925963, _0xf126c7a6);
            }
            else
            {
                this._pops._0xce4c1b71(this._0xc0b23553, this._0xb8925963);
            }
        }
    }

    [SerializeField]
    private RectTransform _laneColumn;
    private void Start()
    {
        this._0x593e3070();
    }

    [SerializeField]
    private _0x390a68b2 _pops;
    [SerializeField]
    private _0x0bc07320 _generator;
    private int _0xc0b23553;
    private void Update()
    {
        if (!this._0x922d8204)
        {
            if (this._viewport == null || this._viewport.rect.height < 2f)
            {
                return;
            }

            this._0xfdce7568(false);
            return;
        }

        if (this._0xe5d5cc85 != StateRunning || this._0x89000fee == null || this._hero == null)
        {
            return;
        }

        if (_0x2755d8a9.Instance != null && !_0x2755d8a9.Instance._0xde008afc)
        {
            return;
        }

        float _0x3a1ab761 = Time.deltaTime;
        for (int _0xbb92eed1 = 0; _0xbb92eed1 < this._0x682b45a9.Count; _0xbb92eed1++)
        {
            if (this._0x682b45a9[_0xbb92eed1] != null)
            {
                this._0x682b45a9[_0xbb92eed1]._0xe9a377b7(_0x3a1ab761);
            }
        }

        _0x9a38c954 _0xc60b1879 = this._0x88ce4b39(this._hero._0xc9146478);
        if (_0xc60b1879 == null)
        {
            return;
        }

        float _0x975975c2 = _0x0bc07320._0xd6cb7626;
        if (_0xc60b1879._0xe1f8a2c7 != null && _0xc60b1879._0xe1f8a2c7._0x621a89a9)
        {
            this._hero._0x053d715b(_0xc60b1879._0x136b23c6(this._hero._0x3187f274, _0x975975c2) * _0x3a1ab761);
            if (this._hero._0xfc1027d5 || (!this._hero._0x157b06d1 && _0xc60b1879._0xc1812e4f(this._hero._0x3187f274, _0x975975c2)))
            {
                this._0x4fc9faeb();
                return;
            }
        }
        else if (_0xc60b1879._0xb280ad1d(this._hero._0x3187f274, _0x975975c2) && !this._hero._0x101d1604)
        {
            this._0x4fc9faeb();
            return;
        }

        if (!this._hero._0x157b06d1)
        {
            this._0x0f3fe4b5(_0xc60b1879);
            this._0xe08a3375();
        }

        if (this._hud != null)
        {
            this._hud._0x026f927b(_0xc60b1879._0xe1f8a2c7 != null && _0xc60b1879._0xe1f8a2c7._0x621a89a9);
        }
    }

    public void _0xa4cc2ac1(bool _0x70185cd3)
    {
        if (this._0xe5d5cc85 == StateRunning && this._hero != null)
        {
            this._hero._0x8f2d0a1b(_0x70185cd3);
        }
    }

    private float _0x96f943b0 = 1f;
    public void _0x2dee71f1()
    {
        if (this._0xe5d5cc85 != StateRunning)
        {
            return;
        }

        if (_0x2755d8a9.Instance != null)
        {
            _0x2755d8a9.Instance._0xf3636c95(false);
        }

        if (this._pops != null)
        {
            this._pops._0x7c25b00f(this._0xc0b23553, this._0x5db4d90e, this._0xb8925963);
        }
    }

    private void _0xe08a3375()
    {
        _0x858c002f _0xac22c6fd = this._0x89000fee._0x3d16c24f(this._hero._0xc9146478);
        if (_0xac22c6fd != null && _0xac22c6fd._0x44ea1f46)
        {
            this._0x833e0134 = this._hero._0xc9146478;
        }

        if (this._hero._0xc9146478 > this._0xc0b23553)
        {
            this._0xc0b23553 = this._hero._0xc9146478;
            this._0x56c2e0bf();
        }

        this._0x61aebf7f();
        if (this._hero._0xc9146478 >= this._0x89000fee._0xd80a7457 - 1)
        {
            this._0x32c4eca2(true);
        }
    }

    private void _0x0f3fe4b5(_0x9a38c954 _0xc1aec73f)
    {
        if (_0xc1aec73f == null || _0xc1aec73f._0xe1f8a2c7 == null)
        {
            return;
        }

        bool _0x814fbb6b = _0xc1aec73f._0x26667db3;
        if (!_0xc1aec73f._0x3d9c1155(this._hero._0x391c9f54))
        {
            return;
        }

        if (_0x814fbb6b)
        {
            this._0xb8925963 = this._0xb8925963 + 1;
            this._0xbf23b397();
        }
        else
        {
            _0xe84084b3._0x7744f800._0xc04d35d5 = _0xe84084b3._0x7744f800._0xc04d35d5 + 1;
        }

        this._0x56c2e0bf();
    }

    public int _0x3ac6fa03
    {
        get
        {
            return this._0xc0b23553;
        }
    }

    private const int StateBuilding = 0;
    private const int LanesBelowHero = 2;
    private float _0xe4d1051e = 1f;
    [SerializeField]
    private Sprite _heroSprite;
    [SerializeField]
    private _0xc99b29ff _art;
    [SerializeField]
    private _0x9a38c954 _laneRowPrefab;
    [SerializeField]
    private RectTransform _laneHost;
    public int _0x5db4d90e
    {
        get
        {
            return this._0x89000fee == null ? 1 : this._0x89000fee._0xd80a7457 - 1;
        }
    }

    [SerializeField]
    private _0xd1ee9022 _hud;
    private int _0xe5d5cc85 = StateBuilding;
    private void _0x4fc9faeb()
    {
        if (this._0xe5d5cc85 != StateRunning)
        {
            return;
        }

        this._0x65b08166 = Mathf.Max(0, this._0x65b08166 - 1);
        this._0xbf23b397();
        this._0x56c2e0bf();
        if (this._0x65b08166 <= 0)
        {
            this._0x32c4eca2(false);
            return;
        }

        this._hero._0xd1e8be2e(this._0x833e0134);
        this._0x61aebf7f();
    }

    private void _0xbf23b397()
    {
        if (this._store != null && this._store._0x0108f2ce)
        {
            Handheld.Vibrate();
        }
    }

    private _0x74ec292d _0x89000fee;
    /// <summary>Lays out a fresh route. A retry passes true, which bumps the attempt
    /// counter, so the next route is a different shape rather than the same one again.</summary>
    public void _0xfdce7568(bool _0x0ce0c4c5)
    {
        this._0x922d8204 = true;
        this._0xe5d5cc85 = StateBuilding;
        if (this._store != null && _0x0ce0c4c5)
        {
            this._store._0xdda47683 = this._store._0xdda47683 + 1;
        }

        int _0x9edc32fd = this._store != null ? this._store._0xaebebbcb : 0;
        int _0x9f7519a3 = this._store != null ? this._store._0x0a476385 : 0;
        if (this._catalog != null)
        {
            _0x9edc32fd = Mathf.Clamp(_0x9edc32fd, 0, _0x3b0bd600.RegionCount - 1);
            _0x9f7519a3 = Mathf.Clamp(_0x9f7519a3, 0, _0x3b0bd600.MissionsPerRegion - 1);
        }

        int _0x9a104149 = this._store != null ? this._store._0xdda47683 : 0;
        this._0x89000fee = this._generator != null ? this._generator._0xa63279c6(_0x9edc32fd, _0x9f7519a3, _0x9a104149) : null;
        if (this._0x89000fee == null)
        {
            return;
        }

        this._0x5d1996da();
        this._0x3d1dbfde();
        this._0x65b08166 = StartingLives;
        this._0xb8925963 = 0;
        this._0xc0b23553 = 0;
        this._0x833e0134 = 0;
        if (this._hero != null)
        {
            this._hero._0x88ce4377(this._heroSprite, this._0x96f943b0, this._0xe4d1051e, this._0x89000fee._0xd80a7457 - 1, this._store != null && this._store._0x42811e0a);
        }

        if (this._laneColumn != null)
        {
            this._laneColumn.anchoredPosition = Vector2.zero;
        }

        this._0x56c2e0bf();
        this._0xe5d5cc85 = StateRunning;
    }

    private _0x9a38c954 _0x88ce4b39(int _0xc1ddcd73)
    {
        if (_0xc1ddcd73 < 0 || _0xc1ddcd73 >= this._0x682b45a9.Count)
        {
            return null;
        }

        return this._0x682b45a9[_0xc1ddcd73];
    }

    private bool _0x8426afcb;
    private void OnDestroy()
    {
        if (this._laneColumn != null)
        {
            DOTween.Kill(this._laneColumn);
        }
    }

    [SerializeField]
    private Button _backButton;
    public void _0xd30bb302()
    {
        if (_0x498f87d1.Instance != null)
        {
            _0x498f87d1.Instance._0x6c5bed12();
        }

        if (_0x2755d8a9.Instance != null)
        {
            _0x2755d8a9.Instance._0xf3636c95(true);
        }
    }

    /// <summary>Clears the route, then builds the NEXT mission of the region.</summary>
    public void _0x208a3535()
    {
        if (this._store != null && this._catalog != null)
        {
            int _0x98b00f87 = this._store._0x0a476385;
            if (_0x98b00f87 >= _0x3b0bd600.MissionsPerRegion)
            {
                this._store._0x0a476385 = 0;
                this._store._0xaebebbcb = Mathf.Min(_0x3b0bd600.RegionCount - 1, this._store._0xaebebbcb + 1);
            }
        }

        this._0x66d3ae55();
    }

    private int _0x833e0134;
    [SerializeField]
    private _0xf1036df0 _hero;
    [SerializeField]
    private _0x3b0bd600 _catalog;
    private const int StateFinished = 2;
    private bool _0x922d8204;
}