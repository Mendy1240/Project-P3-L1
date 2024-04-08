using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPauseMenu : MonoBehaviour
{
    
    public GameObject menu;
    public bool isMenuOpen;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            isMenuOpen = !isMenuOpen;
            menu.SetActive(isMenuOpen);


            if (isMenuOpen)
            {
                Cursor.lockState = CursorLockMode.None;
                Time.timeScale = 0f;
            }
            if (!isMenuOpen)
            {
                Cursor.lockState = CursorLockMode.Locked;
                Time.timeScale = 1f;
            }
        }
    }

}

