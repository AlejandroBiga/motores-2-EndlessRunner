using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountManager : MonoBehaviour
{

    public static int lastCount;

    // marca el ultimo numero de la cuenta de score y la muestro
    public static void SetLastCount(int count)
    {
        lastCount = count;
    }

    void Start()
    {
        // el metodo de DontDestroyOnLoad me asegura que no se borre el numero de la cuenta de puntos al cargar la otra escena
        DontDestroyOnLoad(gameObject);
    }
}
