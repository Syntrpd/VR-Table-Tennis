using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawnThrow : MonoBehaviour
{
    public Transform BatTransfom;
    public GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        GameObject ball=GameObject.Instantiate(go, gameObject.transform);
        Vector3 dir = BatTransfom.position - transform.position;
        dir = dir.normalized;

        ball.GetComponent<BallMovement>().Move(dir * 1000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
