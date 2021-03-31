using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverLoadScene : MonoBehaviour
{
    int playerLifes;

    private void Start()
    {
        FindObjectOfType<GameState>().Start();
    }
    private void Update()
    {
        playerLifes = FindObjectOfType<GameState>().playerlifes;

        if (playerLifes < 1)
        {
            SceneManager.LoadScene(2);
        }
    }

}
