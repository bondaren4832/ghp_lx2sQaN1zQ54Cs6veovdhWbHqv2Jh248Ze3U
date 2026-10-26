using UnityEngine;

/// <summary>
/// Builds the route of one journey from a seed, then PROVES it before anyone sees it
/// (rule C.11). Two checks run on every candidate:
///   1. an arithmetic gate - the gap between two movers of a lane must take at least
///      HopWindow + Safety seconds to pass the column the hero stands in;
///   2. a greedy walker that actually crosses the whole route, always taking the first
///      legal gap, and has to reach the picnic lane inside laneCount * 3 seconds.
/// Up to 20 candidates are drawn; if none passes, the hand-written FallbackPlan is used.
/// The fallback is insurance, never the game.
/// </summary>
public sealed class _0x0bc07320 : MonoBehaviour
{
    /// <summary>
    /// One candidate route. Lane order, lane kind, mover count, speed, direction, phase,
    /// which island carries a chick and in which column are all drawn here - two attempts
    /// differ in the shape of the route, not just in a HUD number.
    /// </summary>
    private _0x74ec292d _0x51ca2967(System.Random _0x77d0cdef, int _0x7105cfae, int _0xb49e3a53, int _0x3d3689e2, int _0x6edbf25f, int _0x0e3e8b1f)
    {
        float _0x088792e7 = this._catalog != null ? this._catalog._0x7776b33e(_0xb49e3a53, _0x3d3689e2) : 0.9f;
        float _0xb4685018 = this._catalog != null ? this._catalog._0x1b4ffd7e(_0xb49e3a53, _0x3d3689e2) : 1.15f;
        int _0xd898b973 = this._catalog != null ? this._catalog._0x1acb7b39(_0xb49e3a53, _0x3d3689e2) : 1;
        float _0x94700251 = this._catalog != null ? this._catalog._0x96269059(_0xb49e3a53, _0x3d3689e2) : 0f;
        float _0x6d09af3e = 1f / WorldWidth;
        _0x858c002f[] _0xa1a55649 = new _0x858c002f[_0x6edbf25f];
        _0xa1a55649[0] = new _0x858c002f()._0x798dd182(_0x858c002f.KindVerge, _0x858c002f.MoverCar, 0, 1, 0f, 0f, 0f);
        _0xa1a55649[1] = new _0x858c002f()._0x798dd182(_0x858c002f.KindVerge, _0x858c002f.MoverCar, 0, 1, 0f, 0f, 0f);
        _0xa1a55649[_0x6edbf25f - 1] = new _0x858c002f()._0x798dd182(_0x858c002f.KindFinish, _0x858c002f.MoverCar, 0, 1, 0f, 0f, 0f);
        int _0x559ab2e1 = 0;
        int _0xaf8f4602 = 0;
        int _0x9fb1a188 = 0;
        bool _0xf5849c8c = true;
        for (int _0x974435fd = 2; _0x974435fd < _0x6edbf25f - 1; _0x974435fd++)
        {
            bool _0xa8841e2e = _0x559ab2e1 >= 2 && _0x77d0cdef.Next(0, 100) < 45;
            if (_0x559ab2e1 >= 3)
            {
                _0xa8841e2e = true;
            }

            if (_0xa8841e2e)
            {
                _0xa1a55649[_0x974435fd] = new _0x858c002f()._0x798dd182(_0x858c002f.KindIsland, _0x858c002f.MoverCar, 0, 1, 0f, 0f, 0f);
                _0xa1a55649[_0x974435fd].DecorColumn = _0x77d0cdef.Next(0, Columns);
                _0x559ab2e1 = 0;
                _0xf5849c8c = true;
                _0xaf8f4602 = 0;
                _0x9fb1a188 = 0;
                continue;
            }

            if (_0xaf8f4602 <= 0 && _0x94700251 > 0f && _0x77d0cdef.NextDouble() < _0x94700251)
            {
                // Exactly two lanes per band. A longer band lets the raft drift stack up
                // in one direction and carries the rooster off the field before it can ever
                // line up a hop - measured as half of all routes failing the walker.
                _0xaf8f4602 = 2;
            }

            bool _0xa15f4e9e = _0xaf8f4602 > 0;
            if (_0xa15f4e9e)
            {
                _0xaf8f4602--;
            }

            int _0x7a404328 = 1 + _0x77d0cdef.Next(0, _0xd898b973);
            float _0x15f7b59d = (_0x088792e7 + (float)_0x77d0cdef.NextDouble() * (_0xb4685018 - _0x088792e7)) * _0x6d09af3e;
            if (_0xf5849c8c)
            {
                // The lane straight after a safe one is deliberately gentle, so the roughly
                // random tap sequence a review capture produces still advances the rooster
                // instead of ending the run (rule C.5).
                _0x7a404328 = 1;
                _0x15f7b59d = _0x088792e7 * _0x6d09af3e;
            }

            int _0x970b3e1b = _0x77d0cdef.Next(0, 2) == 0 ? -1 : 1;
            if (_0xa15f4e9e)
            {
                // Consecutive rafts run opposite ways, so the carry of the first lane is
                // undone by the second instead of adding up.
                _0x970b3e1b = _0x9fb1a188 == 0 ? _0x970b3e1b : -_0x9fb1a188;
                _0x9fb1a188 = _0x970b3e1b;
            }

            float _0xe5311216 = (float)_0x77d0cdef.NextDouble();
            int _0x8073a930 = _0xa15f4e9e ? _0x858c002f.MoverRaft : (_0x77d0cdef.Next(0, 100) < 62 ? _0x858c002f.MoverCar : (_0x77d0cdef.Next(0, 2) == 0 ? _0x858c002f.MoverTruck : _0x858c002f.MoverBus));
            // Make the lane crossable BY CONSTRUCTION instead of drawing again until it
            // happens to be: two long movers at the top speed close their gap faster than
            // a hop takes, and rejection sampling sent a quarter of all routes to the
            // fallback. The speed is capped to what the gap can actually carry, and a lane
            // that cannot carry two movers at any sane speed simply gets one.
            _0x7a404328 = this._0x3d99c4ab(_0x7a404328, _0xa6be82c7[_0x8073a930], _0x088792e7 * _0x6d09af3e);
            _0x15f7b59d = Mathf.Min(_0x15f7b59d, this._0x21076743(_0x7a404328, _0xa6be82c7[_0x8073a930]));
            _0xa1a55649[_0x974435fd] = new _0x858c002f()._0x798dd182(_0xa15f4e9e ? _0x858c002f.KindRiver : _0x858c002f.KindHighway, _0x8073a930, _0x7a404328, _0x970b3e1b, _0x15f7b59d, _0xe5311216, _0xa6be82c7[_0x8073a930]);
            _0x559ab2e1++;
            _0xf5849c8c = false;
        }

        int _0x0ae585bd = this._0x05f4b063(_0x77d0cdef, _0xa1a55649, _0x0e3e8b1f);
        this._0xb5cd945b(_0x77d0cdef, _0xa1a55649);
        return new _0x74ec292d()._0xc83bd809(_0xa1a55649, _0x7105cfae, _0x0ae585bd, _0xb49e3a53, _0x3d3689e2);
    }

