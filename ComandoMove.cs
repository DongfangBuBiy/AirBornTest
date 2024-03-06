using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.AI;

public class ComandoMove : MonoBehaviour
{
    [Header("Move and animtor")]
    public NavMeshAgent agent;
    public Animator animator;

    [Header("Move Variabel")]
    public float inputx;
    public float inputz;
    private Vector3 v_movement;
    private Vector3 v_velocity;
    public float moveSpeed;

    [Header("MoveAnimationModel")]
    public string WepeanModel;
    public bool Walk;
    public bool Run;
    public bool Crouch;
    public bool Chesty;
    public bool Rifel;
    public bool Belt;
  

    
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        moveSpeed = 4f;
        
    }

    // Update is called once per frame
    void Update()
    {
        inputx = Input.GetAxis("Horizontal");
        inputz = Input.GetAxis("Vertical");

        //setanimationmodel
 

        //animation
      
    }
    private void IsPlayerMove(string movemodel1,string movemodel2)
    {
        if (inputz == 0)
        {

           //
        }
        else
        {
            //
        }

    }
    private void MoveModel()
    {
        if(WepeanModel ==null)
        {
            if (Walk)
            {
                IsPlayerMove("Idel", "Walk");
            }
            else if (Run)
            {
                IsPlayerMove("Idel", "Run");
            }
            else if (Crouch)
            {
                IsPlayerMove("CrouchIdel", "CrouchWalk");
            }
            else if (Chesty)
            {
                IsPlayerMove("ChestyIdel", "ChestyMove");
            }
           
        }
        //check solid if loop
        
    }
    private void FixedUpdate()
    {
        v_movement = agent.transform.forward * inputz;

        //charter rotat
        agent.transform.Rotate(Vector3.up * inputx*(100f*Time.deltaTime));
        //charatermove
        agent.Move(v_movement*moveSpeed*Time.deltaTime);



    }
   
    
}
