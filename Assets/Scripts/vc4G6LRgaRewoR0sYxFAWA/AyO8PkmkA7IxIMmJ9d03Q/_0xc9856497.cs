using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xe84084b3;

public class _0xc9856497 : MonoBehaviour
{
    public static _0xc9856497 Instance;
    public float StaticBlurMaterialInitialValue;
    public float ScaleDuration = 0.4f;
    private void SwitchSplash()
    {
        if (_0x547f0258.Instance.IsTutorialEnabled && !_0x2755d8a9._0x0c0d1506._0x068c2625)
            this._0xf246b714(_0x35f75e78.TUTORIAL0);
        else
            this._0xf246b714(_0x35f75e78.DEFAULT);
    }

    private void _0x784fe56a(int _0x8555656a)
    {
        this.LastPanelIndexes.Add(_0x8555656a);
        this.CurrentPanelIndex = _0x8555656a;
        for (int _0x0a29b19d = 0; _0x0a29b19d < this.Panels.Count; _0x0a29b19d++)
            if (_0x0a29b19d != _0x8555656a && this.Panels[_0x0a29b19d] != null)
                this.Panels[_0x0a29b19d]._0x69ccb69b();
    }

    public List<_0x544a2399> Panels;
    private void _0xe15b7d17()
    {
        this._0x923ce005(_0x35f75e78.SPLASH);
        if (_0x2755d8a9.Instance._0x3dc419bb == _0x75d3016f.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0x6fd584ac.Instance.DefaultAnimationTime);
        }
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xc9856497>();
    }

    private _0x544a2399 _0xb8184b78(int _0x0efbe709)
    {
        return this.Panels[_0x0efbe709];
    }

    private void Start()
    {
        this._0xe15b7d17();
    }

    private void _0x923ce005(int _0xdcef6920)
    {
        this._0x784fe56a(_0xdcef6920);
        this._0x327c4346(_0xdcef6920);
        this.CurrentPanelIndex = _0xdcef6920;
        this.Panels[_0xdcef6920]._0x75c25ebc();
    }

    public int CurrentPanelIndex;
    private void _0x327c4346(int _0x3985aa1c)
    {
        if (_0x3985aa1c == _0x35f75e78.SPLASH)
            _0x6fd584ac.Instance._0x531c3337();
        if (_0x2755d8a9.Instance._0x3dc419bb == _0x75d3016f.SCENE_0)
        {
        }
    }

    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    private void _0x9731cc27(int _0xc63189ce)
    {
        this.LastPanelIndexes.Add(_0xc63189ce);
        this.CurrentPanelIndex = _0xc63189ce;
        for (int _0x1be30f83 = 0; _0x1be30f83 < this.Panels.Count; _0x1be30f83++)
            if (_0x1be30f83 != _0xc63189ce && this.Panels[_0x1be30f83] != null)
                this.Panels[_0x1be30f83]._0x69ccb69b();
    }

    public bool IsShowSplashOnStart = true;
    public void _0x9095aa9a()
    {
        this.LastPanelIndexes.RemoveAll(_0xda67b22e => _0xda67b22e == this.CurrentPanelIndex);
        int _0x1b9286a8 = this.LastPanelIndexes.Last();
        this._0x327c4346(_0x1b9286a8);
        this._0x9731cc27(_0x1b9286a8);
        this.CurrentPanelIndex = _0x1b9286a8;
        this.Panels[_0x1b9286a8].Show();
    }

    public void _0xfb4b2a0e(int _0xe807e1a3)
    {
        if (_0xe807e1a3 == _0x35f75e78.SPLASH && _0x2755d8a9.Instance._0x3dc419bb != _0x75d3016f.SCENE_0)
            _0x6fd584ac.Instance._0xfe881cb2();
        if (_0x2755d8a9.Instance._0x3dc419bb != _0x75d3016f.SCENE_0)
        {
            if (_0xe807e1a3 == _0x35f75e78.SPLASH || _0xe807e1a3 == _0x35f75e78.TUTORIAL0)
                _0x2755d8a9.Instance._0xf3636c95(false);
            else if (_0xe807e1a3 == _0x35f75e78.DEFAULT)
                _0x2755d8a9.Instance._0xf3636c95(true);
        }
    }

    public void _0xf246b714(int _0x893d1e31)
    {
        this._0x784fe56a(_0x893d1e31);
        this._0x327c4346(_0x893d1e31);
        this.CurrentPanelIndex = _0x893d1e31;
        this.Panels[_0x893d1e31].Show();
    }
}