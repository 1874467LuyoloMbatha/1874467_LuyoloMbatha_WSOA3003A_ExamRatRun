using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camFollow : MonoBehaviour
{
    private Transform playerMovement;

    void Start()
    {
        playerMovement = GameObject.FindGameObjectWithTag("Player").transform;

    }

    void LateUpdate()
    {
        //Stores the temporary positioon  of camera.
        Vector3 tempPosition = transform.position;

        //Equals the position of the player's x-axis position.
        tempPosition.x = playerMovement.position.x;
        tempPosition.y = playerMovement.position.y;


        //Sets cameras's temporary position current position. 
        transform.position = tempPosition;



    }
}
