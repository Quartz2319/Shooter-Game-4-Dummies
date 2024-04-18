using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public int health = 3;
   
    private void Start()
    {
       
    }

    void Update()
    {
        //if the enemy's health reaches 0 or lower destroy it
        if (health <= 0)
        {
            Destroy(gameObject);
        }

    }
}
