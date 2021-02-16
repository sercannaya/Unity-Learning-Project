using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void PlayJumpingAnimation()
    {
        animator.SetBool("isJumping", true);
    }

    public void PlayIdleAnimation()
    {
        animator.SetBool("isRunning", false);
        animator.SetBool("isJumping", false);
    }

    public void PlayRunningAnimation()
    {
        animator.SetBool("isRunning", true);
        animator.SetBool("isJumping", false);
    }


}
