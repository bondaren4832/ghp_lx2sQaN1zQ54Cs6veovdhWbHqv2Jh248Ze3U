using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// One lane of the route: its surface tile, its movers and whatever is standing on it.
/// Movers are plain UGUI images moved by anchoredPosition every frame - the whole game is
/// kinematic, there is not a single body anywhere in the project.
/// Positions come from <see cref = "LaneSpec.MoverCentre"/>, the same method the solvability
/// proof used, so what was checked is what is drawn.
/// </summary>
public sealed class _0x9a38c954 : MonoBehaviour
{
    [SerializeField]
    private RectTransform _moverHost;
    private readonly List<RectTransform> _0xde63f409 = new List<RectTransform>();
    [SerializeField]
    private RectTransform _pickupRect;
    [SerializeField]
    private Image _pickup;
    /// <summary>A river lane with nothing under the hero drops it into the water.</summary>
    public bool _0xc1812e4f(float _0x92812f62, float _0xc2f67749)
    {
        return this._0x69af38f4 != null && this._0x69af38f4._0x621a89a9 && !this._0x69af38f4._0x974bc64b(_0x92812f62, _0xc2f67749, this._0x20566c5c);
    }

    private float _0x20566c5c;
    /// <summary>
    /// Lays the lane out. Sizes come from the field rectangle the director measured, never
    /// from a literal, so the lane fits whatever shape the device turns out to be.
    /// </summary>
    public void _0x390b7eff(_0x858c002f _0x025ae6a3, _0xc99b29ff _0x2174f5fc, float _0x3977a5ae, float _0x9be927d9, float _0x0a6730cc)
    {
        this._0x69af38f4 = _0x025ae6a3;
        this._0x060d28e3 = _0x3977a5ae;
        this._0xd60fc68a = _0x9be927d9;
        this._0x20566c5c = _0x0a6730cc;
        this._0xdb4022ab = false;
        if (this._tile != null && _0x2174f5fc != null)
        {
            this._tile.sprite = _0x2174f5fc._0xab7b7001(_0x025ae6a3.Kind);
            this._tile.color = _0x2174f5fc._0x837ce308(_0x025ae6a3.Kind);
        }

        this._0x9905baf8(_0x2174f5fc);
        this._0x951d698a(_0x2174f5fc);
    }

    [SerializeField]
    private Image _tile;
    public bool _0x3d9c1155(int _0x0f9a44e2)
    {
        if (this._0x69af38f4 == null || this._0xdb4022ab)
        {
            return false;
        }

        int _0x04e77617 = this._0x69af38f4.ChickColumn >= 0 ? this._0x69af38f4.ChickColumn : this._0x69af38f4.FeatherColumn;
        if (_0x04e77617 < 0 || _0x04e77617 != _0x0f9a44e2)
        {
            return false;
        }

        this._0xdb4022ab = true;
        if (this._pickup != null)
        {
            this._pickup.gameObject.SetActive(false);
        }

        return true;
    }

    private void _0x9905baf8(_0xc99b29ff _0x3e1701f5)
    {
        for (int _0x22bb3ba5 = 0; _0x22bb3ba5 < this._0xde63f409.Count; _0x22bb3ba5++)
        {
            if (this._0xde63f409[_0x22bb3ba5] != null)
            {
                Destroy(this._0xde63f409[_0x22bb3ba5].gameObject);
            }
        }

        this._0xde63f409.Clear();
        if (this._0x69af38f4 == null || this._0x69af38f4.MoverCount <= 0 || this._moverPrefab == null || this._moverHost == null)
        {
            return;
        }

        // A square box, because the generated PNG is square: the picture then keeps its own
        // proportions instead of being stretched, and its width on screen is exactly the
        // width the solvability proof used (LaneSpec.HitLength is that width times ArtFill).
        float _0xe7df923e = this._0x69af38f4.MoverLength * this._0x060d28e3;
        for (int _0x757adfb8 = 0; _0x757adfb8 < this._0x69af38f4.MoverCount; _0x757adfb8++)
        {
            Image _0x6ffdf038 = Instantiate(this._moverPrefab, this._moverHost, false);
            if (_0x3e1701f5 != null)
            {
                _0x6ffdf038.sprite = _0x3e1701f5._0x1c624ac4(this._0x69af38f4.MoverKind);
                // The box is square because the generated PNG is; preserving the aspect
                // is what keeps a bus a bus instead of a stretched car (rule F.2a).
                _0x6ffdf038.preserveAspect = true;
            }

            // The sprites are drawn facing RIGHT (declared in assets.json); a lane running
            // the other way flips a deliberately asymmetric picture, which is what rule C.8
            // asks for. The raft is symmetric and is never flipped.
            _0x6ffdf038.transform.localScale = this._0x69af38f4.MoverKind == _0x858c002f.MoverRaft || this._0x69af38f4.Direction >= 0 ? Vector3.one : new Vector3(-1f, 1f, 1f);
            RectTransform _0x4afada28 = _0x6ffdf038.rectTransform;
            _0x4afada28.anchorMin = new Vector2(0.5f, 0.5f);
            _0x4afada28.anchorMax = new Vector2(0.5f, 0.5f);
            _0x4afada28.pivot = new Vector2(0.5f, 0.5f);
            _0x4afada28.sizeDelta = new Vector2(_0xe7df923e, _0xe7df923e);
            _0x6ffdf038.gameObject.SetActive(true);
            this._0xde63f409.Add(_0x4afada28);
        }

        this._0x3b4b5eed();
    }

