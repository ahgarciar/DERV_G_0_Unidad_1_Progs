using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisiones_V1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Entro a Colisión");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Se mantiene la Colisión");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Sale de la Colisión");
    }
}
