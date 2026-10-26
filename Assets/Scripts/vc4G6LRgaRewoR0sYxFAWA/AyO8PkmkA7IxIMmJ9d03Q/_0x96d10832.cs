using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x96d10832 : MonoBehaviour
{
    [HideInInspector]
    public int TimeLeft;
    public void _0xf4f30696()
    {
        if (_0x547f0258.Instance.IsOnlyWinGameEndEnabled)
            this._0x397f6320();
        if (!this.IsGameEnd)
        {
            this._0x04741de8();
            _0x2755d8a9.IsAfterLevelComplete = false;
            _0x2755d8a9.IsAfterLevelFailed = true;
            _0x97d07d83 _0xb50405c5 = _0x498f87d1.Instance._0x9515894f(_0xe84084b3._0x0d0ffff4.LOSE).GetComponent<_0x97d07d83>();
            if (_0x547f0258.Instance.IsCheckScoreEnabled)
                _0xb50405c5.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x15bf7030}";
            else
                _0xb50405c5.ContentMainText.text = $"{this.ScoreCurrent}";
            _0xb50405c5.ContentAdditionalText.text = $"{0}";
            _0xe84084b3._0x7744f800._0xc04d35d5 += 0;
            _0x498f87d1.Instance._0x20ed82d1(_0xe84084b3._0x0d0ffff4.LOSE);
        }
    }

    public List<TMP_Text> TimerText = new();
    private void _0xf31bcf0b()
    {
        if (this.ScoreCurrent > _0x2755d8a9._0x0c0d1506._0x32703d62)
            _0x2755d8a9._0x0c0d1506._0x32703d62 = this.ScoreCurrent;
        if (_0x547f0258.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0x15bf7030)
                this._0x397f6320();
    }

    private IEnumerator _0x3e974152()
    {
        this._0xbb216fd3();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0x2755d8a9.Instance._0x3dc419bb == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0x2755d8a9.Instance._0xde008afc)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0xbb216fd3();
            }
        }

        if (!this.IsGameEnd)
            this._0xf4f30696();
    }

    public List<TMP_Text> LevelNumberText = new();
    public int CustomTimeInitial = 30;
    private static _0x96d10832 _0xaa5ce3ef;
    private void _0xbb216fd3()
    {
        this.TimerText.ForEach(_0x0820551e => _0x0820551e.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0xa6bb318a._0x1ae099c1(new byte[6] { 171, 171, 154, 252, 181, 181 }, 198)));
    }

    [HideInInspector]
    public int ScoreCurrent;
    public List<TMP_Text> ScoreText = new();
    public List<Button> PauseButtons = new();
    public int CustomTargetScore = 10;
    public List<TMP_Text> SubtitleText = new();
    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0x99a7fe23;
        this.CurrentGameIndex = _0x2755d8a9.Instance._0x3dc419bb;
        foreach (Button _0x330353ab in this.HomeButtons)
            _0x330353ab.onClick.AddListener(() =>
            {
                this._0x490e0596();
            });
        foreach (Button _0xbbc3e46e in this.PauseButtons)
            _0xbbc3e46e.onClick.AddListener(() =>
            {
                _0x2755d8a9.Instance._0xf3636c95(false);
                _0x498f87d1.Instance._0x20ed82d1(_0xe84084b3._0x0d0ffff4.PAUSE);
            });
        this._0x92f6d76d();
        this.LevelNumberText.ForEach(_0x0820551e => _0x0820551e.text = $"LVL {_0x2755d8a9._0x0c0d1506._0x2253b18a + 1}");
        if (_0x547f0258.Instance.IsTimerEnabled)
        {
            this._0xbb216fd3();
            this.StartCoroutine(this._0x3e974152());
        }
    }

    private void Awake()
    {
        _0xaa5ce3ef = this.gameObject.GetComponent<_0x96d10832>();
    }

    public List<Button> HomeButtons = new();
    private int _0x99a7fe23 => this.CustomTimeInitial + _0x2755d8a9._0x0c0d1506._0x2253b18a * 10;
    private int _0x058ed203 => this.ScoreCurrent;

    public void _0x397f6320()
    {
        if (!this.IsGameEnd)
        {
            this._0x04741de8();
            _0x2755d8a9.IsAfterLevelComplete = true;
            _0x2755d8a9.IsAfterLevelFailed = false;
            _0x97d07d83 _0xeea9f6cb = _0x498f87d1.Instance._0x9515894f(_0xe84084b3._0x0d0ffff4.WIN).GetComponent<_0x97d07d83>();
            if (_0x547f0258.Instance.IsCheckScoreEnabled)
                _0xeea9f6cb.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x15bf7030}";
            else
                _0xeea9f6cb.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0x547f0258.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0xe84084b3._0x7744f800._0xc04d35d5)
                    _0xe84084b3._0x7744f800._0xc04d35d5 = this.ScoreCurrent;
                _0xeea9f6cb.ContentAdditionalText.text = $"{_0xe84084b3._0x7744f800._0xc04d35d5}";
            }
            else
            {
                _0xeea9f6cb.ContentAdditionalText.text = $"{this._0x058ed203}";
                _0xe84084b3._0x7744f800._0xc04d35d5 += this._0x058ed203;
            }

            if (_0x547f0258.Instance.IsLevelIncrementOnWin)
                ++_0x2755d8a9._0x0c0d1506._0x2253b18a;
            _0x498f87d1.Instance._0x20ed82d1(_0xe84084b3._0x0d0ffff4.WIN);
        }
    }

    private int _0x15bf7030 => this.CustomTargetScore + _0x2755d8a9._0x0c0d1506._0x2253b18a * 10;

    private void _0x92f6d76d()
    {
        if (_0x547f0258.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0x0820551e => _0x0820551e.text = $"{this.ScoreCurrent}/{this._0x15bf7030}");
        else
            this.ScoreText.ForEach(_0x0820551e => _0x0820551e.text = $"{this.ScoreCurrent}");
    }

    private void _0x04741de8()
    {
        this.IsGameEnd = true;
        _0x2755d8a9.IsAfterLevelComplete = true;
    }

    [HideInInspector]
    public bool IsGameEnd;
    public void _0xaaa1fe68(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0x92f6d76d();
            this._0xf31bcf0b();
        }
    }

    private void _0x03629757()
    {
        if (this.ScoreCurrent >= this._0x15bf7030)
            this._0x397f6320();
        else
            this._0xf4f30696();
    }

    public void _0x490e0596()
    {
        _0x2755d8a9.Instance._0xf3636c95(true);
        _0x2755d8a9.Instance._0x017e7362(_0xe84084b3._0x75d3016f.SCENE_0);
    }

    [HideInInspector]
    public int CurrentGameIndex;
}

internal static class _0xa6bb318a
{
    internal static string _0x1ae099c1(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}