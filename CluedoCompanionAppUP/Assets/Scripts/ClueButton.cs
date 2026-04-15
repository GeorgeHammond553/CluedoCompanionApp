using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClueButton : MonoBehaviour
{
    public Image background;
    public TextMeshProUGUI label;
    public Image strikeLine;
    public Button button;

    private int state = 0;

    void Awake()
    {
        button.onClick.AddListener(OnClick);
        UpdateVisual();
    }

    void OnClick()
    {
        state = (state + 1) % 3;
        UpdateVisual();
    }

    void UpdateVisual()
    {
        switch (state)
        {
            case 0:
                background.color = new Color32(72, 91, 13, 255);
                label.color = new Color32(255, 255, 255, 255);
                strikeLine.gameObject.SetActive(false);
                break;

            case 1:
                background.color = new Color32(158, 180, 77, 220);
                label.color = new Color32(0, 0, 0, 255);
                strikeLine.gameObject.SetActive(false);
                break;

            case 2:
                background.color = new Color32(182, 200, 120, 100);
                label.color = new Color32(0, 0, 0, 255);
                strikeLine.color = new Color32(0, 0, 0, 255);
                strikeLine.gameObject.SetActive(true);
                break;
        }
    }
}