using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swichcam : MonoBehaviour
{
    [Header("Cam and Canves")]
    public GameObject ThirdPersonCam;
    public GameObject AnimingCam;
    public GameObject TPS;
    public GameObject Anim;
    public Vladimir Vladimir;
   


    void Update()
    {
        if (Input.GetButton("Fire1") && Vladimir.rifel)
        {
            ThirdPersonCam.SetActive(false);
            TPS.SetActive(false);
            AnimingCam.SetActive(true);
            Anim.SetActive(true);
        }
        else
        {
            ThirdPersonCam.SetActive(true);
            TPS.SetActive(true);
            AnimingCam.SetActive(false);
            Anim.SetActive(false);
        }
    }
}
