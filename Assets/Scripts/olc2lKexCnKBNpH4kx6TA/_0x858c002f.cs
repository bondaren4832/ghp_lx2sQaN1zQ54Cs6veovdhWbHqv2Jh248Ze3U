/// <summary>
/// One lane of a generated route. Plain data: no constructor, built with Init(...) which
/// returns the object (rule C.59). All horizontal quantities are fractions of the play
/// field's width, so the same spec drives the solvability proof and the live lane without
/// either of them knowing the pixel size of the field.
/// </summary>
public sealed class _0x858c002f
{
    public const int MoverTruck = 1;
    public float Phase;
    public int MoverKind;
    /// <summary>Total distance a mover travels before it reappears on the far side.</summary>
    public float _0x42369a09
    {
        get
        {
            return 1f + this.MoverLength;
        }
    }

    public bool _0x44ea1f46
    {
        get
        {
            return this.Kind == KindVerge || this.Kind == KindIsland || this.Kind == KindFinish;
        }
    }

    /// <summary>Width that actually hits, as a fraction of the field.</summary>
    public float _0x43a53f63
    {
        get
        {
            return this.MoverLength * ArtFill;
        }
    }

    public const int KindFinish = 4;
    /// <summary>
    /// Share of a mover sprite that is actually drawn on. The generated PNGs arrive on a
    /// square canvas with transparent margins, so the picture fills about this much of the
    /// box it is drawn in. Collisions use the PICTURE, not the box - otherwise the rooster
    /// dies on empty asphalt a hand width in front of a car.
    /// </summary>
    public const float ArtFill = 0.78f;
    public int MoverCount;
    public int DecorColumn = -1;
    /// <summary>
    /// Centre of mover <paramref name = "index"/> at time <paramref name = "time"/>, in field
    /// fractions where the visible field spans -0.5 .. 0.5. LaneRunner draws from this
    /// very method, so what the solvability proof checked is what the player meets.
    /// </summary>
    public float _0x8a062e5f(int _0x301861b2, float _0x3c9c4691)
    {
        float _0x8e752a53 = this._0x42369a09;
        if (this.MoverCount <= 0 || _0x8e752a53 <= 0f)
        {
            return -10f;
        }

        float _0x65648433 = (this.Phase + (float)_0x301861b2 / this.MoverCount) * _0x8e752a53 + this.Speed * _0x3c9c4691;
        float _0x528376e0 = _0x65648433 - _0x8e752a53 * UnityEngine.Mathf.Floor(_0x65648433 / _0x8e752a53);
        if (this.Direction >= 0)
        {
            return -_0x8e752a53 * 0.5f + _0x528376e0;
        }

        return _0x8e752a53 * 0.5f - _0x528376e0;
    }

    public const int KindRiver = 3;
    public const int KindVerge = 0;
    public const int MoverBus = 2;
    /// <summary>True when a hero of half-width <paramref name = "pad"/> standing at
    /// <paramref name = "x"/> would be touching a mover at <paramref name = "time"/>.</summary>
    public bool _0x974bc64b(float _0xa88f0a63, float _0x57cb4148, float _0x200c8f4b)
    {
        if (this.MoverCount <= 0)
        {
            return false;
        }

        float _0x90550419 = this._0x43a53f63 * 0.5f + _0x57cb4148;
        for (int _0xb5396de5 = 0; _0xb5396de5 < this.MoverCount; _0xb5396de5++)
        {
            float _0x6d894b52 = this._0x8a062e5f(_0xb5396de5, _0x200c8f4b);
            if (_0xa88f0a63 > _0x6d894b52 - _0x90550419 && _0xa88f0a63 < _0x6d894b52 + _0x90550419)
            {
                return true;
            }
        }

        return false;
    }

    public int ChickColumn = -1;
    public bool _0x621a89a9
    {
        get
        {
            return this.Kind == KindRiver;
        }
    }

    public int FeatherColumn = -1;
    public const int MoverRaft = 3;
    public float Speed;
    public const int MoverCar = 0;
    public const int KindIsland = 2;
    public const int KindHighway = 1;
    public int Direction;
    public int Kind;
    public float MoverLength;
    public _0x858c002f _0x798dd182(int _0x7eac0581, int _0xd7fe37b7, int _0x7bd632fa, int _0x63e569e8, float _0x55a45d1c, float _0x6072af5a, float _0x7b0eeb9d)
    {
        this.Kind = _0x7eac0581;
        this.MoverKind = _0xd7fe37b7;
        this.MoverCount = _0x7bd632fa;
        this.Direction = _0x63e569e8;
        this.Speed = _0x55a45d1c;
        this.Phase = _0x6072af5a;
        this.MoverLength = _0x7b0eeb9d;
        return this;
    }
}