 
using UnityEngine;

public class ball_movement : MonoBehaviour
{
    public Rigidbody Rb; 
    // Start is called before the first frame update
    void Start()
    {
        Rb.useGravity = true;
        Rb.AddForce(0, 49, 50);
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Rb.AddForce(0,0,100*Time.deltaTime);
    }
}
 