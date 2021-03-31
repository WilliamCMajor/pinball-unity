using UnityEngine;

public class GameState : MonoBehaviour
{
    public int score;
    public int playerlifes;

    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("GameState");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    public void Start()
    {
        score = 0;
        playerlifes = 3;
    }

    public void updatePlayerLifes()
    {
        GameObject[] heartLife;
        heartLife = GameObject.FindGameObjectsWithTag("Lifes");
        Destroy(heartLife[0]);
      
        playerlifes -= 1;

    }

    public void updateBumperBlackScore()
    {
        score += 100;
    }

    public void updateBumperOrangeScore()
    {
        score += 50;
    }
    public void updateBumperGreenScore()
    {
        score += 20;
    }

    public void resetScore()
    {
        score = 0;
    }

    /*
     * To access the gameState object in any *other* script:
     * -declare protected GameState gameState;
     * -add a Start() method that contains:
     * gameState = GameObject.FindGameObjectWithTag("GameState").GetComponent<GameState>();
     */
}
