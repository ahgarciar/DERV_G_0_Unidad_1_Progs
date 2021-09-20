using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionPowerUP : MonoBehaviour
{
    public GameObject controlador;
    DecrementoVida decVida;

    // Start is called before the first frame update
    void Start()
    {
        decVida =  controlador.GetComponent<DecrementoVida>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Objeto en Colision con: " + collision.gameObject.name);

        if (collision.gameObject.name.Equals("Jugador"))
        {
            decVida.vida = decVida.vida + 1;
            decVida.texto_vida.text = decVida.vida.ToString();

        }


    }
}
