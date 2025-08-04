using UnityEngine;
using UnityEngine.UI;
using TMPro;
//using UnityEditor.SearchService;
using UnityEngine.SceneManagement;


public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public int playerCoin;

    [Header("Score Display")]
    public TMP_Text scoreText;
    public TMP_Text coinsText;

    public GameObject gameOverScreen;


    [ContextMenu("Increase Score")]
    public void AddScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();

    }

    [ContextMenu("Increase Coin")]
    public void AddCoin(int coinToAdd)
    {
        playerCoin = playerCoin + coinToAdd;

        coinsText.text = playerCoin.ToString();
    }

    //     public void RestartGame()
    //     {
    //         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    //         Debug.Log("button is pressed");
    //     }

    //     public void BacktoMenu()
    //     {

    //      SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    //     }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }

}
