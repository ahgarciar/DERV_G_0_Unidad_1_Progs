using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientosFisicas : MonoBehaviour
{
    int i;


    public float desplazamiento = 10;

    [SerializeField]
    private float speedRotacion = 5;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        i = 0;

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {

    }

    void FixedUpdate()
    {
        //Debug.Log("Score: " + i);
        //i++;

        //Debug.Log("Has atacado");

        if (Input.GetKey(KeyCode.W)) {
            Debug.Log("Adelante");
            rb.MovePosition(rb.position + transform.forward * desplazamiento * Time.deltaTime);
            //            x  y  z
            //new Vector3(0, 0, 1f)
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Izquierda");
            rb.MovePosition(rb.position + transform.right * -1f * desplazamiento * Time.deltaTime);
            //Vector3.left
            //new Vector3(-1, 0, 0)
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Atras");
            rb.MovePosition(rb.position + Vector3.back * desplazamiento * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Derecha");
            rb.MovePosition(rb.position + new Vector3(1f, 0f, 0f) * desplazamiento * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            Debug.Log("Girar Izquierda");
            Quaternion q = Quaternion.Euler(new Vector3(0f,-1f,0f) * speedRotacion * Time.deltaTime);

            rb.MoveRotation(rb.rotation * q);

        }

        if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("Girar Drecha");
            Quaternion q = Quaternion.Euler(new Vector3(0f, 1f, 0f) * speedRotacion * Time.deltaTime);

            rb.MoveRotation(rb.rotation * q);
        }
    }
}
