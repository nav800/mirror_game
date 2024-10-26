using UnityEngine;
using UnityEngine.SceneManagement;

public class ColliderSceneChanger : MonoBehaviour
{
    public string sceneToLoad;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player")){
            Debug.Log("Player entered the trigger zone! Loading scene: " + sceneToLoad);
            LoadScene();
        }
    }

    private void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}