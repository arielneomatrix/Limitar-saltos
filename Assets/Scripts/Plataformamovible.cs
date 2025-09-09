using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataformamovible : MonoBehaviour
{
   public Transform pointA;
   public Transform pointB;
   public bool goingUp;

    // Update is called once per frame
    void Update()
    {
        Vector3 wantedPosition = Vector3.zero;

        if (goingUp)
            wantedPosition = pointA.position;
        else
            wantedPosition = pointB.position;

        Vector3 direction = (wantedPosition - transform.position);
        transform.position += direction.normalized * Time.deltaTime;

        if (direction.magnitude < 1)
        {
            if (goingUp)
                goingUp = false;
            else
                goingUp = true;
        }


    }
}
