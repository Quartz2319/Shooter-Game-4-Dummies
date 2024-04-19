using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int health = 10;
    void Start()
    {
        
    }

    void Update()
    {
       if (health <= 0)
        {
            Destroy(gameObject);
        }

       if (health <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
