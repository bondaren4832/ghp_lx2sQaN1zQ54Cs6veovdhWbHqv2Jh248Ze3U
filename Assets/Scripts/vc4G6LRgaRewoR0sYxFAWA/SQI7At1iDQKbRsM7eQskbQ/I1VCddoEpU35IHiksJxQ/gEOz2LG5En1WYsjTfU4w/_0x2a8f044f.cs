using UnityEngine;
using UnityEngine.UI;

public class _0x2a8f044f : MonoBehaviour
{
    public Button Button;
    public bool IsPhysicsRunOnClick;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    private void Start()
    {
        this.Button.onClick.AddListener(() => _0x2755d8a9.Instance._0xf3636c95(this.IsPhysicsRunOnClick));
    }
}