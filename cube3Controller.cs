using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube3Controller : MonoBehaviour
{
    float x;
    float z;
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

    }
    void OnMouseDown()
    {
        x = Random.Range(-3f,5f);
        z = Random.Range(-6.5f,2.5f);
        Instantiate(cylinder.gameObject, new Vector3(x,5.5f,z), cylinder_tr.rotation);

    }
}
