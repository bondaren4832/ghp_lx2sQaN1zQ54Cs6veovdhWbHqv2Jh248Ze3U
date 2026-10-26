using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x6fd584ac : MonoBehaviour
{
    private Sequence _0xd19ee51b;
    public void _0x99f22bf4()
    {
        this._0xd19ee51b?.Play();
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x6fd584ac>();
    }

    public GameObject Background;
    public GameObject Content;
    public Slider AnimationSlider;
    public void _0x531c3337()
    {
        this._0xd19ee51b?.Kill();
        this.AnimationSlider.value = _0xcb0f30a6 ? this.SecondPassSliderValue : 0.05f;
    }

    public static _0x6fd584ac Instance;
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0xe84084b3._0x75d3016f.SCENE_0 && !_0xcb0f30a6)
        {
            this._0x6a1c7e79();
        }
        else
        {
            this._0xfe881cb2();
        }
    }

    public GameObject Error;
    public void _0xe5885772()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0xd19ee51b?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0xcb0f30a6 = false;
    }

    public void _0x238b1fac()
    {
        this._0xd19ee51b?.Pause();
    }

    private static bool _0xcb0f30a6 = false;
    public void _0xfe881cb2()
    {
        this._0x531c3337();
        bool _0x699efe70 = _0xcb0f30a6;
        this._0xd19ee51b = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x506090ec => this.AnimationSlider.value = _0x506090ec, _0x699efe70 ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0xcb0f30a6 = !_0xcb0f30a6;
    }

    private void _0x6a1c7e79()
    {
        this.AnimationSlider.value = 0.05f;
        _0xcb0f30a6 = !_0xcb0f30a6;
        this._0xd19ee51b = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x506090ec => this.AnimationSlider.value = _0x506090ec, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0x793cf17f._0xfafb13df?._0xc7a8c99b();
        });
    }

    public float FirstAnimationTime = 10.0f;
    public float DefaultAnimationTime = 0.4f;
    public float SecondPassSliderValue = 0.5f;
}