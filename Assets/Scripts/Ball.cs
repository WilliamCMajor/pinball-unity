using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Color colorStart = new Color32(250, 215, 95, 98);
    Color colorEnd = new Color32(250, 91, 69, 98);
    float duration = 0.5f;
    Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    public void OnCollisionEnter2D(Collision2D collision)
    {
        float lerp = Mathf.PingPong(Time.time, duration) / duration;
        rend.material.color = Color.Lerp(colorStart, colorEnd, lerp);

        if (collision.gameObject.tag == "BumperBlack")
        {
            FindObjectOfType<GameState>().updateBumperBlackScore();
        }
        else if (collision.gameObject.tag == "BumperOrange")
        {
            FindObjectOfType<GameState>().updateBumperOrangeScore();
        }
        else if (collision.gameObject.tag == "BumperGreen")
        {
            FindObjectOfType<GameState>().updateBumperGreenScore();
        }
    }

}
