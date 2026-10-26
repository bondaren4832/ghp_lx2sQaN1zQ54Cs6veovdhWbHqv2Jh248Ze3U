using UnityEngine;

/// <summary>
/// Shows and hides one of OUR OWN objects through a serialized reference. Rule C.2: an
/// m_IsActive modification written into a scene against a template object is silently
/// discarded, so the visibility of generated content is driven from code instead.
/// </summary>
public sealed class _0xf7a0106b : MonoBehaviour
{
    [SerializeField]
    private GameObject _content;
    public bool _0x60323e76
    {
        get
        {
            return this._content != null && this._content.activeSelf;
        }
    }

    public void _0xd34829df(bool _0xb342d913)
    {
        this._0x10045ae6 = true;
        if (this._content != null)
        {
            this._content.SetActive(_0xb342d913);
        }
    }

    public void _0x77805346()
    {
        if (this._0x10045ae6)
        {
            return;
        }

        this._0x10045ae6 = true;
        this._0xd34829df(this._visibleOnStart);
    }

    public void _0x9fef1366()
    {
        this._0xd34829df(!this._0x60323e76);
    }

    private void Start()
    {
        this._0x77805346();
    }

    [SerializeField]
    private bool _visibleOnStart;
    private bool _0x10045ae6;
}