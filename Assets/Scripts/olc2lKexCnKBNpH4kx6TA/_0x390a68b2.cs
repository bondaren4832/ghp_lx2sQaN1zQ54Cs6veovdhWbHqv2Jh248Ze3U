using TMPro;
using UnityEngine;

/// <summary>
/// Dresses the three popups this game uses - PAUSE 6, WIN 7, LOSE 8, addressed by their
/// SETTINGS index and never by name. The template surface inside each one is blanked and
/// switched off at runtime, and our own card is instantiated in its place, so no template
/// caption, no empty "Score:" row and no unsprited white close square can reach the screen
/// (rules C.3, C.15, C.17).
/// </summary>
public sealed class _0x390a68b2 : MonoBehaviour
{
    private void Start()
    {
        this._0x11f7f8be();
    }

    public void _0x11f7f8be()
    {
        if (this._0xe4eae23a)
        {
            return;
        }

        this._0xe4eae23a = true;
        if (this._cardPrefab == null || _0x498f87d1.Instance == null)
        {
            return;
        }

        this._0xd5f91eec = this._0xbf4f7c10(_0x498f87d1.Instance._0x9515894f(_0xe84084b3._0x0d0ffff4.WIN));
        this._0xbff58734 = this._0xbf4f7c10(_0x498f87d1.Instance._0x9515894f(_0xe84084b3._0x0d0ffff4.LOSE));
        this._0x4e9ba614 = this._0xbf4f7c10(_0x498f87d1.Instance._0x9515894f(_0xe84084b3._0x0d0ffff4.PAUSE));
    }

    public void _0xd8dda5b1(int _0xb79c5c16, int _0xa66441db, int _0x902ad5a7)
    {
        this._0x11f7f8be();
        if (this._0xd5f91eec == null || _0x498f87d1.Instance == null)
        {
            return;
        }

        string _0x3aba0436 = this._catalog != null && this._store != null ? this._catalog._0x7c95c2a4(this._store._0xaebebbcb) : _0xa90c6c9f._0x72c67e81(new byte[15] { 98, 126, 115, 22, 117, 121, 99, 120, 98, 100, 111, 101, 127, 114, 115 }, 54);
        this._0xd5f91eec._0x4bd1ca36(this._winBadge, _0xa567d11e.Primary);
        this._0xd5f91eec._0xb043f903(_0xa90c6c9f._0x72c67e81(new byte[14] { 8, 17, 27, 22, 17, 27, 120, 10, 29, 25, 27, 16, 29, 28 }, 88), _0xb79c5c16.ToString() + _0xa90c6c9f._0x72c67e81(new byte[14] { 26, 118, 123, 116, 127, 105, 26, 121, 104, 117, 105, 105, 127, 126 }, 58), _0xa66441db.ToString() + _0xa90c6c9f._0x72c67e81(new byte[19] { 6, 101, 110, 111, 101, 109, 117, 6, 116, 99, 117, 101, 115, 99, 98, 6, 111, 104, 6 }, 38) + _0x3aba0436);
        this._0xd5f91eec._0xf539f8b2(Mathf.Clamp(_0x902ad5a7, 0, 3), this._0xeb3a9d75);
        this._0xd5f91eec._0xe4fe36d1(_0xa90c6c9f._0x72c67e81(new byte[12] { 14, 5, 24, 20, 96, 10, 15, 21, 18, 14, 5, 25 }, 64), () => this._0x31acfdff());
        this._0xd5f91eec._0xbbb6ec70(_0xa90c6c9f._0x72c67e81(new byte[7] { 129, 158, 155, 155, 150, 144, 146 }, 215), () => this._0xcf16acae());
        this._0xd5f91eec._0x0edf0b10(() => this._0xcf16acae());
        _0x498f87d1.Instance._0x20ed82d1(_0xe84084b3._0x0d0ffff4.WIN);
        this._0xd5f91eec._0x751475c6(this._0xeb3a9d75);
    }

    [SerializeField]
    private _0x51e8ccc0 _director;
    private void _0x9fd88f83()
    {
        if (this._director != null)
        {
            this._director._0x66d3ae55();
        }
    }

    private bool _0xe4eae23a;
    private void _0xcf16acae()
    {
        if (this._director != null)
        {
            this._director._0xcb22184c();
        }
    }

    [SerializeField]
    private _0x3b0bd600 _catalog;
    private _0x5af30773 _0xbf4f7c10(_0x97d07d83 _0x41a4fe8c)
    {
        if (_0x41a4fe8c == null || _0x41a4fe8c.Content == null)
        {
            return null;
        }

        this._0x93e17e20(_0x41a4fe8c);
        _0x5af30773 _0x7cc35589 = Instantiate(this._cardPrefab, _0x41a4fe8c.Content.transform, false);
        RectTransform _0x71e61a87 = _0x7cc35589.transform as RectTransform;
        if (_0x71e61a87 != null)
        {
            _0x71e61a87.anchorMin = Vector2.zero;
            _0x71e61a87.anchorMax = Vector2.one;
            _0x71e61a87.offsetMin = Vector2.zero;
            _0x71e61a87.offsetMax = Vector2.zero;
        }

        _0x7cc35589.transform.SetAsLastSibling();
        _0x7cc35589._0x172d9c65();
        return _0x7cc35589;
    }

    [SerializeField]
    private _0x5af30773 _cardPrefab;
    private void _0x31acfdff()
    {
        if (this._director != null)
        {
            this._director._0x208a3535();
        }
    }

    private _0x5af30773 _0xbff58734;
    private void _0xaddf2cf7()
    {
        if (this._director != null)
        {
            this._director._0xd30bb302();
        }
    }

