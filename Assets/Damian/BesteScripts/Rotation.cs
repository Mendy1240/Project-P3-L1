using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public Vector3 rotated;
    public float mousex;
    public float speed;
    void Update()
    {

        mousex = Input.GetAxis("Mouse X");
        rotated.y = +mousex;
        transform.Rotate(rotated * Time.deltaTime * speed);

    }
}
