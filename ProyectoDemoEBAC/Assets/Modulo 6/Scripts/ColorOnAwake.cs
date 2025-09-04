using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorOnAwake : MonoBehaviour
{
    //Awake antes de función Start
    private void Awake()
    {
        Color c = new Color(Random.value, Random.value, Random.value);
        GetComponent<MeshRenderer>().material.color = c;
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Cambiando el color desde Awake en este objeto: " + gameObject.name);
    }

}
