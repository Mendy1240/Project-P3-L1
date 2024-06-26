using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float Hor;
    public float Ver;
    public float speed;
    public Vector3 moveDir;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Hor = Input.GetAxis("Horizontal");
        moveDir.x = Hor;
        transform.Translate(moveDir*speed*Time.deltaTime);
        Ver = Input.GetAxis("Vertical");
        moveDir.z = Ver;
        transform.Translate(moveDir*speed*Time.deltaTime);
    }
}
