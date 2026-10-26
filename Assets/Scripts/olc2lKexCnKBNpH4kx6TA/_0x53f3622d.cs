using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>One chick in the friend album: found, or a muted silhouette with NOT YET.</summary>
public sealed class _0x53f3622d : MonoBehaviour
{
    [SerializeField]
    private Image _plate;
    [SerializeField]
    private TMP_Text _whereLabel;
    public void _0x9ed71970(Sprite _0x610a934f, string _0x1185c8fd, string _0x0fa75f38, bool _0x9fa8875d)
    {
        if (this._portrait != null)
        {
            this._portrait.sprite = _0x610a934f;
            this._portrait.color = _0x9fa8875d ? Color.white : _0xa567d11e.Fade(_0xa567d11e.Edge, 0.95f);
        }

        if (this._plate != null)
        {
            this._plate.color = _0x9fa8875d ? _0xa567d11e.Base : _0xa567d11e.SurfaceAlt;
        }

        if (this._namePlate != null)
        {
            this._namePlate.color = _0x9fa8875d ? _0xa567d11e.Surface : _0xa567d11e.Edge;
        }

        if (this._nameLabel != null)
        {
            this._nameLabel.text = _0x9fa8875d ? _0x1185c8fd : _0xa15efba7._0x01f7ce2e(new byte[7] { 235, 234, 241, 133, 252, 224, 241 }, 165);
            this._nameLabel.color = _0x9fa8875d ? _0xa567d11e.Ink : _0xa567d11e.Caption;
        }

        if (this._whereLabel != null)
        {
            this._whereLabel.text = _0x9fa8875d ? _0x0fa75f38 : _0xa15efba7._0x01f7ce2e(new byte[12] { 68, 74, 74, 95, 47, 88, 78, 67, 68, 70, 65, 72 }, 15);
        }
    }

    [SerializeField]
    private TMP_Text _nameLabel;
    [SerializeField]
    private Image _portrait;
    [SerializeField]
    private Image _namePlate;
}

internal static class _0xa15efba7
{
    internal static string _0x01f7ce2e(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}