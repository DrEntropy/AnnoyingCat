using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    private float spawnY = 21.0f;
    private float spawnX = 28.0f;
    private float spawnMinZ = 5.0f;
    private float spawnMaxZ = 20.0f;

    // Later, make this a random amount.. dont use invoke repeating
    private float spawnDelay = 1.0f;

    public GameObject[] spawnies;




    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnSomething", spawnDelay, spawnDelay) ;
    }


    void spawnSomething()
    {
        int index = Random.Range(0, spawnies.Length);
        Vector3 location = new Vector3(spawnX, spawnY, Random.Range(spawnMinZ, spawnMaxZ));
        Instantiate(spawnies[index], location, spawnies[index].transform.rotation);
    }
     
}
