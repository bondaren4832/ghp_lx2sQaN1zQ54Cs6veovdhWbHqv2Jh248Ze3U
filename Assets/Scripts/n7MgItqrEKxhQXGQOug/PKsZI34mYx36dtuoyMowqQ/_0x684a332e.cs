using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0x684a332e : MonoBehaviour
{
    private float _0x94dccba7 = 4;
    private float _0x5ba47306 = 0.6f;
    private AspectRatioFitter _0x94d29743;
    private float _0xf910bc45 = 1.5f;
    private float _0xa42c22e9;
    private TMP_Text _0xba4b134e;
    private void Update()
    {
        int _0x3997bd20 = 1;
        if (this._0x56603c31.Count > 0)
        {
            string _0xda30639b = this._0xba4b134e.text;
            foreach (string _0x68feec4e in this._0x56603c31)
                while (_0xda30639b.Contains(_0x68feec4e))
                    _0xda30639b = _0xda30639b.Replace(_0x68feec4e, "");
            _0x3997bd20 = _0xda30639b.Length;
        }
        else
        {
            _0x3997bd20 = this._0xba4b134e.text.Length;
        }

        float _0x4a134bcd = Mathf.Clamp(this._0xa42c22e9 + this._0x5ba47306 * _0x3997bd20, this._0xf910bc45, this._0x94dccba7);
        if (!Mathf.Approximately(this._0x94d29743.aspectRatio, _0x4a134bcd))
            this._0x94d29743.aspectRatio = _0x4a134bcd;
    }

    private List<string> _0x56603c31 = new();
}