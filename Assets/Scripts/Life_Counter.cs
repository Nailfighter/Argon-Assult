using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using UnityEngine.UI;
using System;
using System.Diagnostics;

public class Life_Counter : MonoBehaviour
{
    public float Life = 20;
    [SerializeField] Text[] Life_X;
    int div = 20 / 5;
    [SerializeField] Text visula;

    private void Update()
    {
        Life_Text_Changer();
        visula.text = Life.ToString();
    }

    private void Life_Text_Changer()
    {
        if (Life <=div*4)
        {
            Life_X[4].enabled = false;
        }
        if (Life <=div*3)
        {
            Life_X[3].enabled = false;
        }
        if (Life <= div *2)
        {
            Life_X[2].enabled = false;
        }
        if (Life <= div)
        {
            Life_X[1].enabled = false;
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
