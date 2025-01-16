using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Diagnostics.DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float forwardforce =2000f;
    public float sidewaysfroce =500f; 
    
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardforce * Time.deltaTime);
        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysfroce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        else if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysfroce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }



    }





    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
