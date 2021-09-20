using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DecrementoVida : MonoBehaviour
{
    public int vida;

    public TextMeshProUGUI texto_vida;

    // Start is called before the first frame update
    void Start()
    {
        vida = 100;
        StartCoroutine("decVida");
    }

    IEnumerator decVida() {
        while (true)
        {
            vida--;
            texto_vida.text = vida.ToString();

            yield return new WaitForSeconds(1.0f);
        }
    }

}
