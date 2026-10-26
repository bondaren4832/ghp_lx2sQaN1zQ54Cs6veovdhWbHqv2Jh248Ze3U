using TMPro;
using UnityEngine;
using static _0xe84084b3;

public class _0xed270438 : MonoBehaviour
{
    public TMP_Text MoneyCountText;
    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0xfd29da8e;
            if (this.gameObject.TryGetComponent(out _0xfd29da8e))
                this.MoneyCountText = _0xfd29da8e;
        }

        this._0xb91b66da();
    }

    public void _0xb91b66da()
    {
        this.MoneyCountText.text = _0x7744f800._0xc04d35d5.ToString();
    }
}