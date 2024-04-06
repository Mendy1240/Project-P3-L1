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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
