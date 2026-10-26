using UnityEngine;

/// <summary>
/// Every persisted value of the game, behind LITERAL string ids. The ids are literals and
/// never nameof(...): obfuscation renames symbols, and a renamed save key would wipe the
/// player's progress on the first update. Reads are defensive - a missing or unparsable
/// key yields the documented default, so the UI never shows a blank where a number belongs.
/// A plain MonoBehaviour with no static state; whoever needs it holds a serialized
/// reference and calls EnsureReady() before the first read (rule C.59).
/// </summary>
public sealed class _0xa198a498 : MonoBehaviour
{
    private static readonly string KeyReduceMotion = _0x80e54b4c._0x3d172b47(new byte[14] { 223, 209, 200, 151, 214, 201, 205, 151, 212, 214, 205, 208, 214, 215 }, 185);
    private bool _0x9cc75f17;
    public int _0x73e111de
    {
        get
        {
            return Mathf.Max(0, PlayerPrefs.GetInt(KeyBestLanes, 0));
        }

        set
        {
            PlayerPrefs.SetInt(KeyBestLanes, Mathf.Max(0, value));
        }
    }

    public bool _0x42811e0a
    {
        get
        {
            return PlayerPrefs.GetInt(KeyReduceMotion, 0) != 0;
        }

        set
        {
            PlayerPrefs.SetInt(KeyReduceMotion, value ? 1 : 0);
        }
    }

    private static readonly string KeyAttempt = _0x80e54b4c._0x3d172b47(new byte[11] { 86, 88, 65, 30, 81, 68, 68, 85, 93, 64, 68 }, 48);
    public void _0xb3ebe2fe(int _0xc5b21820, int _0xf347c54d, int _0x19b06101)
    {
        int _0x8c7280d8 = Mathf.Clamp(_0x19b06101, 0, 3);
        if (_0x8c7280d8 <= this._0x4f35c54e(_0xc5b21820, _0xf347c54d))
        {
            return;
        }

        PlayerPrefs.SetInt(KeyStars + _0xc5b21820.ToString() + _0x80e54b4c._0x3d172b47(new byte[1] { 80 }, 126) + _0xf347c54d.ToString(), _0x8c7280d8);
    }

    private static readonly string KeyAlbum = _0x80e54b4c._0x3d172b47(new byte[10] { 253, 243, 234, 181, 250, 247, 249, 238, 246, 181 }, 155);
    public bool _0x52f0a7a9(int _0xeb3706e1)
    {
        return PlayerPrefs.GetInt(KeyAlbum + _0xeb3706e1.ToString(), 0) != 0;
    }

    public int _0xdde8cedd
    {
        get
        {
            return Mathf.Max(0, PlayerPrefs.GetInt(KeyJourneys, 0));
        }

        set
        {
            PlayerPrefs.SetInt(KeyJourneys, Mathf.Max(0, value));
        }
    }

    private static readonly string KeyVibration = _0x80e54b4c._0x3d172b47(new byte[12] { 4, 10, 19, 76, 13, 18, 22, 76, 20, 11, 0, 7 }, 98);
    /// <summary>The run just finished; fold its results into the saved profile.</summary>
    public void _0x6fee3ee5(int _0x61397a07, int _0x80d5683c, int _0xb881b266, int _0x921b4ebb, int _0x071302be, bool _0x0d7c7ef8)
    {
        if (_0xb881b266 > this._0x73e111de)
        {
            this._0x73e111de = _0xb881b266;
        }

        this._0x3aab6a43 = this._0x3aab6a43 + _0x921b4ebb;
        this._0xdda47683 = this._0xdda47683 + 1;
        this._0x883e1805(0, _0xb881b266);
        this._0x883e1805(1, _0x921b4ebb);
        if (_0x0d7c7ef8)
        {
            this._0xb3ebe2fe(_0x61397a07, _0x80d5683c, _0x071302be);
            this._0xdde8cedd = this._0xdde8cedd + 1;
            if (_0x80d5683c + 1 > this._0x0a476385)
            {
                this._0x0a476385 = _0x80d5683c + 1;
            }
        }

        PlayerPrefs.Save();
    }

    private static readonly string KeyChicks = _0x80e54b4c._0x3d172b47(new byte[10] { 157, 147, 138, 213, 152, 147, 146, 152, 144, 136 }, 251);
    private static readonly string KeyBestLanes = _0x80e54b4c._0x3d172b47(new byte[14] { 134, 136, 145, 206, 130, 133, 147, 148, 206, 140, 129, 142, 133, 147 }, 224);
    public int _0x4f35c54e(int _0x0a49bb11, int _0x0a3dd073)
    {
        int _0x459c69b2 = PlayerPrefs.GetInt(KeyStars + _0x0a49bb11.ToString() + _0x80e54b4c._0x3d172b47(new byte[1] { 196 }, 234) + _0x0a3dd073.ToString(), 0);
        return Mathf.Clamp(_0x459c69b2, 0, 3);
    }

