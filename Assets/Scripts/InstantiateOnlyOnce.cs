using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateOnlyOnce : MonoBehaviour
{

    public GameObject cubePreFab;
    int cantidad;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InstantiatePreFab()
    {
        while (cantidad == 0)
        {
            Instantiate(cubePreFab);
            cantidad++;
        }
        
    }

}
