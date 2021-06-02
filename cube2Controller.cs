using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube2Controller : MonoBehaviour
{
    float x;
    float z;
    // Start is called before the first frame update
    Transform cube_tr;
    void Start()
    {
        cube_tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            x = Random.Range(-3f,5f);
            z = Random.Range(-6.5f,2.5f);
            Instantiate(gameObject, new Vector3(x,5f,z), cube_tr.rotation);
        }
    }
}

