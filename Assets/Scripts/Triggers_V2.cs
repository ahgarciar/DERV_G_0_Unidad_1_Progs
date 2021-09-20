using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers_V2 : MonoBehaviour
{
    public GameObject generadorObj;

    [SerializeField]
    GameObject objetoCubo;

    int i;

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        string tag = other.gameObject.tag;
        if (tag.Equals("Player"))
        {
            for (int j = 0; j < 10; j++)
            {
                GameObject enemigoCubo = Instantiate(objetoCubo, generadorObj.transform.position+
                    new Vector3(2f, 0f, 5f),
                generadorObj.transform.rotation) as GameObject;

                enemigoCubo.name = "Enemigo_" + i;

                Destroy(enemigoCubo, 5);  //elimina al objeto despues de 5 segs

                i++;
            }
            
        }
    }

}
