using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public Transform Player;

    public float ChaseSpeed;
    // Start is called before the first frame update

    //Locks on to what makes the player unique so is able to track it
    void Start()
    {
        Player = FindObjectOfType<PlayerMovement>().transform;
        
    }

    // Update is called once per frame

    //Allows the enemy to move
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Player.position, ChaseSpeed * Time.deltaTime);
    }
}
