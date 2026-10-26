using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using Unity.Services.CloudSave.Models.Data.Player;
using Unity.Services.Core;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

public class _0x793cf17f : MonoBehaviour
{
    private async Task<bool> _0xd8f5a025(int _0xa48cafb4 = 5, int _0xb5e29043 = 500)
    {
        List<EntityData> _0x275c4c5e = new List<EntityData>();
        int _0xdd3c9dd2 = 0;
        do
        {
            try
            {
                _0x275c4c5e = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x3d947f34._0xcb080bfe(new byte[8] { 108, 112, 125, 101, 121, 110, 85, 120 }, 28), _0x39231805, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x3d947f34._0xcb080bfe(new byte[9] { 123, 97, 66, 96, 123, 100, 115, 113, 107 }, 18) }), new QueryOptions())).ToList();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0x3d947f34._0xcb080bfe(new byte[32] { 252, 243, 194, 212, 211, 250, 135, 214, 210, 194, 213, 222, 230, 212, 222, 201, 196, 245, 194, 212, 210, 203, 211, 212, 135, 194, 213, 213, 200, 213, 157, 135 }, 167) + e.Message);
                    }
#endif
                }
            }

            await Task.Delay(_0xb5e29043);
        }
        while (_0x275c4c5e.Count == 0 && _0xdd3c9dd2++ < _0xa48cafb4);
        {
#if B_LOGS
            {
                Debug.Log(_0x3d947f34._0xcb080bfe(new byte[32] { 116, 123, 74, 92, 91, 114, 15, 102, 92, 127, 93, 70, 89, 78, 76, 86, 15, 126, 90, 74, 93, 86, 15, 93, 74, 92, 90, 67, 91, 92, 21, 15 }, 47) + JsonConvert.SerializeObject(_0x275c4c5e, Formatting.Indented));
            }
#endif
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x3d947f34._0xcb080bfe(new byte[38] { 176, 191, 142, 152, 159, 182, 203, 162, 152, 187, 153, 130, 157, 138, 136, 146, 203, 186, 158, 142, 153, 146, 203, 153, 142, 152, 158, 135, 159, 152, 203, 136, 132, 158, 133, 159, 209, 203 }, 235) + _0x275c4c5e.Count);
            }
#endif
        }

        bool _0x16262be3 = true;
        if (_0x275c4c5e.Count == 0)
        {
            _0x16262be3 = false;
        }
        else
        {
            _0x16262be3 = _0x275c4c5e.Any(_0x182a0be9 => _0x182a0be9.Data.Any(IsPrivacyItemTrue));
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x3d947f34._0xcb080bfe(new byte[25] { 159, 144, 161, 183, 176, 153, 228, 141, 183, 148, 182, 173, 178, 165, 167, 189, 228, 182, 161, 183, 177, 168, 176, 254, 228 }, 196) + _0x16262be3);
            }
#endif
        }

        return _0x16262be3;
    }

    private bool _0xb2d7c534()
    {
        if (_0xbcb508cc())
            return true;
        if (_0x139560db != null && _0x139560db.CanGoBack)
        {
            WLog(_0x3d947f34._0xcb080bfe(new byte[36] { 165, 140, 159, 137, 154, 140, 159, 136, 205, 143, 140, 142, 134, 205, 192, 211, 205, 128, 140, 132, 131, 205, 186, 136, 143, 187, 132, 136, 154, 205, 170, 130, 175, 140, 142, 134 }, 237));
            _0x139560db.GoBack();
            return true;
        }

        return false;
    }

    internal Rect lastSafe = Rect.zero;
    private IEnumerator _0xc0fbcb6c(string _0xc9a76960)
    {
        if (_0x139560db != null && _0xa0eeacac)
            yield break;
        _0x139560db = gameObject.AddComponent<UniWebView>();
        _0xe6cc703e(_0x139560db);
        _0x4e0b66ed(_0x139560db);
        _0x139560db.BackgroundColor = Color.clear;
        var _0x1abc87a1 = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0x3ee7036b();
        yield return new WaitForEndOfFrame();
        _0xa0eeacac = true;
        _0x63166baa();
        _0x6fe84711(true);
        _0xe11c7db5 = false;
        _0xf5f46bf2 = false;
        _0xca1115fa.Clear();
        _0x6c86bf8b = -1;
        firstLoadShown = false;
        _0x3b520c34 = false;
        _0x50ba8ffc = false;
        _0x139560db.SetUserAgent("");
        _0xc0704ef4 = Time.realtimeSinceStartup;
        _0x139560db.Stop();
        _0x139560db.Load(_0xc9a76960);
        _0x139560db.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0x3d947f34._0xcb080bfe(new byte[25] { 11, 39, 47, 40, 102, 17, 35, 36, 16, 47, 35, 49, 102, 15, 40, 47, 50, 47, 39, 42, 102, 21, 46, 41, 49 }, 70));
    }

    // NATIVE WEB VIEW METHODS
    private UniWebView _0x139560db = null;
    private IEnumerator _0x12e6331c()
    {
        yield return _0x7adcdcef(Permission.Camera);
    }

    private string _0xe80e9b68 = "";
    private float _0xc0704ef4 = 0f;
    private string _0xeb4e6301 = "";
    // WEB VIEW LOGIC END
    internal void _0xfb3aac93()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0xbc52a39a = new AndroidNotificationChannel
        {
            Id = _0x3d947f34._0xcb080bfe(new byte[15] { 38, 39, 36, 35, 55, 46, 54, 29, 33, 42, 35, 44, 44, 39, 46 }, 66),
            Name = _0x3d947f34._0xcb080bfe(new byte[15] { 76, 109, 110, 105, 125, 100, 124, 40, 75, 96, 105, 102, 102, 109, 100 }, 8),
            Importance = Importance.High,
            Description = _0x3d947f34._0xcb080bfe(new byte[21] { 121, 91, 80, 91, 76, 95, 82, 30, 80, 81, 74, 87, 88, 87, 93, 95, 74, 87, 81, 80, 77 }, 62)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0xbc52a39a);
        // Build notification
        var _0x7c3b8875 = new AndroidNotification
        {
            Title = _0xf21170c4[UnityEngine.Random.Range(0, _0xf21170c4.Length)],
            Text = _0x3d947f34._0xcb080bfe(new byte[21] { 57, 10, 29, 88, 1, 23, 13, 88, 11, 13, 10, 29, 88, 12, 23, 88, 29, 0, 17, 12, 71 }, 120),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0x7c3b8875, _0x3d947f34._0xcb080bfe(new byte[15] { 200, 201, 202, 205, 217, 192, 216, 243, 207, 196, 205, 194, 194, 201, 192 }, 172));
    }

    private IEnumerator _0xb3e43ed9(Dictionary<string, object> _0xd17bfc74)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x3d947f34._0xcb080bfe(new byte[30] { 1, 14, 63, 41, 46, 7, 122, 28, 63, 46, 57, 50, 122, 31, 34, 46, 40, 59, 122, 10, 47, 41, 50, 122, 30, 59, 46, 59, 96, 122 }, 90) + string.Join(_0x3d947f34._0xcb080bfe(new byte[1] { 241 }, 248), _0xd17bfc74));
#endif
            }
        }

        string _0x9eaf3f55 = "";
        // Primary source: nested JSON under "notificationData"
        if (_0xd17bfc74 != null && _0xd17bfc74.TryGetValue(_0x3d947f34._0xcb080bfe(new byte[16] { 187, 186, 161, 188, 179, 188, 182, 180, 161, 188, 186, 187, 145, 180, 161, 180 }, 213), out var raw))
        {
            try
            {
                var _0xaf9cb013 = raw?.ToString();
                var _0x21e03409 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xaf9cb013);
                if (_0x21e03409 != null && _0x21e03409.TryGetValue(_0x3d947f34._0xcb080bfe(new byte[6] { 130, 148, 159, 149, 152, 149 }, 241), out var val))
                {
                    _0x9eaf3f55 = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0x3d947f34._0xcb080bfe(new byte[30] { 173, 162, 147, 133, 130, 214, 166, 131, 133, 158, 171, 214, 188, 165, 185, 184, 214, 134, 151, 132, 133, 147, 214, 147, 132, 132, 153, 132, 204, 214 }, 246) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0x9eaf3f55) && _0xd17bfc74 != null && _0xd17bfc74.TryGetValue(_0x3d947f34._0xcb080bfe(new byte[6] { 235, 253, 246, 252, 241, 252 }, 152), out var lab))
        {
            _0x9eaf3f55 = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x3d947f34._0xcb080bfe(new byte[38] { 195, 204, 253, 235, 236, 184, 200, 237, 235, 240, 197, 184, 222, 253, 236, 251, 240, 253, 252, 184, 235, 253, 246, 252, 241, 252, 184, 254, 234, 247, 245, 184, 242, 235, 247, 246, 162, 184 }, 152) + _0x9eaf3f55);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0x9eaf3f55))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0x3d947f34._0xcb080bfe(new byte[38] { 125, 114, 67, 85, 82, 6, 118, 83, 85, 78, 123, 6, 113, 71, 79, 82, 6, 82, 73, 6, 73, 86, 67, 72, 6, 81, 79, 82, 78, 6, 85, 67, 72, 66, 79, 66, 28, 6 }, 38) + _0x9eaf3f55);
            }
