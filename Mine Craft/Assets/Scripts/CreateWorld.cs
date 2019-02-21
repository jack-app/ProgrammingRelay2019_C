using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWorld : MonoBehaviour
{

    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
       
        for(int i = -50; i < 50; i++)
        {
            for(int j = -50; j < 50; j++)
            {
                Instantiate(prefab,new Vector3(i,0,j) , Quaternion.identity);
            }
        }
    }

    
}
