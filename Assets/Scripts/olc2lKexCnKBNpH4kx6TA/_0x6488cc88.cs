using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Three standing challenges, fed by the counters the run commits to the store. The empty
/// plate is wired even though the catalogue always yields three rows - the page must never
/// be able to show a blank area with no explanation.
/// </summary>
public sealed class _0x6488cc88 : MonoBehaviour
{
    [SerializeField]
    private _0xa198a498 _store;
    private readonly List<_0xe8f442dc> _0xdcfa2acc = new List<_0xe8f442dc>();
    [SerializeField]
    private RectTransform _list;
    private bool _0x9c6694e6;
    [SerializeField]
    private _0xe8f442dc _rowPrefab;
    private void _0x0a389489()
    {
        if (this._0x9c6694e6)
        {
            return;
        }

        this._0x9c6694e6 = true;
        for (int _0x271742ca = 0; _0x271742ca < _0x697a24d5.Length; _0x271742ca++)
        {
            _0xe8f442dc _0xa0d43229 = Instantiate(this._rowPrefab, this._list, false);
            _0xa0d43229.gameObject.SetActive(true);
            this._0xdcfa2acc.Add(_0xa0d43229);
        }
    }

    [SerializeField]
    private GameObject _emptyPlate;
    public void _0x7fbdc1f0()
    {
        if (this._store == null || this._rowPrefab == null || this._list == null)
        {
            return;
        }

        this._store._0xe422ae80();
        this._0x0a389489();
        for (int _0xcb6f1619 = 0; _0xcb6f1619 < this._0xdcfa2acc.Count; _0xcb6f1619++)
        {
            int _0x9a4821d9 = _0xcb6f1619 == 2 ? this._store._0xdde8cedd : this._store._0x5fb3ffc5(_0xcb6f1619);
            if (this._0xdcfa2acc[_0xcb6f1619] != null)
            {
                this._0xdcfa2acc[_0xcb6f1619]._0xe5003e78(_0x697a24d5[_0xcb6f1619], _0x9a4821d9, _0x1d460db1[_0xcb6f1619]);
            }
        }

        if (this._emptyPlate != null)
        {
            this._emptyPlate.SetActive(this._0xdcfa2acc.Count == 0);
        }
    }

    private void Start()
    {
        this._0x7fbdc1f0();
    }

    private static readonly int[] _0x1d460db1 =
    {
        20,
        3,
        5
    };
    private static readonly string[] _0x697a24d5 =
    {
        _0xb0029b1f._0x370ad7b1(new byte[29] { 32, 49, 44, 48, 48, 67, 81, 83, 67, 47, 34, 45, 38, 48, 67, 42, 45, 67, 44, 45, 38, 67, 41, 44, 54, 49, 45, 38, 58 }, 99),
        _0xb0029b1f._0x370ad7b1(new byte[30] { 231, 240, 230, 246, 224, 240, 149, 134, 149, 246, 253, 252, 246, 254, 230, 149, 252, 251, 149, 250, 251, 240, 149, 255, 250, 224, 231, 251, 240, 236 }, 181),
        _0xb0029b1f._0x370ad7b1(new byte[17] { 0, 15, 8, 15, 21, 14, 102, 115, 102, 12, 9, 19, 20, 8, 3, 31, 21 }, 70),
    };
}

internal static class _0xb0029b1f
{
    internal static string _0x370ad7b1(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}