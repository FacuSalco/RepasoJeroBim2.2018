using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowInputInText : MonoBehaviour
{

    public Text InputField;
    public Text txtInput;

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
            txtInput.text = InputField.text;
        }

        else
        {
            Debug.Log("No puede estar vacio el InputField");
        }
    }

}
