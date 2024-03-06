using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vladimir_Rifel : MonoBehaviour
{
    [Header("Rifel things")]
    public GameObject Wepanes;
    public Camera Cam;
    public float giveDamageOf = 10f;
    public float shootingRange = 100f;
    public float fireCharge = 15f;
    private float nextTimeToshoot = 0f;
    public Vladimir vladimir;



    [Header("Rifel Ammunition and shooting")]
    private int maximumAmmunition = 32;
    public int mag = 10;
    private int presentAmmunition;
    public float reloadingTime = 1.3f;
    private bool setReloading = false;

    [Header("rifel Effect")]
    public ParticleSystem muzzleSpark;
    public GameObject WoodedEffect;


    private void Awake()
    {

        presentAmmunition = maximumAmmunition;
    }
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetButton("Fire1") && vladimir.rifel&&Time.time >= nextTimeToshoot)
        {
            nextTimeToshoot = Time.time + 1f / fireCharge;
            Shooting();

        }
       
    }
    private void Shooting()
    {
        //muzzleSpark.Play();
        RaycastHit hitInfo;
        if(Physics.Raycast(Cam.transform.position , Cam.transform.forward, out hitInfo , shootingRange))
        {
            Debug.Log(hitInfo.transform.name);
            ObjectHit objectHit = hitInfo.transform.GetComponent<ObjectHit>();
            if (objectHit != null)
            {
                objectHit.ObjectHitDamage(giveDamageOf);
                //GameObject WoodGo = Instantiate(WoodedEffect, hitInfo.point, Quaternion.LookRotation(hitInfo.normal));
               // Destroy(WoodGo, 1f);
            }

        }
        
    }
}
