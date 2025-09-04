using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearCubo : MonoBehaviour
{
    public GameObject cuboAwake;
    private void Awake()
    {
        //Inicializo el objeto
        //Parámetros Nombre del Objeto, Posición, y Rotación

        Instantiate(cuboAwake, new Vector3(0.5f, 1f, 1f), Quaternion.identity);
        /*GameObject copia = Instantiate(cuboAwake, new Vector3(0.5f, 1f, 1f), Quaternion.identity);
        copia.AddComponent<Rigidbody>();*/

    }
    // Start is called before the first frame update
    void Start()
    {

    }

}
