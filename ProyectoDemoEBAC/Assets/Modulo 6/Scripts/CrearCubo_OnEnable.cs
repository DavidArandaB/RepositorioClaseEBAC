using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearCubo_OnEnable : MonoBehaviour
{
    public GameObject cuboEnable;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnEnable()
    {

        //Par�metros Nombre del Objeto, Posici�n, y Rotaci�n
        Instantiate(cuboEnable, new Vector3(5f, 1f, 1f), Quaternion.identity);

        /*GameObject copia = Instantiate(cuboEnable, new Vector3(5f, 1f, 1f), Quaternion.identity);
        copia.AddComponent<Rigidbody>();*/
    }
    private void OnDisable()
    {
        //Par�metros Nombre del Objeto, Posici�n, y Rotaci�n
        Instantiate(cuboEnable, new Vector3(7f, 1f, 1f), Quaternion.identity);

        /*GameObject copia = Instantiate(cuboEnable, new Vector3(7f, 1f, 1f), Quaternion.identity);
        copia.AddComponent<Rigidbody>();*/


    }
}