#endif
        }

        _0xee372db2 = _0x9eaf3f55;
        yield return new WaitUntil(() => _0xa0eeacac);
        var _0x29f38609 = _0xf780e548(2, 100);
        yield return new WaitUntil(() => _0x29f38609.IsCompleted);
        string _0x7e325015 = _0x29f38609.Result;
        if (!string.IsNullOrEmpty(_0x7e325015))
        {
            string _0x714dec87 = _0xf7296715(_0x7e325015, _0x9eaf3f55);
            {
#if B_LOGS
                Debug.Log(_0x3d947f34._0xcb080bfe(new byte[33] { 128, 143, 190, 168, 175, 251, 139, 174, 168, 179, 134, 251, 137, 190, 183, 180, 186, 191, 251, 140, 190, 185, 141, 178, 190, 172, 251, 172, 178, 175, 179, 225, 251 }, 219) + _0x714dec87);
#endif
            }

            _0x139560db.Load(_0x714dec87);
        }
    }

    private async void Start()
    {
        await _0x238a5fbf();
    }

    private Task _0xe533b31d(IEnumerator _0x87237c6d)
    {
        var _0x87b1ba51 = new TaskCompletionSource<bool>();
        StartCoroutine(_0x29aad776(_0x87237c6d, _0x87b1ba51));
        return _0x87b1ba51.Task;
    }

    private static bool IsPrivacyItemTrue(Item _0xd00fa387)
    {
        if (_0xd00fa387.Key != _0x3d947f34._0xcb080bfe(new byte[9] { 45, 55, 20, 54, 45, 50, 37, 39, 61 }, 68))
            return false;
        try
        {
            var _0xd6ee5fb8 = _0xd00fa387.Value.GetAs<object>();
            return _0xd6ee5fb8 switch
            {
                bool b => b,
                string s when bool.TryParse(s, out var parsed) => parsed,
                _ => false
            };
        }
        catch
        {
            return false;
        }
    }

    private AndroidJavaObject _0xdbc822b7 { get; set; }

    private void _0x40e44ff7(string _0xeecc1118)
    {
        Dictionary<string, object> _0x3088869d;
        try
        {
            _0x3088869d = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xeecc1118);
        }
        catch
        {
            return;
        }

        var _0x322f7987 = ReadPushField(_0x3088869d, _0x3d947f34._0xcb080bfe(new byte[3] { 39, 32, 62 }, 82));
        if (string.IsNullOrWhiteSpace(_0x322f7987))
            return;
        _0x322f7987 = _0x322f7987.Trim();
        if (!IsHttpUrl(_0x322f7987))
            return;
        if (string.Equals(_0x322f7987, _0x1fce25f0, StringComparison.Ordinal))
            return;
        _0x1fce25f0 = _0x322f7987;
        OpenUrlExternally(_0x322f7987);
    }

    private string _0x83223c99 = "";
    private Canvas _0xa8ccb28f;
    private bool _0x3b520c34 = false;
    private bool _0x5d6ee6a5 = false;
    private string _0xf100370c = "";
    private void _0x080aa498()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    // WEB VIEW LOGIC
    public bool _0xa0eeacac { get; set; }

    private Action _0x33a8f003;
    internal void _0x3ee7036b()
    {
        Rect _0x4b789f6a = Screen.safeArea;
        Vector2 _0xb2e7beda = new Vector2(Screen.width, Screen.height);
        if (_0x4b789f6a == lastSafe && _0xb2e7beda == lastSize)
            return;
        // Apply manual padding
        _0x4b789f6a.xMin += _0x7cddf376;
        _0x4b789f6a.xMax -= _0x2fb8858e;
        _0x4b789f6a.yMin += _0xfd8aa7ce;
        _0x4b789f6a.yMax -= _0xa763d740;
        // Convert Unity safe area -> native WebView frame
        Rect _0xc60524c2 = new Rect(_0x4b789f6a.x, _0xb2e7beda.y - _0x4b789f6a.y - _0x4b789f6a.height, // Y flip for native coordinate system
 _0x4b789f6a.width, _0x4b789f6a.height);
        _0x139560db.Frame = _0xc60524c2;
        lastSafe = Screen.safeArea;
        lastSize = _0xb2e7beda;
    }

    private IEnumerator _0x7adcdcef(string _0xf8c8df7b)
    {
        if (Permission.HasUserAuthorizedPermission(_0xf8c8df7b))
            yield break;
        bool _0x854b0685 = false;
        var _0x91baad60 = new PermissionCallbacks();
        _0x91baad60.PermissionGranted += _0x227e9f73 => _0x854b0685 = true;
        _0x91baad60.PermissionDenied += _0x227e9f73 => _0x854b0685 = true;
        Permission.RequestUserPermission(_0xf8c8df7b, _0x91baad60);
        yield return new WaitUntil(() => _0x854b0685);
    }

    private async Task<string> _0xf780e548(int _0xa50f0373 = 5, int _0x719640dd = 500)
    {
        try
        {
            List<EntityData> _0x794080ca = new List<EntityData>();
            int _0x037a3dc2 = 0;
            do
            {
                _0x794080ca = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x3d947f34._0xcb080bfe(new byte[8] { 146, 142, 131, 155, 135, 144, 171, 134 }, 226), _0x39231805, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x39231805 }), new QueryOptions())).ToList();
                await Task.Delay(_0x719640dd);
            }
            while (_0x794080ca.Count == 0 && _0x037a3dc2++ < _0xa50f0373);
            {
#if B_LOGS
                {
                    Debug.Log(_0x3d947f34._0xcb080bfe(new byte[33] { 157, 146, 163, 181, 178, 155, 230, 149, 167, 176, 163, 162, 230, 138, 175, 168, 173, 230, 151, 179, 163, 180, 191, 230, 180, 163, 181, 179, 170, 178, 181, 252, 230 }, 198) + JsonConvert.SerializeObject(_0x794080ca, Formatting.Indented));
                }
#endif
            }

            {
#if B_LOGS
                {
                    Debug.Log(_0x3d947f34._0xcb080bfe(new byte[39] { 46, 33, 16, 6, 1, 40, 85, 38, 20, 3, 16, 17, 85, 57, 28, 27, 30, 85, 36, 0, 16, 7, 12, 85, 7, 16, 6, 0, 25, 1, 6, 85, 22, 26, 0, 27, 1, 79, 85 }, 117) + _0x794080ca.Count);
                }
#endif
            }

            var _0x979f0e99 = _0x794080ca.SelectMany(_0x182a0be9 => _0x182a0be9.Data).FirstOrDefault(_0x232dbe93 => _0x232dbe93.Key == _0x39231805)?.Value.GetAs<string>() ?? string.Empty;
            _0x979f0e99 = Decrypt(_0x979f0e99, _0x39231805);
            {
#if B_LOGS
                {
                    Debug.Log(_0x3d947f34._0xcb080bfe(new byte[24] { 230, 233, 216, 206, 201, 224, 157, 241, 210, 220, 217, 157, 206, 220, 203, 216, 217, 157, 209, 212, 211, 214, 135, 157 }, 189) + _0x979f0e99);
                }
#endif
            }

            return _0x979f0e99;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x3d947f34._0xcb080bfe(new byte[39] { 0, 15, 62, 40, 47, 6, 123, 28, 62, 47, 123, 52, 41, 123, 43, 58, 41, 40, 62, 123, 40, 58, 45, 62, 63, 123, 55, 50, 53, 48, 123, 61, 58, 50, 55, 62, 63, 97, 123 }, 91) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    private void Awake()
    {
        if (_0xfafb13df != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0xfafb13df = gameObject.GetComponent<_0x793cf17f>();
        DontDestroyOnLoad(gameObject);
        _0xeb4e6301 = _0x0617c81c = _0xcead1fc8 = "";
        _0xa7f3dabf = "";
        _0xa0eeacac = false;
    }

    private string _0x5dcf408a()
    {
        string _0x267ea65a = _0x3d947f34._0xcb080bfe(new byte[62] { 230, 229, 228, 227, 226, 225, 224, 239, 238, 237, 236, 235, 234, 233, 232, 247, 246, 245, 244, 243, 242, 241, 240, 255, 254, 253, 198, 197, 196, 195, 194, 193, 192, 207, 206, 205, 204, 203, 202, 201, 200, 215, 214, 213, 212, 211, 210, 209, 208, 223, 222, 221, 183, 182, 181, 180, 179, 178, 177, 176, 191, 190 }, 135);
        System.Random _0x971f0c39 = new System.Random();
        int _0x5166bde6 = _0x971f0c39.Next(8, 16);
        return new string (Enumerable.Repeat(_0x267ea65a, _0x5166bde6).Select(_0xc0d3ab6e => _0xc0d3ab6e[_0x971f0c39.Next(_0xc0d3ab6e.Length)]).ToArray());
    }

    private void _0xb3546697(string _0xab3d8e20)
    {
        _0xcf3f6a35();
        StartCoroutine(_0xc0fbcb6c(_0xab3d8e20));
    }

    private void OnApplicationFocus(bool _0x5bbcede4)
    {
        isApplicationFocus = _0x5bbcede4;
        if (_0x5bbcede4 && _0xa0eeacac)
        {
            _0xcf3f6a35();
        }
    }

    private void _0x804a293f()
    {
        WLog(_0x3d947f34._0xcb080bfe(new byte[21] { 161, 136, 155, 141, 158, 136, 155, 140, 201, 139, 136, 138, 130, 201, 153, 155, 140, 154, 154, 140, 141 }, 233));
        if (Time.frameCount == _0x6c86bf8b)
            return;
        _0x6c86bf8b = Time.frameCount;
        if (_0xb2d7c534())
            return;
        _0x2368f0d8();
    }

    private void _0x90e84931(string _0x365702bf)
    {
        if (string.IsNullOrEmpty(_0x365702bf))
            return;
        if (TryOpenExternalLikeChrome(_0x365702bf))
            return;
        OpenUrlExternally(_0x365702bf);
    }

    private RectTransform _0xa86edf5b;
    internal bool IsHttpUrl(string _0x4f172bce)
    {
        if (string.IsNullOrEmpty(_0x4f172bce))
            return false;
        return _0x4f172bce.StartsWith(_0x3d947f34._0xcb080bfe(new byte[7] { 206, 210, 210, 214, 156, 137, 137 }, 166), StringComparison.OrdinalIgnoreCase) || _0x4f172bce.StartsWith(_0x3d947f34._0xcb080bfe(new byte[8] { 54, 42, 42, 46, 45, 100, 113, 113 }, 94), StringComparison.OrdinalIgnoreCase);
    }

    internal bool firstLoadShown = false;
    private string _0x39231805 = "";
    private bool _0x4085cc79(string _0x9366dd98)
    {
        try
        {
            using (var _0x504fa7ae = new AndroidJavaClass(_0x3d947f34._0xcb080bfe(new byte[30] { 54, 58, 56, 123, 32, 59, 60, 33, 44, 102, 49, 123, 37, 57, 52, 44, 48, 39, 123, 0, 59, 60, 33, 44, 5, 57, 52, 44, 48, 39 }, 85)))
            using (var _0x070ac2c8 = _0x504fa7ae.GetStatic<AndroidJavaObject>(_0x3d947f34._0xcb080bfe(new byte[15] { 128, 150, 145, 145, 134, 141, 151, 162, 128, 151, 138, 149, 138, 151, 154 }, 227)))
            using (var _0x80b0329a = _0x070ac2c8.Call<AndroidJavaObject>(_0x3d947f34._0xcb080bfe(new byte[17] { 209, 211, 194, 230, 215, 213, 221, 215, 209, 211, 251, 215, 216, 215, 209, 211, 196 }, 182)))
            using (var _0x40637131 = new AndroidJavaClass(_0x3d947f34._0xcb080bfe(new byte[22] { 55, 56, 50, 36, 57, 63, 50, 120, 53, 57, 56, 34, 51, 56, 34, 120, 31, 56, 34, 51, 56, 34 }, 86)))
            using (var _0xa2633eb6 = _0x40637131.CallStatic<AndroidJavaObject>(_0x3d947f34._0xcb080bfe(new byte[8] { 236, 253, 238, 239, 249, 201, 238, 245 }, 156), _0x9366dd98, 1))
            {
                string _0x05df6671 = _0xa2633eb6.Call<string>(_0x3d947f34._0xcb080bfe(new byte[14] { 110, 108, 125, 90, 125, 123, 96, 103, 110, 76, 113, 125, 123, 104 }, 9), _0x3d947f34._0xcb080bfe(new byte[20] { 168, 184, 165, 189, 185, 175, 184, 149, 172, 171, 166, 166, 168, 171, 169, 161, 149, 191, 184, 166 }, 202));
                string _0x1788c2dc = _0xa2633eb6.Call<string>(_0x3d947f34._0xcb080bfe(new byte[10] { 56, 58, 43, 15, 62, 60, 52, 62, 56, 58 }, 95));
                _0xa2633eb6.Call<AndroidJavaObject>(_0x3d947f34._0xcb080bfe(new byte[11] { 205, 200, 200, 239, 205, 216, 201, 203, 195, 222, 213 }, 172), _0x3d947f34._0xcb080bfe(new byte[33] { 11, 4, 14, 24, 5, 3, 14, 68, 3, 4, 30, 15, 4, 30, 68, 9, 11, 30, 15, 13, 5, 24, 19, 68, 40, 56, 37, 61, 57, 43, 40, 38, 47 }, 106));
                _0xa2633eb6.Call<AndroidJavaObject>(_0x3d947f34._0xcb080bfe(new byte[11] { 164, 179, 187, 185, 160, 179, 147, 174, 162, 164, 183 }, 214), _0x3d947f34._0xcb080bfe(new byte[20] { 126, 110, 115, 107, 111, 121, 110, 67, 122, 125, 112, 112, 126, 125, 127, 119, 67, 105, 110, 112 }, 28));
                if (_0xa2633eb6.Call<AndroidJavaObject>(_0x3d947f34._0xcb080bfe(new byte[15] { 84, 67, 85, 73, 74, 80, 67, 103, 69, 82, 79, 80, 79, 82, 95 }, 38), _0x80b0329a) != null)
                {
                    WLog(_0x3d947f34._0xcb080bfe(new byte[24] { 66, 105, 115, 110, 108, 100, 77, 104, 106, 100, 33, 110, 113, 100, 111, 33, 104, 111, 117, 100, 111, 117, 59, 33 }, 1) + _0x9366dd98);
                    _0xa2633eb6.Call<AndroidJavaObject>(_0x3d947f34._0xcb080bfe(new byte[8] { 173, 168, 168, 138, 160, 173, 171, 191 }, 204), 0x10000000);
                    _0x070ac2c8.Call(_0x3d947f34._0xcb080bfe(new byte[13] { 80, 87, 66, 81, 87, 98, 64, 87, 74, 85, 74, 87, 90 }, 35), _0xa2633eb6);
                    return true;
                }

                if (_0xffa76e47(_0x1788c2dc))
                    return true;
                if (!string.IsNullOrEmpty(_0x05df6671))
                {
                    WLog(_0x3d947f34._0xcb080bfe(new byte[28] { 211, 248, 226, 255, 253, 245, 220, 249, 251, 245, 176, 249, 254, 228, 245, 254, 228, 176, 246, 241, 252, 252, 242, 241, 243, 251, 170, 176 }, 144) + _0x05df6671);
                    if (_0xfcfdff7d(_0x05df6671))
                        return _0x1453b0f9(_0x05df6671, _0x1788c2dc);
                    return _0x3d33f858(_0x05df6671);
                }

                WLog(_0x3d947f34._0xcb080bfe(new byte[30] { 182, 157, 135, 154, 152, 144, 185, 156, 158, 144, 213, 156, 155, 129, 144, 155, 129, 213, 155, 154, 213, 157, 148, 155, 145, 153, 144, 135, 207, 213 }, 245) + _0x9366dd98);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x3d947f34._0xcb080bfe(new byte[26] { 41, 2, 24, 5, 7, 15, 38, 3, 1, 15, 74, 3, 4, 30, 15, 4, 30, 74, 12, 11, 3, 6, 15, 14, 80, 74 }, 106) + e.Message);
            return true;
        }
    }

    private JObject _0x15772327(params string[] _0x3c4e2d45)
    {
        JObject _0x06761a8f = new JObject();
        foreach (var _0x1139ce4e in _0x3c4e2d45)
        {
            string _0xd6c6fcf1 = _0x5dcf408a();
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0xd6c6fcf1} val={_0x1139ce4e}");
#endif
            }

            _0x06761a8f.Add(_0xd6c6fcf1, _0x1139ce4e == null ? "" : _0x1139ce4e);
        }

        return _0x06761a8f;
    }

    private ApplicationInstallMode _0xd592929a = ApplicationInstallMode.Unknown;
    private async Task<bool> _0x58d0e950()
    {
        {
#if B_LOGS
            Debug.Log(_0x3d947f34._0xcb080bfe(new byte[37] { 35, 44, 29, 11, 12, 37, 88, 43, 17, 31, 22, 49, 22, 45, 22, 17, 12, 1, 43, 29, 10, 14, 17, 27, 29, 11, 57, 22, 23, 22, 1, 21, 23, 13, 11, 20, 1 }, 120));
#endif
        }

        try
        {
            var _0x7417db61 = new InitializationOptions();
            await UnityServices.InitializeAsync(_0x7417db61);
            {
#if B_LOGS
                Debug.Log(_0x3d947f34._0xcb080bfe(new byte[32] { 153, 150, 167, 177, 182, 159, 226, 151, 172, 171, 182, 187, 145, 167, 176, 180, 171, 161, 167, 177, 226, 139, 172, 171, 182, 171, 163, 174, 171, 184, 167, 166 }, 194));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0x3d947f34._0xcb080bfe(new byte[20] { 67, 82, 68, 67, 55, 66, 121, 126, 99, 110, 68, 114, 101, 97, 126, 116, 114, 100, 45, 55 }, 23) + ex.Message);
#endif
            }

            _0xfafb13df?._0x2f201f78();
            return true;
        }

        bool _0x8b9bb7d8 = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0x8b9bb7d8 = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0x3d947f34._0xcb080bfe(new byte[37] { 100, 107, 90, 76, 75, 98, 31, 108, 86, 88, 81, 18, 86, 81, 31, 126, 81, 80, 81, 70, 82, 80, 74, 76, 17, 31, 111, 83, 94, 70, 90, 77, 31, 118, 123, 5, 31 }, 63) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0x39231805 = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x3d947f34._0xcb080bfe(new byte[25] { 153, 136, 158, 153, 237, 158, 164, 170, 163, 224, 164, 163, 237, 140, 184, 185, 165, 237, 136, 159, 159, 130, 159, 247, 237 }, 205) + ex.Message);
#endif
                }

                _0xfafb13df?._0x2f201f78();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x3d947f34._0xcb080bfe(new byte[28] { 2, 19, 5, 2, 118, 5, 63, 49, 56, 123, 63, 56, 118, 4, 51, 39, 35, 51, 37, 34, 118, 19, 4, 4, 25, 4, 108, 118 }, 86) + ex.Message);
