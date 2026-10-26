using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0xe84084b3;

public class _0x2755d8a9 : MonoBehaviour
{
    public int _0x3dc419bb => SceneManager.GetActiveScene().buildIndex;

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x2755d8a9>();
        this.RootGameObject = GameObject.FindWithTag(_0x88150ceb._0xe787a2d1(new byte[4] { 120, 69, 69, 94 }, 42));
        if (this._0x3dc419bb == _0x75d3016f.SCENE_0)
            this._0xf3636c95(true);
        else
            this._0xf3636c95(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0xed270438>(true).ToList();
    }

    public Transform EnvironmentWithTweensToToggle;
    public static _0x2755d8a9 Instance;
    public static bool IsAfterLevelComplete;
    private void _0xb8714408(Transform _0x743386c5)
    {
        Transform[] _0x7deaa35f = _0x743386c5.GetComponentsInChildren<Transform>();
        foreach (Transform _0x890f1f16 in _0x7deaa35f)
            if (_0x890f1f16 != null && DOTween.IsTweening(_0x890f1f16))
            {
                if (this._0xde008afc)
                    DOTween.Play(_0x890f1f16);
                else
                    DOTween.Pause(_0x890f1f16);
            }
    }

    public Button DeleteProgressDataButton;
    public static bool IsAfterLevelFailed = false;
    public void _0xc6b0d76b()
    {
        this._0x017e7362(SceneManager.GetActiveScene().buildIndex);
    }

    private static _0x1a5247c2 GAME_INDEX_SETTINGS(int _0x9ac1ce2c)
    {
        return _0x1a5247c2.ALL_SCENES_SETTING_SINGLETONS[_0x9ac1ce2c];
    }

    private void _0x035a5e45()
    {
        IsAfterLevelComplete = true;
        Instance._0x017e7362(_0x75d3016f.SCENE_0);
    }

    private static void ExitGame()
    {
        Application.Quit();
    }

    private IEnumerator _0xb61d4f9e(int _0x856339d5)
    {
        _0xc9856497.Instance._0xf246b714(_0x35f75e78.SPLASH);
        AsyncOperation _0x5585fb94 = SceneManager.LoadSceneAsync(_0x856339d5);
        while (!_0x5585fb94.isDone)
            yield return null;
    }

    [HideInInspector]
    public List<_0xed270438> MoneyCountContainers = new();
    private static _0x1a5247c2 _0xed19d9d8 => _0x1a5247c2.ALL_SCENES_SETTING_SINGLETONS[0];

    private IEnumerator _0x0d96d0e8(string _0x8673fd43)
    {
        _0xc9856497.Instance._0xf246b714(_0x35f75e78.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0x5b2d1499 = SceneManager.LoadSceneAsync(_0x8673fd43);
        while (!_0x5b2d1499.isDone)
            yield return null;
    }

    public Button ShowResetTutorialButton;
    private static void MakeGrid(List<RectTransform> _0x76356e39, AspectRatioFitter _0x768a3825, float _0xaae3d766, int _0x1f750fcf, int _0x3ae8499b)
    {
        _0x768a3825.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0x768a3825.aspectRatio = _0xaae3d766;
        foreach (RectTransform _0x053cae89 in _0x76356e39)
        {
            int _0xca31700a = _0x053cae89.transform.GetSiblingIndex();
            _0x053cae89.anchorMin = new Vector3(Mathf.FloorToInt((float)_0xca31700a % _0x1f750fcf) * (1f / _0x1f750fcf), (_0x3ae8499b - (Mathf.FloorToInt((float)_0xca31700a / _0x1f750fcf) % _0x3ae8499b + 1f)) * (1f / _0x3ae8499b));
            _0x053cae89.anchorMax = new Vector3(Mathf.FloorToInt((float)_0xca31700a % _0x1f750fcf + 1f) * (1f / _0x1f750fcf), (_0x3ae8499b - Mathf.FloorToInt((float)_0xca31700a / _0x1f750fcf) % _0x3ae8499b) * (1f / _0x3ae8499b));
            _0x053cae89.offsetMin = Vector2.zero;
            _0x053cae89.offsetMax = Vector2.zero;
        }
    }

    public Canvas MainCanvas;
    public void _0x017e7362(int _0xc8362e5d)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0xb61d4f9e(_0xc8362e5d));
    }

    private void _0x212f8575(bool _0xe75c3f72)
    {
        Rigidbody2D[] _0x557dbe11 = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0xc134eb11 in _0x557dbe11)
            if (_0xe75c3f72)
                _0xc134eb11.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0xc134eb11.constraints = RigidbodyConstraints2D.None;
    }

    public Transform Environment;
    public bool _0xde008afc { get; private set; }

    public void _0xfa5188d2()
    {
        foreach (_0xed270438 _0x74542b95 in this.MoneyCountContainers)
            _0x74542b95._0xb91b66da();
    }

    public void _0xa593e5e1()
    {
        _0x0c0d1506._0x068c2625 = true;
    }

    private void Start()
    {
        if (this._0x3dc419bb != _0x75d3016f.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance._0x017e7362(_0x75d3016f.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0x0c0d1506._0x068c2625 = false;
            _0x498f87d1.Instance._0x6c5bed12();
            _0xc9856497.Instance._0xf246b714(_0x35f75e78.TUTORIAL0);
        });
    }

    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    public void _0xf3636c95(bool _0xd8042de2)
    {
        this._0xde008afc = _0xd8042de2;
        this._0x212f8575(!this._0xde008afc);
        Physics2D.simulationMode = this._0xde008afc ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0xb8714408(this.EnvironmentWithTweensToToggle);
    }

    public static _0x1a5247c2 _0x0c0d1506 => _0x1a5247c2.ALL_SCENES_SETTING_SINGLETONS[Instance._0x3dc419bb];
}

internal static class _0x88150ceb
{
    internal static string _0xe787a2d1(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}