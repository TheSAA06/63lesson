using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube4Controller : MonoBehaviour
{
    public GameObject cylinder;
    // Start is called before the first frame update
    Transform cube_tr;
    Transform cylinder_tr;
    void Start()
    {
        cube_tr = GetComponent<Transform>();
        cylinder_tr = cylinder.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            cube_tr.Translate(0,0,1f);
        }
        if (Input.GetKeyDown("a"))
        {
            cube_tr.Translate(-1f,0,0);
        }
        if (Input.GetKeyDown("d"))
        {
            cube_tr.Translate(1f,0,0);
        }
        if (Input.GetKeyDown("s"))
        {
            cube_tr.Translate(0,0,-1f);
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "cylinder")
        {
            Destroy(cylinder.gameObject);
            Instantiate(gameObject, new Vector3(4f,5.5f,0f), cube_tr.rotation);
        }
    }
}