#endif
                }

                _0xfafb13df?._0x2f201f78();
                return true;
            }
        }
        while (!_0x8b9bb7d8);
        return false;
    }

    private void WLog(string _0x49f8181c)
    {
#if B_LOGS
        {
            Debug.Log(_0x3d947f34._0xcb080bfe(new byte[7] { 23, 24, 41, 63, 56, 17, 108 }, 76) + _0x49f8181c);
        }
#endif
    }

    private string _0x30fc7aab()
    {
        try
        {
            using (var _0x018089f5 = new AndroidJavaClass(_0x3d947f34._0xcb080bfe(new byte[30] { 70, 74, 72, 11, 80, 75, 76, 81, 92, 22, 65, 11, 85, 73, 68, 92, 64, 87, 11, 112, 75, 76, 81, 92, 117, 73, 68, 92, 64, 87 }, 37)))
            {
                var _0xf1222da0 = _0x018089f5.GetStatic<AndroidJavaObject>(_0x3d947f34._0xcb080bfe(new byte[15] { 44, 58, 61, 61, 42, 33, 59, 14, 44, 59, 38, 57, 38, 59, 54 }, 79));
                var _0x9954ed2c = _0xf1222da0.Call<AndroidJavaObject>(_0x3d947f34._0xcb080bfe(new byte[21] { 87, 85, 68, 113, 64, 64, 92, 89, 83, 81, 68, 89, 95, 94, 115, 95, 94, 68, 85, 72, 68 }, 48));
                using (var _0x6623631b = new AndroidJavaClass(_0x3d947f34._0xcb080bfe(new byte[26] { 139, 132, 142, 152, 133, 131, 142, 196, 157, 143, 136, 129, 131, 158, 196, 189, 143, 136, 185, 143, 158, 158, 131, 132, 141, 153 }, 234)))
                {
                    return _0x6623631b.CallStatic<string>(_0x3d947f34._0xcb080bfe(new byte[19] { 222, 220, 205, 253, 220, 223, 216, 204, 213, 205, 236, 202, 220, 203, 248, 222, 220, 215, 205 }, 185), _0x9954ed2c);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    private int _0x1674b961 = 0;
    private string _0x2beff5d4()
    {
        if (string.IsNullOrEmpty(_0xa0a42562) && _0x139560db != null)
            _0xa0a42562 = _0x139560db.GetUserAgent();
        if (string.IsNullOrEmpty(_0xa0a42562))
            return string.Empty;
        string _0xff8c82fc = Regex.Replace(_0xa0a42562, _0x3d947f34._0xcb080bfe(new byte[11] { 65, 110, 55, 38, 65, 110, 55, 106, 107, 65, 127 }, 29), string.Empty);
        _0xff8c82fc = Regex.Replace(_0xff8c82fc, _0x3d947f34._0xcb080bfe(new byte[15] { 203, 228, 188, 213, 226, 254, 251, 243, 184, 204, 201, 172, 190, 202, 188 }, 151), string.Empty);
        _0xff8c82fc = Regex.Replace(_0xff8c82fc, _0x3d947f34._0xcb080bfe(new byte[15] { 77, 126, 105, 104, 114, 116, 117, 52, 47, 71, 53, 43, 71, 104, 49 }, 27), string.Empty);
        return Regex.Replace(_0xff8c82fc, _0x3d947f34._0xcb080bfe(new byte[6] { 11, 36, 44, 101, 123, 42 }, 87), _0x3d947f34._0xcb080bfe(new byte[1] { 85 }, 117)).Trim();
    }

    private string _0x1fce25f0;
    // MAIN FLOW
    private bool _0xabc17188 { get; set; }

    private void _0x31d8a61d()
    {
        if (_0x139560db == null)
            return;
        if (_0xf5f46bf2)
            _0x139560db.SetUserAgent(_0x2beff5d4());
        else
            _0x139560db.SetUserAgent("");
    }

    private GameObject _0x0f78b904;
    private int _0x6c86bf8b = -1;
    private void _0xeaef7f22()
    {
        _0xf5f46bf2 = true;
        if (_0x139560db != null)
            _0x139560db.SetUserAgent(_0x2beff5d4());
    }

    private UniWebViewPopup _0x87222aac()
    {
        for (int _0x34670f32 = _0xca1115fa.Count - 1; _0x34670f32 >= 0; _0x34670f32--)
        {
            var _0x74d6e45a = _0xca1115fa[_0x34670f32];
            if (_0x74d6e45a != null && _0x74d6e45a.IsAlive)
                return _0x74d6e45a;
            _0xca1115fa.RemoveAt(_0x34670f32);
        }

        return null;
    }

    private string _0x8b69ee87 = "";
    private async Task _0x238a5fbf()
    {
        if (await _0x58d0e950())
            return;
        if (await _0x1fb812a8())
            return;
        if (await _0x208756a2())
            return;
        _0xd359b62f();
        await _0xe533b31d(_0xa5c43546());
        _0x9cacd2e8 = await _0x2b996d82();
        await _0x84766846();
    }

    private bool _0xab88876e = false;
    private bool _0xbcb508cc()
    {
        var _0x8e56c33d = _0x87222aac();
        if (_0x8e56c33d == null)
            return false;
        WLog(_0x3d947f34._0xcb080bfe(new byte[31] { 11, 34, 49, 39, 52, 34, 49, 38, 99, 33, 34, 32, 40, 99, 110, 125, 99, 51, 44, 51, 54, 51, 99, 4, 44, 1, 34, 32, 40, 121, 99 }, 67) + _0x8e56c33d.Id);
        _0x8e56c33d.GoBack();
        return true;
    }

    private void _0x4e0b66ed(UniWebView _0x78111c3f)
    {
        if (_0xa9a95523)
            return;
        _0xa9a95523 = true;
        _0x78111c3f.AddUrlScheme(_0x3d947f34._0xcb080bfe(new byte[2] { 11, 24 }, 127));
        _0x78111c3f.AddUrlScheme(_0x3d947f34._0xcb080bfe(new byte[6] { 63, 56, 34, 51, 56, 34 }, 86));
        _0x78111c3f.AddUrlScheme(_0x3d947f34._0xcb080bfe(new byte[6] { 128, 140, 159, 134, 136, 153 }, 237));
        _0x78111c3f.OnMessageReceived += (_0xa8753ec0, _0xb9c8dcbf) =>
        {
            if (TryOpenExternalLikeChrome(_0xb9c8dcbf.RawMessage))
            {
                _0x6fe84711(false);
                return;
            }
        };
        _0x78111c3f.RegisterShouldHandleRequest(_0x26b5c4fb =>
        {
            string _0x5a4f5851 = _0x26b5c4fb != null ? _0x26b5c4fb.Url : string.Empty;
            if (string.IsNullOrEmpty(_0x5a4f5851))
                return true;
            WLog(_0x3d947f34._0xcb080bfe(new byte[21] { 159, 164, 163, 185, 160, 168, 132, 173, 162, 168, 160, 169, 158, 169, 189, 185, 169, 191, 184, 246, 236 }, 204) + _0x5a4f5851);
            if (TryOpenExternalLikeChrome(_0x5a4f5851))
            {
                _0x6fe84711(false);
                return false;
            }

            if (_0x26b5c4fb != null && _0x26b5c4fb.IsMainFrame && IsGoogleAuthFlowUrl(_0x5a4f5851) && !_0xf5f46bf2)
            {
                WLog(_0x3d947f34._0xcb080bfe(new byte[62] { 116, 88, 80, 87, 25, 110, 92, 91, 111, 80, 92, 78, 25, 93, 92, 77, 92, 90, 77, 92, 93, 25, 126, 86, 86, 94, 85, 92, 25, 88, 76, 77, 81, 25, 108, 107, 117, 25, 20, 7, 25, 75, 92, 85, 86, 88, 93, 25, 78, 80, 77, 81, 25, 126, 86, 86, 94, 85, 92, 25, 108, 120 }, 57));
                _0xf5f46bf2 = true;
                _0x6fe84711(true);
                _0x139560db.SetUserAgent(_0x2beff5d4());
                _0x139560db.Load(_0x5a4f5851);
                return false;
            }

            return true;
        });
        _0x78111c3f.OnLoadingErrorReceived += (_0xa8753ec0, _0x44405211, _0xb9c8dcbf, _0xba964fa4) =>
        {
            WLog(_0x3d947f34._0xcb080bfe(new byte[25] { 52, 24, 16, 23, 89, 46, 28, 27, 47, 16, 28, 14, 89, 60, 11, 11, 22, 11, 67, 89, 26, 22, 29, 28, 68 }, 121) + _0x44405211 + _0x3d947f34._0xcb080bfe(new byte[9] { 82, 31, 23, 1, 1, 19, 21, 23, 79 }, 114) + _0xb9c8dcbf);
            string _0x6b95a7cf = GetFailingUrl(_0xba964fa4);
            if (string.IsNullOrEmpty(_0x6b95a7cf) || IsAboutBlank(_0x6b95a7cf))
                return;
            _ = _0x647f16a1(_0x3d947f34._0xcb080bfe(new byte[8] { 27, 26, 51, 9, 30, 30, 3, 30 }, 108));
            WLog(_0x3d947f34._0xcb080bfe(new byte[45] { 122, 86, 94, 89, 23, 96, 82, 85, 97, 94, 82, 64, 23, 81, 86, 94, 91, 94, 89, 80, 23, 98, 101, 123, 23, 26, 9, 23, 88, 71, 82, 89, 23, 82, 79, 67, 82, 69, 89, 86, 91, 91, 78, 13, 23 }, 55) + _0x6b95a7cf);
            StopCurrentFailedLoad(_0xa8753ec0);
            _0x90e84931(_0x6b95a7cf);
        };
        _0x78111c3f.OnPageStarted += (_0xa8753ec0, _0x35a2264e) =>
        {
            _0x1674b961 = 0;
            if (_0xe11c7db5 && IsAboutBlank(_0x35a2264e))
            {
                WLog(_0x3d947f34._0xcb080bfe(new byte[27] { 236, 206, 217, 203, 221, 206, 209, 156, 221, 222, 211, 201, 200, 134, 222, 208, 221, 210, 215, 156, 207, 200, 221, 206, 200, 217, 216 }, 188));
                return;
            }

            WLog(_0x3d947f34._0xcb080bfe(new byte[29] { 139, 167, 175, 168, 230, 145, 163, 164, 144, 175, 163, 177, 230, 137, 168, 150, 167, 161, 163, 149, 178, 167, 180, 178, 163, 162, 252, 230, 237 }, 198) + (Time.realtimeSinceStartup - _0xc0704ef4).ToString(_0x3d947f34._0xcb080bfe(new byte[5] { 151, 137, 151, 151, 151 }, 167)) + _0x3d947f34._0xcb080bfe(new byte[2] { 232, 187 }, 155) + _0x35a2264e);
            if (TryOpenExternalLikeChrome(_0x35a2264e))
            {
                StopCurrentFailedLoad(_0xa8753ec0);
                return;
            }

            if (ContainsIgnoreCase(_0x35a2264e, _0x3d947f34._0xcb080bfe(new byte[8] { 174, 163, 163, 171, 228, 171, 186, 186 }, 202)) || ContainsIgnoreCase(_0x35a2264e, _0x3d947f34._0xcb080bfe(new byte[15] { 225, 240, 232, 191, 230, 248, 245, 246, 244, 229, 191, 243, 253, 254, 246 }, 145)) || _0x35a2264e.StartsWith(_0x3d947f34._0xcb080bfe(new byte[25] { 232, 244, 244, 240, 243, 186, 175, 175, 226, 240, 231, 236, 239, 226, 225, 236, 230, 225, 246, 174, 236, 233, 246, 229, 175 }, 128), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0xa8753ec0);
                OpenUrlExternally(_0x35a2264e);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0x35a2264e))
            {
                _0x6fe84711(true);
                WLog(_0x3d947f34._0xcb080bfe(new byte[41] { 104, 64, 64, 72, 67, 74, 15, 78, 90, 91, 71, 15, 73, 67, 64, 88, 15, 75, 74, 91, 74, 76, 91, 74, 75, 15, 2, 17, 15, 68, 74, 74, 95, 15, 89, 70, 92, 70, 77, 67, 74 }, 47));
                return;
            }

            _0x3b520c34 = true;
            _0x6fe84711(true);
            WLog(_0x3d947f34._0xcb080bfe(new byte[43] { 204, 254, 249, 205, 242, 254, 236, 187, 247, 244, 250, 255, 242, 245, 252, 180, 233, 254, 255, 242, 233, 254, 248, 239, 242, 245, 252, 187, 182, 165, 187, 240, 254, 254, 235, 187, 237, 242, 232, 242, 249, 247, 254 }, 155));
        };
        _0x78111c3f.OnPageCommitted += (_0xa8753ec0, _0x35a2264e) =>
        {
            if (_0xe11c7db5 && IsAboutBlank(_0x35a2264e))
                return;
            WLog(_0x3d947f34._0xcb080bfe(new byte[31] { 115, 95, 87, 80, 30, 105, 91, 92, 104, 87, 91, 73, 30, 113, 80, 110, 95, 89, 91, 125, 81, 83, 83, 87, 74, 74, 91, 90, 4, 30, 21 }, 62) + (Time.realtimeSinceStartup - _0xc0704ef4).ToString(_0x3d947f34._0xcb080bfe(new byte[5] { 149, 139, 149, 149, 149 }, 165)) + _0x3d947f34._0xcb080bfe(new byte[2] { 155, 200 }, 232) + _0x35a2264e);
            if (!firstLoadShown && IsHttpUrl(_0x35a2264e))
            {
                firstLoadShown = true;
                _0x3b520c34 = false;
                _0x6fe84711(false);
                _0x080aa498();
                _0x3ee7036b();
                _0xa8753ec0.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x647f16a1(_0x3d947f34._0xcb080bfe(new byte[9] { 118, 119, 94, 110, 113, 100, 111, 100, 101 }, 1));
                WLog(_0x3d947f34._0xcb080bfe(new byte[39] { 29, 49, 57, 62, 112, 7, 53, 50, 6, 57, 53, 39, 112, 35, 56, 63, 39, 62, 112, 63, 62, 112, 51, 63, 61, 61, 57, 36, 36, 53, 52, 112, 51, 63, 62, 36, 53, 62, 36 }, 80));
            }
        };
        _0x78111c3f.OnPageProgressChanged += (_0xa8753ec0, _0xd4e32549) =>
        {
            if (_0xe11c7db5)
                return;
            if (!firstLoadShown && _0xd4e32549 >= 0.65f)
            {
                firstLoadShown = true;
                _0x3b520c34 = false;
                _0x6fe84711(false);
                _0x080aa498();
                _0x3ee7036b();
                _0xa8753ec0.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x647f16a1(_0x3d947f34._0xcb080bfe(new byte[9] { 148, 149, 188, 140, 147, 134, 141, 134, 135 }, 227));
                WLog(_0x3d947f34._0xcb080bfe(new byte[32] { 49, 29, 21, 18, 92, 43, 25, 30, 42, 21, 25, 11, 92, 15, 20, 19, 11, 18, 92, 30, 5, 92, 12, 14, 19, 27, 14, 25, 15, 15, 70, 92 }, 124) + _0xd4e32549);
            }
        };
        _0x78111c3f.OnPageFinished += (_0xa8753ec0, _0x44405211, _0x35a2264e) =>
        {
            if (_0xe11c7db5 && IsAboutBlank(_0x35a2264e))
            {
                _0xe11c7db5 = false;
                WLog(_0x3d947f34._0xcb080bfe(new byte[28] { 96, 66, 85, 71, 81, 66, 93, 16, 81, 82, 95, 69, 68, 10, 82, 92, 81, 94, 91, 16, 86, 89, 94, 89, 67, 88, 85, 84 }, 48));
                return;
            }

            WLog(_0x3d947f34._0xcb080bfe(new byte[24] { 140, 160, 168, 175, 225, 150, 164, 163, 151, 168, 164, 182, 225, 135, 168, 175, 168, 178, 169, 164, 165, 251, 225, 234 }, 193) + (Time.realtimeSinceStartup - _0xc0704ef4).ToString(_0x3d947f34._0xcb080bfe(new byte[5] { 159, 129, 159, 159, 159 }, 175)) + _0x3d947f34._0xcb080bfe(new byte[7] { 202, 153, 218, 214, 221, 220, 132 }, 185) + _0x44405211 + _0x3d947f34._0xcb080bfe(new byte[5] { 164, 241, 246, 232, 185 }, 132) + _0x35a2264e);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0x3b520c34 = false;
                _0x6fe84711(false);
                _0x080aa498();
                _0x3ee7036b();
                _0xa8753ec0.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x647f16a1(_0x3d947f34._0xcb080bfe(new byte[9] { 123, 122, 83, 99, 124, 105, 98, 105, 104 }, 12));
                WLog(_0x3d947f34._0xcb080bfe(new byte[33] { 229, 201, 193, 198, 136, 255, 205, 202, 254, 193, 205, 223, 136, 206, 193, 218, 219, 220, 136, 196, 199, 201, 204, 136, 203, 199, 197, 216, 196, 205, 220, 205, 204 }, 168));
            }
            else if (_0x3b520c34)
            {
                _0x3b520c34 = false;
                _0x6fe84711(false);
                _0xa8753ec0.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0x3d947f34._0xcb080bfe(new byte[40] { 21, 57, 49, 54, 120, 15, 61, 58, 14, 49, 61, 47, 120, 11, 48, 55, 47, 120, 57, 62, 44, 61, 42, 120, 52, 55, 57, 60, 49, 54, 63, 120, 62, 49, 54, 49, 43, 48, 61, 60 }, 88));
            }
            else
            {
                _0x6fe84711(false);
            }

            if (_0xf5f46bf2 && !IsGoogleAuthFlowUrl(_0x35a2264e) && !IsGoogleAuthFlowUrl(_0x35a2264e))
            {
                WLog(_0x3d947f34._0xcb080bfe(new byte[48] { 152, 176, 176, 184, 179, 186, 255, 190, 170, 171, 183, 255, 172, 186, 186, 178, 172, 255, 185, 182, 177, 182, 172, 183, 186, 187, 255, 242, 225, 255, 173, 186, 172, 171, 176, 173, 186, 255, 187, 186, 185, 190, 170, 179, 171, 255, 138, 158 }, 223));
                _0xf5f46bf2 = false;
                _0x139560db.SetUserAgent("");
            }
        };
        _0x78111c3f.OnShouldClose += _0xa8753ec0 =>
        {
            WLog(_0x3d947f34._0xcb080bfe(new byte[41] { 74, 69, 116, 98, 101, 76, 49, 92, 112, 120, 127, 49, 70, 116, 115, 71, 120, 116, 102, 49, 94, 127, 66, 121, 126, 100, 125, 117, 82, 125, 126, 98, 116, 49, 120, 127, 103, 126, 122, 116, 117 }, 17));
            _0x804a293f();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0x78111c3f.SetPopupPageEventEnabled(true);
        bool _0xf43c421f = false;
        bool _0xaa248a07 = false;
        _0x78111c3f.OnMultipleWindowOpened += (_0xa8753ec0, _0x1d79289f) =>
        {
            _0xa8753ec0.ScrollTo(0, 0, false);
            WLog(_0x3d947f34._0xcb080bfe(new byte[43] { 196, 203, 250, 236, 235, 194, 191, 210, 254, 246, 241, 191, 200, 250, 253, 201, 246, 250, 232, 191, 210, 234, 243, 235, 246, 239, 243, 250, 200, 246, 241, 251, 240, 232, 191, 208, 239, 250, 241, 250, 251, 165, 191 }, 159) + _0x1d79289f);
            var _0xf629b0bb = _0x78111c3f.GetPopupWindow(_0x1d79289f);
            if (_0xf629b0bb == null)
                return;
            _0xca1115fa.Add(_0xf629b0bb);
            Debug.Log($"[Test] Popup ID: {_0xf629b0bb.Id}");
            _0xf629b0bb.OnPageStarted += (_0x19f0ea4b, _0x35a2264e) =>
            {
                WLog(_0x3d947f34._0xcb080bfe(new byte[36] { 32, 47, 30, 8, 15, 38, 91, 43, 20, 11, 14, 11, 91, 44, 30, 25, 45, 18, 30, 12, 91, 52, 21, 43, 26, 28, 30, 40, 15, 26, 9, 15, 30, 31, 65, 91 }, 123) + _0x35a2264e);
                _0x1674b961 = 0;
                if (string.IsNullOrEmpty(_0x35a2264e) || IsAboutBlank(_0x35a2264e))
                    return;
                if (IsGoogleAuthFlowUrl(_0x35a2264e))
                {
                    WLog(_0x3d947f34._0xcb080bfe(new byte[57] { 241, 254, 207, 217, 222, 247, 138, 250, 197, 218, 223, 218, 138, 237, 197, 197, 205, 198, 207, 138, 203, 223, 222, 194, 138, 204, 198, 197, 221, 138, 135, 148, 138, 217, 218, 197, 197, 204, 138, 237, 197, 197, 205, 198, 207, 138, 233, 194, 216, 197, 199, 207, 138, 255, 235, 144, 138 }, 170) + _0x35a2264e);
                    _0xf43c421f = false;
                    _0xeaef7f22();
                    if (_0x19f0ea4b != null && _0x19f0ea4b.IsAlive)
                        _0x19f0ea4b.EvaluateJavaScript(_0x2400df92());
                    return;
                }

                if (_0x139560db == null)
                    return;
                if (!_0xf43c421f)
                {
                    _0xf43c421f = true;
                    _0x139560db.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0x3d947f34._0xcb080bfe(new byte[39] { 210, 221, 236, 250, 253, 212, 169, 217, 230, 249, 252, 249, 169, 232, 249, 249, 229, 240, 169, 222, 224, 231, 237, 230, 254, 250, 169, 237, 236, 250, 226, 253, 230, 249, 169, 220, 200, 179, 169 }, 137) + _0x35a2264e);
                }

                if (_0x19f0ea4b != null && _0x19f0ea4b.IsAlive)
                    _0x19f0ea4b.EvaluateJavaScript(_0x4e94f2da());
                if (!_0xaa248a07 && _0x19f0ea4b != null && _0x19f0ea4b.IsAlive && IsHttpUrl(_0x35a2264e))
                {
                    _0xaa248a07 = true;
                }
            };
            _0xf629b0bb.OnPageFinished += (_0x19f0ea4b, _0xba964fa4) =>
            {
                string _0xd421eadd = _0xba964fa4 != null ? _0xba964fa4.data : string.Empty;
                WLog(_0x3d947f34._0xcb080bfe(new byte[35] { 198, 201, 248, 238, 233, 192, 189, 205, 242, 237, 232, 237, 189, 202, 248, 255, 203, 244, 248, 234, 189, 219, 244, 243, 244, 238, 245, 248, 249, 167, 189, 232, 239, 241, 160 }, 157) + _0xd421eadd);
                if (_0x19f0ea4b == null || !_0x19f0ea4b.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0xd421eadd))
                {
                    _0xeaef7f22();
                    _0x19f0ea4b.EvaluateJavaScript(_0x2400df92());
                    return;
                }

                if (!_0xf43c421f)
                    return;
                _0x19f0ea4b.EvaluateJavaScript(_0x4e94f2da());
            };
        };
        _0x78111c3f.OnMultipleWindowClosed += (_0xa8753ec0, _0x1d79289f) =>
        {
            _0xca1115fa.RemoveAll(_0xb19cd858 => _0xb19cd858 == null || _0xb19cd858.Id == _0x1d79289f || !_0xb19cd858.IsAlive);
            _0x6fe84711(false);
            if (_0xca1115fa.Count == 0 && _0x139560db != null)
            {
                _0xf43c421f = false;
                _0xaa248a07 = false;
                _0x31d8a61d();
            }

            WLog(_0x3d947f34._0xcb080bfe(new byte[43] { 151, 152, 169, 191, 184, 145, 236, 129, 173, 165, 162, 236, 155, 169, 174, 154, 165, 169, 187, 236, 129, 185, 160, 184, 165, 188, 160, 169, 155, 165, 162, 168, 163, 187, 236, 143, 160, 163, 191, 169, 168, 246, 236 }, 204) + _0x1d79289f);
        };
        _0x78111c3f.RegisterOnRequestMediaCapturePermission(_0x26b5c4fb =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    private int _0xa763d740 = 5, _0xfd8aa7ce = 5, _0x7cddf376 = 5, _0x2fb8858e = 5;
    private string _0xcead1fc8 { get; set; }

    internal Vector2 lastSize = Vector2.zero;
    private bool TryOpenExternalLikeChrome(string _0x1e55f7d6)
    {
        if (string.IsNullOrEmpty(_0x1e55f7d6))
            return false;
        if (_0x1e55f7d6.StartsWith(_0x3d947f34._0xcb080bfe(new byte[9] { 8, 15, 21, 4, 15, 21, 91, 78, 78 }, 97), StringComparison.OrdinalIgnoreCase))
            return _0x4085cc79(_0x1e55f7d6);
        if (_0xfcfdff7d(_0x1e55f7d6))
            return _0x1453b0f9(_0x1e55f7d6, null);
        if (!_0x1e55f7d6.StartsWith(_0x3d947f34._0xcb080bfe(new byte[7] { 119, 107, 107, 111, 37, 48, 48 }, 31), StringComparison.OrdinalIgnoreCase) && !_0x1e55f7d6.StartsWith(_0x3d947f34._0xcb080bfe(new byte[8] { 230, 250, 250, 254, 253, 180, 161, 161 }, 142), StringComparison.OrdinalIgnoreCase) && !_0x1e55f7d6.StartsWith(_0x3d947f34._0xcb080bfe(new byte[11] { 60, 63, 50, 40, 41, 103, 63, 49, 60, 51, 54 }, 93), StringComparison.OrdinalIgnoreCase))
        {
            return _0x3d33f858(_0x1e55f7d6);
        }

        return false;
    }

    private IEnumerator _0xa5c43546()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0x3d947f34._0xcb080bfe(new byte[26] { 252, 243, 194, 212, 211, 250, 135, 238, 201, 206, 211, 206, 198, 203, 206, 221, 194, 245, 194, 193, 193, 194, 213, 194, 213, 135 }, 167));
            }
