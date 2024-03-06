using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class FieldOfView : MonoBehaviour
{
    public float radius;
    [Range(0f, 360)]
    public float angle;

    public GameObject playerRef;

    public LayerMask targetMask;
    public LayerMask obstructionMAsk;


    public bool canSeeplayer;


    private void Start()
    {
        playerRef = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine(FOVRoutine());
    }

    IEnumerator FOVRoutine()
    {
        WaitForSeconds wait = new WaitForSeconds(0.2f);

        while (true)
        {
            yield return wait;
            FieldOfViewCheck();

        }
    }

    private void FieldOfViewCheck()
    {
        Collider[] rangeChecks = Physics.OverlapSphere(transform.position, radius , targetMask);
        if(rangeChecks.Length != 0 )
        {
            Transform target = rangeChecks[0].transform;
            Vector3 directionTotarget = (target.position - transform.position).normalized;  

            if(Vector3.Angle(transform.forward, directionTotarget) < angle / 2)
            {
                float distanceTotarget = Vector3.Distance(transform.position ,  target.position);
                if(!Physics.Raycast(transform.position,directionTotarget , distanceTotarget, obstructionMAsk))
                {
                    canSeeplayer = true;
                }
                else
                {
                    canSeeplayer=false;
                }
            }
            else
            {
                canSeeplayer = false;
            }
        }
        else if (canSeeplayer)
        {
            canSeeplayer = false;
        }
    }
}
