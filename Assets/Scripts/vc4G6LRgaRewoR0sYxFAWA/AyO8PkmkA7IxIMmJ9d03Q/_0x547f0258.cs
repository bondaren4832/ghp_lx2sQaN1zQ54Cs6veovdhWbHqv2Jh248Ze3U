using UnityEngine;

public class _0x547f0258 : MonoBehaviour
{
    public bool IsTutorialEnabled;
    public static _0x547f0258 Instance;
    private void _0x29ab9c0f()
    {
        {
#if !B_LOGS
        {
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
        }
#endif
        }

        QualitySettings.vSyncCount = 1;
        Application.runInBackground = true;
    //Application.targetFrameRate = 60;
    // Time.fixedDeltaTime = 0.03f; // USE CUSTOM PHYSICS TIME FOR OPTIMIZATION IF NEEDED
    // Add this once at startup to silence the specific assertion
    }

    public bool IsCheckScoreEnabled;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0x547f0258>();
            DontDestroyOnLoad(this.gameObject);
            this._0x29ab9c0f();
        }
        else
        {
            this._0x85def703();
            Destroy(this.gameObject);
        }
    }

    public bool IsTimerEnabled;
    public bool IsBestScoreEnabled;
    public bool IsLevelIncrementOnWin;
    public bool IsLevelSelectorEnabled;
    public bool IsStoryEnabled;
    public bool IsOnlyWinGameEndEnabled;
    private void _0x85def703()
    {
    }

    public bool IsSkipSplashEnabled;
}