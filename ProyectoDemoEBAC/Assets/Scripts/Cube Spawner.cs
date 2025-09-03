using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject PrefabCubo;
    public List<GameObject> cubeList;
    public float FactorEscalamiento;
    public int numCubos = 0;

    // Start is called before the first frame update
    void Start()
    {
        cubeList = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        numCubos++;
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCubo);
        tempGameObject.name = "CuboNumero" + numCubos;
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
        tempGameObject.transform.position = Random.insideUnitSphere;

        cubeList.Add(tempGameObject);

        List<GameObject> CubeToDelete = new List<GameObject>();
        foreach (GameObject cube in cubeList) { 
            float scale = cube.transform.localScale.x;
            scale *= FactorEscalamiento;
            cube.transform.localScale = Vector3.one * scale;

            if (scale <= 0.1) { 
                CubeToDelete.Add(cube);
            }
        }
        foreach (GameObject cube in CubeToDelete) { 
            cubeList.Remove(cube);
            Destroy(cube);
        }
    }
}
