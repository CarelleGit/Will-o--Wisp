using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] Monster;
    int numberSpawned;
    public int spawnLimit = 2;
    public float[] timer;
    public float[] spawnRate;
    // Use this for initialization
    void Start()
    {
        Debug.Assert(timer.Length == Monster.Length && spawnRate.Length == timer.Length);
       // timer = spawnRate;
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < timer.Length; i++)
        {
            timer[i] += Time.deltaTime;

            if (timer[i] >= spawnRate[i])
            {
                Instantiate(Monster[ranNum()], transform.position, transform.rotation);
                timer[i] = 0;
            }
        }


    }

    public int ranNum()
    {
        return Random.Range(0, Monster.Length);
    }

    //float ranXSpawn()
    //{
    //    return Random.Range(0, transform.position)
    //}
}
