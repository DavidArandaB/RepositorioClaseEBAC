using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    //Paso 1 - Entero que se incrementará en Update y Flotante al que se aplicará *= en FixedUpdate
    int var1 = 0;
    float var2 = 1;
    //Paso 2 - Dos variables flotantes para castear como entero
    float var3, var4;
    //Paso 4 - String para sentencia Switch
    string var5;
    //Paso 5 - String para numero flotante a presición
    string var6;
    //Nombre (Paso 6)
    string miNombre = "Alberto Aranda Baltazar";
    // Paso 1B - Strings para TryParse
    string parse1 = "12347";
    string parse2 = "35451";
    // Paso 2B - String para obtener índices pares
    string toPares = "Hola Mundo";
    //Paso 3B - String para eliminar 5 primeros lugares 
    string toDelete = "Estudiando en EBAC me la paso bien";

    void Start()
    {
        //Paso 2 - Operación con casteo
        int resPaso2;
        var3 = 2.34f; var4 = 1.23456f;
        resPaso2 = (int)var3 + (int)var4;
        Debug.Log("Resultado con casteo: " + resPaso2);

        //Paso 6 - Dividir nombre en substrings
        string nombre1 = miNombre.Substring(0, 7);
        Debug.Log("Nombre substring: " + nombre1);
        string apellido1 = miNombre.Substring(8, 6);
        Debug.Log("Apellido1 substring: " + apellido1);
        string apellido2 = miNombre.Substring(15, 8);
        Debug.Log("Apellido2 substring: " + apellido2);

        //Paso 6 - Hacer un split del nombre
        string[] nombreDividido = miNombre.Split(' ');
        foreach (var name in nombreDividido)
        {
            Debug.Log("Actual Split: " + name);
        }

        //Paso 1B - Realizo Parseo, si todo sale bien, se suma
        int x1, x2, x3;
        if (int.TryParse(parse1, out x1) && int.TryParse(parse2, out x2)) { 
            x3 = x1 + x2;
            Debug.Log("Resultado Parse: " +  x3);
        }

        //Paso 2B - Recorro con un ciclo la cadena
        for (int i = 0; i < toPares.Length; i++)
        {
            if(i%2 == 0)
            {
                Debug.Log($"Índice #{i}: {toPares[i]}");
            }
        }

        //Paso 3B - Aplico la función split para eliminar un fragmento del string
        string resultToDel;
        resultToDel = toDelete.Substring(5, toDelete.Length-5);
        Debug.Log ("Borrando 5 posiciones :" + resultToDel);
    }

    // Update is called once per frame
    void Update()
    {
        //Operación paso 1 Update
        var1 += 1;
        Debug.Log("Update Var1 " + var1);
    }

    void FixedUpdate()
    {
        //Operación paso 1 Fixed Update
        var2 *= 1.2f;
        Debug.Log("Fixed Var2 " + var2);

        //Paso 3 - Modificar color de GO de acuerdo al módulo de var1

        if (var1 % 2 == 0)
        {
            GetComponent<MeshRenderer>().material.color = Color.white;
            var5 = "PAR";
            Debug.Log("Es PAR");
        }
        else { GetComponent<MeshRenderer>().material.color = Color.black; var5 = "IMPAR"; Debug.Log("Es IMPAR"); }

        //Paso 4 - Modificar color de GO de acuerdo a string con statement Switch
        switch (var5)
        {
            case "PAR":
                GetComponent<MeshRenderer>().material.color = Color.white;
                break;
            case "IMPAR":
                GetComponent<MeshRenderer>().material.color = Color.black;
                break;
        }

        //Paso 5 - Convierte el resultado de var2 (Paso 2) y lo guardo en string con 4 decimales
        var6 = var2.ToString("F4");
        Debug.Log("Resultado Paso 5: " + var6);

    }
}
