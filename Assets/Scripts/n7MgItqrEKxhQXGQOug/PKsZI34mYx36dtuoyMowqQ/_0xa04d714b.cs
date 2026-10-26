using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xa04d714b : MonoBehaviour
{
    private void _0xe8eb3e2e()
    {
        if (this._0x4416560e.canvasRenderer.GetColor() != this._0x0d5ede48.canvasRenderer.GetColor())
            this._0x0d5ede48.canvasRenderer.SetColor(this._0x4416560e.canvasRenderer.GetColor());
    }

    private TMP_Text _0x0d5ede48;
    private Image _0x4416560e;
    private void Update()
    {
        this._0xe8eb3e2e();
    }
}