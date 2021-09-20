using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientosBasicos : MonoBehaviour
{
    int i;


    public float desplazamiento = 10;

    [SerializeField]
    private float speedRotacion = 5;

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Score: " + i);
        //i++;

        //Debug.Log("Has atacado");

        if (Input.GetKey(KeyCode.W)) {
            //Debug.Log("Adelante");
            transform.Translate(Vector3.forward * desplazamiento);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //Debug.Log("Izquierda");
            transform.Translate(Vector3.left * desplazamiento);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //Debug.Log("Atras");
            transform.Translate(Vector3.back * desplazamiento);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //Debug.Log("Derecha");
            transform.Translate(Vector3.right * desplazamiento);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            //Debug.Log("Girar Izquierda");
            transform.Rotate(new Vector3(0,-1,0) * speedRotacion);
        }

        if (Input.GetKey(KeyCode.E))
        {
            //Debug.Log("Girar Drecha");
            transform.Rotate(new Vector3(0, 1, 0) * speedRotacion);
        }
    }
}
