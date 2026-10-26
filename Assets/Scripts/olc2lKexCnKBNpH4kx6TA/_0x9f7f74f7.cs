using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The journey map: five mission nodes of the current region, built from a prefab. The
/// current node also starts the run, which is the second way into the game besides the
/// Play slot on the village page.
/// The empty-state plate exists and is wired even though a region always has five nodes -
/// the page must never be able to render an unexplained blank (rule G / EMPTY STATES).
/// </summary>
public sealed class _0x9f7f74f7 : MonoBehaviour
{
    private const int StateCurrent = 1;
    private void _0x0ed83ac0()
    {
        if (this._0x65b0f274)
        {
            return;
        }

        this._0x65b0f274 = true;
        for (int _0x78ede481 = 0; _0x78ede481 < _0x3b0bd600.MissionsPerRegion; _0x78ede481++)
        {
            _0x84bd5ab1 _0xc9be9035 = Instantiate(this._nodePrefab, this._nodeHost, false);
            _0xc9be9035.gameObject.SetActive(true);
            this._0x35e9a26b.Add(_0xc9be9035);
        }
    }

    private const int StateCleared = 0;
    public void _0xe09c0c28()
    {
        if (this._store == null || this._catalog == null || this._nodePrefab == null || this._nodeHost == null)
        {
            return;
        }

        this._store._0xe422ae80();
        this._0x0ed83ac0();
        int _0xe91c3f7e = Mathf.Clamp(this._store._0xaebebbcb, 0, _0x3b0bd600.RegionCount - 1);
        int _0x39d3c83f = Mathf.Clamp(this._store._0x0a476385, 0, _0x3b0bd600.MissionsPerRegion - 1);
        bool _0x18763f82 = this._store._0x42811e0a;
        for (int _0xb2da98be = 0; _0xb2da98be < this._0x35e9a26b.Count; _0xb2da98be++)
        {
            _0x84bd5ab1 _0xe17eea24 = this._0x35e9a26b[_0xb2da98be];
            if (_0xe17eea24 == null)
            {
                continue;
            }

            int _0x2457f54f = _0xb2da98be;
            int _0x7441d5f7 = this._store._0x4f35c54e(_0xe91c3f7e, _0x2457f54f);
            int _0xb9abb6d5 = _0x2457f54f < _0x39d3c83f ? StateCleared : (_0x2457f54f == _0x39d3c83f ? StateCurrent : StateLocked);
            string _0x8b05a0b0 = this._catalog._0x05a42898(_0xe91c3f7e, _0x2457f54f).ToString() + _0x72f02aec._0x29dcf34d(new byte[9] { 118, 26, 23, 24, 19, 5, 118, 123, 118 }, 86) + this._catalog._0x1e553a3b(_0xe91c3f7e, _0x2457f54f).ToString() + _0x72f02aec._0x29dcf34d(new byte[7] { 140, 239, 228, 229, 239, 231, 255 }, 172);
            _0xe17eea24._0xc1e1a189(_0x2457f54f + 1, this._catalog._0x4d9d35e2(_0x2457f54f), _0x8b05a0b0, _0x7441d5f7, _0xb9abb6d5, _0x18763f82, () => this._0x099df9d0(_0x2457f54f));
        }

        if (this._emptyPlate != null)
        {
            this._emptyPlate.SetActive(this._0x35e9a26b.Count == 0);
        }
    }

    [SerializeField]
    private _0x84bd5ab1 _nodePrefab;
    private bool _0x65b0f274;
    private void _0x099df9d0(int _0x2dab10ea)
    {
        if (this._store != null)
        {
            this._store._0x0a476385 = _0x2dab10ea;
        }

        if (_0x2755d8a9.Instance != null)
        {
            _0x2755d8a9.Instance._0x017e7362(_0xe84084b3._0x75d3016f.SCENE_1);
        }
    }

    private const int StateLocked = 2;
    private void Start()
    {
        this._0xe09c0c28();
    }

    [SerializeField]
    private _0x3b0bd600 _catalog;
    [SerializeField]
    private GameObject _emptyPlate;
    [SerializeField]
    private RectTransform _nodeHost;
    [SerializeField]
    private _0xa198a498 _store;
    private readonly List<_0x84bd5ab1> _0x35e9a26b = new List<_0x84bd5ab1>();
}

internal static class _0x72f02aec
{
    internal static string _0x29dcf34d(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}