#endif
        }

        bool _0x10c7bfaf = false;
        InstallReferrer.GetReferrer((_0x892300ed) =>
        {
            Debug.Log(_0x3d947f34._0xcb080bfe(new byte[24] { 200, 199, 246, 224, 231, 179, 193, 246, 245, 246, 225, 225, 246, 225, 206, 179, 244, 246, 231, 179, 113, 21, 1, 179 }, 147) + _0xe80e9b68);
            if (_0x892300ed.IsSuccess)
            {
                _0xe80e9b68 = _0x892300ed.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0x3d947f34._0xcb080bfe(new byte[28] { 123, 116, 69, 83, 84, 0, 114, 69, 70, 69, 82, 82, 69, 82, 125, 0, 115, 85, 67, 67, 69, 83, 83, 0, 194, 166, 178, 0 }, 32) + _0xe80e9b68);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0x3d947f34._0xcb080bfe(new byte[27] { 114, 125, 76, 90, 93, 9, 123, 76, 79, 76, 91, 91, 76, 91, 116, 9, 111, 72, 64, 69, 76, 77, 9, 203, 175, 187, 9 }, 41) + _0x892300ed);
#endif
                }

                _0xe80e9b68 = "";
            }

            _0xabc17188 = true;
        });
        StartCoroutine(_0x15003eec(2f));
        yield return new WaitUntil(() => _0xabc17188);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0xe80e9b68}");
#endif
        }

        bool _0x90b2bdc7 = _0xe80e9b68.Contains(_0x3d947f34._0xcb080bfe(new byte[6] { 251, 255, 240, 245, 248, 161 }, 156));
        _0x10c7bfaf = _0x90b2bdc7 || _0xe80e9b68.Contains(_0x3d947f34._0xcb080bfe(new byte[18] { 9, 24, 24, 27, 70, 1, 6, 27, 28, 9, 15, 26, 9, 5, 70, 11, 7, 5 }, 104)) || _0xe80e9b68.Contains(_0x3d947f34._0xcb080bfe(new byte[17] { 31, 14, 14, 13, 80, 24, 31, 29, 27, 28, 17, 17, 21, 80, 29, 17, 19 }, 126));
        _0x0617c81c = _0x90b2bdc7 ? "" : (_0x10c7bfaf ? "" : _0x0617c81c);
        _0x0617c81c = _0x0617c81c ?? "";
        _0xcead1fc8 = _0xcead1fc8 ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0x0617c81c}");
