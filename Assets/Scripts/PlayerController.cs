﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float tablespeed = 4.0f;
    private float speed= 10.0f;
    private float minX = -22.0f;
    private float maxX = 30.0f;
    private float minZ = 3.0f;
    private float maxZ = 23.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovePlayer();
        ConstrainPlayer();   
 

    }

    void  MovePlayer()
    {
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");

        Vector3 moveDir = Vector3.forward * vInput + Vector3.up * hInput;
        transform.Translate(moveDir * speed * Time.deltaTime);
        // Also always move left, to simulate table
        transform.Translate(Vector3.up * tablespeed *(-1.0f)* Time.deltaTime);

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Vac"))
        {
            // TODO actually what should happen? Sound: MEOW! and then game over.
            Debug.Log("Game OVer? You got sucked");
        }
    }

    void ConstrainPlayer()
    {

        Vector3 newPosition = transform.position;
        // check if offscreen
        if (newPosition.x < minX)
            newPosition.x = minX;
        if (newPosition.x > maxX)
            newPosition.x = maxX;
        if (newPosition.z < minZ)
            newPosition.z = minZ;
        if (newPosition.z > maxZ)
            newPosition.z = maxZ;

        //update
        transform.position = newPosition;
    }

}
