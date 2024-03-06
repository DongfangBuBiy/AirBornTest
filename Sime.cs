using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sime : MonoBehaviour
{
    
    public GameObject destroysim;


    private void OnMouseDown()
    {
        Instantiate(destroysim, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
      
    }


}
