﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bloque : MonoBehaviour
{

    public Material material;
    public Material IrrompibleColor;
    public int Puntos = 10;
    public bool Rompible = true;
    public int golpesNecesarios = 1;
    public int golpesdados = 0;
    private int total = 0;
    private int numbloques;
    private GameObject[] contarbloques;
    private int bloques;
    
    //public Material[] materiales;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.collider.tag == "pelota"&& Rompible)
        {
            golpeBloque();
        }

        
    }

   // void cambioEscena()
    //{
      //  contarbloques= GameObject.FindGameObjectsWithTag("Bloque");
        //bloques = contarbloques.Length;
        
        // numbloques = bloques;
        //if (bloques == 0)
        //{
           // Application.LoadLevel("Level2");
         //   SceneManager.LoadScene(2);
        //}

    //}


    void golpeBloque()
    {
        golpesdados += 1;

        if (golpesdados == golpesNecesarios)
        {
            Destruir();

        }

    }

    private void cambio()
    {

        if (GameObject.FindGameObjectsWithTag("Bloque").Length == 0)
        {
            SceneManager.LoadScene("2");
        }
    }
    private void Destruir()
    {
        Destroy(gameObject);
    }

    public void AplicarColor(Material material_, Material[] materiales)
    {
        GetComponent<MeshRenderer>().material = material_;
        material = material_;

        for (int i = 1; i <= materiales.Length-1; i++)
        {
            if (material == materiales[i])
            {
                Puntos = i * 10;
            }
        }
        
    }

    public void CambiarAIrrompible()
    {
       Rompible = false;
        GetComponent<MeshRenderer>().material = IrrompibleColor;
        Puntos = 0;


    }

}
