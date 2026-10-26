using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x544a2399 : MonoBehaviour
{
    public float ScaleDuration = 0.4f;
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x62645824();
    }

    public void _0x69ccb69b()
    {
        this._0xa0041e66();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    public void Show()
    {
        this._0x5bdae8e0();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0xc9856497.Instance._0xfb4b2a0e(_0xc9856497.Instance.CurrentPanelIndex);
            });
        }
    }

    public TMP_Text MainText;
    public GameObject OuterBackground;
    private void _0x5bdae8e0()
    {
        if (this.OuterBackground != null)
        {
            Image _0x0777bcb1 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x0777bcb1, true);
            _0x0777bcb1.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    private void _0x62645824()
    {
        if (this.OuterBackground != null)
        {
            Image _0x52646096 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x52646096, true);
            _0x52646096.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    public Ease Ease = Ease.OutSine;
    public GameObject Content;
    public bool IsScaledDownOnAwake = true;
    public TMP_Text HeaderText;
    private void _0x92b592f6()
    {
        if (this.OuterBackground != null)
        {
            Image _0xd3ed86cd = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xd3ed86cd, true);
            _0xd3ed86cd.DOFade(1f, 0f);
        }
    }

    public void _0x75c25ebc()
    {
        this._0x92b592f6();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0xc9856497.Instance._0xfb4b2a0e(_0xc9856497.Instance.CurrentPanelIndex);
    }

    private bool _0xaedf3643 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    private void _0xa0041e66()
    {
        if (this.OuterBackground != null)
        {
            Image _0x1d455c73 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x1d455c73, true);
            _0x1d455c73.DOFade(0f, this.ScaleDuration);
        }
    }
}