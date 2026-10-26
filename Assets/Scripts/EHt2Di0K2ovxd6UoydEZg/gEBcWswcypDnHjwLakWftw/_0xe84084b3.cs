using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0xe84084b3
{
    public static class _0x0d0ffff4
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public class _0x1a5247c2
    {
        private static readonly _0x1a5247c2 _0x767a66c2 = new();
        public static readonly _0x1a5247c2[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0x767a66c2,
            _0x767a66c2,
            _0x767a66c2,
        };
        private int _0xcae3d77a => 0;
        private int _0x79bf8c6c => 10;
        private string _0x1ec99331 => _0x21137a11._0xd0dbae78(new byte[4] { 205, 229, 238, 245 }, 128);
        private string _0x4cdb2b07 => _0x21137a11._0xd0dbae78(new byte[8] { 3, 10, 25, 10, 3, 52, 127, 50 }, 79);

        private int _0xee46a089
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x21137a11._0xd0dbae78(new byte[25] { 29, 43, 44, 44, 59, 48, 42, 25, 50, 49, 60, 63, 50, 29, 54, 63, 46, 42, 59, 44, 23, 48, 58, 59, 38 }, 94)))
                    PlayerPrefs.SetInt(_0x21137a11._0xd0dbae78(new byte[25] { 248, 206, 201, 201, 222, 213, 207, 252, 215, 212, 217, 218, 215, 248, 211, 218, 203, 207, 222, 201, 242, 213, 223, 222, 195 }, 187), 0);
                return PlayerPrefs.GetInt(_0x21137a11._0xd0dbae78(new byte[25] { 77, 123, 124, 124, 107, 96, 122, 73, 98, 97, 108, 111, 98, 77, 102, 111, 126, 122, 107, 124, 71, 96, 106, 107, 118 }, 14));
            }

            set => PlayerPrefs.SetInt(_0x21137a11._0xd0dbae78(new byte[25] { 203, 253, 250, 250, 237, 230, 252, 207, 228, 231, 234, 233, 228, 203, 224, 233, 248, 252, 237, 250, 193, 230, 236, 237, 240 }, 136), value);
        }

        public int _0x2253b18a
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x1ec99331}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0x1ec99331}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0x1ec99331}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0x1ec99331}CurrentLevelIndex", value);
        }

        public int _0x32703d62
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x1ec99331}BestScore"))
                    this._0x32703d62 = 0;
                return PlayerPrefs.GetInt($"{this._0x1ec99331}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0x1ec99331}BestScore", value);
        }

        public bool _0x068c2625
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x1ec99331}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0x1ec99331}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0x1ec99331}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0x1ec99331}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }

    public static class _0x75d3016f
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }

    public static class _0x35f75e78
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }

    public static class _0x7744f800
    {
        public static int _0xc04d35d5
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x21137a11._0xd0dbae78(new byte[5] { 55, 27, 29, 26, 7 }, 116)))
                    PlayerPrefs.SetInt(_0x21137a11._0xd0dbae78(new byte[5] { 29, 49, 55, 48, 45 }, 94), 0);
                return PlayerPrefs.GetInt(_0x21137a11._0xd0dbae78(new byte[5] { 98, 78, 72, 79, 82 }, 33));
            }

            set
            {
                PlayerPrefs.SetInt(_0x21137a11._0xd0dbae78(new byte[5] { 91, 119, 113, 118, 107 }, 24), value);
                _0x2755d8a9.Instance._0xfa5188d2();
            }
        }
    }
}

internal static class _0x21137a11
{
    internal static string _0xd0dbae78(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}