using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorOn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Cambiando el color desde Update en este objeto: " + gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        Color c = new Color(Random.value, Random.value, Random.value);
        GetComponent<MeshRenderer>().material.color = c;
    }
}
