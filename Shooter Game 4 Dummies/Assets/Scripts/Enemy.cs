using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 3;

    void Update()
    {
        //if the enemy's health reaches 0 or lower destroy it
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
