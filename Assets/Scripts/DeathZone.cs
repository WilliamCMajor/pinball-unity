using UnityEngine;
using System.Collections;
public class DeathZone : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform spawnPoint;

    void OnTriggerEnter2D(Collider2D collider)
    {
        FindObjectOfType<GameState>().updatePlayerLifes();
        StartCoroutine(Wait(collider));
        
    }
    IEnumerator Wait(Collider2D collider)
    {
        yield return new WaitForSeconds(1);
        //Instantiate(ballPrefab, spawnPoint.position, spawnPoint.rotation);
        collider.transform.position = spawnPoint.position;
        collider.GetComponent<Rigidbody2D>().velocity = Vector3.zero;

    }

}
