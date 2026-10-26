using UnityEngine;
using UnityEngine.UI;

public class _0x0fb973d8 : MonoBehaviour
{
    public int PopToShowIndex;
    public bool IsHideAllPops;
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0x498f87d1.Instance._0x386c420a();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0x498f87d1.Instance._0x6c5bed12());
        else
            this.Button.onClick.AddListener(() => _0x498f87d1.Instance._0x20ed82d1(this.PopToShowIndex));
    }

    public bool IsShowLastPop;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public Button Button;
}