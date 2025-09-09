using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toqueenemigo : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public bool goingUp;
    public float speep = 2;

    void Update()
    {
        Vector3 wantedPosition = Vector3.zero;

        if (goingUp)
            wantedPosition = pointA.position;
        else
            wantedPosition = pointB.position;

        Vector3 direction = (wantedPosition - transform.position);
        transform.position += direction.normalized * Time.deltaTime * speep;

        if (direction.magnitude < 1)
        {
            if (goingUp)
                goingUp = false;
            else
                goingUp = true;
        }


    }
}
