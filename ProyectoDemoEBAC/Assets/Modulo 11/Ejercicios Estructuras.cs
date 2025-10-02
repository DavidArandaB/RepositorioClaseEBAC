using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EjerciciosEstructuras : MonoBehaviour
{
    //Realizo las funciones por separado, las pruebo en la función Start de Unity
    //Función de Paso 1 - Lista Aleatoria
    public List<int> creaLista(int tamañoLista, int MinNumber, int MaxNumber)
    {
        //Obtengo los parámetros, itero de acuerdo a valor de tamañoLista
        List<int> ListaRandom = new List<int>();
        for (int i = 0; i < tamañoLista; i++)
        {
            //Añado número random entre MinNumber y MaxNumber
            ListaRandom.Add(Random.Range(MinNumber, MaxNumber));
        }
        return ListaRandom;
    }
    //Funcion Paso 2 - Orden descendente
    public List<int> OrdenaNumeros(List<int> oldList)
    {
        //Obtiene el arreglo, "clono" el arreglo haciendo uno nuevo e igualando el resultado
        List<int> ListaOrdenada = oldList;
        //Función Sort deja ordenado, pero de forma ascendente
        ListaOrdenada.Sort();
        //Función Reverse invierte el orden de los elementos, cambiando a un orden descendente
        ListaOrdenada.Reverse();
        return ListaOrdenada;
    }

    //Función Paso 3 - Hashset en base a lista
    //Una función trabaja con ints, la otra con strings
    public HashSet<int> ElementosdeLista(List<int> oldList)
    {
        HashSet<int> nuevoHash = new HashSet<int>();
        foreach (int i in oldList) {
            //Si no se ha insertado el valor anteriormente, se inserta ahora
            if (!nuevoHash.Contains(i))
            {
                nuevoHash.Add(i);
            }
            else { Debug.Log("Este valor ya existe en el HashSet"); }
        }
        return nuevoHash;
    }
    public HashSet<string> ElementosdeLista(List<string> oldList)
    {
        HashSet<string> nuevoHash = new HashSet<string>();
        foreach (string i in oldList)
        {
            //Si no se ha insertado el valor anteriormente, se inserta ahora
            if (!nuevoHash.Contains(i))
            {
                nuevoHash.Add(i);
            }
            else { Debug.Log("Este valor ya existe en el HashSet"); }
        }
        return nuevoHash;
    }

    //Función Paso 4 Llena una Cola en Base a una Pila
    public void Pila_and_Lista(Stack<string> oldStack)
    {
        Queue<string> nuevaFila = new Queue<string>();
        Debug.Log("--- Empieza la Pila --- ");
        while (oldStack.Count > 0) {
            //Guardo el elemento en un temporal haciendo un Peek
            string temp = oldStack.Peek();
            //Guardo en fila con un Enqueue e imprimo valor en consola
            nuevaFila.Enqueue(temp);
            Debug.Log("Elemento de Pila: " + temp);
            //Descarto el elemento actual con un Pop
            oldStack.Pop();
        }
        Debug.Log("--- Empieza la Cola --- ");
        while (nuevaFila.Count > 0)
        {
            //Guardo el elemento en un temporal haciendo un Peek e imprimo
            string temp = nuevaFila.Peek();
            Debug.Log("Elemento de Pila: " + temp);
            //Descarto el elemento actual con un Dequeue
            nuevaFila.Dequeue();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        List<int> ListaPrueba = creaLista(6, 2, 30);
        Debug.Log("Lista Prueba Función creaLista");
        foreach (int i in ListaPrueba)
        {
            Debug.Log(i);
        }
        Debug.Log("--------------------------------------------");
        List<int> PruebaOrdenada = OrdenaNumeros(ListaPrueba);
        Debug.Log("Lista Prueba Función OrdenaNumeros");
        foreach (int i in PruebaOrdenada)
        {
            Debug.Log(i);
        }
        List<int> ListaS3int = new List<int> { 1, 2, 2, 4, 4, 6 };
        HashSet<int> convertints = ElementosdeLista(ListaS3int);
        Debug.Log("--- Función ElementosdeLista INT ---");
        foreach (int i in convertints)
        {
            Debug.Log(i);
        }
        List<string> ListaS3string = new List<string> { "uno", "dos", "dos", "cuatro", "cuatro", "seis" };
        HashSet<string> convertstrings = ElementosdeLista(ListaS3string);
        Debug.Log("--- Función ElementosdeLista STRING ---");
        foreach (string i in convertstrings)
        {
            Debug.Log(i);
        }
        Stack<string> stack = new Stack<string>();
        stack.Push("UNO");
        stack.Push("DOS");
        stack.Push("TRES");
        stack.Push("CUATRO");
        stack.Push("CINCO");
        stack.Push("SEIS");
        stack.Push("SIETE");
        Pila_and_Lista(stack);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
