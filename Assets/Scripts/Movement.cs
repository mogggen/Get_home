using UnityEngine;

public class Movement : MonoBehaviour {

    public float moveSpeed;
    public Rigidbody rb;

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(new Vector3(0, 0, moveSpeed * Time.fixedDeltaTime), ForceMode.VelocityChange);
            //rb.useGravity = false;
        }
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(new Vector3(-moveSpeed * Time.fixedDeltaTime, 0, 0), ForceMode.VelocityChange);
            //rb.useGravity = false;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.AddForce(new Vector3(0, 0, -moveSpeed * Time.fixedDeltaTime), ForceMode.VelocityChange);
            //rb.useGravity = false;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(new Vector3(moveSpeed * Time.fixedDeltaTime, 0, 0), ForceMode.VelocityChange);
            //rb.useGravity = false;
        }
        
        else if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
        {
            rb.AddForce(Vector3.zero);
            //rb.useGravity = true;
        }
    }
}