using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageCheck : MonoBehaviour
{

    public int enemyDamage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerHealth>())
        {
            PlayerHealth player = other.GetComponent<PlayerHealth>();

            player.health = player.health - enemyDamage;
        }
    }

}
