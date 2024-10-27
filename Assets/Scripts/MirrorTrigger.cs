using UnityEngine;
using UnityEngine.SceneManagement;

public class MirrorTrigger : MonoBehaviour
{
    public GameObject Target;
    private Collider2D TargetCollider;

    void Start(){
        Target.TryGetComponent<Collider2D>(out TargetCollider);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.tag);
        if (other.CompareTag("Player"))
        {
            Debug.Log("Activate the dialogue and the goal");

            // Enable the collider
            if (TargetCollider != null)
            {
                TargetCollider.enabled = true;
            }
        }
    }
}