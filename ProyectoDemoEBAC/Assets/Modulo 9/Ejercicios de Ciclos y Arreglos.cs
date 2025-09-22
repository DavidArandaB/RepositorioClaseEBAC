using Palmmedia.ReportGenerator.Core.Reporting.Builders.Rendering;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosdeCiclosyArreglos : MonoBehaviour
{
    //Paso 1 Creo dos arreglos de enteros (No se llenan)
    int[] Arr1= new int[5];
    int[] Arr2 = new int[5];
    int[] Arr3 = new int[5];

    //Paso 2 Arreglo de strings
    string [] palabras = new string[7] {"Escuela ", "Británica ", "de ", "Artes ", "Creativas ", "Y ", "Tecnología"};
    string juntarArray;

    //Paso 3 Inicializo dos arrays con valores para efectuar una mult. de matrices
    int[,] C1_Array = new int[2,3] { { 4, 5, 8},{ 2, 1, 9 } };
    int[] C2_Array = new int[3] { 3, 5 , 7};

    // Start is called before the first frame update
    void Start()
    {
        //Paso 1 - Lleno los primeros dos arreglos usando la función random
        for (int i = 0; i < Arr1.Length; i++) { 
            Arr1 [i] = Random.Range(1,20);
        }
        for (int i = 0; i < Arr2.Length; i++)
        {
            Arr2[i] = Random.Range(20, 40);
        }
        //Paso 1 - Hago una suma usando los elementos de ambos arrays y se guarda en el tercero
        for (int i = 0; i < Arr2.Length; i++)
        {
            Arr3[i] = Arr1[i] + Arr2[i];
            Debug.Log("Valor de posición " + i + " del array1: " + Arr1[i] + " && del array2: " + Arr2[i]);
            Debug.Log("Valor de posición " + i + " del array: " + Arr3[i]);
        }

        //Paso 2 - Operación foreach, junto los elementos del array de strings
        foreach (string pal in palabras)
        {
            juntarArray += pal;
        }
        //Imprime array entero
        Debug.Log(juntarArray);

        //Paso 3 - Empiezo con la operación de matrices
        int[] resultadoMult = new int[2];
        //Va recorriendo cada fila en cada iteración del primer array
        for (int i = 0;i < C1_Array.GetLength(0); i++)
        {
            int temp =0;
            //Recorre cada elemento de la fila
            for (int j = 0; j < C1_Array.GetLength(1); j++) {
                //Para hacer la operación, coincido la posición del array 2 con la posición que se evalua del array1
                temp += C1_Array[i,j] * C2_Array[j];
            }
            //Una vez recorridos y sumados todos los elementos, ya puedo guardar el resultado
            resultadoMult[i] = temp;
        }
        //Ciclo adicional para ver los resultados en consola
        for (int i = 0; i < resultadoMult.Length; i++) { 
            Debug.Log("Resultado "+ i +" = "+ resultadoMult[i]);
        }

    }
}
