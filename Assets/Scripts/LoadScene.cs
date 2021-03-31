using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void LoadSceneByIndex(int sceneIndex)
    {
        Debug.Log("load scene 1");
        SceneManager.LoadScene(sceneIndex);
    }

}