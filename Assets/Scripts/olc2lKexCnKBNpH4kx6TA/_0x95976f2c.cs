using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The friend album: a grid of rescued chicks. With nothing rescued the grid is replaced
/// by a themed plate rather than being left blank - that empty state is mandatory, not a
/// nicety (rule G / EMPTY STATES).
/// </summary>
public sealed class _0x95976f2c : MonoBehaviour
{
    [SerializeField]
    private GameObject _emptyPlate;
    private const int Cells = 9;
    [SerializeField]
    private _0x3b0bd600 _catalog;
    [SerializeField]
    private Sprite _chickSprite;
    private void _0xa29dd83e()
    {
        if (this._0x1dc381e0)
        {
            return;
        }

        this._0x1dc381e0 = true;
        for (int _0x302aa3cf = 0; _0x302aa3cf < Cells; _0x302aa3cf++)
        {
            _0x53f3622d _0x2ddab9e3 = Instantiate(this._cellPrefab, this._grid, false);
            _0x2ddab9e3.gameObject.SetActive(true);
            this._0x4c585ac4.Add(_0x2ddab9e3);
        }
    }

    private void Start()
    {
        this._0x99bd46bb();
    }

    [SerializeField]
    private RectTransform _grid;
    private bool _0x1dc381e0;
    public void _0x99bd46bb()
    {
        if (this._store == null || this._catalog == null || this._cellPrefab == null || this._grid == null)
        {
            return;
        }

        this._store._0xe422ae80();
        this._0xa29dd83e();
        int _0x7a0c9941 = 0;
        for (int _0x81a33504 = 0; _0x81a33504 < this._0x4c585ac4.Count; _0x81a33504++)
        {
            bool _0x5351821b = this._store._0x52f0a7a9(_0x81a33504);
            if (_0x5351821b)
            {
                _0x7a0c9941++;
            }

            int _0x7885dddc = Mathf.Clamp(_0x81a33504 / _0x3b0bd600.MissionsPerRegion, 0, _0x3b0bd600.RegionCount - 1);
            if (this._0x4c585ac4[_0x81a33504] != null)
            {
                this._0x4c585ac4[_0x81a33504]._0x9ed71970(this._chickSprite, this._catalog._0xfe78a2f6(_0x81a33504), this._catalog._0x7c95c2a4(_0x7885dddc), _0x5351821b);
            }
        }

        bool _0xd8b803fa = _0x7a0c9941 == 0;
        if (this._grid != null)
        {
            this._grid.gameObject.SetActive(!_0xd8b803fa);
        }

        if (this._emptyPlate != null)
        {
            this._emptyPlate.SetActive(_0xd8b803fa);
        }
    }

    [SerializeField]
    private _0x53f3622d _cellPrefab;
    private readonly List<_0x53f3622d> _0x4c585ac4 = new List<_0x53f3622d>();
    [SerializeField]
    private _0xa198a498 _store;
}