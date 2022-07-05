using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegionSpawner : MonoBehaviour
{
    public GameObject go;
    GameObject reg;
    bool flag;

    public float t;

    // Start is called before the first frame update
    void Start()
    {
        flag = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (flag)
        {
            float xPos = Random.Range(-2.24f, -0.33f);
            float zPos = Random.Range(-1.73f, 1.72f);
            Vector3 pos = new Vector3(xPos,1.58f,zPos);
            Quaternion q = new Quaternion();
            reg = Instantiate(go, pos, q);
            flag = false;
            StartCoroutine(regionSpawning());

        }
    }

    IEnumerator regionSpawning()
    {
        yield return new WaitForSeconds(t);
        flag = true;
        Destroy(reg);
    }
}
