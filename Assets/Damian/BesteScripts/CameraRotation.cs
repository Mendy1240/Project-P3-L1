using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    void Update()
    {
        Vector3 curEuler = transform.eulerAngles;
        curEuler.x -= Input.GetAxis("Mouse Y");
        curEuler.x = ClampAngle(curEuler.x, -90, 90);
        transform.eulerAngles = curEuler;
    }

    static float ClampAngle(float angle, float min, float max)
    {
        if (min < 0 && max > 0 && (angle > max || angle < min))
        {
            angle -= 360;
            if (angle > max || angle < min)
            {
                if (Mathf.Abs(Mathf.DeltaAngle(angle, min)) < Mathf.Abs(Mathf.DeltaAngle(angle, max)))
                {
                    return min;
                }
                else
                {
                    return max;
                }
            }
        }
        else if (min > 0 && (angle > max || angle < min))
        {
            angle += 360;
            if (angle > max || angle < min)
            {
                if (Mathf.Abs(Mathf.DeltaAngle(angle, min)) < Mathf.Abs(Mathf.DeltaAngle(angle, max)))
                {
                    return min;
                }
                else
                {
                    return max;
                }
            }
        }

        if (angle < min)
        {
            return min;
        }
        else if (angle > max)
        {
            return max;
        }
        else
        {
            return angle;
        }
    }
}
