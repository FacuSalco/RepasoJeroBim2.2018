using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CuentaInputEnText : MonoBehaviour
{

    public Text InputField;
    public Text txtInput;
    int multiplicacion;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowInText()
    {
        
        if (InputField.text != "")
        {
            multiplicacion = (int.Parse(InputField.text)) * (int.Parse(InputField.text));

            txtInput.text = (multiplicacion.ToString());
        }

        else
        {
            Debug.Log("No puede estar vacio el InputField");
        }
    }

}
