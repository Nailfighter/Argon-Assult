using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Diagnostics;

public class Life_Counter : MonoBehaviour
{
    public float Life;
    [SerializeField] Text[] Life_X;
    [SerializeField] GameObject[] spark_particle;
    public Game_Data _data;
    float div;


    public void Start()
    {
        Life = 30;
        div = Life / 5;
    }
    private void Update()
    {
        Life_Text_Changer();
    }

    private void Life_Text_Changer()
    {

        if (Life <=div*4)
        {
            Life_X[4].enabled = false;
            spark_particle[0].SetActive(true);
        }
        if (Life <=div*3)
        {
            Life_X[3].enabled = false;
            spark_particle[1].SetActive(true);
        }
        if (Life <= div *2)
        {
            Life_X[2].enabled = false;
            spark_particle[2].SetActive(true);
        }
        if (Life <= div)
        {
            Life_X[1].enabled = false;
            spark_particle[3].SetActive(true);
        }
        if (Life <=0)
        {
            Life_X[0].enabled = false;
        }
    }

    public void life_counter()
    {
        Life--;
    }
    public void life_reduction_by_missile()
    {
        Life = Life - 3;
    }
}
