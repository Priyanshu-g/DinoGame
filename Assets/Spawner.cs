using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    public GameObject Enemy4;
    int caller = 1;
    int seconds = 0;
    bool spawned = false;
    public int interval = 5;
    public Player player;
    int previous;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Timer", 0, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (seconds % interval == 0 && !spawned)
        {
            caller = Random.Range(1, 4);
            if(caller == previous)
            {
                caller += 1;
                if(caller == 5)
                {
                    caller = Random.Range(1, 3);
                }
            }
            if (caller == 1)
            {
                Enemy1.transform.position = new Vector3(transform.position.x, -3.74f, 0);
                spawned = true;
            }
            else if (caller == 2)
            {
                Enemy2.transform.position = new Vector3(transform.position.x, -3.7f, 0);
                spawned = true;
            }
            else if (caller == 3)
            {
                Enemy3.transform.position = new Vector3(transform.position.x, -3.74f, 0);
                spawned = true;
            }
            else if (caller == 4)
            {
                Enemy4.transform.position = new Vector3(transform.position.x, -3.67f, 0);
                spawned = true;
            }
            previous = caller;
        }
    }

    void Timer()
    {
        if (player.active)
        {
            seconds += 1;
            spawned = false;
        }
        else
        {
            seconds = 0;
            spawned = false;
        }
    }
}
