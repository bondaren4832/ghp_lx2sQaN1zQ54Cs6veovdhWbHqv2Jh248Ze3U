using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xe84084b3;

public class _0x498f87d1 : MonoBehaviour
{
    public GameObject BlurBackground;
    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0x97d07d83 _0xd5d4cc8f in this.Pops)
            if (_0xd5d4cc8f != null)
                _0xd5d4cc8f.gameObject.SetActive(true);
    }

    public int CurrentPopIndex;
    private void _0x9fbabbd2(bool _0x7e7665ab = false)
    {
        for (int _0x9bba680f = 0; _0x9bba680f < this.Pops.Count; ++_0x9bba680f)
            if (this.Pops[_0x9bba680f] != null && !(_0x9bba680f == this.CurrentPopIndex && _0x7e7665ab))
                this.Pops[_0x9bba680f]._0xbbcd1d15();
    }

    public void _0x386c420a()
    {
        this.LastPopIndexes.RemoveAll(_0xda67b22e => _0xda67b22e == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0x6c5bed12();
        else
            this._0x20ed82d1(this.LastPopIndexes.Last());
    }

    private void _0x36495c64()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x498f87d1>();
    }

    public List<GameObject> GameObjectsToHide;
    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    public List<_0x97d07d83> Pops;
    public float ScaleDuration = 0.4f;
    public _0x97d07d83 _0x9515894f(int _0x8f44adaa)
    {
        return this.Pops[_0x8f44adaa];
    }

    private void _0x71c34088()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    public void _0x6c5bed12()
    {
        this.LastPopIndexes.Clear();
        this._0x9fbabbd2();
        foreach (GameObject _0xc495e63c in this.GameObjectsToHide)
            if (_0xc495e63c != null)
                _0xc495e63c.SetActive(true);
        this._0x36495c64();
    }

    public static _0x498f87d1 Instance;
    public List<int> LastPopIndexes = new();
    public void _0x20ed82d1(int _0xcc56a8e4)
    {
        this.CurrentPopIndex = _0xcc56a8e4;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0x9fbabbd2(true);
        this._0x71c34088();
        this.Pops[_0xcc56a8e4].Show();
        foreach (GameObject _0x8ed91460 in this.GameObjectsToHide)
            _0x8ed91460.SetActive(false);
    }
}