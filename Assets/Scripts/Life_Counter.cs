using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using UnityEngine.UI;

public class Life_Counter : MonoBehaviour
{
    public int Life = 10;
    public Text Life_UI;

    public void Start()
    {
        Life_UI.text = "Life Left-"+Life.ToString();
    }
    public void life_counter()
    {
        Life--;
        Life_UI.text = "Life Left-"+Life.ToString();
    }
}
