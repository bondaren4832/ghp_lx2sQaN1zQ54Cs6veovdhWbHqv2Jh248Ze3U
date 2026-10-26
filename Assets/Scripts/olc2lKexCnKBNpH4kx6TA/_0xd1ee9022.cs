using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The in-run HUD: three feather pips, the chick counter, the lane progress bar and the
/// permanent control hint. All of these are OUR OWN objects inside the generated game
/// view - not one template placeholder is reused or written into (rule C.2).
/// </summary>
public sealed class _0xd1ee9022 : MonoBehaviour
{
    private bool _0x5af9a287;
    public void _0x7af14811()
    {
        if (this._progressFill != null && this._progressFill.parent is RectTransform)
        {
            RectTransform _0x1bdfc80a = (RectTransform)this._progressFill.parent;
            this._0x69286c2b = Mathf.Max(1f, _0x1bdfc80a.rect.width);
            this._progressFill.sizeDelta = new Vector2(0f, this._progressFill.sizeDelta.y);
        }

        if (this._hintLabel != null)
        {
            this._hintLabel.text = RoadHint;
        }
    }

    private static readonly string RoadHint = _0x0ea037c5._0x1a20c6a0(new byte[49] { 217, 204, 221, 173, 217, 194, 173, 197, 194, 221, 173, 160, 173, 197, 194, 193, 201, 173, 217, 194, 173, 193, 194, 195, 202, 173, 197, 194, 221, 173, 160, 173, 217, 204, 221, 173, 222, 196, 201, 200, 222, 173, 217, 194, 173, 222, 217, 200, 221 }, 141);
    [SerializeField]
    private Image[] _pips;
    private void OnDestroy()
    {
        if (this._pips != null)
        {
            for (int _0x4cf62f6f = 0; _0x4cf62f6f < this._pips.Length; _0x4cf62f6f++)
            {
                if (this._pips[_0x4cf62f6f] != null)
                {
                    DOTween.Kill(this._pips[_0x4cf62f6f]);
                }
            }
        }

        if (this._progressFill != null)
        {
            DOTween.Kill(this._progressFill);
        }
    }

    public void _0x04aeca60(int _0xe3a5499f, int _0xb6c76675)
    {
        if (this._chickLabel != null)
        {
            this._chickLabel.text = _0xe3a5499f.ToString() + _0x0ea037c5._0x1a20c6a0(new byte[3] { 41, 38, 41 }, 9) + Mathf.Max(1, _0xb6c76675).ToString();
        }
    }

    private float _0x69286c2b = 1f;
    [SerializeField]
    private TMP_Text _hintLabel;
    public void _0x8d74b845(int _0x00605b75)
    {
        if (this._pips == null)
        {
            return;
        }

        for (int _0xf0d0b2ea = 0; _0xf0d0b2ea < this._pips.Length; _0xf0d0b2ea++)
        {
            if (this._pips[_0xf0d0b2ea] == null)
            {
                continue;
            }

            bool _0x2ec784b0 = _0xf0d0b2ea < _0x00605b75;
            Color _0xbcf52719 = _0x2ec784b0 ? _0xa567d11e.Primary : _0xa567d11e.Fade(_0xa567d11e.Edge, 0.5f);
            this._pips[_0xf0d0b2ea].DOColor(_0xbcf52719, 0.22f).SetLink(this._pips[_0xf0d0b2ea].gameObject);
        }
    }

    [SerializeField]
    private TMP_Text _chickLabel;
    [SerializeField]
    private RectTransform _progressFill;
    [SerializeField]
    private TMP_Text _laneLabel;
    /// <summary>The hint swaps while the rooster is in a river band, because the control
    /// that matters there is the timing of the next raft, not the hop itself (rule C.6).</summary>
    public void _0x026f927b(bool _0x7509c1a8)
    {
        if (this._0x5af9a287 == _0x7509c1a8 || this._hintLabel == null)
        {
            return;
        }

        this._0x5af9a287 = _0x7509c1a8;
        this._hintLabel.text = _0x7509c1a8 ? RiverHint : RoadHint;
    }

    private void Start()
    {
        this._0x7af14811();
    }

    private static readonly string RiverHint = _0x0ea037c5._0x1a20c6a0(new byte[46] { 10, 17, 28, 29, 120, 12, 16, 29, 120, 10, 25, 30, 12, 120, 117, 120, 16, 23, 8, 120, 15, 16, 29, 22, 120, 12, 16, 29, 120, 22, 29, 0, 12, 120, 23, 22, 29, 120, 20, 17, 22, 29, 11, 120, 13, 8 }, 88);
    public void _0xd0d26cc1(int _0x9d911981, int _0x164f406c)
    {
        int _0xe93654e4 = Mathf.Max(1, _0x164f406c);
        if (this._laneLabel != null)
        {
            this._laneLabel.text = _0x0ea037c5._0x1a20c6a0(new byte[5] { 248, 245, 250, 241, 148 }, 180) + Mathf.Clamp(_0x9d911981, 0, _0xe93654e4).ToString() + _0x0ea037c5._0x1a20c6a0(new byte[3] { 228, 235, 228 }, 196) + _0xe93654e4.ToString();
        }

        if (this._progressFill != null)
        {
            float width = this._0x69286c2b * Mathf.Clamp01((float)_0x9d911981 / _0xe93654e4);
            this._progressFill.DOSizeDelta(new Vector2(width, this._progressFill.sizeDelta.y), 0.2f).SetLink(this._progressFill.gameObject);
        }
    }
}

internal static class _0x0ea037c5
{
    internal static string _0x1a20c6a0(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}