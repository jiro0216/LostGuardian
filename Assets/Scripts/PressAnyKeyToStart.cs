using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressAnyKeyToStart : MonoBehaviour
{
    private bool hasStarted = false;
    public SceneController sceneController; // Reference in Inspector

    void Update()
    {
        if (!hasStarted && Input.anyKeyDown)
        {
            hasStarted = true;
            sceneController.MainGame(); // Calls the function
        }
    }
}
