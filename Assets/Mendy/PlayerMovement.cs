using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float hor;
    public float ver;
    public Vector3 dir;
    public float speed;
    public float mouseX;
    public float rotSpeed;
   
    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");
        dir.x = hor;
        dir.z = ver;
        transform.Translate(dir*speed*Time.deltaTime);
        mouseX = Input.GetAxis("Mouse X");
        dir.y = -mouseX;
        transform.Rotate(dir*Time.deltaTime*rotSpeed);
    }
}
