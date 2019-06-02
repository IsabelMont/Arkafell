using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crearbloques2_ : MonoBehaviour
{


        public GameObject bloquePrfb;
        public Material[] materiales;
        public GameObject Bloques;

        // Start is called before the first frame update
        void Start()
        {
            Invoke("CrearBloques2_", 0.5f);
        }

        void CrearBloques2_()
        {
            CrearFilas(6);
            CrearIrrompibles();
        }

        void CrearFilas(int num)
        {
            for (float i = 0; i <= num; i++)
            {
                CrearFila(4 - (i / 2));
            }
        }

        void CrearFila(float y)
        {
            for (int i = 0; i <= 7; i++)
            {
                
                GameObject Bloquetemp = Instantiate(bloquePrfb, new Vector2(i - (7 - i*1), y), Quaternion.identity);
                Bloquetemp.GetComponent<Bloque>().AplicarColor(materiales[Random.Range(0, materiales.Length)], materiales);
                Bloquetemp.transform.parent = Bloques.transform;
            }

        }

       void CrearIrrompibles() {
        GameObject[] bloques = GameObject.FindGameObjectsWithTag("Bloque");



        for (int i = 0; i< bloques.Length; i++)
        {
            int aleatorio = Random.Range(0, 10);
            if (aleatorio == 1)
             {
                bloques[i].GetComponent<Bloque>().CambiarAIrrompible();
             }
        }
       }

    //void Cambiopantalla();





    // Para cambiar a irrompibles algunos de los bloques
    // void CrearIrrompibles()
    //{
    //  GameObject[] bloques = GameObject.FindGameObjectsWithTag("Bloque");



    //for (int i = 0; i< bloques.Length; i++)
    //  {
    // int aleatorio = Random.Range(0, 10);
    //  if (aleatorio == 1)
    // {
    //  bloques[i].GetComponent<Bloque>().CambiarAIrrompible();
    // }

    //  }

    // }


}
