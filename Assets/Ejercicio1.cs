using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{

    public bool encendido = true;
    public float numero1 = 8.45f;
    public float numero2 = 6.09f;
    public string operaciones = "null";
    private float resultado;
    private bool resultadoOperacion = true;
    void Start()
    {
        if (encendido == true)
        {
            switch (operaciones)
            {
                case "suma":
                    //Debug.Log(numero1 + numero2);
                    //numero1 += numero2;
                    //Debug.Log(numero1);
                    resultado = numero1 + numero2;
                    

                    break;
                case "resta":
                    resultado = numero1 - numero2;

                    break;
                case "multiplicar":
                    resultado = numero1 * numero2;

                    break;
                case "dividir":
                    resultado = numero1 / numero2;

                    break;
                default:
                    Debug.Log("Operación no disponible");
                    resultadoOperacion =false;

                    break;
            }
            if (resultadoOperacion ==true)
            {
                Debug.Log(resultado);
            }
            
        }
        else
        {
            Debug.Log("Apagada");
        }
    }

    void Update()
    {
        
    }
}