#endif
        }
    }

    internal bool isApplicationPause = false;
    private string _0x8b3e4e41 = "";
    private void _0x2368f0d8()
    {
        if (_0x50ba8ffc)
        {
            WLog(_0x3d947f34._0xcb080bfe(new byte[18] { 95, 98, 115, 110, 58, 123, 118, 104, 127, 123, 126, 99, 58, 105, 114, 117, 109, 116 }, 26));
            return;
        }

        _0x6fe84711(false);
        WLog(_0x3d947f34._0xcb080bfe(new byte[46] { 130, 174, 166, 161, 239, 152, 170, 173, 153, 166, 170, 184, 239, 159, 186, 188, 167, 239, 129, 160, 187, 166, 169, 166, 172, 174, 187, 166, 160, 161, 239, 231, 167, 174, 189, 171, 184, 174, 189, 170, 239, 173, 174, 172, 164, 230 }, 207));
        ++_0x1674b961;
        _0xfb3aac93();
        if (_0x1674b961 <= 1)
            return;
        if (_0xd47f39bc())
        {
            WLog(_0x3d947f34._0xcb080bfe(new byte[37] { 31, 34, 51, 46, 122, 41, 49, 51, 42, 42, 63, 62, 122, 119, 100, 122, 42, 53, 42, 47, 42, 41, 122, 41, 46, 51, 54, 54, 122, 53, 42, 63, 52, 63, 62, 96, 122 }, 90) + _0xca1115fa.Count);
            return;
        }

        Application.Quit();
    }

    private string _0xee372db2;
    internal string _0x80b5266d(string _0x5ff4fa27)
    {
        int _0x77d30839 = _0x5ff4fa27.IndexOf(_0x3d947f34._0xcb080bfe(new byte[3] { 22, 27, 66 }, 127), StringComparison.OrdinalIgnoreCase);
        if (_0x77d30839 < 0)
            return null;
        string _0xb0880a6e = _0x5ff4fa27.Substring(_0x77d30839 + 3);
        int _0x50ed8ff3 = _0xb0880a6e.IndexOf('&');
        return _0x50ed8ff3 >= 0 ? _0xb0880a6e.Substring(0, _0x50ed8ff3) : _0xb0880a6e;
    }

    internal bool IsAboutBlank(string _0x795455e8)
    {
        if (string.IsNullOrEmpty(_0x795455e8))
            return false;
        return _0x795455e8.StartsWith(_0x3d947f34._0xcb080bfe(new byte[11] { 103, 100, 105, 115, 114, 60, 100, 106, 103, 104, 109 }, 6), StringComparison.OrdinalIgnoreCase);
    }

    private bool OpenUrlExternally(string _0xc1f5e3e7)
    {
        return _0x3d33f858(_0xc1f5e3e7);
    }

    private Text _0x44aca0c0;
    private async Task<bool> _0x208756a2()
    {
        {
#if B_LOGS
            Debug.Log(_0x3d947f34._0xcb080bfe(new byte[29] { 80, 95, 110, 120, 127, 86, 43, 66, 120, 91, 121, 98, 125, 106, 104, 114, 74, 101, 111, 88, 106, 125, 110, 111, 72, 99, 110, 104, 96 }, 11));
#endif
        }

        string _0xf0771983 = "";
        for (int _0x959a8c3d = 0; _0x959a8c3d < 2; _0x959a8c3d++)
        {
            if (await _0xd8f5a025(1, 100))
            {
                await _0x647f16a1(_0x3d947f34._0xcb080bfe(new byte[7] { 51, 61, 62, 50, 58, 52, 53 }, 81));
                _0x2f201f78();
                return true;
            }

            _0xf0771983 = await _0xf780e548(1, 100);
            if (!string.IsNullOrEmpty(_0xf0771983))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0xf0771983))
            {
                if (!string.IsNullOrEmpty(_0xee372db2))
                {
                    _0xf0771983 = _0xf7296715(_0xf0771983, _0xee372db2);
                    {
#if B_LOGS
                        Debug.Log(_0x3d947f34._0xcb080bfe(new byte[53] { 81, 94, 111, 121, 126, 87, 42, 73, 107, 105, 98, 111, 110, 42, 108, 99, 100, 107, 102, 95, 120, 102, 42, 125, 99, 126, 98, 42, 121, 111, 100, 110, 99, 110, 42, 232, 140, 152, 42, 121, 98, 101, 125, 42, 93, 111, 104, 92, 99, 111, 125, 48, 42 }, 10) + _0xf0771983);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0x3d947f34._0xcb080bfe(new byte[39] { 236, 227, 210, 196, 195, 234, 151, 244, 214, 212, 223, 210, 211, 151, 209, 222, 217, 214, 219, 226, 197, 219, 151, 85, 49, 37, 151, 196, 223, 216, 192, 151, 224, 210, 213, 225, 222, 210, 192 }, 183));
#endif
                    }
                }

                _0x9a87561c = true;
                _0xb3546697(_0xf0771983);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x3d947f34._0xcb080bfe(new byte[44] { 154, 149, 164, 178, 181, 156, 225, 132, 185, 162, 164, 177, 181, 168, 174, 175, 225, 182, 169, 168, 173, 164, 225, 162, 169, 164, 162, 170, 168, 175, 166, 225, 178, 160, 183, 164, 165, 225, 173, 168, 175, 170, 251, 225 }, 193) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    internal bool isApplicationFocus = false;
    private string _0xf7296715(string _0x7f7adbe4, string _0x895ad023)
    {
        if (string.IsNullOrEmpty(_0x895ad023))
            return _0x7f7adbe4;
        if (_0x7f7adbe4.Contains(_0x3d947f34._0xcb080bfe(new byte[1] { 141 }, 178)))
            return _0x7f7adbe4 + _0x3d947f34._0xcb080bfe(new byte[8] { 151, 194, 212, 223, 213, 216, 213, 140 }, 177) + UnityWebRequest.EscapeURL(_0x895ad023);
        else
            return _0x7f7adbe4 + _0x3d947f34._0xcb080bfe(new byte[8] { 142, 194, 212, 223, 213, 216, 213, 140 }, 177) + UnityWebRequest.EscapeURL(_0x895ad023);
    }

    private string _0xc1e6ce1d = "";
    private bool _0x9a87561c = false;
    private string _0x9cacd2e8 = "";
    private string _0x0617c81c { get; set; }

    private bool _0x1453b0f9(string _0xd89463d4, string _0xff98e4e7)
    {
        string _0x2fc924d1 = _0x80b5266d(_0xd89463d4);
        if (string.IsNullOrEmpty(_0x2fc924d1))
            _0x2fc924d1 = _0xff98e4e7;
        if (_0xffa76e47(_0x2fc924d1))
            return true;
        string _0xe3b91149 = string.IsNullOrEmpty(_0x2fc924d1) ? _0x3d947f34._0xcb080bfe(new byte[29] { 119, 107, 107, 111, 108, 37, 48, 48, 111, 115, 126, 102, 49, 120, 112, 112, 120, 115, 122, 49, 124, 112, 114, 48, 108, 107, 112, 109, 122 }, 31) : _0x3d947f34._0xcb080bfe(new byte[46] { 56, 36, 36, 32, 35, 106, 127, 127, 32, 60, 49, 41, 126, 55, 63, 63, 55, 60, 53, 126, 51, 63, 61, 127, 35, 36, 63, 34, 53, 127, 49, 32, 32, 35, 127, 52, 53, 36, 49, 57, 60, 35, 111, 57, 52, 109 }, 80) + _0x2fc924d1;
        WLog(_0x3d947f34._0xcb080bfe(new byte[35] { 248, 211, 201, 212, 214, 222, 247, 210, 208, 222, 155, 214, 218, 201, 208, 222, 207, 155, 221, 218, 215, 215, 217, 218, 216, 208, 155, 218, 200, 155, 204, 222, 217, 129, 155 }, 187) + _0xe3b91149);
        return _0x3d33f858(_0xe3b91149);
    }

    private string _0x4e94f2da()
    {
        return _0x3d947f34._0xcb080bfe(new byte[12] { 145, 223, 204, 215, 218, 205, 208, 214, 215, 145, 144, 194 }, 185) + _0x3d947f34._0xcb080bfe(new byte[8] { 134, 145, 130, 208, 133, 145, 205, 215 }, 240) + WindowsDesktopUserAgent + _0x3d947f34._0xcb080bfe(new byte[2] { 34, 62 }, 5) + _0x3d947f34._0xcb080bfe(new byte[30] { 245, 226, 241, 163, 243, 241, 236, 247, 236, 190, 205, 226, 245, 234, 228, 226, 247, 236, 241, 173, 243, 241, 236, 247, 236, 247, 250, 243, 230, 184 }, 131) + _0x3d947f34._0xcb080bfe(new byte[121] { 116, 103, 124, 113, 102, 123, 125, 124, 50, 118, 119, 116, 58, 125, 112, 120, 62, 121, 119, 107, 62, 100, 115, 126, 59, 105, 102, 96, 107, 105, 93, 112, 120, 119, 113, 102, 60, 118, 119, 116, 123, 124, 119, 66, 96, 125, 98, 119, 96, 102, 107, 58, 125, 112, 120, 62, 121, 119, 107, 62, 105, 117, 119, 102, 40, 116, 103, 124, 113, 102, 123, 125, 124, 58, 59, 105, 96, 119, 102, 103, 96, 124, 50, 100, 115, 126, 41, 111, 62, 113, 125, 124, 116, 123, 117, 103, 96, 115, 112, 126, 119, 40, 102, 96, 103, 119, 111, 59, 41, 111, 113, 115, 102, 113, 122, 58, 119, 59, 105, 111, 111 }, 18) + _0x3d947f34._0xcb080bfe(new byte[26] { 196, 197, 198, 136, 208, 210, 207, 212, 207, 140, 135, 213, 211, 197, 210, 225, 199, 197, 206, 212, 135, 140, 213, 193, 137, 155 }, 160) + _0x3d947f34._0xcb080bfe(new byte[130] { 179, 178, 177, 255, 167, 165, 184, 163, 184, 251, 240, 182, 167, 167, 129, 178, 165, 164, 190, 184, 185, 240, 251, 240, 226, 249, 231, 247, 255, 128, 190, 185, 179, 184, 160, 164, 247, 153, 131, 247, 230, 231, 249, 231, 236, 247, 128, 190, 185, 225, 227, 236, 247, 175, 225, 227, 254, 247, 150, 167, 167, 187, 178, 128, 178, 181, 156, 190, 163, 248, 226, 228, 224, 249, 228, 225, 247, 255, 156, 159, 131, 154, 155, 251, 247, 187, 190, 188, 178, 247, 144, 178, 180, 188, 184, 254, 247, 148, 191, 165, 184, 186, 178, 248, 230, 229, 231, 249, 231, 249, 231, 249, 231, 247, 132, 182, 177, 182, 165, 190, 248, 226, 228, 224, 249, 228, 225, 240, 254, 236 }, 215) + _0x3d947f34._0xcb080bfe(new byte[30] { 227, 226, 225, 175, 247, 245, 232, 243, 232, 171, 160, 247, 235, 230, 243, 225, 232, 245, 234, 160, 171, 160, 208, 238, 233, 180, 181, 160, 174, 188 }, 135) + _0x3d947f34._0xcb080bfe(new byte[34] { 132, 133, 134, 200, 144, 146, 143, 148, 143, 204, 199, 150, 133, 142, 132, 143, 146, 199, 204, 199, 167, 143, 143, 135, 140, 133, 192, 169, 142, 131, 206, 199, 201, 219 }, 224) + _0x3d947f34._0xcb080bfe(new byte[30] { 164, 165, 166, 232, 176, 178, 175, 180, 175, 236, 231, 173, 161, 184, 148, 175, 181, 163, 168, 144, 175, 169, 174, 180, 179, 231, 236, 240, 233, 251 }, 192) + _0x3d947f34._0xcb080bfe(new byte[449] { 242, 244, 255, 253, 240, 231, 244, 166, 243, 231, 226, 187, 253, 228, 244, 231, 232, 226, 245, 188, 221, 253, 228, 244, 231, 232, 226, 188, 161, 197, 238, 244, 233, 235, 239, 243, 235, 161, 170, 240, 227, 244, 245, 239, 233, 232, 188, 161, 183, 180, 182, 161, 251, 170, 253, 228, 244, 231, 232, 226, 188, 161, 193, 233, 233, 225, 234, 227, 166, 197, 238, 244, 233, 235, 227, 161, 170, 240, 227, 244, 245, 239, 233, 232, 188, 161, 183, 180, 182, 161, 251, 170, 253, 228, 244, 231, 232, 226, 188, 161, 200, 233, 242, 187, 199, 185, 196, 244, 231, 232, 226, 161, 170, 240, 227, 244, 245, 239, 233, 232, 188, 161, 180, 178, 161, 251, 219, 170, 235, 233, 228, 239, 234, 227, 188, 224, 231, 234, 245, 227, 170, 246, 234, 231, 242, 224, 233, 244, 235, 188, 161, 209, 239, 232, 226, 233, 241, 245, 161, 170, 225, 227, 242, 206, 239, 225, 238, 195, 232, 242, 244, 233, 246, 255, 208, 231, 234, 243, 227, 245, 188, 224, 243, 232, 229, 242, 239, 233, 232, 174, 175, 253, 244, 227, 242, 243, 244, 232, 166, 214, 244, 233, 235, 239, 245, 227, 168, 244, 227, 245, 233, 234, 240, 227, 174, 253, 231, 244, 229, 238, 239, 242, 227, 229, 242, 243, 244, 227, 188, 161, 254, 190, 176, 161, 170, 228, 239, 242, 232, 227, 245, 245, 188, 161, 176, 178, 161, 170, 235, 233, 228, 239, 234, 227, 188, 224, 231, 234, 245, 227, 170, 235, 233, 226, 227, 234, 188, 161, 161, 170, 246, 234, 231, 242, 224, 233, 244, 235, 188, 161, 209, 239, 232, 226, 233, 241, 245, 161, 170, 246, 234, 231, 242, 224, 233, 244, 235, 208, 227, 244, 245, 239, 233, 232, 188, 161, 183, 179, 168, 182, 168, 182, 161, 170, 243, 231, 192, 243, 234, 234, 208, 227, 244, 245, 239, 233, 232, 188, 161, 183, 180, 182, 168, 182, 168, 182, 168, 182, 161, 251, 175, 189, 251, 251, 189, 201, 228, 236, 227, 229, 242, 168, 226, 227, 224, 239, 232, 227, 214, 244, 233, 246, 227, 244, 242, 255, 174, 246, 244, 233, 242, 233, 170, 161, 243, 245, 227, 244, 199, 225, 227, 232, 242, 194, 231, 242, 231, 161, 170, 253, 225, 227, 242, 188, 224, 243, 232, 229, 242, 239, 233, 232, 174, 175, 253, 244, 227, 242, 243, 244, 232, 166, 243, 231, 226, 189, 251, 170, 229, 233, 232, 224, 239, 225, 243, 244, 231, 228, 234, 227, 188, 242, 244, 243, 227, 251, 175, 189, 251, 229, 231, 242, 229, 238, 174, 227, 175, 253, 251 }, 134) + _0x3d947f34._0xcb080bfe(new byte[112] { 176, 177, 178, 252, 167, 183, 166, 177, 177, 186, 248, 243, 163, 189, 176, 160, 188, 243, 248, 229, 237, 230, 228, 253, 239, 176, 177, 178, 252, 167, 183, 166, 177, 177, 186, 248, 243, 188, 177, 189, 179, 188, 160, 243, 248, 229, 228, 236, 228, 253, 239, 176, 177, 178, 252, 167, 183, 166, 177, 177, 186, 248, 243, 181, 162, 181, 189, 184, 131, 189, 176, 160, 188, 243, 248, 229, 237, 230, 228, 253, 239, 176, 177, 178, 252, 167, 183, 166, 177, 177, 186, 248, 243, 181, 162, 181, 189, 184, 156, 177, 189, 179, 188, 160, 243, 248, 229, 228, 224, 228, 253, 239 }, 212) + _0x3d947f34._0xcb080bfe(new byte[45] { 239, 233, 226, 224, 236, 242, 245, 255, 244, 236, 181, 244, 245, 239, 244, 238, 248, 243, 232, 239, 250, 233, 239, 166, 238, 245, 255, 254, 253, 242, 245, 254, 255, 160, 230, 248, 250, 239, 248, 243, 179, 254, 178, 224, 230 }, 155) + _0x3d947f34._0xcb080bfe(new byte[721] { 213, 211, 216, 218, 215, 192, 211, 129, 206, 211, 200, 198, 156, 214, 200, 207, 197, 206, 214, 143, 204, 192, 213, 194, 201, 236, 196, 197, 200, 192, 143, 195, 200, 207, 197, 137, 214, 200, 207, 197, 206, 214, 136, 154, 214, 200, 207, 197, 206, 214, 143, 204, 192, 213, 194, 201, 236, 196, 197, 200, 192, 156, 199, 212, 207, 194, 213, 200, 206, 207, 137, 208, 136, 218, 215, 192, 211, 129, 210, 156, 242, 213, 211, 200, 207, 198, 137, 208, 136, 143, 213, 206, 237, 206, 214, 196, 211, 226, 192, 210, 196, 137, 136, 154, 200, 199, 137, 210, 143, 200, 207, 197, 196, 217, 238, 199, 137, 134, 209, 206, 200, 207, 213, 196, 211, 155, 129, 194, 206, 192, 211, 210, 196, 134, 136, 159, 156, 145, 221, 221, 210, 143, 200, 207, 197, 196, 217, 238, 199, 137, 134, 201, 206, 215, 196, 211, 155, 129, 207, 206, 207, 196, 134, 136, 159, 156, 145, 221, 221, 210, 143, 200, 207, 197, 196, 217, 238, 199, 137, 134, 204, 192, 217, 140, 214, 200, 197, 213, 201, 134, 136, 159, 156, 145, 221, 221, 210, 143, 200, 207, 197, 196, 217, 238, 199, 137, 134, 204, 192, 217, 140, 197, 196, 215, 200, 194, 196, 140, 214, 200, 197, 213, 201, 134, 136, 159, 156, 145, 136, 211, 196, 213, 212, 211, 207, 129, 218, 204, 192, 213, 194, 201, 196, 210, 155, 199, 192, 205, 210, 196, 141, 204, 196, 197, 200, 192, 155, 208, 141, 206, 207, 194, 201, 192, 207, 198, 196, 155, 207, 212, 205, 205, 141, 192, 197, 197, 237, 200, 210, 213, 196, 207, 196, 211, 155, 199, 212, 207, 194, 213, 200, 206, 207, 137, 136, 218, 220, 141, 211, 196, 204, 206, 215, 196, 237, 200, 210, 213, 196, 207, 196, 211, 155, 199, 212, 207, 194, 213, 200, 206, 207, 137, 136, 218, 220, 141, 192, 197, 197, 228, 215, 196, 207, 213, 237, 200, 210, 213, 196, 207, 196, 211, 155, 199, 212, 207, 194, 213, 200, 206, 207, 137, 136, 218, 220, 141, 211, 196, 204, 206, 215, 196, 228, 215, 196, 207, 213, 237, 200, 210, 213, 196, 207, 196, 211, 155, 199, 212, 207, 194, 213, 200, 206, 207, 137, 136, 218, 220, 141, 197, 200, 210, 209, 192, 213, 194, 201, 228, 215, 196, 207, 213, 155, 199, 212, 207, 194, 213, 200, 206, 207, 137, 136, 218, 211, 196, 213, 212, 211, 207, 129, 199, 192, 205, 210, 196, 154, 220, 220, 154, 200, 199, 137, 210, 143, 200, 207, 197, 196, 217, 238, 199, 137, 134, 209, 206, 200, 207, 213, 196, 211, 155, 129, 199, 200, 207, 196, 134, 136, 159, 156, 145, 221, 221, 210, 143, 200, 207, 197, 196, 217, 238, 199, 137, 134, 201, 206, 215, 196, 211, 155, 129, 201, 206, 215, 196, 211, 134, 136, 159, 156, 145, 136, 211, 196, 213, 212, 211, 207, 129, 218, 204, 192, 213, 194, 201, 196, 210, 155, 213, 211, 212, 196, 141, 204, 196, 197, 200, 192, 155, 208, 141, 206, 207, 194, 201, 192, 207, 198, 196, 155, 207, 212, 205, 205, 141, 192, 197, 197, 237, 200, 210, 213, 196, 207, 196, 211, 155, 199, 212, 207, 194, 213, 200, 206, 207, 137, 136, 218, 220, 141, 211, 196, 204, 206, 215, 196, 237, 200, 210, 213, 196, 207, 196, 211, 155, 199, 212, 207, 194, 213, 200, 206, 207, 137, 136, 218, 220, 141, 192, 197, 197, 228, 215, 196, 207, 213, 237, 200, 210, 213, 196, 207, 196, 211, 155, 199, 212, 207, 194, 213, 200, 206, 207, 137, 136, 218, 220, 141, 211, 196, 204, 206, 215, 196, 228, 215, 196, 207, 213, 237, 200, 210, 213, 196, 207, 196, 211, 155, 199, 212, 207, 194, 213, 200, 206, 207, 137, 136, 218, 220, 141, 197, 200, 210, 209, 192, 213, 194, 201, 228, 215, 196, 207, 213, 155, 199, 212, 207, 194, 213, 200, 206, 207, 137, 136, 218, 211, 196, 213, 212, 211, 207, 129, 199, 192, 205, 210, 196, 154, 220, 220, 154, 211, 196, 213, 212, 211, 207, 129, 206, 211, 200, 198, 137, 208, 136, 154, 220, 154, 220, 194, 192, 213, 194, 201, 137, 196, 136, 218, 220 }, 161) + _0x3d947f34._0xcb080bfe(new byte[5] { 250, 174, 175, 174, 188 }, 135);
    }

    private bool _0xd47f39bc()
    {
        _0xca1115fa.RemoveAll(_0xb19cd858 => _0xb19cd858 == null || !_0xb19cd858.IsAlive);
        return _0xca1115fa.Count > 0;
    }

    private async Task _0x84766846()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0xfa1b4410 = _0x3d947f34._0xcb080bfe(new byte[5] { 123, 124, 113, 110, 120 }, 29);
        _0x446acf9f = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0x7509652c = DateTime.UtcNow.Ticks.ToString();
        _0x83223c99 = "";
        JObject _0x15bc77b1 = _0x15772327(_0xc1e6ce1d, _0xd9fe3118, _0x8b3e4e41, _0xeb4e6301, _0xe80e9b68, _0x0617c81c, _0xcead1fc8, _0xa0a42562, _0x9cacd2e8, _0x65099719, _0xfa1b4410, _0x83223c99, _0x50382243, _0xf100370c, _0xd592929a.ToString(), _0x876edd02, _0x7509652c, _0x446acf9f, _0x39231805, _0x8b69ee87, _0xcb6dbbeb, _0x392b8494, _0x820ce48c());
        var _0x3b7e50e5 = _0x8202f621(_0x15bc77b1.ToString(), _0x39231805);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0x15bc77b1}");
            }
#endif
        }

        try
        {
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x3d947f34._0xcb080bfe(new byte[7] { 108, 125, 101, 112, 115, 125, 120 }, 28) + _0x39231805, _0x3b7e50e5 } });
            await Task.Delay(500);
            string _0xf58cbb6c = "";
            for (int _0x5487e17f = 0; _0x5487e17f < 20; _0x5487e17f++)
            {
                if (await _0xd8f5a025(1, 1))
                {
                    await _0x647f16a1(_0x3d947f34._0xcb080bfe(new byte[7] { 238, 224, 227, 239, 231, 233, 232 }, 140));
                    _0x2f201f78();
                    return;
                }

                _0xf58cbb6c = await _0xf780e548(1, 500);
                if (!string.IsNullOrEmpty(_0xf58cbb6c))
                    break;
            }

            _0xd11b28e3(_0xf58cbb6c);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x3d947f34._0xcb080bfe(new byte[22] { 212, 219, 202, 220, 219, 210, 175, 200, 234, 225, 234, 253, 238, 227, 175, 234, 253, 253, 224, 253, 181, 175 }, 143) + e.Message);
