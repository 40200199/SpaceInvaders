using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invader : MonoBehaviour
{
    [SerializeField]
    GameObject fire = null;

    [SerializeField]
    float cadencia = 1.5f;

    float tempoQuePassou = 0f;

    private void Update()
    {
        if(tag == "Destrutivel")
        {
            tempoQuePassou += Random.value*Time.deltaTime;
            if(tempoQuePassou >= cadencia)
            {
                Instantiate(fire, transform.position, transform.rotation);
                tempoQuePassou = 0f;
            }
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (tag == "Destrutivel")
        {
            if (collision.gameObject.tag == "DisparoNave")
            {
                Destroy(gameObject);                    //Destruir Prefab
                Destroy(collision.gameObject);          //Destruir Tiro
            }
        }
        
        else
        {
                Destroy(collision.gameObject);
            }


    }
}
