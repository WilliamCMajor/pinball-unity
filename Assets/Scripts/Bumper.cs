using UnityEngine;

public class Bumper : MonoBehaviour
{
    public float bumperForce;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D ballRigidBody;
        //ballRigidBody = collision.gameObject.GetComponent<Rigidbody2D>();
        ballRigidBody = collision.rigidbody;
        ballRigidBody.AddForce(bumperForce * collision.relativeVelocity);

        //Best Practice: never use transform.Translate() with a dynamic rigidbody;

    }
}
