using UnityEngine;

public class ImageChanger : MonoBehaviour
{
    public Sprite initialImage;  // The first image
    public Sprite changedImage;  // The second image

    private SpriteRenderer spriteRenderer;
    private int pressCount = 0;   // Count of Space key presses

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = initialImage;  // Set the initial image
    }

    void Update()
    {
        // Check if the "Space" key was pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            pressCount++;

            // Change the image after two presses
            if (pressCount == 2)
            {
                spriteRenderer.sprite = changedImage;  // Change to the new image
            }
            // Change back to the initial image for all future presses
            else if (pressCount > 2)
            {
                spriteRenderer.sprite = initialImage;  // Change back to the initial image
            }
        }
    }
}
