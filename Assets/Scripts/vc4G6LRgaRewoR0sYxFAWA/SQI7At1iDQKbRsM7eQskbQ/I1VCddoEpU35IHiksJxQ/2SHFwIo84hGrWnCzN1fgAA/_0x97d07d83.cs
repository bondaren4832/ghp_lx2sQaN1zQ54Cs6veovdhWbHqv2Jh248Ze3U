using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x97d07d83 : MonoBehaviour
{
    public TMP_Text ContentAdditionalText;
    public Image ContentImage;
    public GameObject Content;
    public static void HideAllPops()
    {
        _0x498f87d1.Instance._0x6c5bed12();
    }

    public TMP_Text ContentHeaderText;
    private void _0x50d177d5()
    {
        DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(0f, 0.01f);
        else
            this.Content.transform.DOScale(0f, 0.01f);
        this.Content.SetActive(false);
    }

    private bool _0x6408927a => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public TMP_Text ContentMainText;
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x50d177d5();
    }

    private void Start()
    {
    // Content.SetActive(false);
    }

    public bool IsScaledDownOnAwake = true;
    public float scaleDuration = 0.4f;
    public bool IsOnlyYScale;
    public void _0xbbcd1d15()
    {
        if (this.Content.gameObject.activeSelf)
        {
            DOTween.Kill(this.Content.transform, true);
            if (this.IsOnlyYScale)
                this.Content.transform.DOScaleY(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
            else
                this.Content.transform.DOScale(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
        }
    }

    public void Show()
    {
        this.Content.SetActive(true);
        if ((DOTween.TweensByTarget(this.Content.transform)?.Count ?? 0) > 0)
            DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
        else
            this.Content.transform.DOScale(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
    }

    public Ease ease = Ease.OutSine;
}