#endif
            }

            _0x2f201f78();
        }
    }

    private string _0x7509652c = "";
    private bool _0x8cf50e62()
    {
        var _0x226211f6 = Keyboard.current;
        return _0x226211f6 != null && _0x226211f6.escapeKey.wasPressedThisFrame;
    }

    private string Decrypt(string _0x45e4a94f, string _0xd76e99cd)
    {
        try
        {
            var _0x315c4673 = Convert.FromBase64String(_0x45e4a94f);
            using var _0xe0ebb9b2 = Aes.Create();
            _0xe0ebb9b2.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xd76e99cd));
            var _0xa3f50389 = new byte[16];
            Buffer.BlockCopy(_0x315c4673, 0, _0xa3f50389, 0, 16);
            _0xe0ebb9b2.IV = _0xa3f50389;
            using var _0xd06a7e00 = new MemoryStream(_0x315c4673, 16, _0x315c4673.Length - 16);
            using var _0x46299a88 = new CryptoStream(_0xd06a7e00, _0xe0ebb9b2.CreateDecryptor(), CryptoStreamMode.Read);
            using var _0x831352ef = new StreamReader(_0x46299a88, Encoding.UTF8);
            return _0x831352ef.ReadToEnd();
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    internal bool IsGoogleAuthFlowUrl(string _0xacdf4de0)
    {
        if (string.IsNullOrEmpty(_0xacdf4de0))
            return false;
        return _0xacdf4de0.IndexOf(_0x3d947f34._0xcb080bfe(new byte[19] { 230, 228, 228, 232, 242, 233, 243, 244, 169, 224, 232, 232, 224, 235, 226, 169, 228, 232, 234 }, 135), StringComparison.OrdinalIgnoreCase) >= 0 || _0xacdf4de0.IndexOf(_0x3d947f34._0xcb080bfe(new byte[16] { 228, 230, 230, 234, 240, 235, 241, 246, 171, 226, 234, 234, 226, 233, 224, 171 }, 133), StringComparison.OrdinalIgnoreCase) >= 0 || _0xacdf4de0.IndexOf(_0x3d947f34._0xcb080bfe(new byte[21] { 247, 255, 255, 247, 252, 245, 229, 227, 245, 226, 243, 255, 254, 228, 245, 254, 228, 190, 243, 255, 253 }, 144), StringComparison.OrdinalIgnoreCase) >= 0 || _0xacdf4de0.IndexOf(_0x3d947f34._0xcb080bfe(new byte[11] { 254, 234, 237, 248, 237, 240, 250, 183, 250, 246, 244 }, 153), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private static string ReadPushField(Dictionary<string, object> _0x4b1434db, string _0x9d5e0717)
    {
        if (_0x4b1434db == null || string.IsNullOrEmpty(_0x9d5e0717))
            return string.Empty;
        if (_0x4b1434db.TryGetValue(_0x3d947f34._0xcb080bfe(new byte[16] { 31, 30, 5, 24, 23, 24, 18, 16, 5, 24, 30, 31, 53, 16, 5, 16 }, 113), out var raw))
        {
            try
            {
                var _0x1decc297 = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0x1decc297 != null && _0x1decc297.TryGetValue(_0x9d5e0717, out var nestedVal))
                {
                    var _0x18ab699e = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0x18ab699e))
                        return _0x18ab699e;
                }
            }
            catch
            {
            }
        }

        if (_0x4b1434db.TryGetValue(_0x9d5e0717, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }

    private void _0xd359b62f()
    {
        {
#if B_LOGS
            Debug.Log(_0x3d947f34._0xcb080bfe(new byte[22] { 1, 14, 63, 41, 46, 7, 122, 9, 46, 53, 40, 63, 30, 63, 44, 51, 57, 63, 19, 52, 60, 53 }, 90));
#endif
        }

        _0x50382243 = SystemInfo.deviceModel;
        _0xf100370c = Application.version;
        _0xd592929a = Application.installMode;
        _0x876edd02 = Application.installerName;
        _0xc1e6ce1d = Application.identifier;
        _0x8b3e4e41 = _0xad3881bf();
        _0xa0a42562 = _0x30fc7aab();
        _0x65099719 = SystemInfo.deviceUniqueIdentifier;
        _0x8b69ee87 = SystemInfo.graphicsDeviceName;
        _0xcb6dbbeb = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0xf100370c = _0x3d947f34._0xcb080bfe(new byte[5] { 183, 174, 183, 174, 183 }, 128);
                _0xd592929a = ApplicationInstallMode.Store;
                _0x876edd02 = _0x3d947f34._0xcb080bfe(new byte[19] { 134, 138, 136, 203, 132, 139, 129, 151, 138, 140, 129, 203, 147, 128, 139, 129, 140, 139, 130 }, 229);
                _0xa0a42562 = _0x3d947f34._0xcb080bfe(new byte[8] { 110, 102, 123, 127, 114, 43, 126, 106 }, 11);
                _0x65099719 = Guid.NewGuid().ToString().Replace(_0x3d947f34._0xcb080bfe(new byte[1] { 128 }, 173), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0x3d947f34._0xcb080bfe(new byte[17] { 54, 57, 8, 30, 25, 48, 77, 9, 8, 27, 32, 2, 9, 8, 1, 87, 77 }, 109) + _0x50382243);
            Debug.Log(_0x3d947f34._0xcb080bfe(new byte[19] { 128, 143, 190, 168, 175, 134, 251, 186, 171, 171, 141, 190, 169, 168, 178, 180, 181, 225, 251 }, 219) + _0xf100370c);
            Debug.Log(_0x3d947f34._0xcb080bfe(new byte[20] { 100, 107, 90, 76, 75, 98, 31, 86, 81, 76, 75, 94, 83, 83, 114, 80, 91, 90, 5, 31 }, 63) + _0xd592929a);
            Debug.Log(_0x3d947f34._0xcb080bfe(new byte[23] { 12, 3, 50, 36, 35, 10, 119, 62, 57, 36, 35, 54, 59, 59, 50, 37, 4, 35, 56, 37, 50, 109, 119 }, 87) + _0x876edd02);
            Debug.Log(_0x3d947f34._0xcb080bfe(new byte[14] { 140, 131, 178, 164, 163, 138, 247, 182, 167, 167, 158, 179, 237, 247 }, 215) + _0xc1e6ce1d);
            Debug.Log(_0x3d947f34._0xcb080bfe(new byte[14] { 61, 50, 3, 21, 18, 59, 70, 7, 2, 16, 47, 2, 92, 70 }, 102) + _0x8b3e4e41);
            Debug.Log(_0x3d947f34._0xcb080bfe(new byte[18] { 108, 99, 82, 68, 67, 106, 23, 66, 68, 82, 69, 118, 80, 82, 89, 67, 13, 23 }, 55) + _0xa0a42562);
            Debug.Log(_0x3d947f34._0xcb080bfe(new byte[17] { 195, 204, 253, 235, 236, 197, 184, 235, 225, 235, 220, 253, 238, 209, 252, 162, 184 }, 152) + _0x65099719);
            Debug.Log(_0x3d947f34._0xcb080bfe(new byte[12] { 191, 176, 129, 151, 144, 185, 196, 131, 148, 145, 222, 196 }, 228) + _0x8b69ee87);
            Debug.Log(_0x3d947f34._0xcb080bfe(new byte[12] { 55, 56, 9, 31, 24, 49, 76, 15, 28, 25, 86, 76 }, 108) + _0xcb6dbbeb);
#endif
        }
    }

    internal Button _0xaa7a1f2d(string _0xfa3a3d9c, Transform _0x43a08c00)
    {
        var _0x5fcaae8c = new GameObject(_0xfa3a3d9c + _0x3d947f34._0xcb080bfe(new byte[3] { 58, 12, 22 }, 120), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0xe6a96800 = _0x5fcaae8c.GetComponent<RectTransform>();
        _0xe6a96800.SetParent(_0x43a08c00, false);
        var _0x7823d080 = _0x5fcaae8c.GetComponent<Image>();
        _0x7823d080.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0xce47ed57 = _0x5fcaae8c.GetComponent<Button>();
        var _0x41dce1ec = _0xce47ed57.colors;
        _0x41dce1ec.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0x41dce1ec.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0xce47ed57.colors = _0x41dce1ec;
        var _0xc076d9f5 = new GameObject(_0x3d947f34._0xcb080bfe(new byte[4] { 163, 146, 143, 131 }, 247), typeof(RectTransform), typeof(Text));
        var _0xc32946cf = _0xc076d9f5.GetComponent<RectTransform>();
        _0xc32946cf.SetParent(_0x5fcaae8c.transform, false);
        _0xc32946cf.anchorMin = Vector2.zero;
        _0xc32946cf.anchorMax = Vector2.one;
        _0xc32946cf.offsetMin = _0xc32946cf.offsetMax = Vector2.zero;
        var _0x05772a89 = _0xc076d9f5.GetComponent<Text>();
        _0x05772a89.text = _0xfa3a3d9c;
        _0x05772a89.alignment = TextAnchor.MiddleCenter;
        _0x05772a89.color = Color.black;
        _0x05772a89.font = Resources.GetBuiltinResource<Font>(_0x3d947f34._0xcb080bfe(new byte[9] { 144, 163, 184, 176, 189, 255, 165, 165, 183 }, 209));
        _0x05772a89.fontSize = 28;
        WLog(_0x3d947f34._0xcb080bfe(new byte[14] { 221, 236, 251, 255, 234, 251, 220, 235, 234, 234, 241, 240, 190, 185 }, 158) + _0xfa3a3d9c + _0x3d947f34._0xcb080bfe(new byte[1] { 99 }, 68));
        return _0xce47ed57;
    }

    private string _0x820ce48c()
    {
        float _0x8048a893 = Time.realtimeSinceStartup;
        if (_0x8048a893 < 0f)
            _0x8048a893 = 0f;
        int _0x5e3c4b8d = (int)(_0x8048a893 * 1000f);
        int _0x2ab31c97 = _0x5e3c4b8d / 60000;
        int _0xbd18505b = (_0x5e3c4b8d / 1000) % 60;
        int _0x24853f5d = _0x5e3c4b8d % 1000;
        return string.Format(_0x3d947f34._0xcb080bfe(new byte[21] { 255, 180, 190, 180, 180, 249, 190, 255, 181, 190, 180, 180, 249, 190, 255, 182, 190, 180, 180, 180, 249 }, 132), _0x2ab31c97, _0xbd18505b, _0x24853f5d);
    }

    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0x2b996d82()
    {
        var _0x24dff288 = _0x3d947f34._0xcb080bfe(new byte[40] { 20, 8, 8, 12, 15, 70, 83, 83, 11, 11, 11, 82, 31, 16, 19, 9, 24, 26, 16, 29, 14, 25, 82, 31, 19, 17, 83, 31, 24, 18, 81, 31, 27, 21, 83, 8, 14, 29, 31, 25 }, 124);
        using (UnityWebRequest _0x1d6dddeb = UnityWebRequest.Get(_0x24dff288))
        {
            await _0x1d6dddeb.SendWebRequest();
            string[] _0x0c165e51 = _0x1d6dddeb.downloadHandler.text.Split('\n');
            foreach (string _0xe718e967 in _0x0c165e51)
            {
                if (_0xe718e967.StartsWith(_0x3d947f34._0xcb080bfe(new byte[3] { 4, 29, 80 }, 109)))
                {
                    string _0xee9fd45d = _0xe718e967.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0xee9fd45d} from {_0x24dff288}");
                        }
#endif
                    }

                    return _0xee9fd45d;
                }
            }
        }

        return "";
    }

    // WS_SOURCE MONO
    public static _0x793cf17f _0xfafb13df { get; private set; }

    private string _0x392b8494 = "";
    private bool _0xa9a95523 = false;
    public void _0x2f201f78()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0x3d947f34._0xcb080bfe(new byte[18] { 76, 67, 114, 100, 99, 74, 55, 91, 118, 98, 121, 116, 127, 55, 80, 118, 122, 114 }, 23));
#endif
        }

        _0x6fd584ac.Instance?._0xe5885772();
        _0xc9856497.Instance._0xf246b714(_0xe84084b3._0x35f75e78.DEFAULT);
    }

    private IEnumerator _0x29aad776(IEnumerator _0x1c3a3cf4, TaskCompletionSource<bool> _0xfe901cab)
    {
        yield return _0x1c3a3cf4;
        _0xfe901cab.SetResult(true);
    }

    private bool _0xf5f46bf2 = false;
    public void _0xc7a8c99b()
    {
        if (_0xa0eeacac)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0x3d947f34._0xcb080bfe(new byte[33] { 96, 111, 94, 72, 79, 102, 27, 111, 82, 86, 94, 73, 27, 84, 78, 79, 27, 22, 5, 27, 86, 84, 77, 94, 27, 79, 84, 27, 72, 88, 94, 85, 94 }, 59));
            }
#endif
        }

        _0x2f201f78();
    }

    private readonly List<UniWebViewPopup> _0xca1115fa = new List<UniWebViewPopup>();
    /* ============================= */
    /* ENCRYPT / DECRYPT             */
    /* ============================= */
    private string _0x8202f621(string _0x20f90b93, string _0x97f4b075)
    {
        try
        {
            using var _0xd4637eb2 = Aes.Create();
            _0xd4637eb2.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x97f4b075));
            _0xd4637eb2.GenerateIV();
            using var _0xceca14e8 = new MemoryStream();
            _0xceca14e8.Write(_0xd4637eb2.IV, 0, _0xd4637eb2.IV.Length);
            using (var _0x896b740f = new CryptoStream(_0xceca14e8, _0xd4637eb2.CreateEncryptor(), CryptoStreamMode.Write))
            {
                var _0xf6bc04c2 = Encoding.UTF8.GetBytes(_0x20f90b93);
                _0x896b740f.Write(_0xf6bc04c2, 0, _0xf6bc04c2.Length);
                _0x896b740f.FlushFinalBlock();
            }

            return Convert.ToBase64String(_0xceca14e8.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private Canvas _0x66b0ca20()
    {
        if (_0xa8ccb28f != null)
            return _0xa8ccb28f;
        var _0x9e54ca3a = gameObject.GetComponentInChildren<Canvas>();
        if (_0x9e54ca3a == null)
        {
            var _0x9da8732b = new GameObject(_0x3d947f34._0xcb080bfe(new byte[6] { 213, 247, 248, 224, 247, 229 }, 150), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0x9e54ca3a = _0x9da8732b.GetComponent<Canvas>();
            _0x9e54ca3a.transform.SetParent(transform, false);
            _0x9e54ca3a.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0xa8ccb28f = _0x9e54ca3a;
        return _0xa8ccb28f;
    }

    private void _0x6fe84711(bool _0x5bfd0e43)
    {
        _0x63166baa();
        _0x0f78b904.SetActive(_0x5bfd0e43);
        _0x5d6ee6a5 = _0x5bfd0e43;
        if (_0x5bfd0e43)
        {
            _0x0f78b904.transform.SetAsLastSibling();
            if (_0xa86edf5b != null)
                _0xa86edf5b.localRotation = Quaternion.identity;
        }
    }

    internal bool isDestroyedForce = false;
    private bool _0x2969e6a6(int _0x09276f3d, string _0x744b939c, string _0xc11672eb)
    {
        if (string.IsNullOrEmpty(_0xc11672eb))
            return false;
        if (!IsHttpUrl(_0xc11672eb))
            return true;
        if (string.IsNullOrEmpty(_0x744b939c))
            return false;
        return _0x744b939c.IndexOf(_0x3d947f34._0xcb080bfe(new byte[20] { 211, 196, 196, 201, 213, 217, 216, 216, 211, 213, 194, 223, 217, 216, 201, 196, 211, 197, 211, 194 }, 150), StringComparison.OrdinalIgnoreCase) >= 0 || _0x744b939c.IndexOf(_0x3d947f34._0xcb080bfe(new byte[22] { 99, 116, 116, 121, 101, 105, 104, 104, 99, 101, 114, 111, 105, 104, 121, 116, 99, 96, 115, 117, 99, 98 }, 38), StringComparison.OrdinalIgnoreCase) >= 0 || _0x744b939c.IndexOf(_0x3d947f34._0xcb080bfe(new byte[21] { 203, 220, 220, 209, 205, 193, 192, 192, 203, 205, 218, 199, 193, 192, 209, 205, 194, 193, 221, 203, 202 }, 142), StringComparison.OrdinalIgnoreCase) >= 0 || _0x744b939c.IndexOf(_0x3d947f34._0xcb080bfe(new byte[22] { 141, 154, 154, 151, 157, 134, 131, 134, 135, 159, 134, 151, 157, 154, 132, 151, 155, 139, 128, 141, 133, 141 }, 200), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private string _0xa0a42562 = "";
    private void OnApplicationPause(bool _0x48f999f9)
    {
        isApplicationPause = _0x48f999f9;
    }

    private async Task<bool> _0x1fb812a8()
    {
        _0x6fd584ac.Instance?._0x238b1fac();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0xf8e73b17) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x3d947f34._0xcb080bfe(new byte[32] { 109, 98, 83, 69, 66, 107, 22, 99, 88, 95, 66, 79, 22, 102, 67, 69, 94, 22, 120, 89, 66, 95, 80, 95, 85, 87, 66, 95, 89, 88, 12, 22 }, 54) + string.Join(_0x3d947f34._0xcb080bfe(new byte[1] { 32 }, 41), _0xf8e73b17));
                }
#endif
            }
        };
        try
        {
            _0xeb4e6301 = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x3d947f34._0xcb080bfe(new byte[31] { 12, 3, 50, 36, 35, 10, 119, 17, 54, 62, 59, 50, 51, 119, 35, 56, 119, 48, 50, 35, 119, 39, 34, 36, 63, 119, 35, 56, 60, 50, 57 }, 87));
                }
