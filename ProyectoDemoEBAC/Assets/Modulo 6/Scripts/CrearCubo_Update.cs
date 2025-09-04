using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearCubo_Update : MonoBehaviour
{
    public GameObject cuboUpdate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Parámetros Nombre del Objeto, Posición, y Rotación
        Instantiate(cuboUpdate, new Vector3(-19f, 7f, 21f), Quaternion.identity);


        /*GameObject copia = Instantiate(cuboUpdate, new Vector3(-19f, 7f, 21f), Quaternion.identity);
        copia.AddComponent<Rigidbody>();*/
    }
}
