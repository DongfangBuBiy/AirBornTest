using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

public class Eemey : MonoBehaviour
{
    [Header("Componet")]
    public NavMeshAgent agent;
    public GameManegerData data;
    public Animator animator;
    public bool ComandoInKnifelPoint;//در صورتی که کماندو با چاقو در نقطه چاقو باشد این متغیر فعال میشود
    public Transform KnifelPoint;//نقطه چاقو 

    [Header("PlayerMovement")]
    public Transform[] points;
    private int destPoint = 0;



    [Header("HealthyandData")]
    public float Healthy;
    public int xp;
    public int coin;
    public int Check;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = false;
        animator = GetComponent<Animator>();
        Healthy = data.simpel_soljer_Healthy;
        xp = data.simpel_soljer_xp;
        coin = data.simpel_soljer_coin;
        Check = data.simpel_soljer_Check;
       
       


    }
    private void GotoNextPoint()
    {
        if (points.Length == 0)
            return;

        agent.destination = points[destPoint].position;
        destPoint = (destPoint + 1) % points.Length;
    }
    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void Move()
    {
        if(!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            GotoNextPoint();
            Animationmanger("Move");
        }
    }
   

       
   

    private void Animationmanger(string senario)
    {
        switch (senario)
        {
            case "Move":
                if (agent.velocity != Vector3.zero)
                {
                    animator.SetBool("Walk", true);
                }
                else if (agent.velocity == Vector3.zero)
                {
                    animator.SetBool("Walk", false);
                }
                break;
        }
       

    }

   
}
