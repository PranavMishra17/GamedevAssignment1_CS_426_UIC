// add score manager
using UnityEngine;
using UnityEngine.UI;

// access the Text Mesh Pro namespace
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text scoreText;
    public int maxScore = 10;

    int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score;
    }

    //we will call this method from our target script
    // whenever the player collides or shoots a target a point will be added
    public void AddPoint()
    {
        score++;

        scoreText.text = "Score: " + score;

        if(score >= maxScore)
        {
            score = 0;
            scoreText.text = "YOU WON!";
        }
       
    }

    public void SubPoint()
    {
        score--;

        scoreText.text = "Score: " + score;

    }
}