    private void _0x93e17e20(_0x97d07d83 _0x190f80ed)
    {
        if (_0x190f80ed.ContentHeaderText != null)
        {
            _0x190f80ed.ContentHeaderText.text = string.Empty;
        }

        if (_0x190f80ed.ContentMainText != null)
        {
            _0x190f80ed.ContentMainText.text = string.Empty;
        }

        if (_0x190f80ed.ContentAdditionalText != null)
        {
            _0x190f80ed.ContentAdditionalText.text = string.Empty;
        }

        TMP_Text[] _0x2eac511f = _0x190f80ed.Content.GetComponentsInChildren<TMP_Text>(true);
        for (int _0x151f9493 = 0; _0x151f9493 < _0x2eac511f.Length; _0x151f9493++)
        {
            _0x2eac511f[_0x151f9493].text = string.Empty;
        }

        Transform _0x2e55a1d3 = _0x190f80ed.Content.transform;
        for (int _0x45c6f3b1 = 0; _0x45c6f3b1 < _0x2e55a1d3.childCount; _0x45c6f3b1++)
        {
            _0x2e55a1d3.GetChild(_0x45c6f3b1).gameObject.SetActive(false);
        }
    }

    [SerializeField]
    private _0xa198a498 _store;
    private _0x5af30773 _0x4e9ba614;
    [SerializeField]
    private Sprite _loseBadge;
    private _0x5af30773 _0xd5f91eec;
    private bool _0xeb3a9d75
    {
        get
        {
            return this._store != null && this._store._0x42811e0a;
        }
    }

    public void _0xce4c1b71(int _0xdf527066, int _0x4cf3ebe0)
    {
        this._0x11f7f8be();
        if (this._0xbff58734 == null || _0x498f87d1.Instance == null)
        {
            return;
        }

        this._0xbff58734._0x4bd1ca36(this._loseBadge, _0xa567d11e.Value);
        this._0xbff58734._0xb043f903(_0xa90c6c9f._0x72c67e81(new byte[13] { 235, 232, 236, 249, 229, 232, 255, 254, 141, 234, 226, 227, 232 }, 173), _0xa90c6c9f._0x72c67e81(new byte[16] { 99, 100, 127, 96, 96, 117, 116, 16, 113, 100, 16, 124, 113, 126, 117, 16 }, 48) + _0xdf527066.ToString(), _0x4cf3ebe0.ToString() + _0xa90c6c9f._0x72c67e81(new byte[21] { 118, 21, 30, 31, 21, 29, 5, 118, 1, 19, 4, 19, 118, 1, 31, 2, 30, 118, 15, 25, 3 }, 86));
        this._0xbff58734._0xf539f8b2(-1, this._0xeb3a9d75);
        this._0xbff58734._0xe4fe36d1(_0xa90c6c9f._0x72c67e81(new byte[9] { 191, 185, 178, 203, 170, 172, 170, 162, 165 }, 235), () => this._0x9fd88f83());
        this._0xbff58734._0xbbb6ec70(_0xa90c6c9f._0x72c67e81(new byte[7] { 36, 59, 62, 62, 51, 53, 55 }, 114), () => this._0xcf16acae());
        this._0xbff58734._0x0edf0b10(() => this._0xcf16acae());
        _0x498f87d1.Instance._0x20ed82d1(_0xe84084b3._0x0d0ffff4.LOSE);
        this._0xbff58734._0x751475c6(this._0xeb3a9d75);
    }

    public void _0x7c25b00f(int _0xe9207b37, int _0x2b58a19e, int _0xef0ed93a)
    {
        this._0x11f7f8be();
        if (this._0x4e9ba614 == null || _0x498f87d1.Instance == null)
        {
            return;
        }

        this._0x4e9ba614._0x4bd1ca36(this._pauseBadge, _0xa567d11e.Teal);
        this._0x4e9ba614._0xb043f903(_0xa90c6c9f._0x72c67e81(new byte[14] { 140, 137, 147, 148, 136, 131, 159, 230, 150, 135, 147, 149, 131, 130 }, 198), _0xa90c6c9f._0x72c67e81(new byte[5] { 13, 0, 15, 4, 97 }, 65) + _0xe9207b37.ToString() + _0xa90c6c9f._0x72c67e81(new byte[4] { 183, 216, 209, 183 }, 151) + Mathf.Max(1, _0x2b58a19e).ToString(), _0xef0ed93a.ToString() + _0xa90c6c9f._0x72c67e81(new byte[33] { 215, 180, 191, 190, 180, 188, 164, 215, 160, 190, 163, 191, 215, 174, 184, 162, 215, 218, 215, 163, 182, 188, 178, 215, 174, 184, 162, 165, 215, 163, 190, 186, 178 }, 247));
        this._0x4e9ba614._0xf539f8b2(-1, this._0xeb3a9d75);
        this._0x4e9ba614._0xe4fe36d1(_0xa90c6c9f._0x72c67e81(new byte[6] { 96, 119, 97, 103, 127, 119 }, 50), () => this._0xaddf2cf7());
        this._0x4e9ba614._0xbbb6ec70(_0xa90c6c9f._0x72c67e81(new byte[7] { 102, 121, 124, 124, 113, 119, 117 }, 48), () => this._0xcf16acae());
        this._0x4e9ba614._0x0edf0b10(() => this._0xaddf2cf7());
        _0x498f87d1.Instance._0x20ed82d1(_0xe84084b3._0x0d0ffff4.PAUSE);
        this._0x4e9ba614._0x751475c6(this._0xeb3a9d75);
    }

    [SerializeField]
    private Sprite _winBadge;
    [SerializeField]
    private Sprite _pauseBadge;
}

internal static class _0xa90c6c9f
{
    internal static string _0x72c67e81(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}