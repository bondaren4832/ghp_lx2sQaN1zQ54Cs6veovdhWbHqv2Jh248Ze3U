using UnityEngine;

/// <summary>
/// The static shape of the journey: three regions of five missions each, the lane and
/// chick counts per mission, the unlock thresholds and the chick names for the album.
/// Data only - the ROUTE of every mission is generated per run by LanePlanGenerator
/// (rule C.11). A plain MonoBehaviour so views can hold a serialized reference to it;
/// no constructor and no static state (rule C.59).
/// </summary>
public sealed class _0x3b0bd600 : MonoBehaviour
{
    public string _0x4d9d35e2(int _0x555493a5)
    {
        return _0x391b9166[Mathf.Clamp(_0x555493a5, 0, _0x391b9166.Length - 1)];
    }

    /// <summary>Lanes to cross, from the difficulty table in the design document.</summary>
    public int _0x05a42898(int _0x4e22a96a, int _0xbfa4b48c)
    {
        int _0x656ff1b7 = _0xbfa4b48c <= 0 ? 12 : (_0xbfa4b48c <= 2 ? 14 : 16);
        if (_0x4e22a96a >= 1)
        {
            _0x656ff1b7 = _0x656ff1b7 + 2;
        }

        return Mathf.Clamp(_0x656ff1b7, 10, 20);
    }

    private static readonly string[] _0x0b3b8d20 =
    {
        _0xf3ff82f9._0xcb9ea599(new byte[6] { 181, 177, 180, 180, 189, 172 }, 248),
        _0xf3ff82f9._0xcb9ea599(new byte[6] { 53, 54, 37, 59, 50, 46 }, 119),
        _0xf3ff82f9._0xcb9ea599(new byte[6] { 86, 67, 68, 68, 74, 67 }, 6),
        _0xf3ff82f9._0xcb9ea599(new byte[6] { 199, 200, 203, 210, 193, 214 }, 132),
        _0xf3ff82f9._0xcb9ea599(new byte[4] { 171, 172, 170, 178 }, 249),
        _0xf3ff82f9._0xcb9ea599(new byte[5] { 165, 186, 165, 165, 172 }, 245),
        _0xf3ff82f9._0xcb9ea599(new byte[7] { 173, 177, 176, 170, 173, 181, 188 }, 249),
        _0xf3ff82f9._0xcb9ea599(new byte[5] { 58, 56, 52, 41, 53 }, 123),
        _0xf3ff82f9._0xcb9ea599(new byte[6] { 126, 98, 127, 127, 104, 97 }, 45),
        _0xf3ff82f9._0xcb9ea599(new byte[7] { 100, 123, 96, 103, 126, 107, 124 }, 46),
        _0xf3ff82f9._0xcb9ea599(new byte[6] { 69, 91, 94, 94, 93, 69 }, 18),
        _0xf3ff82f9._0xcb9ea599(new byte[6] { 24, 28, 0, 7, 10, 12 }, 73),
    };
    public int _0x35196b7b(int _0x80a1705d)
    {
        return _0x4872a1e0[Mathf.Clamp(_0x80a1705d, 0, _0x4872a1e0.Length - 1)];
    }

    public int _0x21867d9e
    {
        get
        {
            return _0x0b3b8d20.Length;
        }
    }

    /// <summary>Journeys that must be finished before a region opens.</summary>
    private static readonly int[] _0x4872a1e0 =
    {
        0,
        5,
        10
    };
    public float _0x1b4ffd7e(int _0xb985e7a4, int _0x1f82a114)
    {
        if (_0xb985e7a4 >= 1)
        {
            return 1.7f;
        }

        return _0x1f82a114 <= 0 ? 1.15f : (_0x1f82a114 <= 2 ? 1.3f : 1.45f);
    }

    public string _0x7c95c2a4(int _0x88b7ff15)
    {
        return _0xadfc7342[Mathf.Clamp(_0x88b7ff15, 0, _0xadfc7342.Length - 1)];
    }

