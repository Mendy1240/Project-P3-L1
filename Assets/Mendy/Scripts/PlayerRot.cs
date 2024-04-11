using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRot : MonoBehaviour
{
        public Transform head;
    public float mouseY;
    public Vector3 headRot;
    public float rotSpeed;
    public float maxRotationX = 60f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         mouseY = Input.GetAxis("Mouse Y");
        headRot.x = -mouseY * rotSpeed * Time.deltaTime;

        Vector3 currentRotation = head.localRotation.eulerAngles;

        head.Rotate(headRot);

        float newRotationX = ClampRotation(head.localRotation.eulerAngles.x);

        head.localRotation = Quaternion.Euler(newRotationX, currentRotation.y, currentRotation.z);
    }

    // Methode om de rotatie te beperken tot het bereik van -maxRotationX tot maxRotationX
    float ClampRotation(float rotation)
    {
        if (rotation > 180)
            rotation -= 360;
        return Mathf.Clamp(rotation, -maxRotationX, maxRotationX);
    }
}
