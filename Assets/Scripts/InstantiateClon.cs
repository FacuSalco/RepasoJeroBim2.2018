using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstantiateClon : MonoBehaviour
{

    public GameObject cube;
    int cantidad = 0;
    GameObject clone;
    public Text clonemaxamount;
    public Text lbl;
    int clonea;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clonar()
    {
        if (clonemaxamount.text != "")
        {

            clonea = (int.Parse(clonemaxamount.text));

            if (cantidad < clonea)
            {

                clone = Instantiate(cube);
                cantidad++;
                lbl.text = (clonea - cantidad).ToString();

            }
            else
            {
                lbl.text = ("Ya ingreso la cantidad maxima");
            }
        }
        else
        {
            lbl.text = ("Ingrese una cantidad valida");
        }
    }


}
