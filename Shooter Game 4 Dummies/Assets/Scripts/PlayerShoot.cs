using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [System.Serializable]
    public class Weapon
    {
        public string name;
        public int damage;
        public float fireRate;
    }

    public Weapon currentWeapon;
    public Weapon[] weaponsList;

    public GameObject projectile;

    public float projectileSpeed = 10f;

    private float timer;

    private void Start()
    {
        //make sure the player starts with a weapon
        currentWeapon = weaponsList[0];
    }

    void Update()
    {
        //have the timer count up
        timer += Time.deltaTime;

        //if we are pressing the button and enough time has elapsed on the timer
        if (Input.GetButton("Fire1") && timer >= currentWeapon.fireRate)
        {
            //reset the timer
            timer = 0;

            //set up the rotation to spawn the bullet
            Vector3 projectileRotation = transform.eulerAngles + projectile.transform.eulerAngles;

            //spawn the bullet 
            GameObject spawn = Instantiate(projectile, transform.position, Quaternion.Euler(projectileRotation));

            //set the velocity of the bullet
            spawn.GetComponent<Rigidbody>().velocity = transform.right * projectileSpeed;

            //destroy the bullet after 5 seconds
            Destroy(spawn, 5);
        }

        //switch bewteen weapons using the number keys
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentWeapon = weaponsList[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentWeapon = weaponsList[1];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentWeapon = weaponsList[2];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            currentWeapon = weaponsList[3];
        }
    }
}
