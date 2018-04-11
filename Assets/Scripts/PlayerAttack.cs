using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject bulletPref;
    [SerializeField]
    public float offset = 2.0f;

    float timer;
    public float timerLimit;

    // Use this for initialization
    void Start()
    {
        timer = timerLimit;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
       
        if (Input.GetMouseButtonDown(0))
        {
            if (timer >= timerLimit)
            {
                GameObject bulletSpawn = Instantiate(bulletPref);
                bulletSpawn.transform.position = transform.position + Vector3.up * offset;

                //transform.position = target.transform.position;

                bulletSpawn.GetComponent<Rigidbody2D>().velocity = transform.up * 6;
                Destroy(bulletSpawn, 2.0f);
                timer = 0;
            }
        }
    }
}
