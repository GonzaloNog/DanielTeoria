using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicionales : MonoBehaviour
{
    public bool game = false;

    public int num1 = 10;
    public int num2 = 0;

    public string namePlayer = "pedro";

    public int dinero;
    public int edad;
    void Start()
    {
        if(num1 == num2)
        {
            Debug.Log(namePlayer);
        }
        else if(game == true)
        {
            Debug.Log("No se cumple condicion");
        }
        else
        {
            Debug.Log("No se cumple condicion");
        }

        if(edad >= 18 && dinero >= 5000)
        {

        }
    }
}