    /// <summary>Mover footprint as a fraction of the field width, by mover kind.</summary>
     // Movers are drawn as a SQUARE of this many field widths, because the generated PNGs
    // are square. Keeping every one of them at or under 0.25 means the square is never
    // more than about 1.2 lane heights tall, so a vehicle cannot spill into the lane above.
    private static readonly float[] _0xa6be82c7 =
    {
        0.2f,
        0.25f,
        0.23f,
        0.24f
    };
    [SerializeField]
    private _0x3b0bd600 _catalog;
    /// <summary>
    /// The insurance route: alternating quiet islands and single-mover highways, slow
    /// enough that the gap gate passes by construction. Never used unless twenty draws in
    /// a row failed.
    /// </summary>
    public _0x74ec292d _0xfd9eecdc(int _0xf29bf6ac, int _0xf158cebe, int _0x8a695938, int _0x213b0486)
    {
        _0x858c002f[] _0x1af7734e = new _0x858c002f[_0x8a695938];
        int _0xe566898b = 0;
        for (int _0xe5fc0d0f = 0; _0xe5fc0d0f < _0x8a695938; _0xe5fc0d0f++)
        {
            if (_0xe5fc0d0f < 2)
            {
                _0x1af7734e[_0xe5fc0d0f] = new _0x858c002f()._0x798dd182(_0x858c002f.KindVerge, _0x858c002f.MoverCar, 0, 1, 0f, 0f, 0f);
                continue;
            }

            if (_0xe5fc0d0f == _0x8a695938 - 1)
            {
                _0x1af7734e[_0xe5fc0d0f] = new _0x858c002f()._0x798dd182(_0x858c002f.KindFinish, _0x858c002f.MoverCar, 0, 1, 0f, 0f, 0f);
                continue;
            }

            if (_0xe5fc0d0f % 3 == 0)
            {
                _0x1af7734e[_0xe5fc0d0f] = new _0x858c002f()._0x798dd182(_0x858c002f.KindIsland, _0x858c002f.MoverCar, 0, 1, 0f, 0f, 0f);
                if (_0xe566898b < _0x213b0486)
                {
                    _0x1af7734e[_0xe5fc0d0f].ChickColumn = (_0xe5fc0d0f * 2) % Columns;
                    _0xe566898b++;
                }

                continue;
            }

            _0x1af7734e[_0xe5fc0d0f] = new _0x858c002f()._0x798dd182(_0x858c002f.KindHighway, _0x858c002f.MoverCar, 1, _0xe5fc0d0f % 2 == 0 ? 1 : -1, 0.9f / WorldWidth, (_0xe5fc0d0f * 0.17f) % 1f, _0xa6be82c7[_0x858c002f.MoverCar]);
        }

        return new _0x74ec292d()._0xc83bd809(_0x1af7734e, 0, _0xe566898b, _0xf29bf6ac, _0xf158cebe);
    }

