using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotNewRight : MonoBehaviour
{
    // Interpolates rotation between the rotations
    // of from and to.
    // (Choose from and to not to be the same as
    // the object you attach this script to)

   public Transform from;
  public   Transform to;
    float speed = 0.1f;
    void Update()
    {
        transform.rotation = Quaternion.Lerp(from.rotation, to.rotation, Time.time * speed);
    }

}
