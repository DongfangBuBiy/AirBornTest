using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombCreat : MonoBehaviour
{
    public GameObject Bomb;
    public GameObject player;
    

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
       
    }

    // Update is called once per frame
    void Update()
    {
        float dict = Vector3.Distance(player.transform.position, gameObject.transform.position);
        if (dict < 3f )
        {
            Debug.Log("convert to bomb mesg");
        
            Die();
        }
        
    }
    private void Die()
    {
        Destroy(gameObject);
    }
}
