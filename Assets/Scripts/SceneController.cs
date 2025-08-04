using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Debug.Log("button is pressed");
    }

    public void MainGame()
    {
        SceneManager.LoadScene("GameScene");
        Debug.Log("button is pressed");
    }

}
