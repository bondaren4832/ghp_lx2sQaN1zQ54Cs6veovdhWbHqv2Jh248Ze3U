using TMPro;
using UnityEngine;

/// <summary>
/// The only generated object standing in the game scene root. It drops the crossing view
/// into the template DefaultPanel by INDEX (never by name) and empties every template
/// panel this game does not dress, so no placeholder copy can reach the screen (C.15).
/// </summary>
public sealed class _0x867850d7 : MonoBehaviour
{
    private void _0x59e9d844()
    {
        for (int _0xf7a3d776 = 0; _0xf7a3d776 < _0xdf294793.Length; _0xf7a3d776++)
        {
            int _0xe3565c15 = _0xdf294793[_0xf7a3d776];
            if (_0xe3565c15 < 0 || _0xe3565c15 >= _0xc9856497.Instance.Panels.Count)
            {
                continue;
            }

            _0x544a2399 _0x40262b64 = _0xc9856497.Instance.Panels[_0xe3565c15];
            if (_0x40262b64 == null)
            {
                continue;
            }

            TMP_Text[] _0x89a4d68e = _0x40262b64.GetComponentsInChildren<TMP_Text>(true);
            for (int _0x5a6d722f = 0; _0x5a6d722f < _0x89a4d68e.Length; _0x5a6d722f++)
            {
                _0x89a4d68e[_0x5a6d722f].text = string.Empty;
            }
        }
    }

    [SerializeField]
    private GameObject _splashViewPrefab;
    private void Start()
    {
        if (_0xc9856497.Instance == null || _0xc9856497.Instance.Panels == null)
        {
            return;
        }

        this._0xc9266237(this._splashViewPrefab, _0xe84084b3._0x35f75e78.SPLASH, true);
        this._0xc9266237(this._crossingViewPrefab, _0xe84084b3._0x35f75e78.DEFAULT, false);
        this._0x59e9d844();
    }

    /// <summary>
    /// Panel.Content is public and the list is addressed by index, so this survives
    /// obfuscation. Panel.Awake leaves Content active at scale zero, so the view runs its
    /// own Start while the splash is still up and the panel tween reveals it.
    /// </summary>
    private void _0xc9266237(GameObject _0x8bdeeb30, int _0xea67cfd3, bool _0x36e5cd61)
    {
        if (_0x8bdeeb30 == null || _0xea67cfd3 < 0 || _0xea67cfd3 >= _0xc9856497.Instance.Panels.Count)
        {
            return;
        }

        _0x544a2399 _0xc365316e = _0xc9856497.Instance.Panels[_0xea67cfd3];
        if (_0xc365316e == null || _0xc365316e.Content == null)
        {
            return;
        }

        GameObject _0xcf4cb8c7 = Instantiate(_0x8bdeeb30, _0xc365316e.Content.transform, false);
        RectTransform _0xe0544156 = _0xcf4cb8c7.transform as RectTransform;
        if (_0xe0544156 != null)
        {
            _0xe0544156.anchorMin = Vector2.zero;
            _0xe0544156.anchorMax = Vector2.one;
            _0xe0544156.offsetMin = Vector2.zero;
            _0xe0544156.offsetMax = Vector2.zero;
        }

        if (_0x36e5cd61)
        {
            _0xcf4cb8c7.transform.SetAsFirstSibling();
        }
        else
        {
            _0xcf4cb8c7.transform.SetAsLastSibling();
        }
    }

    [SerializeField]
    private GameObject _crossingViewPrefab;
    /// <summary>SETTINGS declares TUTORIAL0..TUTORIAL6. The tutorial is off for this game -
    /// the control scheme is explained by the permanent hint strip in the play field
    /// (rule C.6) - so all seven are emptied rather than shipped with template copy.</summary>
    private static readonly int[] _0xdf294793 =
    {
        _0xe84084b3._0x35f75e78.TUTORIAL0,
        _0xe84084b3._0x35f75e78.TUTORIAL1,
        _0xe84084b3._0x35f75e78.TUTORIAL2,
        _0xe84084b3._0x35f75e78.TUTORIAL3,
        _0xe84084b3._0x35f75e78.TUTORIAL4,
        _0xe84084b3._0x35f75e78.TUTORIAL5,
        _0xe84084b3._0x35f75e78.TUTORIAL6,
    };
}