    private const int MaxAttempts = 20;
    public static float _0xd6cb7626
    {
        get
        {
            return 1f / Columns * 0.34f;
        }
    }

    /// <summary>
    /// Fastest a lane of this many movers of this length may run and still leave a gap
    /// that takes HopWindow + Safety seconds to pass the hero.
    /// </summary>
    private float _0x21076743(int _0x23c99a08, float _0xe2858fd9)
    {
        float _0xe952a5c1 = (1f + _0xe2858fd9) / Mathf.Max(1, _0x23c99a08) - _0xe2858fd9 * _0x858c002f.ArtFill - _0xd6cb7626 * 2f;
        if (_0xe952a5c1 <= 0f)
        {
            return 0f;
        }

        // 0.97 leaves a sliver of margin: a speed set to EXACTLY gap / required makes the
        // gate a borderline float comparison, and it then failed about half the time.
        return _0xe952a5c1 / (HopWindow + Safety) * 0.97f;
    }

    /// <summary>Drops a lane back to a single mover when two of them could not be driven
    /// at even the slowest speed of this mission.</summary>
    private int _0x3d99c4ab(int _0x6eb0641f, float _0x3d2f700e, float _0xe036bc36)
    {
        while (_0x6eb0641f > 1 && this._0x21076743(_0x6eb0641f, _0x3d2f700e) < _0xe036bc36)
        {
            _0x6eb0641f--;
        }

        return Mathf.Max(1, _0x6eb0641f);
    }

    private int _0x05f4b063(System.Random _0x2694d7c2, _0x858c002f[] _0x2f85e74e, int _0x8666ad93)
    {
        int _0x4d9bf6de = 0;
        int _0x297a168f = 0;
        while (_0x4d9bf6de < _0x8666ad93 && _0x297a168f < 120)
        {
            _0x297a168f++;
            int _0xebe6d823 = _0x2694d7c2.Next(2, _0x2f85e74e.Length - 1);
            _0x858c002f _0xac6f492e = _0x2f85e74e[_0xebe6d823];
            if (_0xac6f492e == null || _0xac6f492e.Kind != _0x858c002f.KindIsland || _0xac6f492e.ChickColumn >= 0)
            {
                continue;
            }

            _0xac6f492e.ChickColumn = _0x2694d7c2.Next(0, Columns);
            _0x4d9bf6de++;
        }

        if (_0x4d9bf6de < _0x8666ad93)
        {
            // Not enough islands came out of this draw: the safe lanes always have room,
            // so the stated goal stays reachable instead of being impossible.
            for (int _0x7fa98be6 = _0x2f85e74e.Length - 2; _0x7fa98be6 >= 2 && _0x4d9bf6de < _0x8666ad93; _0x7fa98be6--)
            {
                if (_0x2f85e74e[_0x7fa98be6] != null && _0x2f85e74e[_0x7fa98be6]._0x44ea1f46 && _0x2f85e74e[_0x7fa98be6].ChickColumn < 0)
                {
                    _0x2f85e74e[_0x7fa98be6].ChickColumn = _0x2694d7c2.Next(0, Columns);
                    _0x4d9bf6de++;
                }
            }
        }

        return _0x4d9bf6de;
    }

