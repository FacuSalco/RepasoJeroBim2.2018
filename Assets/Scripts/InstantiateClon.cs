using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstantiateClon : MonoBehaviour
{

    public GameObject cubePrefab;
    public Text maxcant;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InstantiateTheClone()
    {
        GameObject clon;

        for (int i = 0; i < (int.Parse(maxcant.text)); i++)
        {
            clon = Instantiate (cubePrefab);
        }
        


    }

}
