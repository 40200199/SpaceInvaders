using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInvaders : MonoBehaviour
{
    [SerializeField]
    GameObject invasorA;
    [SerializeField]
    GameObject invasorB;
    [SerializeField]
    GameObject invasorC;

    [SerializeField]
    int nInvasores = 7;
    [SerializeField]
    float xMin = -3f;

    void Awake()
    {
        //Pegar num invader e colocar na posição correta; através de um ciclo, a instrução vai ser repetida

        float x = xMin;
        
        for (int i = 1; i <= nInvasores; i++)
        {
            GameObject newInvader = Instantiate(invasorA, transform);
            newInvader.transform.position = new Vector3(x, -1f, 0f); //ADICIONEI SEMPRE 7F AO X
            x += 1f;
        }

        for (int i = 1; i <= nInvasores; i++)
        {
            GameObject newInvader = Instantiate(invasorA, transform);
            newInvader.transform.position = new Vector3(x-1f, -0.5f, 0f);
            x += -1f;
        }

        for (int i = 1; i <= nInvasores; i++)
        {
            GameObject newInvader = Instantiate(invasorB, transform);
            newInvader.transform.position = new Vector3(x+6f, 0f, 0f);
            x += -1f;
        }

        for (int i = 1; i <= nInvasores; i++)
        {
            GameObject newInvader = Instantiate(invasorB, transform);
            newInvader.transform.position = new Vector3(x+13f, 0.5f, 0f);
            x += -1f;
        }

        for (int i = 1; i <= nInvasores; i++)
        {
            GameObject newInvader = Instantiate(invasorC, transform);
            newInvader.transform.position = new Vector3(x+20f, 1f, 0f);
            x += -1f;
        }
    }

}
