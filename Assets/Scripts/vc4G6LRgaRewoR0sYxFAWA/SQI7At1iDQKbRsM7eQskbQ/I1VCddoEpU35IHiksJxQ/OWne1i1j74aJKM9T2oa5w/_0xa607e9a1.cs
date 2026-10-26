using UnityEngine;
using UnityEngine.UI;

public class _0xa607e9a1 : MonoBehaviour
{
    public int NextTutorialPanelIndex;
    public bool IsTutorialEndPanel;
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0xc9856497.Instance._0xf246b714(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0x2755d8a9.Instance._0xa593e5e1());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0xc9856497.Instance._0xf246b714(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0xc9856497.Instance._0xf246b714(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0x2755d8a9.Instance._0xa593e5e1());
        }
    }

    public int EndTutorialPanelIndex = 1;
    public Button TutorialEndButton;
    public Button NextTutorialButton;
}