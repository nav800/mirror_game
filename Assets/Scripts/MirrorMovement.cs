using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorMovement : MonoBehaviour
{

    public Rigidbody2D rb2d;

    public GameObject Target; // Assign this in the Inspector

    private Rigidbody2D targetRb2D; // For 2D

    // Start is called before the first frame update
    void Start(){
        Target.TryGetComponent<Rigidbody2D>(out targetRb2D);

    }

    // Update is called once per frame
    void Update()
    {
        if (targetRb2D != null){
            Vector2 velocity2D = targetRb2D.velocity;
                
            rb2d.velocity = new Vector2(-1 * velocity2D.x, velocity2D.y);
            }
    }
}
