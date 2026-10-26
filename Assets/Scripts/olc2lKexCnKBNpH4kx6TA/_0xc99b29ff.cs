using UnityEngine;

/// <summary>
/// Every sprite the play field needs, in one serialized place on the game view. Lane rows
/// are instantiated from their own prefab and are handed this object, so a lane never has
/// to look an asset up by name and the art lives in exactly one authored spot.
/// </summary>
public sealed class _0xc99b29ff : MonoBehaviour
{
    [SerializeField]
    private Sprite _moverBus;
    [SerializeField]
    private Sprite _tileWater;
    [SerializeField]
    private Sprite _tileAsphalt;
    public Sprite _0xab7b7001(int _0xe674f4d1)
    {
        if (_0xe674f4d1 == _0x858c002f.KindHighway)
        {
            return this._tileAsphalt;
        }

        if (_0xe674f4d1 == _0x858c002f.KindIsland)
        {
            return this._tileIsland;
        }

        if (_0xe674f4d1 == _0x858c002f.KindRiver)
        {
            return this._tileWater;
        }

        return this._tileVerge;
    }

    public Sprite _0x7144c0cb
    {
        get
        {
            return this._feather;
        }
    }

    [SerializeField]
    private Sprite _chick;
    public Color _0x837ce308(int _0x236a4612)
    {
        if (_0x236a4612 == _0x858c002f.KindHighway)
        {
            return _0xa567d11e.Asphalt;
        }

        if (_0x236a4612 == _0x858c002f.KindIsland)
        {
            return _0xa567d11e.Edge;
        }

        if (_0x236a4612 == _0x858c002f.KindRiver)
        {
            return _0xa567d11e.Teal;
        }

        return _0xa567d11e.Grass;
    }

    [SerializeField]
    private Sprite _feather;
    [SerializeField]
    private Sprite _tileVerge;
    public Sprite _0x52326b69
    {
        get
        {
            return this._chick;
        }
    }

    [SerializeField]
    private Sprite _moverRaft;
    public Sprite _0x1c624ac4(int _0x96165742)
    {
        if (_0x96165742 == _0x858c002f.MoverTruck)
        {
            return this._moverTruck;
        }

        if (_0x96165742 == _0x858c002f.MoverBus)
        {
            return this._moverBus;
        }

        if (_0x96165742 == _0x858c002f.MoverRaft)
        {
            return this._moverRaft;
        }

        return this._moverCar;
    }

    [SerializeField]
    private Sprite _tileIsland;
    [SerializeField]
    private Sprite _moverCar;
    [SerializeField]
    private Sprite _moverTruck;
}