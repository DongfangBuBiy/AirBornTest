using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactab : MonoBehaviour
{
    public float radius = 3f;
    private bool isFouse = false;
    private Transform player;
    private bool hasInteracted = false;

    public virtual void Interact()
    {

    }

    private void Update()
    {
        if (isFouse)
        {
            float distance = Vector3.Distance(player.position, transform.position);
            if (distance <= radius)
            {
                Interact();
                hasInteracted=true;
            }
        }
    }






    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;    
        Gizmos.DrawWireSphere(transform.position, radius);
    }
    public void OnFocused(Transform playertransform)
    {
        isFouse = true;
        player = playertransform;
    }
    public void OnDefoused()
    {
        isFouse = false;
        player = null;
    }
   
}
