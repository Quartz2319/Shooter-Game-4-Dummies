using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private int bulletDamage;

    private void Start()
    {
        //set the damage to deal when the bullet spawns
        PlayerShoot player = FindObjectOfType<PlayerShoot>();
        bulletDamage = player.currentWeapon.damage;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Enemy>())
        {
            //get the script on the enemy
            Enemy enemy = other.GetComponent<Enemy>();

            //remove health from the enemy based on our damage
            enemy.health = enemy.health - bulletDamage;
            //destroy the bullet after it hits the enemy
            Destroy(gameObject);
        }
    }
}