    public const int MissionsPerRegion = 5;
    /// <summary>Chicks waiting on the islands of this mission.</summary>
    public int _0x1e553a3b(int _0xeb2aebd5, int _0x49c7adc5)
    {
        if (_0xeb2aebd5 >= 1)
        {
            return 3;
        }

        return _0x49c7adc5 <= 2 ? 2 : 3;
    }

    public string _0xfe78a2f6(int _0xdf2181bd)
    {
        return _0x0b3b8d20[Mathf.Clamp(_0xdf2181bd, 0, _0x0b3b8d20.Length - 1)];
    }

    public bool _0x801b134c(int _0x9c9ee63d, int _0x41aeca8e)
    {
        return _0x41aeca8e >= this._0x35196b7b(_0x9c9ee63d);
    }

    public int _0x1acb7b39(int _0x8bd98e77, int _0x875ec687)
    {
        if (_0x8bd98e77 >= 1)
        {
            return 2;
        }

        return _0x875ec687 <= 0 ? 1 : 2;
    }

    /// <summary>Share of river lanes. Region 1 mission 1-2 is dry road only.</summary>
    public float _0x96269059(int _0x4a8dc5f9, int _0xf86b2a5d)
    {
        if (_0x4a8dc5f9 >= 1)
        {
            return 0.3f;
        }

        return _0xf86b2a5d >= 2 ? 0.25f : 0f;
    }

    private static readonly string[] _0x391b9166 =
    {
        _0xf3ff82f9._0xcb9ea599(new byte[13] { 33, 35, 62, 34, 37, 34, 43, 76, 58, 41, 62, 43, 41 }, 108),
        _0xf3ff82f9._0xcb9ea599(new byte[14] { 137, 133, 150, 143, 129, 144, 228, 144, 150, 133, 130, 130, 141, 135 }, 196),
        _0xf3ff82f9._0xcb9ea599(new byte[10] { 180, 171, 168, 176, 199, 181, 174, 177, 162, 181 }, 231),
        _0xf3ff82f9._0xcb9ea599(new byte[10] { 115, 122, 98, 27, 120, 116, 117, 109, 116, 98 }, 59),
        _0xf3ff82f9._0xcb9ea599(new byte[11] { 126, 103, 109, 96, 103, 109, 14, 102, 103, 98, 98 }, 46),
    };
    private static readonly string[] _0xadfc7342 =
    {
        _0xf3ff82f9._0xcb9ea599(new byte[15] { 205, 210, 223, 219, 206, 220, 211, 223, 214, 222, 186, 216, 223, 212, 222 }, 154),
        _0xf3ff82f9._0xcb9ea599(new byte[17] { 99, 120, 103, 116, 99, 17, 115, 116, 127, 117, 17, 124, 116, 112, 117, 126, 102 }, 49),
        _0xf3ff82f9._0xcb9ea599(new byte[12] { 163, 190, 175, 164, 173, 190, 168, 204, 161, 165, 160, 169 }, 236),
    };
    public float _0x7776b33e(int _0xb5a6ea1b, int _0x590ab785)
    {
        if (_0xb5a6ea1b >= 1)
        {
            return 1.2f;
        }

        return _0x590ab785 <= 0 ? 0.9f : (_0x590ab785 <= 2 ? 1f : 1.1f);
    }

    /// <summary>Index into the friend list for the n-th chick of this mission.</summary>
    public int _0x1a4c5d15(int _0xcdcb2792, int _0x0ff7f25c, int _0x267e96f8)
    {
        int _0xadf962e0 = _0xcdcb2792 * MissionsPerRegion + _0x0ff7f25c + _0x267e96f8;
        return _0xadf962e0 % _0x0b3b8d20.Length;
    }

    public const int RegionCount = 3;
}

internal static class _0xf3ff82f9
{
    internal static string _0xcb9ea599(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}