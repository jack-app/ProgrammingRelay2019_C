using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
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
            Vector3Int point = new Vector3Int();
            RaycastHit hit = rayposition();
            var temp = hit.transform.position;
            //int型への変換
            point.x = Mathf.RoundToInt(temp.x);
            point.y = Mathf.RoundToInt(temp.y);
            point.z = Mathf.RoundToInt(temp.z);

            float deltax = hit.point.x - hit.transform.position.x;
            float deltay = hit.point.y - hit.transform.position.y;
            float deltaz = hit.point.z - hit.transform.position.z;
            float deltamax = Mathf.Max(Mathf.Abs(deltax), Mathf.Abs(deltay), Mathf.Abs(deltaz));
            Debug.Log("x" + deltax);
            Debug.Log("y" + deltay);
            Debug.Log("z" + deltaz);
            Debug.Log("max" + deltamax);


            if (deltamax == Mathf.Abs(deltax))
            {
                if (deltax > 0)
                {
                    point.x += 1;
                }
                else
                {
                    point.x -= 1;
                }
            }
            if (deltamax == Mathf.Abs(deltay))
            {
                if (deltay > 0)
                {
                    point.y += 1;
                }
                else
                {
                    point.y -= 1;
                }
            }
            if (deltamax == Mathf.Abs(deltaz))
            {
                if (deltaz > 0)
                {
                    point.z += 1;
                }
                else
                {
                    point.z -= 1;
                }
            }

            Debug.Log(point);
            Instantiate(mad,point, Quaternion.identity);
        }
    }

    RaycastHit rayposition()
    {
        RaycastHit hit;
        
        if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity))
        {
            
        }
        return hit;
    }
}
