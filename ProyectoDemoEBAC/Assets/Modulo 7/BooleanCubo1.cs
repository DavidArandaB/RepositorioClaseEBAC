using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooleanCubo1 : MonoBehaviour
{
    //Declaro la variable pero no le hago nada
    //Por tanto inicia como false
    public bool varBooleana;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void FixedUpdate()
    {
        //Realizo operación unaria usando el estado del bool
        //True= Blanco ; False = Negro
        GetComponent<MeshRenderer>().material.color = (varBooleana) ? Color.white : Color.black;
        Debug.Log("Valor de Cubo 1 " + varBooleana);
        //Niego la variable booleana para cambiar el valor
        varBooleana = !varBooleana;
    }
}
