using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CluedoTutorialScript : MonoBehaviour
{
    public Image displayImage;
    public Sprite[] pages;
    private int currentPage = 0;
    public TMP_Text pageNumberText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ShowPage();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NextPage()
    {
        if (currentPage < pages.Length - 1)
        {
            currentPage++;
            ShowPage();
        }
    }

    public void PreviousPage()
    {
        if (currentPage > 0)
        {
            currentPage--;
            ShowPage();
        }
    }

    void ShowPage()
    {
        displayImage.sprite = pages[currentPage];
        pageNumberText.text = $"{currentPage + 1} / {pages.Length}";

    }
}