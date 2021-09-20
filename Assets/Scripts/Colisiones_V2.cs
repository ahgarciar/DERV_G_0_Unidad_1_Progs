using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Colisiones_V2 : MonoBehaviour
{
    public TextMeshProUGUI txt_puntaje;

    int puntaje;

    // Start is called before the first frame update
    void Start()
    {
        puntaje = 0;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        string name = collision.gameObject.name;
        Debug.Log("En Colision con :" + name);

        if (!name.Equals("Plane") && !name.Equals("Jugador"))
        {
            puntaje++;
            txt_puntaje.text = puntaje.ToString();

            GameObject gameobj = GameObject.Find(name);

            Destroy(gameobj);
        }

        


    }

    private void OnCollisionStay(Collision collision)
    {
        //Debug.Log("Se mantiene la Colisión");
    }

    private void OnCollisionExit(Collision collision)
    {
        //Debug.Log("Sale de la Colisión");
    }
}