#endif
            }

            _0xeb4e6301 = "";
        }

        _0xab88876e = !string.IsNullOrEmpty(_0xeb4e6301);
        _0x392b8494 = _0x820ce48c();
        {
#if B_LOGS
            Debug.Log(_0x3d947f34._0xcb080bfe(new byte[25] { 201, 198, 247, 225, 230, 207, 178, 199, 252, 251, 230, 235, 178, 194, 231, 225, 250, 178, 198, 253, 249, 247, 252, 168, 178 }, 146) + _0xeb4e6301);
#endif
        }

        _0x6fd584ac.Instance?._0x99f22bf4();
        return false;
    }

    private void _0xcf3f6a35()
    {
        using (var _0x73a41d0e = new AndroidJavaClass(_0x3d947f34._0xcb080bfe(new byte[30] { 74, 70, 68, 7, 92, 71, 64, 93, 80, 26, 77, 7, 89, 69, 72, 80, 76, 91, 7, 124, 71, 64, 93, 80, 121, 69, 72, 80, 76, 91 }, 41)))
        using (var _0x742316a6 = _0x73a41d0e.GetStatic<AndroidJavaObject>(_0x3d947f34._0xcb080bfe(new byte[15] { 242, 228, 227, 227, 244, 255, 229, 208, 242, 229, 248, 231, 248, 229, 232 }, 145)))
        using (var _0x99159b21 = _0x742316a6.Call<AndroidJavaObject>(_0x3d947f34._0xcb080bfe(new byte[9] { 221, 223, 206, 243, 212, 206, 223, 212, 206 }, 186)))
        {
            if (_0x99159b21 == null)
                return;
            using (var _0x8e9a713c = _0x99159b21.Call<AndroidJavaObject>(_0x3d947f34._0xcb080bfe(new byte[9] { 170, 168, 185, 136, 181, 185, 191, 172, 190 }, 205)))
            {
                if (_0x8e9a713c == null)
                    return;
                using (var _0xddb38d3e = new AndroidJavaObject(_0x3d947f34._0xcb080bfe(new byte[19] { 182, 171, 190, 247, 179, 170, 182, 183, 247, 147, 138, 150, 151, 150, 187, 179, 188, 186, 173 }, 217)))
                using (var _0xe5ea628f = _0x8e9a713c.Call<AndroidJavaObject>(_0x3d947f34._0xcb080bfe(new byte[6] { 31, 17, 13, 39, 17, 0 }, 116)))
                using (var _0xf7063866 = _0xe5ea628f.Call<AndroidJavaObject>(_0x3d947f34._0xcb080bfe(new byte[8] { 141, 144, 129, 150, 133, 144, 139, 150 }, 228)))
                {
                    while (_0xf7063866.Call<bool>(_0x3d947f34._0xcb080bfe(new byte[7] { 47, 38, 52, 9, 34, 63, 51 }, 71)))
                    {
                        string _0xb26effff = _0xf7063866.Call<string>(_0x3d947f34._0xcb080bfe(new byte[4] { 19, 24, 5, 9 }, 125));
                        using (var _0xb0dc5074 = _0x8e9a713c.Call<AndroidJavaObject>(_0x3d947f34._0xcb080bfe(new byte[3] { 164, 166, 183 }, 195), _0xb26effff))
                        {
                            _0xddb38d3e.Call<AndroidJavaObject>(_0x3d947f34._0xcb080bfe(new byte[3] { 75, 78, 79 }, 59), _0xb26effff, _0xb0dc5074);
                        }
                    }

                    string _0xfd1e814f = _0xddb38d3e.Call<string>(_0x3d947f34._0xcb080bfe(new byte[8] { 36, 63, 3, 36, 34, 57, 62, 55 }, 80));
                    if (!string.IsNullOrEmpty(_0xfd1e814f))
                    {
                        _0x40e44ff7(_0xfd1e814f);
                        _0xfd2fa6d9(_0xfd1e814f);
                    }
                }
            }
        }
    }

    private IEnumerator _0x15003eec(float _0x9bbb219b)
    {
        yield return new WaitForSeconds(_0x9bbb219b);
        if (!_0xabc17188)
        {
            _0xabc17188 = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0xe80e9b68}");
                }
#endif
            }
        }
    }

    private string _0x2400df92()
    {
        string _0x85b54850 = _0x2beff5d4();
        if (string.IsNullOrEmpty(_0x85b54850))
            return _0x3d947f34._0xcb080bfe(new byte[7] { 245, 236, 234, 231, 163, 179, 184 }, 131);
        string _0x31e6ce71 = _0x85b54850.Replace(_0x3d947f34._0xcb080bfe(new byte[1] { 106 }, 54), _0x3d947f34._0xcb080bfe(new byte[2] { 124, 124 }, 32)).Replace(_0x3d947f34._0xcb080bfe(new byte[1] { 48 }, 23), _0x3d947f34._0xcb080bfe(new byte[2] { 210, 169 }, 142));
        var _0x8676935c = Regex.Match(_0x85b54850, _0x3d947f34._0xcb080bfe(new byte[12] { 240, 219, 193, 220, 222, 214, 156, 155, 239, 215, 152, 154 }, 179));
        string _0x88f2defe = _0x8676935c.Success ? _0x8676935c.Groups[1].Value : _0x3d947f34._0xcb080bfe(new byte[3] { 192, 195, 193 }, 241);
        return _0x3d947f34._0xcb080bfe(new byte[12] { 126, 48, 35, 56, 53, 34, 63, 57, 56, 126, 127, 45 }, 86) + _0x3d947f34._0xcb080bfe(new byte[8] { 154, 141, 158, 204, 153, 141, 209, 203 }, 236) + _0x31e6ce71 + _0x3d947f34._0xcb080bfe(new byte[2] { 251, 231 }, 220) + _0x3d947f34._0xcb080bfe(new byte[30] { 101, 114, 97, 51, 99, 97, 124, 103, 124, 46, 93, 114, 101, 122, 116, 114, 103, 124, 97, 61, 99, 97, 124, 103, 124, 103, 106, 99, 118, 40 }, 19) + _0x3d947f34._0xcb080bfe(new byte[121] { 168, 187, 160, 173, 186, 167, 161, 160, 238, 170, 171, 168, 230, 161, 172, 164, 226, 165, 171, 183, 226, 184, 175, 162, 231, 181, 186, 188, 183, 181, 129, 172, 164, 171, 173, 186, 224, 170, 171, 168, 167, 160, 171, 158, 188, 161, 190, 171, 188, 186, 183, 230, 161, 172, 164, 226, 165, 171, 183, 226, 181, 169, 171, 186, 244, 168, 187, 160, 173, 186, 167, 161, 160, 230, 231, 181, 188, 171, 186, 187, 188, 160, 238, 184, 175, 162, 245, 179, 226, 173, 161, 160, 168, 167, 169, 187, 188, 175, 172, 162, 171, 244, 186, 188, 187, 171, 179, 231, 245, 179, 173, 175, 186, 173, 166, 230, 171, 231, 181, 179, 179 }, 206) + _0x3d947f34._0xcb080bfe(new byte[26] { 171, 170, 169, 231, 191, 189, 160, 187, 160, 227, 232, 186, 188, 170, 189, 142, 168, 170, 161, 187, 232, 227, 186, 174, 230, 244 }, 207) + _0x3d947f34._0xcb080bfe(new byte[52] { 124, 125, 126, 48, 104, 106, 119, 108, 119, 52, 63, 121, 104, 104, 78, 125, 106, 107, 113, 119, 118, 63, 52, 109, 121, 54, 106, 125, 104, 116, 121, 123, 125, 48, 55, 70, 85, 119, 98, 113, 116, 116, 121, 68, 55, 55, 52, 63, 63, 49, 49, 35 }, 24) + _0x3d947f34._0xcb080bfe(new byte[37] { 177, 176, 179, 253, 165, 167, 186, 161, 186, 249, 242, 165, 185, 180, 161, 179, 186, 167, 184, 242, 249, 242, 153, 188, 187, 160, 173, 245, 180, 167, 184, 163, 237, 185, 242, 252, 238 }, 213) + _0x3d947f34._0xcb080bfe(new byte[34] { 210, 211, 208, 158, 198, 196, 217, 194, 217, 154, 145, 192, 211, 216, 210, 217, 196, 145, 154, 145, 241, 217, 217, 209, 218, 211, 150, 255, 216, 213, 152, 145, 159, 141 }, 182) + _0x3d947f34._0xcb080bfe(new byte[30] { 203, 202, 201, 135, 223, 221, 192, 219, 192, 131, 136, 194, 206, 215, 251, 192, 218, 204, 199, 255, 192, 198, 193, 219, 220, 136, 131, 154, 134, 148 }, 175) + _0x3d947f34._0xcb080bfe(new byte[48] { 249, 255, 244, 246, 251, 236, 255, 173, 248, 236, 233, 176, 246, 239, 255, 236, 227, 233, 254, 183, 214, 246, 239, 255, 236, 227, 233, 183, 170, 206, 229, 255, 226, 224, 228, 248, 224, 170, 161, 251, 232, 255, 254, 228, 226, 227, 183, 170 }, 141) + _0x88f2defe + _0x3d947f34._0xcb080bfe(new byte[35] { 134, 220, 141, 218, 195, 211, 192, 207, 197, 155, 134, 230, 206, 206, 198, 205, 196, 129, 226, 201, 211, 206, 204, 196, 134, 141, 215, 196, 211, 210, 200, 206, 207, 155, 134 }, 161) + _0x88f2defe + _0x3d947f34._0xcb080bfe(new byte[238] { 26, 64, 17, 70, 95, 79, 92, 83, 89, 7, 26, 115, 82, 73, 0, 124, 2, 127, 79, 92, 83, 89, 26, 17, 75, 88, 79, 78, 84, 82, 83, 7, 26, 15, 9, 26, 64, 96, 17, 80, 82, 95, 84, 81, 88, 7, 73, 79, 72, 88, 17, 77, 81, 92, 73, 91, 82, 79, 80, 7, 26, 124, 83, 89, 79, 82, 84, 89, 26, 17, 90, 88, 73, 117, 84, 90, 85, 120, 83, 73, 79, 82, 77, 68, 107, 92, 81, 72, 88, 78, 7, 91, 72, 83, 94, 73, 84, 82, 83, 21, 20, 70, 79, 88, 73, 72, 79, 83, 29, 109, 79, 82, 80, 84, 78, 88, 19, 79, 88, 78, 82, 81, 75, 88, 21, 70, 92, 79, 94, 85, 84, 73, 88, 94, 73, 72, 79, 88, 7, 26, 92, 79, 80, 26, 17, 95, 84, 73, 83, 88, 78, 78, 7, 26, 11, 9, 26, 17, 80, 82, 95, 84, 81, 88, 7, 73, 79, 72, 88, 17, 80, 82, 89, 88, 81, 7, 26, 26, 17, 77, 81, 92, 73, 91, 82, 79, 80, 7, 26, 124, 83, 89, 79, 82, 84, 89, 26, 17, 77, 81, 92, 73, 91, 82, 79, 80, 107, 88, 79, 78, 84, 82, 83, 7, 26, 12, 9, 19, 13, 19, 13, 26, 17, 72, 92, 123, 72, 81, 81, 107, 88, 79, 78, 84, 82, 83, 7, 26 }, 61) + _0x88f2defe + _0x3d947f34._0xcb080bfe(new byte[117] { 241, 239, 241, 239, 241, 239, 248, 162, 246, 228, 162, 162, 228, 144, 189, 181, 186, 188, 171, 241, 187, 186, 185, 182, 177, 186, 143, 173, 176, 175, 186, 173, 171, 166, 247, 175, 173, 176, 171, 176, 243, 248, 170, 172, 186, 173, 158, 184, 186, 177, 171, 155, 190, 171, 190, 248, 243, 164, 184, 186, 171, 229, 185, 170, 177, 188, 171, 182, 176, 177, 247, 246, 164, 173, 186, 171, 170, 173, 177, 255, 170, 190, 187, 228, 162, 243, 188, 176, 177, 185, 182, 184, 170, 173, 190, 189, 179, 186, 229, 171, 173, 170, 186, 162, 246, 228, 162, 188, 190, 171, 188, 183, 247, 186, 246, 164, 162 }, 223) + _0x3d947f34._0xcb080bfe(new byte[5] { 122, 46, 47, 46, 60 }, 7);
    }

    private bool _0xd9fdb163 = false;
    private string _0xcb6dbbeb = "";
    private void OnDestroy()
    {
        StopAllCoroutines();
        _0x2f201f78();
    }

    private void _0xfd2fa6d9(string _0xc793b585)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x3d947f34._0xcb080bfe(new byte[34] { 224, 239, 222, 200, 207, 230, 155, 253, 222, 207, 216, 211, 155, 254, 195, 207, 201, 218, 155, 235, 206, 200, 211, 155, 255, 218, 207, 218, 155, 233, 218, 204, 129, 155 }, 187) + _0xc793b585);
