using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //print("Algo pasa");
        //Debug.Log("Sucede algo");
        //Debug.LogWarning("Tal vez hay algo malo");
        //Debug.LogError("Algo salió mal");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hola desde Update");
    }
    private void FixedUpdate()
    {
        Debug.LogWarning("Hola desde fixed Update Cada 50 Frames");
    }
    private void LateUpdate()
    {
        Debug.Log("Hola desde Late Update");
    }
    private void OnEnable()
    {
        Debug.LogWarning("El objeto ha sido habilitado");
    }

    private void OnDisable()
    {
        Debug.Log("El objeto ha sido deshabilitado");
    }
}
