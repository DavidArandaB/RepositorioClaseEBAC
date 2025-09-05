using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooleanOnFixedUp : MonoBehaviour
{
    public bool FixedUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void FixedUpdate()
    {
        GetComponent<MeshRenderer>().material.color = (FixedUp) ? Color.white : Color.black;
        FixedUp = !FixedUp;
    }
}
