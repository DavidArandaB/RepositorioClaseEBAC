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

        //Parámetros Nombre del Objeto, Posición, y Rotación
        Instantiate(cuboEnable, new Vector3(5f, 1f, 1f), Quaternion.identity);

        /*GameObject copia = Instantiate(cuboEnable, new Vector3(5f, 1f, 1f), Quaternion.identity);
        copia.AddComponent<Rigidbody>();*/
    }
    private void OnDisable()
    {
        //Parámetros Nombre del Objeto, Posición, y Rotación
        Instantiate(cuboEnable, new Vector3(7f, 1f, 1f), Quaternion.identity);

        /*GameObject copia = Instantiate(cuboEnable, new Vector3(7f, 1f, 1f), Quaternion.identity);
        copia.AddComponent<Rigidbody>();*/


    }
}
