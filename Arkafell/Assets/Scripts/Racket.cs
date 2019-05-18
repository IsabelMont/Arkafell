using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
    // Le damos valor a la velocidad

    public float speed = 10;
    public float forced = 2000;
    private Rigidbody2D rk;
    public float velPelota = 10;
    //Referencia a pelota
    public GameObject pelota;
    private Rigidbody2D rkPelota;

    public bool pelotaMuerta = true;

    void Awake()
    {
        rk = GetComponent<Rigidbody2D>();
    }

    //Usamos el start para recuperar el Rigibody de la pelota
    private void Start()
    {
        rkPelota = pelota.GetComponent<Rigidbody2D>();
    }

    // Para detectar la tecla espacio
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)&& pelotaMuerta)
        {
            LanzarPelota();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        Vector2 vector = new Vector2(h, 0);

        //Añadimos la fuerza al racket

        rk.AddForce(vector * forced * Time.deltaTime);

        // limitamos la velocidad
        rk.velocity = new Vector2(Mathf.Clamp(rk.velocity.x, -speed, speed), 0);

        // Marcamos los limites en los que se va a poder mover el racket, para que no salga de pantalla.

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -8.5f, 8.5f), transform.position.y);
    }

    //Función para lanzar la pelota
    void LanzarPelota()
    {
        //Decimos que la pelota se ha lanzado
        pelotaMuerta = false;
        //Decimos que el Rigibody de la pelota no es kinematico
        rkPelota.isKinematic = false;
        rkPelota.AddForce(new Vector2(0, velPelota));
    }
}
