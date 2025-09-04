using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearCubo : MonoBehaviour
{
    GameObject objToSpawn;
    Vector3[] vertices =
    {
        new Vector3(0,0,0),
        new Vector3(1,0,0),
        new Vector3(1,1,0),
        new Vector3(0,1,0),
        new Vector3(0,1,1),
        new Vector3(1,1,1),
        new Vector3(1,0,1),
        new Vector3(0,0,1),

    };

    int[] triangulos =
    {
        0, 2, 1,
        0, 3 ,2,
        2, 3, 4,
        2, 4, 5,
        1, 2, 5,
        1, 5, 6,
        0, 7, 4,
        0, 4, 3,
        5, 4, 7,
        5, 7, 6,
        0, 6, 7,
        0, 1, 6
    };
    private void Awake()
    {
        //Inicializo el objeto
        objToSpawn = new GameObject("CubeOnAwake");
        //Mesh Filter va a darle una forma al objeto (Aquí forma de cubo)
        objToSpawn.AddComponent<MeshFilter>();
        var meshfilter = objToSpawn.GetComponent<MeshFilter>().mesh;
        meshfilter.Clear();
        //Usamos los parámetros de arriba para formar la figura
        meshfilter.vertices = vertices;
        meshfilter.triangles = triangulos;
        meshfilter.Optimize();
        meshfilter.RecalculateNormals();
        //Colisionador y RigidBody
        objToSpawn.AddComponent<BoxCollider>();
        objToSpawn.AddComponent<Rigidbody>();
        var boxCollider = objToSpawn.GetComponent<BoxCollider>();
        //Queda para coincidir con la forma 
        boxCollider.center = new Vector3(0.5f, 0.5f, 0.5f);
        //Se le da una textura o color
        objToSpawn.AddComponent<MeshRenderer>();
        var meshRendererMaterial = objToSpawn.GetComponent<MeshRenderer>().material;
        meshRendererMaterial.color = Color.red;
        //Movemos a la posición 1,1,1
        objToSpawn.transform.position = new Vector3(1f,2f,-1.5f);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

}
