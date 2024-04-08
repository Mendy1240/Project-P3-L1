using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPlayerLocation : MonoBehaviour
{
    public Transform playerTransform;
    public string playerGameObjectName;

    public void LoadLocation()
    {
        GameObject playerObject = GameObject.Find("Player");

        if (playerObject!= null)
        {
            Transform playerTransform = playerObject.transform;

            float playerX = PlayerPrefs.GetFloat("PlayerX");
            float playerY = PlayerPrefs.GetFloat("PlayerY");
            float playerZ = PlayerPrefs.GetFloat("PlayerZ");

            playerTransform.position = new Vector3(playerX, playerY, playerZ);

        }
        
    }

    public void OnLoadButton()
    {
        LoadLocation();
    }
}
