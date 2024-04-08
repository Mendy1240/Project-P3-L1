using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Hor;
    public float Ver;
    public Vector3 Mov;
    public float speed;
    
    void Update()
    {
        Hor = Input.GetAxis("Horizontal");
        Ver = Input.GetAxis("Vertical");


        Mov.x = Hor;
        Mov.z = Ver;

        transform.Translate(Mov * speed * Time.deltaTime);
    }
}
