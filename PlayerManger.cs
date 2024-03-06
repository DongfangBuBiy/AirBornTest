using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManger : MonoBehaviour
{
    [Header("Box-InLevel")]
    public List<GameObject> Box;
    [Header("Comandos")]
    public List<GameObject> Comandos;
    public List<ScriptableObject> DataBeseComando;

    [Header("KnifelSystem")]
    public bool PlayerSelectKnifel;//روشن کردن چاقو در کماندو و تغییر نشانه گر موس 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
