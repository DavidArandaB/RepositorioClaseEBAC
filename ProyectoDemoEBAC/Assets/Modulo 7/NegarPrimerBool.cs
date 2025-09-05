using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NegarPrimerBool : MonoBehaviour
{
    //Busco la referencia al script de FixedUpdate
    public BooleanOnFixedUp refScriptFixed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        //Recibo el valor y lo niego
        bool changeFixed = !refScriptFixed.FixedUp;
        //Al estar negado, el color mostrado será el opuesto al del cubo de la func. Fixed
        GetComponent<MeshRenderer>().material.color = (changeFixed) ? Color.white : Color.black;
    }
}
