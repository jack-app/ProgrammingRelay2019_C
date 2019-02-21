using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_m : MonoBehaviour
{
    public Transform body;
    // Update is called once per frame
    void LateUpdate()
    {
        body.transform.eulerAngles += new Vector3(0,10 * Input.GetAxis("Mouse X"));
        transform.eulerAngles += new Vector3 (-10 *Input.GetAxis("Mouse Y"),0);
    }
}
