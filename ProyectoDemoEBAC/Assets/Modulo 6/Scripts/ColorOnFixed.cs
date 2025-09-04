using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorOnFixed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Cambiando el color desde FixedUpdate en este objeto: " + gameObject.name);
    }

    //Fixed Update cada 50 frames
    private void FixedUpdate()
    {
        Color c = new Color(Random.value, Random.value, Random.value);
        GetComponent<MeshRenderer>().material.color = c;
    }
}
