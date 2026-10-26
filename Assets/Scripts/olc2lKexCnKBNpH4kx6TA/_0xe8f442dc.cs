using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// One challenge row. Icon gutter at x 96 width 120, text column from x 232 - the two
/// bands never share horizontal space (rule C.25).
/// </summary>
public sealed class _0xe8f442dc : MonoBehaviour
{
    [SerializeField]
    private Image _dot;
    public void _0xe5003e78(string _0xd4c85eb4, int _0x55fbdf8b, int _0xdfa0382a)
    {
        int _0xb06dc66f = Mathf.Max(1, _0xdfa0382a);
        bool _0x10606f89 = _0x55fbdf8b >= _0xb06dc66f;
        if (this._title != null)
        {
            this._title.text = _0xd4c85eb4;
        }

        if (this._progress != null)
        {
            this._progress.text = Mathf.Min(_0x55fbdf8b, _0xb06dc66f).ToString() + _0x5c1f3a93._0xba82e2e6(new byte[4] { 43, 68, 77, 43 }, 11) + _0xb06dc66f.ToString();
        }

        if (this._plate != null)
        {
            this._plate.color = _0x10606f89 ? _0xa567d11e.Base : _0xa567d11e.Surface;
        }

        if (this._dot != null)
        {
            this._dot.color = _0x10606f89 ? _0xa567d11e.Teal : _0xa567d11e.Primary;
        }

        if (this._pillPlate != null)
        {
            this._pillPlate.color = _0x10606f89 ? _0xa567d11e.Teal : _0xa567d11e.SurfaceAlt;
        }

        if (this._pillLabel == null)
        {
            return;
        }

        this._pillLabel.text = _0x10606f89 ? _0x5c1f3a93._0xba82e2e6(new byte[4] { 138, 129, 128, 139 }, 206) : Mathf.RoundToInt(100f * Mathf.Clamp01((float)_0x55fbdf8b / _0xb06dc66f)).ToString() + _0x5c1f3a93._0xba82e2e6(new byte[1] { 197 }, 224);
        this._pillLabel.color = _0x10606f89 ? _0xa567d11e.Ink : _0xa567d11e.Caption;
    }

    [SerializeField]
    private TMP_Text _title;
    [SerializeField]
    private Image _pillPlate;
    [SerializeField]
    private Image _plate;
    [SerializeField]
    private TMP_Text _pillLabel;
    [SerializeField]
    private TMP_Text _progress;
}

internal static class _0x5c1f3a93
{
    internal static string _0xba82e2e6(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}