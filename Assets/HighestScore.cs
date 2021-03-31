using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighestScore : MonoBehaviour
{
    private HUDLevel01 highScore;
    int score;
    private void Awake()
    {

        highScore = GameObject.FindGameObjectWithTag("HUD").GetComponent<HUDLevel01>();
        
    }

    private void Update()
    {
        score = highScore.pinBallScore;
        Debug.Log("score: " + score);

        if (highScore != null)
        {
            GetComponent<Text>().text = score.ToString();

        }
    }

}
