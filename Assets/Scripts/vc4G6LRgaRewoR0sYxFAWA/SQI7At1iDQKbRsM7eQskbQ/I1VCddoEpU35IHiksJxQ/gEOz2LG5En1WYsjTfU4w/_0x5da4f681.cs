using UnityEngine;
using UnityEngine.UI;

public class _0x5da4f681 : MonoBehaviour
{
    private int _0x39f07a08;
    private bool _0x1987e147;
    private void Awake()
    {
        if (this._0xb321b923 == null)
            if (!this.TryGetComponent(out this._0xb321b923))
                this._0xb321b923 = this.GetComponentInChildren<Button>();
    }

    private void Start()
    {
        if (this._0x1987e147)
            this._0xb321b923.onClick.AddListener(() => _0xc9856497.Instance._0x9095aa9a());
        else
            this._0xb321b923.onClick.AddListener(() => _0xc9856497.Instance._0xf246b714(this._0x39f07a08));
    }

    private Button _0xb321b923;
}