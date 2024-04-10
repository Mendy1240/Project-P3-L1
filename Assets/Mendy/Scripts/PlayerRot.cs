using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRot : MonoBehaviour
{
    public float mouseX;
    public float mouseY;
    public float mouseSen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       mouseX = Input.GetAxis("Mouse X") * mouseSen;
       mouseY = Input.GetAxis("Mouse Y") * mouseSen;
    }
}
