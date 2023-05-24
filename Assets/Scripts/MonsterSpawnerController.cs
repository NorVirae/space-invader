using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawnerController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject monster1;
    public GameObject monster2;

    public float interval = 5;

    void Start()
    {
        InvokeRepeating("SpawnMonster", interval, interval);
    }

    private void SpawnMonster()
    {
        float ranValue = Random.value;
        if (ranValue < 0.2) { 
            Instantiate(monster1, transform.position, Quaternion.identity);
        }
        else if(ranValue < 0.4)
        {
            Instantiate(monster2, transform.position, Quaternion.identity);
        }
        else
        {
            // Do nothing
        }
        //Instantiate(monster2, newSpawnPos2, Quaternion.identity);

    }

}
