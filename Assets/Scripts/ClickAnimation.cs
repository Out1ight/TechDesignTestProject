using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAnimation : MonoBehaviour
{
    public Animator animator;

    private void OnMouseUp()
    {
        if (animator.enabled == false)
            animator.enabled = true;
        else animator.enabled = false;
    }
}