    private static readonly string KeyStars = _0x80e54b4c._0x3d172b47(new byte[10] { 167, 169, 176, 239, 178, 181, 160, 179, 178, 239 }, 193);
    public int _0x0a476385
    {
        get
        {
            return Mathf.Max(0, PlayerPrefs.GetInt(KeyMission, 0));
        }

        set
        {
            PlayerPrefs.SetInt(KeyMission, Mathf.Max(0, value));
        }
    }

    private static readonly string KeyMission = _0x80e54b4c._0x3d172b47(new byte[11] { 229, 235, 242, 173, 238, 234, 240, 240, 234, 236, 237 }, 131);
    public int _0x3aab6a43
    {
        get
        {
            return Mathf.Max(0, PlayerPrefs.GetInt(KeyChicks, 0));
        }

        set
        {
            PlayerPrefs.SetInt(KeyChicks, Mathf.Max(0, value));
        }
    }

    private void Start()
    {
        this._0xe422ae80();
    }

    public int _0x5fb3ffc5(int _0xc37edef0)
    {
        return Mathf.Max(0, PlayerPrefs.GetInt(KeyChallenge + _0xc37edef0.ToString(), 0));
    }

    public void _0x96912b84(int _0x17bb8599)
    {
        PlayerPrefs.SetInt(KeyAlbum + _0x17bb8599.ToString(), 1);
    }

    private static readonly string KeyChallenge = _0x80e54b4c._0x3d172b47(new byte[14] { 101, 107, 114, 45, 96, 107, 98, 111, 111, 102, 109, 100, 102, 45 }, 3);
    public int _0xaebebbcb
    {
        get
        {
            return Mathf.Max(0, PlayerPrefs.GetInt(KeyRegion, 0));
        }

        set
        {
            PlayerPrefs.SetInt(KeyRegion, Mathf.Max(0, value));
        }
    }

    private static readonly string KeyJourneys = _0x80e54b4c._0x3d172b47(new byte[12] { 206, 192, 217, 134, 194, 199, 221, 218, 198, 205, 209, 219 }, 168);
    public void _0xe422ae80()
    {
        if (this._0x9cc75f17)
        {
            return;
        }

        this._0x9cc75f17 = true;
    }

    /// <summary>Bumped on every run so a retry draws a different route (rule C.11).</summary>
    public int _0xdda47683
    {
        get
        {
            return Mathf.Max(0, PlayerPrefs.GetInt(KeyAttempt, 0));
        }

        set
        {
            PlayerPrefs.SetInt(KeyAttempt, Mathf.Max(0, value));
        }
    }

    public void _0x883e1805(int _0xd33dba18, int _0xd6b63b8b)
    {
        if (_0xd6b63b8b <= this._0x5fb3ffc5(_0xd33dba18))
        {
            return;
        }

        PlayerPrefs.SetInt(KeyChallenge + _0xd33dba18.ToString(), Mathf.Max(0, _0xd6b63b8b));
    }

    public bool _0x0108f2ce
    {
        get
        {
            return PlayerPrefs.GetInt(KeyVibration, 1) != 0;
        }

        set
        {
            PlayerPrefs.SetInt(KeyVibration, value ? 1 : 0);
        }
    }

    private static readonly string KeyRegion = _0x80e54b4c._0x3d172b47(new byte[10] { 150, 152, 129, 222, 130, 149, 151, 153, 159, 158 }, 240);
    public void _0x6bb4f53e()
    {
        PlayerPrefs.DeleteKey(KeyBestLanes);
        PlayerPrefs.DeleteKey(KeyRegion);
        PlayerPrefs.DeleteKey(KeyMission);
        PlayerPrefs.DeleteKey(KeyChicks);
        PlayerPrefs.DeleteKey(KeyJourneys);
        PlayerPrefs.DeleteKey(KeyAttempt);
        for (int _0x469f3fc5 = 0; _0x469f3fc5 < 12; _0x469f3fc5++)
        {
            PlayerPrefs.DeleteKey(KeyAlbum + _0x469f3fc5.ToString());
            PlayerPrefs.DeleteKey(KeyChallenge + _0x469f3fc5.ToString());
        }

        for (int _0xded80953 = 0; _0xded80953 < 4; _0xded80953++)
        {
            for (int _0x74a75496 = 0; _0x74a75496 < 6; _0x74a75496++)
            {
                PlayerPrefs.DeleteKey(KeyStars + _0xded80953.ToString() + _0x80e54b4c._0x3d172b47(new byte[1] { 180 }, 154) + _0x74a75496.ToString());
            }
        }

        _0xe84084b3._0x7744f800._0xc04d35d5 = 0;
        PlayerPrefs.Save();
    }
}

internal static class _0x80e54b4c
{
    internal static string _0x3d172b47(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}