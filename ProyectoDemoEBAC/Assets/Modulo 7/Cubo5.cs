using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo5 : MonoBehaviour
{
    public BooleanCubo1 CuboUno;
    public BooleanCubo2 CuboDos;
    public IfCubo3AND CuboTres;
    public IfCubo4OR CuboCuatro;
    bool varBooleana;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        //Realizo la un AND del cubo UNO y TRES , un AND del cubo DOS y CUATRO
        //A estos 2 resultados les hago un OR
        varBooleana = ((CuboUno.varBooleana || CuboTres.varBooleana) && (CuboDos.varBooleana || CuboCuatro.varBooleana)) ? true : false;
        //Luego, hago el if con el resultado
        if (varBooleana)
        {
            GetComponent<MeshRenderer>().material.color = Color.white;
        }
        else
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
        }
    }
}
