using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The three regions of the countryside with their unlock rules. Opening an unlocked
/// region really switches the journey: the store moves to it and the village page is
/// rebuilt around it, so the tap changes what the player sees, not only a saved number.
/// </summary>
public sealed class _0x3cc73d02 : MonoBehaviour
{
    private bool _0x984029ed;
    public void _0x8d5e5898()
    {
        if (this._store == null || this._catalog == null || this._cardPrefab == null || this._list == null)
        {
            return;
        }

        this._store._0xe422ae80();
        this._0x168feba7();
        int _0xf1490e5f = this._store._0xdde8cedd;
        for (int _0x9ead2a67 = 0; _0x9ead2a67 < this._0x691d72d4.Count; _0x9ead2a67++)
        {
            int _0xb9dc072e = _0x9ead2a67;
            int _0xfff5bbcc = Mathf.Max(_0x3b0bd600.MissionsPerRegion, this._catalog._0x35196b7b(_0xb9dc072e));
            bool _0xf03d7d9f = !this._catalog._0x801b134c(_0xb9dc072e, _0xf1490e5f);
            if (this._0x691d72d4[_0x9ead2a67] != null)
            {
                this._0x691d72d4[_0x9ead2a67]._0xcc748026(this._catalog._0x7c95c2a4(_0xb9dc072e), _0xf1490e5f, _0xfff5bbcc, _0xf03d7d9f, _0xc6c30cf6[_0xb9dc072e % _0xc6c30cf6.Length], () => this._0xb89c1197(_0xb9dc072e));
            }
        }

        if (this._emptyPlate != null)
        {
            this._emptyPlate.SetActive(this._0x691d72d4.Count == 0);
        }
    }

    private void _0xb89c1197(int _0x99538eae)
    {
        if (this._store == null)
        {
            return;
        }

        this._store._0xaebebbcb = _0x99538eae;
        this._store._0x0a476385 = 0;
        this._0x8d5e5898();
        if (this._home != null)
        {
            this._home._0xf744486d();
        }
    }

    [SerializeField]
    private _0xe2f3b055 _cardPrefab;
    private static readonly Color[] _0xc6c30cf6 =
    {
        new Color(0.8901961f, 0.7764706f, 0.41960785f, 1f),
        new Color(0.18039216f, 0.6156863f, 0.56078434f, 1f),
        new Color(0.9490196f, 0.4117647f, 0.23529412f, 1f),
    };
    private readonly List<_0xe2f3b055> _0x691d72d4 = new List<_0xe2f3b055>();
    [SerializeField]
    private _0x4387ff13 _home;
    [SerializeField]
    private _0xa198a498 _store;
    [SerializeField]
    private RectTransform _list;
    private void Start()
    {
        this._0x8d5e5898();
    }

    [SerializeField]
    private _0x3b0bd600 _catalog;
    [SerializeField]
    private GameObject _emptyPlate;
    private void _0x168feba7()
    {
        if (this._0x984029ed)
        {
            return;
        }

        this._0x984029ed = true;
        for (int _0x27b63622 = 0; _0x27b63622 < _0x3b0bd600.RegionCount; _0x27b63622++)
        {
            _0xe2f3b055 _0x804b89d7 = Instantiate(this._cardPrefab, this._list, false);
            _0x804b89d7.gameObject.SetActive(true);
            this._0x691d72d4.Add(_0x804b89d7);
        }
    }
}