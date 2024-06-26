using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int health = 10;

    public Image healthBar;
    public float healthAmount = 10f;
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

        if (healthAmount <= 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            TakeDamage(1);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Heal(2);
        }
    }

    public void TakeDamage(float damage)
    {
        healthAmount -= damage;
        healthBar.fillAmount = healthAmount / 10f;
    }

    public void Heal(float healingAmount)
    {
        healthAmount += healingAmount;
        healthAmount = Mathf.Clamp(healthAmount, 0, 10);

        healthBar.fillAmount = healthAmount / 10f;
    }
}
