using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class Vladimir : MonoBehaviour
{
   

    [Header("Animation")]
    public Animator animator;
    public bool walk;
    public bool run;
    public bool crouch;
    public bool rifel;
    public bool firing;


    [Header("Movement")]
    public float movespeed;
    public float walkSpeed = 3, walkBackSpeed=2;
    public float runSpeed = 7, runBackSpeed=5;
    public float crouchSpeed = 2, crouchBackSpeed = 1;
    public Vector3 dir;
    public float hzInput, vInput;
    public CharacterController characterController;

    [Header("Gravity")]
    [SerializeField] float groundYOffset;
    [SerializeField] LayerMask groundMask;
    private Vector3 soherPos;
    [SerializeField] float gravity = -9.81f;
    private Vector3  velocity;
    public float jumpHeight = 3f;


    private void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        GetDirectionAndMove();
        Jump();
        Animationmanger();
        movemodel();
        SetFiring();
        
        animator.SetFloat("hzInput", hzInput);
        animator.SetFloat("vInput", vInput);

       
    }


   

    private void GetDirectionAndMove()
    {
        hzInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");
        dir = transform.forward * vInput + transform.right * hzInput;
        if(dir.magnitude > 0.1f)
        {
            characterController.Move(dir.normalized * movespeed * Time.deltaTime);

        }
        
        
       
    }
    private bool IsGrround()
    {
        soherPos = new Vector3(transform.position.x,transform.position.y-groundYOffset,transform.position.z);
        if(Physics.CheckSphere(soherPos,characterController.radius-0.5f,groundMask))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    private void Gravity()
    {
        if (!IsGrround())
        {
            velocity.y += gravity * Time.deltaTime;
        }
        else if(velocity.y < 0)
        {
            velocity.y = -2;
        }
        characterController.Move(velocity*Time.deltaTime);
      
        
    }
    private void Jump()
    {
        if (IsGrround())
        {
            velocity.y = -2f;
            animator.SetBool("Jump", false);
        }
        if(Input.GetKeyDown(KeyCode.J) && IsGrround())
        {
            velocity.y = Mathf.Sqrt(jumpHeight * 2f * gravity);
            animator.SetBool("Jump", true);
        }
        velocity.y += gravity * Time.deltaTime;
        characterController.Move(velocity*Time.deltaTime);
    }
    private void SetFiring()
    {
        if (Input.GetMouseButton(0))
        {
            firing = true;
        }
        else { firing = false; }
    }
    private void movemodel()
    {

        if(Input.GetKeyDown(KeyCode.C))
        {
            crouch = true;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            crouch = false;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            rifel = true;
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            rifel = false;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            run = true;
        }

        if(dir.magnitude > 0.1f)
        {
            walk = true;
        }
        else
        {
            walk = false;
        }

    }
    

   

    private void Animationmanger()
    {
        if(walk == true)
        {
            animator.SetBool("Walking",true);
        }
        if(run == true)
        {
            animator.SetBool("Run", true);
        }
        if(crouch == true)
        {
            animator.SetBool("Crouch", true);
        }
        if (rifel == true)
        {
            animator.SetBool("Rifel", true);
        }
        if(firing == true)
        {
            animator.SetBool("Firing", true);
        }

        //حالت های منفی
        if (walk != true)
        {
            animator.SetBool("Walking", false);
        }
        if (run != true)
        {
            animator.SetBool("Run", false);
        }
        if (crouch != true)
        {
            animator.SetBool("Crouch", false);
        }
        if (rifel != true)
        {
            animator.SetBool("Rifel", false);
        }
        if(firing != true)
        {
            animator.SetBool("Firing", false);
        }
    }
}

