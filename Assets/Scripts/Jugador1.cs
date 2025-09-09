using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador1 : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public int jumps = 2;


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
    }
}
