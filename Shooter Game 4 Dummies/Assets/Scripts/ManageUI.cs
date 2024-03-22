using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ManageUI : MonoBehaviour
{
    public Image crosshair;
    public TextMeshProUGUI weaponText;
    private PlayerShoot player;
    public GameObject pauseMenu;


    void Start()
    {
        player = FindObjectOfType<PlayerShoot>();

        pauseMenu.SetActive(false);

        Cursor.visible = false;
    }

    void Update()
    {
        weaponText.text = player.currentWeapon.name;

        crosshair.transform.position = Input.mousePosition;

        if (player.currentWeapon.name == "Pistol")
        {
            crosshair.color = Color.green;
            weaponText.text = "Current weapon: <b><color=green>" + player.currentWeapon.name;
        }
        else if (player.currentWeapon.name == "Shotgun")
        {
            crosshair.color = Color.blue;
            weaponText.text = "Current weapon: <b><color=blue>" + player.currentWeapon.name;
        }
        else if (player.currentWeapon.name == "Rifle")
        {
            crosshair.color = Color.red;
            weaponText.text = "Current weapon: <b><color=red>" + player.currentWeapon.name;
        }
        else if (player.currentWeapon.name == "Minigun")
        {
            crosshair.color = Color.yellow;
            weaponText.text = "Current weapon: <b><color=yellow>" + player.currentWeapon.name;
        }

        if(Input.GetButtonDown("Cancel"))
        {
            PauseGame();
        }

    }

    public void PauseGame()
    {
        Cursor.visible = true;
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        Cursor.visible = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void QuitToMenu()
    {
        SceneManager.LoadScene(0);
    }
}