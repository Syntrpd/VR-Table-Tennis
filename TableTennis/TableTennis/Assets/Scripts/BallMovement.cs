using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float fwdForce, upForce, latForce;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 force = new Vector3(-fwdForce, upForce, latForce);
        rb.AddForce(force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move(Vector3 force)
    {
        rb.AddForce(force);
    }
}
