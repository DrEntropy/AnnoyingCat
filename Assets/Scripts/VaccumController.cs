using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaccumController : MonoBehaviour
{
    // Max distances that the vacuume can slide
    float maxX = 5.0f;
    float minX = -10.0f;
    float speed = 5.0f;
    float currentDirection = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // at first i will just have it move back and forth at constant speed.
    // LATER: ADD RAndom ness, at least in the speed and have it occassionaly
    // Come very far to the right! Maybe it will blink or something to warn you
    // and make a ton of noise.


    void Update()
    {
        
        if (transform.localPosition.x > maxX)  
        {
            currentDirection = -1.0f;
            //Debug.Log("Hit right max");
            
        }
        if (transform.localPosition.x < minX)
        {
            currentDirection = 1.0f;
        }
        Vector3 direction = new Vector3(speed * currentDirection, 0, 0);
        transform.Translate(direction * Time.deltaTime);
    }
}
