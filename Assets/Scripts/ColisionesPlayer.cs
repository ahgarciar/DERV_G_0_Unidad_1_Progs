using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionesPlayer : MonoBehaviour
{
    Colisiones_V3 scriptColisiones;

    // Start is called before the first frame update
    void Start()
    {
        scriptColisiones = GetComponentInChildren<Colisiones_V3>();        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Vida desde Script: " + scriptColisiones.txt_vida.text);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //EJEMPLO 1
        /*
        string name = collision.gameObject.name;
        Debug.Log("Player en colision con: " + name);

        if (name.Equals("Pared")) {
            int v = scriptColisiones.getVida();
            scriptColisiones.setVida(v - 5);
            scriptColisiones.txt_vida.text= (v - 5).ToString();
        }
        */
    }

    private void OnCollisionStay(Collision collision)
    {
        string name = collision.gameObject.name;
        Debug.Log("Player en colision con: " + name);

        if (name.Equals("Pared"))
        {
            int v = scriptColisiones.getVida();
            scriptColisiones.setVida(v - 1);
            scriptColisiones.txt_vida.text = (v - 1).ToString();
        }
    }
}