    public void _0xe9a377b7(float _0x0f4bf9d0)
    {
        if (this._0x69af38f4 == null || this._0xde63f409.Count == 0)
        {
            return;
        }

        this._0x20566c5c = this._0x20566c5c + _0x0f4bf9d0;
        this._0x3b4b5eed();
    }

    /// <summary>True when a hero standing at <paramref name = "x"/> field fractions is
    /// overlapping one of this lane movers right now.</summary>
    public bool _0xb280ad1d(float _0xcddb87b9, float _0x66dc7520)
    {
        return this._0x69af38f4 != null && this._0x69af38f4._0x974bc64b(_0xcddb87b9, _0x66dc7520, this._0x20566c5c);
    }

    [SerializeField]
    private Image _moverPrefab;
    /// <summary>
    /// Sideways speed, in field fractions per second, of the raft under the hero, or zero
    /// when the hero is standing on open water or on dry land.
    /// </summary>
    public float _0x136b23c6(float _0x5b9ef6e9, float _0xe4da55c0)
    {
        if (this._0x69af38f4 == null || !this._0x69af38f4._0x621a89a9)
        {
            return 0f;
        }

        return this._0x69af38f4._0x974bc64b(_0x5b9ef6e9, _0xe4da55c0, this._0x20566c5c) ? this._0x69af38f4.Direction * this._0x69af38f4.Speed : 0f;
    }

    private bool _0xdb4022ab;
    public bool _0x1b610e46
    {
        get
        {
            return this._0x69af38f4 != null && this._0x69af38f4.FeatherColumn >= 0 && !this._0xdb4022ab;
        }
    }

    private _0x858c002f _0x69af38f4;
    public _0x858c002f _0xe1f8a2c7
    {
        get
        {
            return this._0x69af38f4;
        }
    }

    public bool _0x26667db3
    {
        get
        {
            return this._0x69af38f4 != null && this._0x69af38f4.ChickColumn >= 0 && !this._0xdb4022ab;
        }
    }

    private float _0x060d28e3;
    private float _0xd60fc68a;
    private void _0x951d698a(_0xc99b29ff _0x4ea44d0e)
    {
        if (this._pickup == null || this._pickupRect == null)
        {
            return;
        }

        int _0x0efd5507 = this._0x69af38f4 != null ? (this._0x69af38f4.ChickColumn >= 0 ? this._0x69af38f4.ChickColumn : this._0x69af38f4.FeatherColumn) : -1;
        if (_0x0efd5507 < 0 || _0x4ea44d0e == null)
        {
            this._pickup.gameObject.SetActive(false);
            return;
        }

        this._pickup.gameObject.SetActive(true);
        this._pickup.sprite = this._0x69af38f4.ChickColumn >= 0 ? _0x4ea44d0e._0x52326b69 : _0x4ea44d0e._0x7144c0cb;
        float _0xd048e296 = this._0xd60fc68a * 0.62f;
        this._pickupRect.sizeDelta = new Vector2(_0xd048e296, _0xd048e296);
        this._pickupRect.anchoredPosition = new Vector2(_0x0bc07320.ColumnX(_0x0efd5507) * this._0x060d28e3, 0f);
    }

    private void _0x3b4b5eed()
    {
        for (int _0xd490da7b = 0; _0xd490da7b < this._0xde63f409.Count; _0xd490da7b++)
        {
            RectTransform _0xde14d702 = this._0xde63f409[_0xd490da7b];
            if (_0xde14d702 == null)
            {
                continue;
            }

            _0xde14d702.anchoredPosition = new Vector2(this._0x69af38f4._0x8a062e5f(_0xd490da7b, this._0x20566c5c) * this._0x060d28e3, 0f);
        }
    }
}