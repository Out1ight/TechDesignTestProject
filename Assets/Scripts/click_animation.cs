using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click_animation : MonoBehaviour
{
    public Animator animator;

    private void OnMouseUp()
    {
        if (animator.enabled == false)
            animator.enabled = true;
        else animator.enabled = false;
    }
}
