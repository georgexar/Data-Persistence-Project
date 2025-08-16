using TMPro;
using UnityEngine;

public class UIHandler : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text bestScoreText;

    private int currentScore = 0;

    void Start()
    {
        bestScoreText.text = "Best Score : "
            + GameManager.Instance.highScoreName
            + " : " + GameManager.Instance.highScore;

        scoreText.text = "Score : " + currentScore;
    }

    public void AddPoint(int point)
    {
        currentScore += point;
        scoreText.text = "Score : " + currentScore;

        if (currentScore > GameManager.Instance.highScore)
        {
            GameManager.Instance.highScore = currentScore;
            GameManager.Instance.highScoreName = GameManager.Instance.playerName;
            GameManager.Instance.SaveHighScore();

            bestScoreText.text = "Best Score : "
                + GameManager.Instance.highScoreName
                + " : " + GameManager.Instance.highScore;
        }
    }
}
