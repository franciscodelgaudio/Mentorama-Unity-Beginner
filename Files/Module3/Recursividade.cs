using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recursividade : MonoBehaviour
{
    [Header("Fatorial")]
    [SerializeField] int fatorial = 5;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("O Fatorial de " + fatorial + " eh " + Fatorial(fatorial));
    }

    private int Fatorial (int x)
    {
        if (x == 1) return 1;
        x *= Fatorial(x - 1);
        return x;
    }
}
