using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
    // Le damos valor a la velocidad

    public float speed = 10;
    public float forced = 2000;
    public Rigidbody2D rk;

    // Start is called before the first frame update
    void Awake()
    {
        rk = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxis("horizontal");
        Vector2 vector = new Vector2(h, 0);

        //Añadimos la fuerza al racket

        rk.AddForce(vector * forced * Time.deltaTime);

        // limitamos la velocidad
        rk.velocity = new Vector2(Mathf.Clamp(rk.velocity.x, -speed, speed), 0);
    }
}
