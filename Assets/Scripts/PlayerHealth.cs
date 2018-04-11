using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    [SerializeField]
    private int health = 10;
    public int getHealth
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
        }
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (health < 0)
        {
            SceneManager.LoadScene("DeathScene");
        }
    }
}
