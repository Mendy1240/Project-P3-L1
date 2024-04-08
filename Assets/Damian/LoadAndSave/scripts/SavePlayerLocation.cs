using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePlayerLocation : MonoBehaviour
{
    public Transform playerTransform;

    public void Start()
    {
        float playerX = PlayerPrefs.GetFloat("PlayerX");
        float playerY = PlayerPrefs.GetFloat("PlayerY");                                                                                                        
        float playerZ = PlayerPrefs.GetFloat("PlayerZ");

        playerTransform.position = new Vector3(playerX, playerY, playerZ);
    }
    public void SaveLocation()
    {
        PlayerPrefs.SetFloat("PlayerX", playerTransform.position.x);
        PlayerPrefs.SetFloat("PlayerY", playerTransform.position.y);
        PlayerPrefs.SetFloat("PlayerZ", playerTransform.position.z);
        PlayerPrefs.Save();

        Debug.Log("Location Saved");
    }
    public void OnSaveButtonPressed()
    {
        SaveLocation();
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.SetFloat("PlayerX", 0f);
            PlayerPrefs.SetFloat("PlayerY", 1f);
            PlayerPrefs.SetFloat("PlayerZ", -1.9f);
        }
        
    }
}