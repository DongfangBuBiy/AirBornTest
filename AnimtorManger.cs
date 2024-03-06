using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimtorManger : MonoBehaviour
{
   public virtual void AnimationManger(Animator animator,string MoveModelName)
    {
        switch (MoveModelName)
        {
            case "Idel":
                animator.SetBool("Idel", true);
                animator.SetBool("Run", false);
                animator.SetBool("Walk", false);
                break;

            case "Walk":
                animator.SetBool("Run", false);
                animator.SetBool("Walk", true);
                break;

            case "Run":
                animator.SetBool("Run", true);
                animator.SetBool("Walk", false);
                break;

            case "Crouch":
                animator.SetBool("Crouch", true);
                animator.SetBool("Run", false);
                animator.SetBool("Walk", false);
                break;


            case "CrouchWalk":
                animator.SetBool("WalkCrouch", true);
                break;


            case "ChestyIdel":
                animator.SetBool("ChestyIdel", true);
                animator.SetBool("ChestyMove", false);
                animator.SetBool("Run", false);
                animator.SetBool("Walk", false);
                break;

            case "ChestyMove":
                animator.SetBool("ChestyIdel", false);
                animator.SetBool("ChestyMove", true);
                break;



        }
    }
}
