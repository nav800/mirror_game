using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void Quit()
    {
        #if UNITY_EDITOR
            // If in the editor, stop playing the game
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            // If in a built application, quit the application
            Application.Quit();
        #endif
    }
}
