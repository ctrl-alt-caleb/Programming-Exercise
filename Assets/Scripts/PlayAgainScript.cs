using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgainScript : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI leftScoreText;
    [SerializeField] TextMeshProUGUI rightScoreText;

    public GameObject playAgainMenu;

    public void PlayAgain() //reloads main scene & resets counters
    {
        Debug.Log("loading main scene...");
        Scoring.leftScore = 0;
        Scoring.rightScore = 0;
        leftScoreText.text = Scoring.leftScore.ToString();
        rightScoreText.text = Scoring.rightScore.ToString();
        SceneManager.LoadScene("Main");
        Time.timeScale = 1; 
    }

    public void QuitGame() // closes application
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}

    