    public static float ColumnX(int _0x3cb20e7b)
    {
        float _0xb26890d8 = 1f / Columns;
        return (_0x3cb20e7b - (Columns - 1) * 0.5f) * _0xb26890d8;
    }

    /// <summary>Screen width in world units at ortho size 5 on 19.5:9, used to turn the
    /// catalogue speeds (world units per second) into field fractions per second.</summary>
    private const float WorldWidth = 4.6154f;
    public const int Columns = 7;
    private const float Safety = 0.55f;
    /// <summary>Check 1: no lane may close its gaps faster than a hop takes.</summary>
    public bool _0x152e13e4(_0x74ec292d _0xade29b6c)
    {
        if (_0xade29b6c == null || _0xade29b6c.Lanes == null)
        {
            return false;
        }

        float _0xc37f13f8 = HopWindow + Safety;
        for (int _0x90c21691 = 0; _0x90c21691 < _0xade29b6c.Lanes.Length; _0x90c21691++)
        {
            _0x858c002f _0x555d0fb7 = _0xade29b6c.Lanes[_0x90c21691];
            if (_0x555d0fb7 == null || _0x555d0fb7.MoverCount <= 0 || _0x555d0fb7.Speed <= 0f)
            {
                continue;
            }

            float _0x02b159c5 = _0x555d0fb7._0x42369a09 / _0x555d0fb7.MoverCount - _0x555d0fb7._0x43a53f63 - _0xd6cb7626 * 2f;
            if (_0x02b159c5 <= 0f || _0x02b159c5 / _0x555d0fb7.Speed < _0xc37f13f8)
            {
                return false;
            }
        }

        return true;
    }

    /// <summary>
    /// Check 2: a greedy walker crosses the whole route, always taking the first legal gap
    /// in front of it. It must arrive within three seconds per lane.
    /// </summary>
    public bool _0x530c0d87(_0x74ec292d _0xf3ea04cd)
    {
        if (_0xf3ea04cd == null || _0xf3ea04cd.Lanes == null || _0xf3ea04cd.Lanes.Length < 2)
        {
            return false;
        }

        float _0xd67d0156 = _0xf3ea04cd.Lanes.Length * 3f;
        float _0x199927ea = 0.05f;
        float _0xd078f7a0 = 0f;
        float _0x7797bb05 = ColumnX(Columns / 2);
        float _0xf7e8b7fe = _0xd6cb7626;
        for (int _0x7440f8d2 = 1; _0x7440f8d2 < _0xf3ea04cd.Lanes.Length; _0x7440f8d2++)
        {
            _0x858c002f _0xfe5a7d81 = _0xf3ea04cd.Lanes[_0x7440f8d2];
            bool _0x50122740 = false;
            while (_0xd078f7a0 < _0xd67d0156)
            {
                bool _0x3e344d81 = _0xfe5a7d81 == null || !_0xfe5a7d81._0x974bc64b(_0x7797bb05, _0xf7e8b7fe, _0xd078f7a0);
                bool _0xa3a5e3b8 = _0xfe5a7d81 == null || !_0xfe5a7d81._0x974bc64b(_0x7797bb05, _0xf7e8b7fe, _0xd078f7a0 + HopWindow);
                if (_0x3e344d81 && _0xa3a5e3b8)
                {
                    _0xd078f7a0 = _0xd078f7a0 + HopWindow;
                    _0x50122740 = true;
                    break;
                }

                _0xd078f7a0 = _0xd078f7a0 + _0x199927ea;
            }

            if (!_0x50122740)
            {
                return false;
            }

            // A river lane carries the walker sideways while it rides a raft. The walker may
            // step back toward the middle, exactly as the player can, and only a drift it
            // cannot correct in time makes the route unwalkable.
            if (_0xfe5a7d81 != null && _0xfe5a7d81._0x621a89a9)
            {
                _0x7797bb05 = _0x7797bb05 + _0xfe5a7d81.Direction * _0xfe5a7d81.Speed * 1.1f;
                float _0x3018f08b = 1f / Columns;
                float _0x95c5f75a = ColumnX(Columns - 1);
                int _0x9e7bd47a = 0;
                while (Mathf.Abs(_0x7797bb05) > _0x3018f08b && _0x9e7bd47a < Columns)
                {
                    _0x9e7bd47a++;
                    _0x7797bb05 = _0x7797bb05 + (_0x7797bb05 > 0f ? -_0x3018f08b : _0x3018f08b);
                    _0xd078f7a0 = _0xd078f7a0 + 0.13f;
                }

                if (_0x7797bb05 < -_0x95c5f75a - _0x3018f08b || _0x7797bb05 > _0x95c5f75a + _0x3018f08b)
                {
                    return false;
                }
            }
        }

        return _0xd078f7a0 <= _0xd67d0156;
    }

