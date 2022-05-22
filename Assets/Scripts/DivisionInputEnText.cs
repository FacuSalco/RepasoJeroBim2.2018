using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DivisionInputEnText : MonoBehaviour
{

    public Text dividendo;
    public Text textholder;
    public Text textlbl;
    int divi;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // ESTE ES EL QUE HICE Y NO ANDUVO
    //public void Division()
    //{

    //    if (InputField1.text != "" && (int.Parse(InputField1.text)) != 0 && InputField2.text != "" && (int.Parse(InputField2.text)) != 0)
    //    {
    //        division = (int.Parse(InputField1.text)) / (int.Parse(InputField2.text));

    //        txtDivision.text = (division.ToString());

    //    }

    //    else if ((int.Parse(InputField2.text)) == 0)
    //    {
    //        txtDivision.text = ("No se puede dividir por 0");
    //    }

    //    else if (InputField2.text == "" || InputField1.text == "")
    //    {
    //        txtDivision.text = ("Ingrese algun numero");
    //    }
    //}

    public void division()
    {
        if (textholder.text != "" && (int.Parse(textholder.text)) != 0)
        {
            divi = (int.Parse(dividendo.text)) / (int.Parse(textholder.text));

            textlbl.text = (divi.ToString());

        }
        else if (textholder.text == "")
        {
            textlbl.text = ("Error, ingrese algun valor");
        }

        else if ((int.Parse(textholder.text)) == 0)
        {
            textlbl.text = ("Error, no se puede divir entre 0");
        }
    }
}


