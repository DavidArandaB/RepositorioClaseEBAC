using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooleanCubo2 : MonoBehaviour
{
    //Declaro la variable pero esta vez la fuerzo a empezar como true
    public bool varBooleana = true;
    // Start is called before the first frame update
    void Start()
    {

    }


    private void FixedUpdate()
    {
        //Realizo operación unaria usando el estado del bool
        //True= Blanco ; False = Negro
        GetComponent<MeshRenderer>().material.color = (varBooleana) ? Color.white : Color.black;
        Debug.Log("Valor de Cubo 2 " + varBooleana);
        //Niego la variable booleana para cambiar el valor
        varBooleana = !varBooleana;
    }
}
