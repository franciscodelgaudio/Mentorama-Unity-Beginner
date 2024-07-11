using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculate : MonoBehaviour
{
    public double valor;
    private int x;

    private void Start()
    {
        x = (int) (valor / 200);
        valor = valor - (x * 200);
        Debug.Log(x + " Notas de 200 reais");
        
        x = (int) (valor / 100);
        valor = valor - (x * 100);
        Debug.Log(x + " Notas de 100 reais");

        x = (int) (valor / 50);
        valor = valor - (x * 50);
        Debug.Log(x + " Notas de 50 reais");

        x = (int) (valor / 20);
        valor = valor - (x * 20);
        Debug.Log(x + " Notas de 20 reais");

        x = (int) (valor / 10);
        valor = valor - (x * 10);
        Debug.Log(x + " Notas de 10 reais");

        x = (int) (valor / 5);
        valor = valor - (x * 5);
        Debug.Log(x + " Notas de 5 reais");

        x = (int) (valor / 2);
        valor = valor - (x * 2);
        Debug.Log(x + " Notas de 2 reais");

        x = (int) (valor / 1);
        valor = valor - (x * 1);
        Debug.Log(x + " Moedas de 1 real");

        x = (int) (valor / 0.50) ;
        valor = valor - (x * 0.50);
        Debug.Log(x + " Moedas de 50 centavos");

        x = (int) (valor / 0.25);
        valor = valor - (x * 0.25);
        Debug.Log(x + " Moedas de 25 centavos");

        x = (int) (valor / 0.10);
        valor = valor - (x * 0.10);
        Debug.Log(x + " Moedas de 10 centavos");

        x = (int) (valor / 0.05);
        valor = valor - (x * 0.05);
        Debug.Log(x + " Moedas de 5 centavos");

        x = (int) (valor / 0.01);
        valor = valor - (x * 0.01);
        Debug.Log(x + " Moedas de 1 centavo");
    }
}
