using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Instantiate : MonoBehaviour
{
    public GameObject cubePreFab;

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
        Instantiate(cubePreFab);
    }

}
