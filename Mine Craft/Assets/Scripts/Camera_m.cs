using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_m : MonoBehaviour
{

    // Update is called once per frame
    void LateUpdate()
    {
        Input.GetAxis("Mouse X");
        Input.GetAxis("Mouse Y");
    }
}
