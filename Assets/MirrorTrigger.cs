using UnityEngine;
using UnityEngine.SceneManagement;

public class MirrorTrigger : MonoBehaviour
{
    public string sceneToLoad;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.tag);
        if (other.CompareTag("Player"))
        {
            Debug.Log("Activate the cutscene and the goal");
        }
    }
}