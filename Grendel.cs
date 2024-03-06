using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grendel : MonoBehaviour
{
    public Transform GrendelOnBelt;
    public Transform GrendelOnHand;
    private bool hasExpload = false;


    public GameObject explosionEffeck;
    public float delay = 3f;
    private float countdown;
    public float radius = 5f;
    public float force = 700f;
    // Start is called before the first frame update
    void Start()
    {
        //gameObject.transform.position = GrendelOnBelt.position;
        countdown = delay;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0f && !hasExpload)
        {
            Expload();
            hasExpload = true;  
        }
    }

    private void Expload()
    {
        //Instantiate(explosionEffeck, transform.position, transform.rotation);

        Collider [] colliderToDestroy = Physics.OverlapSphere(transform.position, radius);

        foreach (Collider nearcollider in colliderToDestroy)
        {
          

            BombOrGrendelEcpload bombOrGrendelEcpload = nearcollider.GetComponent<BombOrGrendelEcpload>();
            if(bombOrGrendelEcpload != null )
            {
                bombOrGrendelEcpload.Destroy();
            }
        }

        Collider[] colliderToMove = Physics.OverlapSphere(transform.position, radius);

        foreach(Collider nearcollider in colliderToMove)
        {
            Rigidbody rb = nearcollider.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(force, transform.position, radius);
            }
        }

        Destroy(gameObject);
    }

   
}
