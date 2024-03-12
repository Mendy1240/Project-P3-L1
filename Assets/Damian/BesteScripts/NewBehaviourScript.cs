using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Animator animator;

    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetTrigger("WeaponInspect");
            animator.ResetTrigger("idle");
        }
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("Shooting");
            animator.ResetTrigger("idle");
        }
    }
}
