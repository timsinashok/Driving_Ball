 
using UnityEngine;

public class ball_movement : MonoBehaviour
{
    public Rigidbody Rb; 
    // Start is called before the first frame update
    void Start()
    {
        Rb.useGravity = true;
        Rb.AddForce(0, 0, 0);
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Rb.AddForce(0,0,0);

        if(Input.GetKey(KeyCode.LeftArrow)){
            Rb.AddForce(0, 0, 0);
        }

        if(Input.GetKey(KeyCode.RightArrow)){
            Rb.AddForce(0, 0, 0);
        }

        if(Input.GetKey(KeyCode.UpArrow)){
            Rb.AddForce(0, 50, 30);
        }

        if(Input.GetKey(KeyCode.DownArrow)){
            Rb.AddForce(0, -45, -45);
        }

    }
}
 