using UnityEngine;
using UnityEngine.SceneManagement;

public class MirrorTrigger2 : MonoBehaviour
{
    public GameObject Target;
    private Collider2D TargetCollider;
    private SpriteRenderer TargetSprenderer;

    void Start(){
        Target.TryGetComponent<Collider2D>(out TargetCollider);
        Target.TryGetComponent<SpriteRenderer>(out TargetSprenderer);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.tag);
        if (other.CompareTag("Player"))
        {
            Debug.Log("Activate the dialogue and reveal weapon");

            // Enable the collider
            if (TargetCollider != null && TargetSprenderer != null)
            {
                TargetCollider.enabled = true;
                TargetSprenderer.enabled = true;
            }
        }
    }
}