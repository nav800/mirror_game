using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Set the name of the scene you want to load in the Inspector
    public string sceneToLoad;

    // This method is called when another collider enters the trigger collider
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collider belongs to the player (you can use tags or specific GameObject checks)
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered the trigger zone! Loading scene: " + sceneToLoad);
            LoadScene();
        }
    }

    private void LoadScene()
    {
        // Load the specified scene
        SceneManager.LoadScene(sceneToLoad);
    }
}