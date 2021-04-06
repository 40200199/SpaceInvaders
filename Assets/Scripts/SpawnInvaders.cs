﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInvaders : MonoBehaviour
{
    [SerializeField]
    GameObject[] invasores;
    [SerializeField]
    GameObject[] invasoresIndestrutiveis;

    [SerializeField]
    int nInvasores = 7;
    [SerializeField]
    float xMin = -3f;
    [SerializeField]
    float yMin = -0.5f;
    [SerializeField]
    float xInc = 1f;
    [SerializeField]
    float yInc = 0.5f;

    [SerializeField]
    float probabilidadeIndestrutivel = 0.05f;

    

    void Awake()
    {
        float y = yMin;
        for(int line = 0; line < invasores.Length; line++)
        {

            float x = xMin;
            for (int i = 1; i <= nInvasores; i++)
            {
                GameObject normalOuIndestrutivel;
                if(Random.value <= probabilidadeIndestrutivel)
                {
                    normalOuIndestrutivel = invasoresIndestrutiveis[line];
                }
                else
                {
                    normalOuIndestrutivel = invasores[line];
                }

                GameObject newInvader = Instantiate(normalOuIndestrutivel, transform);
                newInvader.transform.position = new Vector3(x, y, 0f);
                x += xInc;
            }
            y += yInc;
        }
        

    }

}
