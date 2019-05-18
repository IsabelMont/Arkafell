using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suelo : MonoBehaviour
{
    public Vector2 posInicial;
    public GameObject pelota;
    public GameObject racket;
    private Rigidbody2D rkPelota;
    public Racket RacketScript;



    void Start()
    {
        posInicial = pelota.transform.position;
        rkPelota = pelota.GetComponent<Rigidbody2D>();
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "pelota")
        {
            //Cuando la pelota toque el suelo, la devolvemos a su posición inicial.
            pelota.transform.position = new Vector3(posInicial.x+racket.transform.position.x, pelota.transform.position.y+2.0f, pelota.transform.position.z); 

            //Le quitamos la velocidad a la pelota para que empiece desde cero.
            pelota.GetComponent<Rigidbody2D>().velocity = Vector2.zero;

            rkPelota.isKinematic = true;

            //Cambiamos el valor de pelotaMuerta a true para saber que esta muerta.
            RacketScript.pelotaMuerta = true;
        }
    }


}
