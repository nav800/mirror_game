using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer; // Reference to the Sprite Renderer
    public Sprite upSprite;    // Sprite for moving up
    public Sprite downSprite;  // Sprite for moving down
    public Sprite leftSprite;  // Sprite for moving left
    public Sprite rightSprite; // Sprite for moving right

    public void ChangeSprite(float moveHorizontal, float moveVertical)
    {
        // Determine direction and set sprite
        if (moveVertical > 0)
        {
            spriteRenderer.sprite = upSprite; // Up
        }
        else if (moveVertical < 0)
        {
            spriteRenderer.sprite = downSprite; // Down
        }
        else if (moveHorizontal < 0)
        {
            spriteRenderer.sprite = leftSprite; // Left
        }
        else if (moveHorizontal > 0)
        {
            spriteRenderer.sprite = rightSprite; // Right
        }
    }
}
