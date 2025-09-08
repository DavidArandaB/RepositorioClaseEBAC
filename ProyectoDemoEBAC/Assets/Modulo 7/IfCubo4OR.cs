using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfCubo4OR : MonoBehaviour
{
    //Referencias a los scripts para checar los valores bool
    public BooleanCubo1 CuboUno;
    public BooleanCubo2 CuboDos;
    public bool varBooleana;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        ///Realizo la Operación OR para definir el resultado de el bool local
        varBooleana = (CuboUno.varBooleana || CuboDos.varBooleana) ? true : false;
        //Luego, hago el if con el resultado
        if (varBooleana)
        {
            GetComponent<MeshRenderer>().material.color = Color.white;
        }
        else { GetComponent<MeshRenderer>().material.color = Color.black; }

    }
}
