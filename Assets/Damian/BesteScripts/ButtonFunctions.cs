using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour
{
    public void play ()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit ()
    {
        SceneManager.LoadScene (0);
    }
    
}
