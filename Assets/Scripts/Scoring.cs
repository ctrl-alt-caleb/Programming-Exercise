using UnityEngine;
using TMPro;

public class Scoring : MonoBehaviour
{
    public static int leftScore = 0;
    public static int rightScore = 0;
    private int maxScore = 10;

    public TextMeshProUGUI leftScoreText;
    public TextMeshProUGUI rightScoreText;

    public GameObject playAgainMenu;



    void Start()
    {
        rightScoreText.text = rightScore.ToString();
        leftScoreText.text = leftScore.ToString();
    }

    private void Update()
    {
        if (leftScore + rightScore == maxScore) //if max "score" of 10 is reached-- try again menu appears
        {
            playAgainMenu.SetActive(true);
            Time.timeScale = 0; //freezes scene
        }
    }
}
