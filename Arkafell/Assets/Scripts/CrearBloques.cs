using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearBloques : MonoBehaviour
{

    public GameObject bloquePrfb;
    public Material[] materiales;
    public GameObject Bloques;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("CrearBloques_", 0.5f);
    }

    void CrearBloques_()
    {
        CrearFilas(6);
      //  CrearIrrompibles();
    }

    void CrearFilas(int num)
    {
        for (float i = 0; i<= num; i++)
        {
            CrearFila(4-(i/2));
        }
    }

    void CrearFila(float y)
    {
        for (int i = 0; i<= 7; i++)
        {
            GameObject Bloquetemp = Instantiate(bloquePrfb, new Vector2(i- (7-i), y), Quaternion.identity);
            Bloquetemp.GetComponent<Bloque>().AplicarColor(materiales[Random.Range(0, materiales.Length)], materiales);
            Bloquetemp.transform.parent = Bloques.transform;
        }

    }

    
    //void Cambiopantalla();





    // Para cambiar a irrompibles algunos de los bloques

}
