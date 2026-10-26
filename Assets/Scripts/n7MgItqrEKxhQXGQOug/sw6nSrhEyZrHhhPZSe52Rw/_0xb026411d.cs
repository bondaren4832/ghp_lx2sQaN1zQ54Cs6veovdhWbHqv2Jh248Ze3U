using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0xb026411d : MonoBehaviour
{
    private void _0x483af3cd()
    {
        float _0x56f96242, _0x8619f43a, _0x78daee59, _0x81bca105;
        if (this._0x93c0be55 == _0x41973142.Landscape)
            this._0x26fb9130.orthographicSize = 1f / this._0x26fb9130.aspect * this._0x85d93e9e / 2f;
        else
            this._0x26fb9130.orthographicSize = this._0x85d93e9e / 2f;
        this._0x2a856c11 = 2f * this._0x26fb9130.orthographicSize;
        this._0x572378aa = this._0x2a856c11 * this._0x26fb9130.aspect;
        float _0x37b7e4da = this._0x26fb9130.transform.position.x;
        float _0x862959d9 = this._0x26fb9130.transform.position.y;
        _0x56f96242 = _0x37b7e4da - this._0x572378aa / 2;
        _0x8619f43a = _0x37b7e4da + this._0x572378aa / 2;
        _0x78daee59 = _0x862959d9 + this._0x2a856c11 / 2;
        _0x81bca105 = _0x862959d9 - this._0x2a856c11 / 2;
        this._0x306c9ea4 = new Vector3(_0x56f96242, _0x81bca105, 0);
        this._0xb23e9408 = new Vector3(_0x37b7e4da, _0x81bca105, 0);
        this._0x8820a76c = new Vector3(_0x8619f43a, _0x81bca105, 0);
        this._0xce638974 = new Vector3(_0x56f96242, _0x862959d9, 0);
        this._0xc9f355b2 = new Vector3(_0x37b7e4da, _0x862959d9, 0);
        this._0x781fd7a8 = new Vector3(_0x8619f43a, _0x862959d9, 0);
        this._0x3a674b05 = new Vector3(_0x56f96242, _0x78daee59, 0);
        this._0x4495115c = new Vector3(_0x37b7e4da, _0x78daee59, 0);
        this._0x59bad7ce = new Vector3(_0x8619f43a, _0x78daee59, 0);
    }

    public enum _0x41973142
    {
        Landscape,
        Portrait
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = this._0xa106c4c3;
        Matrix4x4 _0xb7b6b315 = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0x26fb9130.orthographic)
        {
            float _0xf5b7433b = this._0x26fb9130.farClipPlane - this._0x26fb9130.nearClipPlane;
            float _0x22d16c93 = (this._0x26fb9130.farClipPlane + this._0x26fb9130.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0x22d16c93), new Vector3(this._0x26fb9130.orthographicSize * 2 * this._0x26fb9130.aspect, this._0x26fb9130.orthographicSize * 2, _0xf5b7433b));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0x26fb9130.fieldOfView, this._0x26fb9130.farClipPlane, this._0x26fb9130.nearClipPlane, this._0x26fb9130.aspect);
        }

        Gizmos.matrix = _0xb7b6b315;
    }

    private Vector3 _0x781fd7a8 { get; set; }

    private static _0xb026411d _0x1c2ed61e;
    private Vector3 _0xb23e9408 { get; set; }
    private Vector3 _0xc9f355b2 { get; set; }
    private Vector3 _0xce638974 { get; set; }

    private _0x41973142 _0x93c0be55 = _0x41973142.Portrait;
    private new Camera _0x26fb9130;
    private Vector3 _0x306c9ea4 { get; set; }
    private Vector3 _0x3a674b05 { get; set; }

    private float _0x85d93e9e = 1;
    private Vector3 _0x4495115c { get; set; }

    private Color _0xa106c4c3 = Color.white;
    private Vector3 _0x8820a76c { get; set; }
    private float _0x2a856c11 { get; set; }
    //public bool executeInUpdate;
    private float _0x572378aa { get; set; }
    private Vector3 _0x59bad7ce { get; set; }

    private void Awake()
    {
        this._0x26fb9130 = this.GetComponent<Camera>();
        _0x1c2ed61e = this;
        this._0x483af3cd();
    }
}