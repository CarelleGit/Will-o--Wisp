using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 5;
    public bool isPlayer = false;
    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(isPlayer)
        {
            other.GetComponent<EnemyHealth>().getHealth -= damage;
            Destroy(gameObject);
        }
        else
        {
            other.GetComponent<PlayerHealth>().getHealth -= damage;
            Destroy(gameObject);
        }
    }
}
