using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperacionAnd : MonoBehaviour
{
    //Busco la referencia al script de FixedUpdate
    public BooleanOnFixedUp refScriptFixed;
    //Busco la referencia al script de BooleanTrue
    public BooleanTrue refScriptTrue;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void FixedUpdate()
    {   
        //Realizo el AND, si es true se pinta de blanco, si no, de negro
        if (refScriptFixed.FixedUp && refScriptTrue.bTrue) GetComponent<MeshRenderer>().material.color = Color.white;
        else GetComponent<MeshRenderer>().material.color = Color.black;
    }
}
