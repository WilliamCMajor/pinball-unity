using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool rightPaddle;
    void Update()
    {
        if(rightPaddle && Input.GetKey(KeyCode.RightAlt) 
            || !rightPaddle && Input.GetKey(KeyCode.LeftAlt))
        {
            GetComponent<HingeJoint2D>().useMotor = true;
        }
        else
        {
            GetComponent<HingeJoint2D>().useMotor = false;
        }
    }
}
