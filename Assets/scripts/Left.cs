using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Left : MonoBehaviour
{
    public GameObject Down;

    public GameObject up;
    public GameObject rot;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(up.transform.localRotation.z);
        
            if (Input.GetKey(KeyCode.UpArrow) && up.transform.localRotation.z < 0.7071068)
            {

                up.transform.Rotate(new Vector3(0, 0, 2) * 15f * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.DownArrow) && up.transform.localRotation.z > -0.3502073)
            {
                rot.transform.Rotate(new Vector3(0, 0, -2) * 15f * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.RightArrow) && Down.transform.localRotation.z > -0.7071068)
            {
                Down.transform.Rotate(new Vector3(0, 0, -2) * 15f * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.LeftArrow) && Down.transform.localRotation.z < 0)
            {
                Down.transform.Rotate(new Vector3(0, 0, 2) * 15f * Time.deltaTime);
            }
        
    }

}