    public _0x74ec292d _0xa63279c6(int _0xde0613b9, int _0x5aca1c84, int _0x9eb9d7da)
    {
        int _0x7efa9a34 = this._catalog != null ? this._catalog._0x05a42898(_0xde0613b9, _0x5aca1c84) : 12;
        int _0x9fee6b31 = this._catalog != null ? this._catalog._0x1e553a3b(_0xde0613b9, _0x5aca1c84) : 2;
        for (int _0x07c8ee18 = 0; _0x07c8ee18 < MaxAttempts; _0x07c8ee18++)
        {
            // tryIndex gets its OWN large multiplier. Folding it into `attempt` made the
            // seed of (attempt 0, try 1) equal to (attempt 1, try 0), so whenever a draw
            // failed once, the NEXT attempt replayed the identical route - measured at
            // 77% of consecutive runs before this was separated out.
            int _0x89237c10 = (_0xde0613b9 * 7919) ^ (_0x5aca1c84 * 104729) ^ (_0x9eb9d7da * 7717) ^ (_0x07c8ee18 * 15485863);
            System.Random _0x908dda95 = new System.Random(_0x89237c10);
            _0x74ec292d _0x12ab8488 = this._0x51ca2967(_0x908dda95, _0x89237c10, _0xde0613b9, _0x5aca1c84, _0x7efa9a34, _0x9fee6b31);
            if (this._0x152e13e4(_0x12ab8488) && this._0x530c0d87(_0x12ab8488))
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0x65d7cdac._0x7ea8220d(new byte[13] { 134, 177, 188, 179, 184, 174, 128, 253, 174, 184, 184, 185, 224 }, 221) + _0x89237c10 + _0x65d7cdac._0x7ea8220d(new byte[7] { 14, 66, 79, 64, 75, 93, 19 }, 46) + _0x12ab8488._0xd80a7457 + _0x65d7cdac._0x7ea8220d(new byte[5] { 16, 68, 66, 73, 13 }, 48) + _0x07c8ee18);
                    }
#endif
                }

                return _0x12ab8488;
            }
        }

        _0x74ec292d _0x44314f64 = this._0xfd9eecdc(_0xde0613b9, _0x5aca1c84, _0x7efa9a34, _0x9fee6b31);
        _0x44314f64.FromFallback = true;
        {
#if B_LOGS
            {
                Debug.Log(_0x65d7cdac._0x7ea8220d(new byte[29] { 122, 77, 64, 79, 68, 82, 124, 1, 71, 64, 77, 77, 67, 64, 66, 74, 1, 84, 82, 68, 69, 1, 83, 68, 70, 72, 78, 79, 28 }, 33) + _0xde0613b9 + _0x65d7cdac._0x7ea8220d(new byte[9] { 196, 137, 141, 151, 151, 141, 139, 138, 217 }, 228) + _0x5aca1c84);
            }
#endif
        }

        return _0x44314f64;
    }

    /// <summary>Hop tween plus the landing settle - the hero is committed for this long.</summary>
    public const float HopWindow = 0.26f;
    private void _0xb5cd945b(System.Random _0x7029aef5, _0x858c002f[] _0x5fbc9822)
    {
        for (int _0x03cb681c = 2; _0x03cb681c < _0x5fbc9822.Length - 1; _0x03cb681c++)
        {
            _0x858c002f _0x71525d4f = _0x5fbc9822[_0x03cb681c];
            if (_0x71525d4f == null || !_0x71525d4f._0x44ea1f46 || _0x71525d4f.ChickColumn >= 0)
            {
                continue;
            }

            if (_0x7029aef5.Next(0, 100) < 55)
            {
                _0x71525d4f.FeatherColumn = _0x7029aef5.Next(0, Columns);
            }
        }
    }
}

internal static class _0x65d7cdac
{
    internal static string _0x7ea8220d(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}