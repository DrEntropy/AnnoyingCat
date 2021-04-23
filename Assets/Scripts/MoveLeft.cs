using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{

    // This script is used by all scene elements to move left
    // to give illusion player is moving right.
    // Note that this is in addition to the normal rigidbody physics.
    // Not sure if this will work.
    // Start is called before the first frame update

    private float speed = 6.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed*Time.deltaTime);
    }


}
