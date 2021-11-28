using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightUp : MonoBehaviour
{
    public GameObject Down;

    public GameObject up;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKey(KeyCode.W) && up.transform.localRotation.z < 0.7071068)
        {
           
            up.transform.Rotate(new Vector3(0, 0, 2) * 15f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) && up.transform.localRotation.z > -0.3502073)
        {
            up.transform.Rotate(new Vector3(0, 0, -2) * 15f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A) && Down.transform.localRotation.z > -0.7071068)
        {
            Down.transform.Rotate(new Vector3(0, 0, -2) * 15f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D)  && Down.transform.localRotation.z < 0)
        {
            Down.transform.Rotate(new Vector3(0, 0, 2) * 15f * Time.deltaTime);
        }
    }
}

