using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers_V1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        string name =  other.gameObject.name;
        string tag = other.gameObject.tag;

        Debug.Log("Entro al Trigger");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Se mantiene en Trigger");
    }


    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Sale del Trigger");
    }
}
