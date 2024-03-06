using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombOrGrendelEcpload : MonoBehaviour
{
    public GameObject DestroyVersion;


    public void Destroy()
    {
        Instantiate(DestroyVersion , transform.position,transform.rotation);

        Destroy(gameObject);
    }
}
