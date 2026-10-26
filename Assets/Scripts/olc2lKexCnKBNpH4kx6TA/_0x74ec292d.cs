/// <summary>
/// A whole generated route plus the numbers the HUD and the result card quote. Built by
/// LanePlanGenerator with Init(...) - no constructor (rule C.59).
/// </summary>
public sealed class _0x74ec292d
{
    public bool FromFallback;
    public int Seed;
    public int ChickTotal;
    public int _0xd80a7457
    {
        get
        {
            return this.Lanes == null ? 0 : this.Lanes.Length;
        }
    }

    public _0x858c002f _0x3d16c24f(int _0x77fe1b6e)
    {
        if (this.Lanes == null || _0x77fe1b6e < 0 || _0x77fe1b6e >= this.Lanes.Length)
        {
            return null;
        }

        return this.Lanes[_0x77fe1b6e];
    }

    public int RegionIndex;
    public _0x74ec292d _0xc83bd809(_0x858c002f[] _0x4323b8b8, int _0x466937a5, int _0x5b0fe1c0, int _0x15b1fec4, int _0x7a077498)
    {
        this.Lanes = _0x4323b8b8;
        this.Seed = _0x466937a5;
        this.ChickTotal = _0x5b0fe1c0;
        this.RegionIndex = _0x15b1fec4;
        this.MissionIndex = _0x7a077498;
        return this;
    }

    public _0x858c002f[] Lanes;
    public int MissionIndex;
}