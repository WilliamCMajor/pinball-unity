using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class HUDLevel01 : MonoBehaviour
{
    public GameState gameState;
    protected Text scoreTextlabel;
    public int pinBallScore;
    // Start is called before the first frame update
    void Start()
    {
        gameState = GameObject.FindGameObjectWithTag("GameState").GetComponent<GameState>();
        scoreTextlabel = GameObject.Find("TextScore").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreTextlabel.text = gameState.score + "";
        if(gameState.playerlifes == 0)
        {
            SaveToDisk();
        }
        LoadFromDisk();
        Debug.Log("pibBallScore" + pinBallScore);

    }

    public void SaveToDisk()
    {
        string dataPath = Path.Combine(Application.persistentDataPath, "savedScore.txt");
        string jsonString = JsonUtility.ToJson(gameState);

        using(StreamWriter streamWriter = File.CreateText(dataPath))
        {
            streamWriter.Write(jsonString);
            Debug.Log(dataPath);
        }
    }

    public void LoadFromDisk()
    {
        string dataPath = Path.Combine(Application.persistentDataPath, "savedScore.txt");

        using (StreamReader streamReader = File.OpenText(dataPath))
        {
            //get the string that we wrote to the file
            string jsonString = streamReader.ReadToEnd();

            //convert the string to an object
            Creature pinballPlayer = JsonUtility.FromJson<Creature>(jsonString);
            pinBallScore = pinballPlayer.score;
        }
    }
}

[System.Serializable]
public class Creature
{
    public string Name;
    public int score;
}
