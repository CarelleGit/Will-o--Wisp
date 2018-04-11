using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Direct : MonoBehaviour
{
    public GameObject enemybullet;
    [SerializeField]
    public float offset = 2.0f;

    float speed = 5f;

    float timer;
    public float timerlimit;

    GameObject player;
    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        transform.position += (player.transform.position - transform.position).normalized * speed * Time.deltaTime;

        if (timer >= timerlimit)
        {
            GameObject bulletSpawn = Instantiate(enemybullet);
            bulletSpawn.transform.position = transform.position + Vector3.down * offset;

            //transform.position = target.transform.position;

            bulletSpawn.GetComponent<Rigidbody2D>().velocity = -transform.up * 6;
            Destroy(bulletSpawn, 2.0f);
            timer = 0;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
       if(collision.collider.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
