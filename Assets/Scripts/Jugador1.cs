using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador1 : MonoBehaviour
{
    public new Rigidbody2D rigidbody;
    public int jumps = 2;
    // Esto es para que el jugador pueda saltar el numero de veces indicado y no más.
    //aprendiendo git
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jumps > 0 )
        { 
            rigidbody.velocity = Vector3.zero;
            rigidbody.AddForce(Vector2.up * 10, ForceMode2D.Impulse); 
            jumps--;
        }
        // Con esta linea tiene instrucciones para ordernar al jugador saltar

        rigidbody.velocity = new Vector2(Input.GetAxis("Horizontal") * 10, rigidbody.velocity.y);
        //Con esta linea tiene instrucciones para mover al personaje.
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        jumps = 2;

        if (collision.gameObject.GetComponent<Plataformamovible>() != null)
        {
            transform.parent = collision.transform;
        }
    }
    
    private void OnCollisionExit2D(Collision2D collision)
    { 
        if (collision.gameObject.GetComponent<Plataformamovible>())
        {
            transform.parent = null;
        }
    }
}

