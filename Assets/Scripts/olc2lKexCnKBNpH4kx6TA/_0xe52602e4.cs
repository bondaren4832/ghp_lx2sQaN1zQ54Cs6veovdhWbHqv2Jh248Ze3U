using TMPro;
using UnityEngine;

/// <summary>
/// The only generated object standing in the menu scene root. It drops the splash and the
/// village surfaces into the template panels by INDEX (never by name) and empties every
/// template panel this game does not dress, so no placeholder copy can reach the screen
/// (rule C.15).
/// </summary>
public sealed class _0xe52602e4 : MonoBehaviour
{
    private void Start()
    {
        if (_0xc9856497.Instance == null || _0xc9856497.Instance.Panels == null)
        {
            return;
        }

        this._0xd6f9dbea(this._splashViewPrefab, _0xe84084b3._0x35f75e78.SPLASH, true);
        this._0xd6f9dbea(this._menuViewPrefab, _0xe84084b3._0x35f75e78.DEFAULT, false);
        this._0xf1ea3384();
    }

    private static readonly int[] _0x116cb8ff =
    {
        _0xe84084b3._0x35f75e78.TUTORIAL0,
        _0xe84084b3._0x35f75e78.TUTORIAL1,
        _0xe84084b3._0x35f75e78.TUTORIAL2,
        _0xe84084b3._0x35f75e78.TUTORIAL3,
        _0xe84084b3._0x35f75e78.TUTORIAL4,
        _0xe84084b3._0x35f75e78.TUTORIAL5,
        _0xe84084b3._0x35f75e78.TUTORIAL6,
    };
    [SerializeField]
    private GameObject _menuViewPrefab;
    private void _0xf1ea3384()
    {
        for (int _0x41189ce9 = 0; _0x41189ce9 < _0x116cb8ff.Length; _0x41189ce9++)
        {
            int _0xe522a969 = _0x116cb8ff[_0x41189ce9];
            if (_0xe522a969 < 0 || _0xe522a969 >= _0xc9856497.Instance.Panels.Count)
            {
                continue;
            }

            _0x544a2399 _0x39b6c707 = _0xc9856497.Instance.Panels[_0xe522a969];
            if (_0x39b6c707 == null)
            {
                continue;
            }

            TMP_Text[] _0x5a42a0b1 = _0x39b6c707.GetComponentsInChildren<TMP_Text>(true);
            for (int _0x9864d621 = 0; _0x9864d621 < _0x5a42a0b1.Length; _0x9864d621++)
            {
                _0x5a42a0b1[_0x9864d621].text = string.Empty;
            }
        }
    }

    private void _0xd6f9dbea(GameObject _0x0ea974be, int _0xe5f31418, bool _0x5e14b523)
    {
        if (_0x0ea974be == null || _0xe5f31418 < 0 || _0xe5f31418 >= _0xc9856497.Instance.Panels.Count)
        {
            return;
        }

        _0x544a2399 _0x19599e14 = _0xc9856497.Instance.Panels[_0xe5f31418];
        if (_0x19599e14 == null || _0x19599e14.Content == null)
        {
            return;
        }

        GameObject _0xb831b542 = Instantiate(_0x0ea974be, _0x19599e14.Content.transform, false);
        RectTransform _0x3f25c4e4 = _0xb831b542.transform as RectTransform;
        if (_0x3f25c4e4 != null)
        {
            _0x3f25c4e4.anchorMin = Vector2.zero;
            _0x3f25c4e4.anchorMax = Vector2.one;
            _0x3f25c4e4.offsetMin = Vector2.zero;
            _0x3f25c4e4.offsetMax = Vector2.zero;
        }

        if (_0x5e14b523)
        {
            // Behind the template loading bar, so the bar keeps drawing over the splash.
            _0xb831b542.transform.SetAsFirstSibling();
        }
        else
        {
            // In front of the Play slot, whose own layers render nothing; HomeView then
            // parents the visible face INTO that slot so the face and the tap rect match.
            _0xb831b542.transform.SetAsLastSibling();
        }
    }

    [SerializeField]
    private GameObject _splashViewPrefab;
}