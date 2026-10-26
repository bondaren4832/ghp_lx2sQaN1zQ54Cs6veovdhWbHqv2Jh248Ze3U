using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x63cbf436 : MonoBehaviour
{
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsLoadCurrentScene;
    public Button Button;
    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0x2755d8a9.Instance._0x017e7362(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0x2755d8a9.Instance._0x017e7362(this.LoadSceneId));
    }

    public int LoadSceneId;
}