#endif
            }
        }

        var _0xb482655b = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xc793b585);
        StartCoroutine(_0xb3e43ed9(_0xb482655b));
    }

    private void _0x63166baa()
    {
        if (_0x0f78b904 != null)
            return;
        var _0xdc67cf2d = _0x66b0ca20();
        _0x0f78b904 = new GameObject(_0x3d947f34._0xcb080bfe(new byte[14] { 141, 191, 184, 140, 179, 191, 173, 137, 170, 179, 180, 180, 191, 168 }, 218), typeof(RectTransform), typeof(Text));
        _0xa86edf5b = _0x0f78b904.GetComponent<RectTransform>();
        _0xa86edf5b.SetParent(_0xdc67cf2d.transform, false);
        _0xa86edf5b.anchorMin = new Vector2(0.5f, 0.5f);
        _0xa86edf5b.anchorMax = new Vector2(0.5f, 0.5f);
        _0xa86edf5b.pivot = new Vector2(0.5f, 0.5f);
        _0xa86edf5b.sizeDelta = new Vector2(600f, 600f);
        _0xa86edf5b.anchoredPosition = Vector2.zero;
        _0x44aca0c0 = _0x0f78b904.GetComponent<Text>();
        _0x44aca0c0.text = _0x3d947f34._0xcb080bfe(new byte[1] { 146 }, 189);
        _0x44aca0c0.font = Resources.GetBuiltinResource<Font>(_0x3d947f34._0xcb080bfe(new byte[17] { 103, 78, 76, 74, 72, 82, 121, 94, 69, 95, 66, 70, 78, 5, 95, 95, 77 }, 43));
        _0x44aca0c0.fontSize = 200;
        _0x44aca0c0.alignment = TextAnchor.MiddleCenter;
        _0x44aca0c0.color = Color.white;
        _0x44aca0c0.raycastTarget = false;
        _0x0f78b904.SetActive(false);
    }

    private string _0x65099719 = "";
    private bool _0x3d33f858(string _0x81ed610e)
    {
        try
        {
            using (var _0xa4c36be9 = new AndroidJavaClass(_0x3d947f34._0xcb080bfe(new byte[30] { 148, 152, 154, 217, 130, 153, 158, 131, 142, 196, 147, 217, 135, 155, 150, 142, 146, 133, 217, 162, 153, 158, 131, 142, 167, 155, 150, 142, 146, 133 }, 247)))
            using (var _0x85c99b1c = _0xa4c36be9.GetStatic<AndroidJavaObject>(_0x3d947f34._0xcb080bfe(new byte[15] { 73, 95, 88, 88, 79, 68, 94, 107, 73, 94, 67, 92, 67, 94, 83 }, 42)))
            using (var _0x423c5326 = new AndroidJavaClass(_0x3d947f34._0xcb080bfe(new byte[15] { 62, 49, 59, 45, 48, 54, 59, 113, 49, 58, 43, 113, 10, 45, 54 }, 95)))
            using (var _0xe49be62c = _0x423c5326.CallStatic<AndroidJavaObject>(_0x3d947f34._0xcb080bfe(new byte[5] { 77, 92, 79, 78, 88 }, 61), _0x81ed610e))
            using (var _0x8cd1fdb2 = new AndroidJavaObject(_0x3d947f34._0xcb080bfe(new byte[22] { 156, 147, 153, 143, 146, 148, 153, 211, 158, 146, 147, 137, 152, 147, 137, 211, 180, 147, 137, 152, 147, 137 }, 253), _0x3d947f34._0xcb080bfe(new byte[26] { 200, 199, 205, 219, 198, 192, 205, 135, 192, 199, 221, 204, 199, 221, 135, 200, 202, 221, 192, 198, 199, 135, 255, 224, 236, 254 }, 169), _0xe49be62c))
            {
                WLog(_0x3d947f34._0xcb080bfe(new byte[26] { 153, 178, 168, 181, 183, 191, 150, 179, 177, 191, 250, 181, 170, 191, 180, 250, 191, 162, 174, 191, 168, 180, 187, 182, 224, 250 }, 218) + _0x81ed610e);
                _0x8cd1fdb2.Call<AndroidJavaObject>(_0x3d947f34._0xcb080bfe(new byte[11] { 139, 142, 142, 169, 139, 158, 143, 141, 133, 152, 147 }, 234), _0x3d947f34._0xcb080bfe(new byte[33] { 114, 125, 119, 97, 124, 122, 119, 61, 122, 125, 103, 118, 125, 103, 61, 112, 114, 103, 118, 116, 124, 97, 106, 61, 81, 65, 92, 68, 64, 82, 81, 95, 86 }, 19));
                _0x8cd1fdb2.Call<AndroidJavaObject>(_0x3d947f34._0xcb080bfe(new byte[8] { 0, 5, 5, 39, 13, 0, 6, 18 }, 97), 0x10000000);
                _0x85c99b1c.Call(_0x3d947f34._0xcb080bfe(new byte[13] { 117, 114, 103, 116, 114, 71, 101, 114, 111, 112, 111, 114, 127 }, 6), _0x8cd1fdb2);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x3d947f34._0xcb080bfe(new byte[28] { 59, 16, 10, 23, 21, 29, 52, 17, 19, 29, 88, 29, 0, 12, 29, 10, 22, 25, 20, 88, 30, 25, 17, 20, 29, 28, 66, 88 }, 120) + e.Message);
            Application.OpenURL(_0x81ed610e);
            return true;
        }
    }

    private bool _0xffa76e47(string _0x3e263f96)
    {
        if (string.IsNullOrEmpty(_0x3e263f96))
            return false;
        try
        {
            using (var _0x08b6e003 = new AndroidJavaClass(_0x3d947f34._0xcb080bfe(new byte[30] { 89, 85, 87, 20, 79, 84, 83, 78, 67, 9, 94, 20, 74, 86, 91, 67, 95, 72, 20, 111, 84, 83, 78, 67, 106, 86, 91, 67, 95, 72 }, 58)))
            using (var _0x420c1fe8 = _0x08b6e003.GetStatic<AndroidJavaObject>(_0x3d947f34._0xcb080bfe(new byte[15] { 225, 247, 240, 240, 231, 236, 246, 195, 225, 246, 235, 244, 235, 246, 251 }, 130)))
            using (var _0x493730af = _0x420c1fe8.Call<AndroidJavaObject>(_0x3d947f34._0xcb080bfe(new byte[17] { 80, 82, 67, 103, 86, 84, 92, 86, 80, 82, 122, 86, 89, 86, 80, 82, 69 }, 55)))
            using (var _0x4d0fc177 = _0x493730af.Call<AndroidJavaObject>(_0x3d947f34._0xcb080bfe(new byte[25] { 101, 103, 118, 78, 99, 119, 108, 97, 106, 75, 108, 118, 103, 108, 118, 68, 109, 112, 82, 99, 97, 105, 99, 101, 103 }, 2), _0x3e263f96))
            {
                if (_0x4d0fc177 == null)
                    return false;
                WLog(_0x3d947f34._0xcb080bfe(new byte[37] { 230, 205, 215, 202, 200, 192, 233, 204, 206, 192, 133, 201, 196, 208, 203, 198, 205, 133, 204, 203, 214, 209, 196, 201, 201, 192, 193, 133, 213, 196, 198, 206, 196, 194, 192, 159, 133 }, 165) + _0x3e263f96);
                _0x4d0fc177.Call<AndroidJavaObject>(_0x3d947f34._0xcb080bfe(new byte[8] { 45, 40, 40, 10, 32, 45, 43, 63 }, 76), 0x10000000);
                _0x420c1fe8.Call(_0x3d947f34._0xcb080bfe(new byte[13] { 12, 11, 30, 13, 11, 62, 28, 11, 22, 9, 22, 11, 6 }, 127), _0x4d0fc177);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private static readonly string WindowsDesktopUserAgent = _0x3d947f34._0xcb080bfe(new byte[111] { 167, 133, 144, 131, 134, 134, 139, 197, 223, 196, 218, 202, 194, 189, 131, 132, 142, 133, 157, 153, 202, 164, 190, 202, 219, 218, 196, 218, 209, 202, 189, 131, 132, 220, 222, 209, 202, 146, 220, 222, 195, 202, 171, 154, 154, 134, 143, 189, 143, 136, 161, 131, 158, 197, 223, 217, 221, 196, 217, 220, 202, 194, 161, 162, 190, 167, 166, 198, 202, 134, 131, 129, 143, 202, 173, 143, 137, 129, 133, 195, 202, 169, 130, 152, 133, 135, 143, 197, 219, 216, 218, 196, 218, 196, 218, 196, 218, 202, 185, 139, 140, 139, 152, 131, 197, 223, 217, 221, 196, 217, 220 }, 234);
    private string _0x50382243 = "";
    internal bool ContainsIgnoreCase(string _0xd851303b, string _0x285c49b7)
    {
        if (string.IsNullOrEmpty(_0xd851303b) || string.IsNullOrEmpty(_0x285c49b7))
            return false;
        return _0xd851303b.IndexOf(_0x285c49b7, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private string GetFailingUrl(UniWebViewNativeResultPayload _0xd0bd7400)
    {
        if (_0xd0bd7400 == null || _0xd0bd7400.Extra == null)
            return null;
        object _0x4d68a2e3;
        if (!_0xd0bd7400.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0x4d68a2e3))
            return null;
        return _0x4d68a2e3 as string;
    }

    private bool _0x50ba8ffc = false;
    private void _0xd11b28e3(string _0x500d2e47)
    {
        bool _0x1ffaa6dd = !string.IsNullOrEmpty(_0x500d2e47);
        if (_0x1ffaa6dd)
        {
            {
#if B_LOGS
                Debug.Log(_0x3d947f34._0xcb080bfe(new byte[13] { 167, 168, 153, 143, 136, 161, 220, 175, 148, 147, 139, 198, 220 }, 252) + _0x500d2e47);
#endif
            }

            _0xb3546697(_0x500d2e47);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0x3d947f34._0xcb080bfe(new byte[39] { 154, 149, 164, 178, 181, 156, 225, 135, 160, 173, 173, 163, 160, 162, 170, 225, 35, 71, 83, 225, 134, 160, 172, 164, 225, 233, 175, 174, 225, 167, 168, 175, 160, 173, 225, 148, 147, 141, 232 }, 193));
#endif
            }

            _0x2f201f78();
            return;
        }
    }

    internal bool _0xfcfdff7d(string _0x3493fdef)
    {
        return _0x3493fdef.StartsWith(_0x3d947f34._0xcb080bfe(new byte[9] { 240, 252, 239, 246, 248, 233, 167, 178, 178 }, 157), StringComparison.OrdinalIgnoreCase) || _0x3493fdef.StartsWith(_0x3d947f34._0xcb080bfe(new byte[24] { 70, 90, 90, 94, 93, 20, 1, 1, 94, 66, 79, 87, 0, 73, 65, 65, 73, 66, 75, 0, 77, 65, 67, 1 }, 46), StringComparison.OrdinalIgnoreCase) || _0x3493fdef.StartsWith(_0x3d947f34._0xcb080bfe(new byte[23] { 255, 227, 227, 231, 173, 184, 184, 231, 251, 246, 238, 185, 240, 248, 248, 240, 251, 242, 185, 244, 248, 250, 184 }, 151), StringComparison.OrdinalIgnoreCase);
    }

    private bool _0xe11c7db5 = false;
    private string _0xfa1b4410 = "";
    // PART 3
    private string _0xad3881bf()
    {
        try
        {
            var _0x7b64ab7e = new AndroidJavaClass(_0x3d947f34._0xcb080bfe(new byte[30] { 140, 128, 130, 193, 154, 129, 134, 155, 150, 220, 139, 193, 159, 131, 142, 150, 138, 157, 193, 186, 129, 134, 155, 150, 191, 131, 142, 150, 138, 157 }, 239));
            var _0x8ad7788c = _0x7b64ab7e.GetStatic<AndroidJavaObject>(_0x3d947f34._0xcb080bfe(new byte[15] { 64, 86, 81, 81, 70, 77, 87, 98, 64, 87, 74, 85, 74, 87, 90 }, 35));
            var _0x912c9c5f = new AndroidJavaClass(_0x3d947f34._0xcb080bfe(new byte[57] { 158, 146, 144, 211, 154, 146, 146, 154, 145, 152, 211, 156, 147, 153, 143, 146, 148, 153, 211, 154, 144, 142, 211, 156, 153, 142, 211, 148, 153, 152, 147, 137, 148, 155, 148, 152, 143, 211, 188, 153, 139, 152, 143, 137, 148, 142, 148, 147, 154, 180, 153, 190, 145, 148, 152, 147, 137 }, 253));
            var _0xb133e2af = _0x912c9c5f.CallStatic<AndroidJavaObject>(_0x3d947f34._0xcb080bfe(new byte[20] { 8, 10, 27, 46, 11, 25, 10, 29, 27, 6, 28, 6, 1, 8, 38, 11, 38, 1, 9, 0 }, 111), _0x8ad7788c);
            var _0xce543755 = _0xb133e2af.Call<string>(_0x3d947f34._0xcb080bfe(new byte[5] { 26, 24, 9, 52, 25 }, 125));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0xce543755}");
#endif
            }

            return string.IsNullOrEmpty(_0xce543755) ? "" : _0xce543755;
        }
        catch
        {
            return "";
        }
    }

    private string _0x446acf9f = "";
    private async Task _0x647f16a1(string _0x563317c2)
    {
        if (_0xd9fdb163 || string.IsNullOrEmpty(_0x39231805) || string.IsNullOrEmpty(_0x563317c2) || _0x9a87561c)
            return;
        _0xd9fdb163 = true;
        try
        {
            JObject _0x1c0aa25f = _0x15772327(_0x563317c2, _0x39231805, _0x820ce48c());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0x563317c2} payload: {_0x1c0aa25f}");
                }
#endif
            }

            var _0x891e9eec = _0x8202f621(_0x1c0aa25f.ToString(), _0x39231805);
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x3d947f34._0xcb080bfe(new byte[4] { 21, 22, 24, 29 }, 121) + _0x39231805, _0x891e9eec } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x3d947f34._0xcb080bfe(new byte[24] { 30, 17, 0, 22, 17, 24, 101, 9, 42, 36, 33, 101, 53, 36, 54, 54, 101, 32, 55, 55, 42, 55, 127, 101 }, 69) + e.Message);
#endif
            }
        }
    }

    private readonly string[] _0xf21170c4 = new string[]
    {
        _0x3d947f34._0xcb080bfe(new byte[60] { 169, 198, 215, 233, 121, 13, 49, 60, 121, 43, 60, 60, 53, 42, 121, 56, 43, 60, 121, 49, 54, 45, 121, 43, 48, 62, 49, 45, 121, 55, 54, 46, 121, 187, 217, 202, 121, 61, 54, 55, 187, 217, 192, 45, 121, 52, 48, 42, 42, 121, 32, 54, 44, 43, 121, 42, 41, 48, 55, 120 }, 89),
        _0x3d947f34._0xcb080bfe(new byte[52] { 148, 251, 233, 228, 68, 45, 16, 68, 7, 11, 17, 8, 0, 68, 6, 1, 68, 29, 11, 17, 22, 68, 8, 17, 7, 15, 29, 68, 9, 11, 9, 1, 10, 16, 68, 134, 228, 247, 68, 19, 12, 29, 68, 23, 16, 11, 20, 68, 10, 11, 19, 91 }, 100),
        _0x3d947f34._0xcb080bfe(new byte[66] { 88, 32, 27, 85, 2, 53, 154, 248, 211, 221, 154, 205, 211, 212, 201, 154, 219, 200, 223, 154, 210, 211, 206, 206, 211, 212, 221, 154, 215, 213, 200, 223, 154, 213, 220, 206, 223, 212, 154, 206, 213, 222, 219, 195, 154, 88, 58, 41, 154, 201, 206, 219, 195, 154, 211, 212, 154, 206, 210, 223, 154, 221, 219, 215, 223, 148 }, 186),
        _0x3d947f34._0xcb080bfe(new byte[54] { 55, 88, 82, 85, 231, 147, 175, 174, 180, 231, 174, 180, 231, 183, 181, 174, 170, 162, 231, 179, 174, 170, 162, 231, 37, 71, 84, 231, 179, 175, 162, 231, 165, 162, 180, 179, 231, 183, 171, 166, 190, 162, 181, 180, 231, 183, 171, 166, 190, 231, 169, 168, 176, 233 }, 199),
        _0x3d947f34._0xcb080bfe(new byte[48] { 5, 106, 97, 80, 213, 172, 154, 128, 135, 213, 130, 156, 155, 155, 156, 155, 146, 213, 134, 129, 135, 144, 148, 158, 213, 150, 154, 128, 153, 145, 213, 151, 144, 213, 154, 155, 144, 213, 134, 133, 156, 155, 213, 148, 130, 148, 140, 219 }, 245),
        _0x3d947f34._0xcb080bfe(new byte[65] { 64, 47, 42, 48, 144, 250, 209, 211, 219, 192, 223, 196, 195, 144, 209, 194, 213, 144, 221, 223, 194, 213, 144, 209, 211, 196, 217, 198, 213, 144, 196, 223, 222, 217, 215, 216, 196, 144, 82, 48, 35, 144, 195, 196, 209, 201, 144, 209, 222, 212, 144, 196, 194, 201, 144, 201, 223, 197, 194, 144, 220, 197, 211, 219, 158 }, 176),
        _0x3d947f34._0xcb080bfe(new byte[55] { 45, 66, 83, 111, 253, 152, 171, 184, 175, 164, 253, 174, 173, 180, 179, 253, 190, 178, 168, 179, 169, 174, 253, 63, 93, 78, 253, 169, 181, 184, 253, 179, 184, 165, 169, 253, 178, 179, 184, 253, 190, 178, 168, 177, 185, 253, 191, 184, 253, 164, 178, 168, 175, 174, 243 }, 221),
        _0x3d947f34._0xcb080bfe(new byte[63] { 138, 197, 248, 135, 208, 231, 72, 56, 4, 9, 17, 13, 26, 27, 72, 26, 1, 15, 0, 28, 72, 6, 7, 31, 72, 9, 26, 13, 72, 31, 1, 6, 6, 1, 6, 15, 72, 138, 232, 251, 72, 12, 7, 6, 138, 232, 241, 28, 72, 31, 9, 4, 3, 72, 9, 31, 9, 17, 72, 17, 13, 28, 70 }, 104),
        _0x3d947f34._0xcb080bfe(new byte[51] { 3, 108, 124, 117, 211, 188, 157, 159, 138, 211, 135, 155, 156, 128, 150, 211, 132, 155, 156, 211, 128, 135, 146, 138, 211, 154, 157, 211, 135, 155, 150, 211, 148, 146, 158, 150, 211, 132, 154, 157, 211, 135, 155, 150, 211, 131, 129, 154, 137, 150, 221 }, 243),
        _0x3d947f34._0xcb080bfe(new byte[64] { 6, 126, 69, 11, 92, 107, 196, 169, 139, 137, 129, 138, 144, 145, 137, 196, 141, 151, 196, 129, 146, 129, 150, 157, 144, 140, 141, 138, 131, 196, 6, 100, 119, 196, 143, 129, 129, 148, 196, 151, 148, 141, 138, 138, 141, 138, 131, 196, 130, 139, 150, 196, 157, 139, 145, 150, 196, 135, 140, 133, 138, 135, 129, 202 }, 228)
    };
    internal void Update()
    {
        if (_0x139560db == null)
            return;
        if (_0x8cf50e62())
            _0x804a293f();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0x3ee7036b();
        if (_0x5d6ee6a5 && _0xa86edf5b != null)
            _0xa86edf5b.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    private string _0xd9fe3118 = "";
    private string _0x876edd02 = "";
    private string _0xa7f3dabf = "";
    private void StopCurrentFailedLoad(UniWebView _0x59019d2b)
    {
        _0x6fe84711(false);
        if (_0x59019d2b == null)
            return;
        _0x59019d2b.Stop();
        if (_0x59019d2b.CanGoBack)
            _0x59019d2b.GoBack();
    }

    private void _0xe6cc703e(UniWebView _0xfe962507)
    {
        _0xfe962507.BackgroundColor = Color.clear;
        _0xfe962507.SetSupportMultipleWindows(true, true);
        _0xfe962507.SetBackButtonEnabled(false);
        _0x139560db.SetUserAgent(_0x2beff5d4());
    }
}

internal static class _0x3d947f34
{
    internal static string _0xcb080bfe(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}