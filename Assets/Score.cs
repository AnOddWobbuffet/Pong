using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public GameObject ball;
    public bool isGoalLeft;
    public GameObject scoreLeft;
    public GameObject scoreRight;

    private int playerLeftScore = 0;
    private int playerRightScore = 0;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball")) 
        { 
            if (isGoalLeft)
            {
                playerLeftScore++;
                scoreLeft.GetComponent<TextMeshProUGUI>().text = playerLeftScore.ToString();
            }
            else
            {
                playerRightScore++;
                scoreRight.GetComponent<TextMeshProUGUI>().text = playerRightScore.ToString();
            }
            ball.GetComponent<Ball>().Reset();
        }
    }

}
