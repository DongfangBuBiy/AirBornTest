using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public void Die()
    {
        Debug.Log("I am die #_#");
        Destroy(gameObject);    
    }
}
