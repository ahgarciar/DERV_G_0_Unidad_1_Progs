using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Colisiones_V3 : MonoBehaviour
{
    public TextMeshProUGUI txt_puntaje;
    public TextMeshProUGUI txt_vida;

    int puntaje;
    int vida;

    public void setVida(int v) {
        vida = v;
    }

    public int getVida()
    {
        return vida;
    }

    // Start is called before the first frame update
    void Start()
    {
        puntaje = 0;
        vida = 100;
        StartCoroutine("subRutina1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        //vida--;
        //txt_vida.text = vida.ToString();
    }

    IEnumerator subRutina1() {
        while (true) {

            if (vida > 0)
            {
                vida--;
                txt_vida.text = vida.ToString();
            }
            else {
                txt_vida.text = "0";
            }
            

            yield return new WaitForSeconds(1.0f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        string name = collision.gameObject.name;
        string tag = collision.gameObject.tag;
        Debug.Log("En Colision con :" + name + "   etiqueta: "  + tag);


        if (tag.Equals("Enemigo"))
        {
            puntaje++;
            txt_puntaje.text = puntaje.ToString();
            
        }
        else if(tag.Equals("Potenciador")){

            vida += 10;
            txt_vida.text = vida.ToString();

        }

        if (!tag.Equals("Player"))
        {
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
