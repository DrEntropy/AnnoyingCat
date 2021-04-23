using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

public class ValuableHandler : MonoBehaviour
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
            // TODO  - score for knocking valuble off!
            Debug.Log("You destroyed a valuable! SCORE!");
            Destroy(gameObject);
           
        }
    }



    // if a valuable hits vacuum, destroy it.

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Vac"))
            Destroy(gameObject);
    }
}
