using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RawImage))]
public class ScrollingBackground : MonoBehaviour
{
    [SerializeField] private float scrollX = 0.01f;
    [SerializeField] private float scrollY = -0.01f;

    private RawImage rawImage;
    private Rect uvRect;

    private void Awake()
    {
        rawImage = GetComponent<RawImage>();
        uvRect = rawImage.uvRect;

        uvRect = new Rect(0, 0, 1f, 1f);
    }

    private void Update()
    {
        uvRect.x += scrollX * Time.deltaTime;
        uvRect.y += scrollY * Time.deltaTime;
        rawImage.uvRect = uvRect;
    }
}