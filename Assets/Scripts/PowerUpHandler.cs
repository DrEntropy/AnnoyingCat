using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

public class PowerUpHandler : MonoBehaviour
{
    // Start is called before the first frame update
     

    // Update is called once per frame
    void Update()
    {
       if(Mathf.Abs(transform.position.x) > 36.0f)
        {
            Destroy(gameObject);
        }
       if(transform.position.y < 1.0f)
        {
            Destroy(gameObject);
        }
    }

    // if a powerup hits vacuum, destroy it.

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Vac"))
            Destroy(gameObject);
    }

    // if a powerup collides with player, power up somehow (More speed!)

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            // TO DO - Power up!}
            Debug.Log("POWER UP!");
        }
            
    }
}
