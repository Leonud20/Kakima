using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balance : MonoBehaviour
{
    public GameObject torso;
    public GameObject LegsObj;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
      Debug.Log(torso.transform.localRotation.z);
        if (torso.transform.rotation.z < -0.008725882)
        {
            Debug.Log("worse");
            torso.transform.Rotate(new Vector3(0, 0, 1) * 10f * Time.deltaTime);
        }
        if (torso.transform.rotation.z > 0.008725975) 
        {
            Debug.Log("better");
            torso.transform.Rotate(new Vector3(0, 0, -1) * 10f * Time.deltaTime);
        }



    }
}
