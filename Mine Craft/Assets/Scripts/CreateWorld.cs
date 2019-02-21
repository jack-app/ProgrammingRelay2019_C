using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWorld : MonoBehaviour
{

    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
       
        for(int i = -5; i < 5; i++)
        {
            for(int j = -5; j < 5; j++)
            {
                Instantiate(prefab,new Vector3(i,0,j) , Quaternion.identity);
            }
        }
    }

    
}
