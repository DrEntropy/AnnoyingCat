using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

public class JammerHandler : MonoBehaviour
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


    // if a jammer hits vacuum, destroy it and DISABLE vaccume (TO DO!)

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Vac"))
        {
            Destroy(gameObject);
            Debug.Log("VacuumJammer Activated!");
        }
    }
}
