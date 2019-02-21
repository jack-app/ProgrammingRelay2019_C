using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ray : MonoBehaviour
{
    public GameObject mad;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Destroy(rayposition().collider.gameObject);
        }
        if (Input.GetMouseButtonDown(0))
        {
            var temp = rayposition().point;
            Vector3Int point = new Vector3Int();
            //int型への変換
            point.x = (int)temp.x;
            point.y = (int)temp.y;
            point.z = (int)temp.z;
            Debug.Log(point);
            Instantiate(mad,point);
        }
    }
    RaycastHit rayposition()
    {
        RaycastHit hit;


        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {

        }
        return hit;
    }
}
